using System.Collections.Generic;
using System.Windows.Forms;
using System.Threading;
using System.Linq;
using System.IO;
using System;

namespace FDiscord
{

    public partial class Form1 : System.Windows.Forms.Form
    {
        enum Modules
        {
            FriendFlood,
            NickChanger,
            ServerFlood,
            MessageSpammer,
            Info,
            None,
        };

        public Form1()
        {
            Console.Title = "FDiscord Log";

            // Legend
            write2console(Modules.None, " LEGEND:", ConsoleColor.White, false);
            write2console(Modules.None, "───────────────────────────────────", ConsoleColor.White, false);
            write2console(Modules.Info, "Cyan\t- Reporting", ConsoleColor.Cyan, false);
            write2console(Modules.Info, "Yellow\t- Warnings", ConsoleColor.Yellow, false);
            write2console(Modules.Info, "Red\t- Errors", ConsoleColor.Red, false);
            write2console(Modules.Info, "Green\t- Success", ConsoleColor.Green, false);
            write2console(Modules.None, "───────────────────────────────────", ConsoleColor.White, false);

            InitializeComponent();
        }

        /// Variables

        // Interval between requests (in milliseconds)
        const int pause = 750;

        bool messageSpam = false;
        bool nickChanger = false;
        bool randomNicks = false;
        const int randomNickLength = 10;

        List<string> tokens = new List<string>();

        // https://stackoverflow.com/questions/1344221/how-can-i-generate-random-alphanumeric-strings
        private static Random random = new Random();
        public static string RandomString(int length)
        {
            const string chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        /// Thread stuff
        public static Thread Start(Action action)
        {
            Thread thread = new Thread(() => { action(); });
            thread.Start();
            return thread;
        }

        private void write2console(Modules module, string text, ConsoleColor color = ConsoleColor.White, bool TimeStamp = true)
        {
            // Time stamp
            if (TimeStamp) Console.Write("[" + DateTime.Now.ToString("h:mm:ss") + "]");

            // Module name
            if(module != Modules.None)
            {
                Console.Write(" [");
                Console.ForegroundColor = color;
                switch (module)
                {
                    case Modules.FriendFlood:
                        Console.Write("Friend Flood");
                        break;

                    case Modules.NickChanger:
                        Console.Write("NickChanger");
                        break;

                    case Modules.ServerFlood:
                        Console.Write("ServerFlood");
                        break;

                    case Modules.MessageSpammer:
                        Console.Write("MessageSpammer");
                        break;

                    case Modules.Info:
                        Console.Write("Info");
                        break;
                }
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("] ");
            }

            Console.ForegroundColor = color;
            Console.WriteLine(text);
            Console.ForegroundColor = ConsoleColor.White;
        }

        /// Form code

        // Always on top button code
        private void alwaysOnTop_CheckedChanged(object sender, EventArgs e)
        {
            Form1.ActiveForm.TopMost = alwaysOnTop.Checked;
        }
        // Clear log
        private void clearLog_BTN_Click(object sender, EventArgs e)
        {
            Console.Clear();
            write2console(Modules.Info, "Log cleared", ConsoleColor.Cyan);
        }

        // Open token file
        private void loadTokens_BTN_Click(object sender, EventArgs e)
        {
            if (loadTokens.ShowDialog() == DialogResult.OK)
            {
                // Clear the list
                tokens.RemoveRange(0, tokens.Count());

                // Open a stream to read from the file
                var file = new StreamReader(loadTokens.FileName);

                // Read the file and put every token in a list
                string line = file.ReadLine();
                while(line != null)
                {
                    tokens.Add(line);
                    line = file.ReadLine();
                }
                // Always close the file
                file.Close();

                // Set the text in loadedTokensLabel to the number of lines
                loadedTokensNumber.Text = tokens.Count().ToString();
                // Set the text in tokenFilePath to the file path
                tokenFilePath.Text = loadTokens.FileName;
            }
        }

        // Friend flood
        private void friendButton_BTN_Click(object sender, EventArgs e)
        {
            if(userName.Text != "" && tokens.Count() > 0)
            {
                // Run the loop in another thread so the UI doesn't become unresponsive
                Start(() =>
                {
                    for (int i = 0; i <= tokens.Count()-1; i++)
                    {
                        libdiscord.DiscordResponse response = libdiscord.SendFriendRequest(tokens[i], userName.Text);
                        if (response.success)
                            write2console(Modules.FriendFlood, "Success", ConsoleColor.Green);
                        else
                            write2console(Modules.FriendFlood, response.status + ": " + response.reason, ConsoleColor.Red);
                    }
                });
            }
            else
                write2console(Modules.FriendFlood, "Missing input", ConsoleColor.Yellow);
        }

        // Server flood
        private void serverFlood_BTN_Click(object sender, EventArgs e)
        {
            if (serverInvite.Text != "" && tokens.Count() > 0)
            {
                // Run the loop in another thread so the UI doesn't become unresponsive
                Start(() =>
                {
                    for (int i = 0; i <= tokens.Count() - 1; i++)
                    {
                        libdiscord.DiscordResponse response = libdiscord.JoinServer(tokens[i], serverInvite.Text);
                        if (response.success)
                            write2console(Modules.ServerFlood, "Success", ConsoleColor.Green);
                        else
                            write2console(Modules.ServerFlood, response.status + ": " + response.reason, ConsoleColor.Red);
                    }
                });
            }
            else
                write2console(Modules.ServerFlood, "Missing input", ConsoleColor.Yellow);
        }

        // Message spam
        private void messageSpam_BTN_Click(object sender, EventArgs e)
        {
            if(channedId.Text != "" && message.Text != "" & tokens.Count() > 0)
            {
                if(!messageSpam)
                {
                    long cid;
                    try
                    {
                        cid = Int64.Parse(channedId.Text.Trim());
                    }
                    catch (FormatException)
                    {
                        write2console(Modules.MessageSpammer, "Error parsing channel id", ConsoleColor.Yellow);
                        return;
                    }
                    write2console(Modules.MessageSpammer, "Started", ConsoleColor.Cyan);
                    messageSpam = true;
                    Start(() =>
                    {
                        while (messageSpam)
                        {
                            for (int i = 0; i <= tokens.Count() - 1; i++)
                            {
                                libdiscord.DiscordResponse response = libdiscord.SendMessage(tokens[i], cid, message.Text);
                                if (response.success)
                                {
                                    write2console(Modules.MessageSpammer, "Success", ConsoleColor.Green);
                                }
                                else
                                {
                                    write2console(Modules.MessageSpammer, response.status + ": " + response.reason, ConsoleColor.Red);
                                }
                                Thread.Sleep(pause);
                            }
                        }
                    });
                }
                else
                {
                    write2console(Modules.MessageSpammer, "Already started", ConsoleColor.Cyan);
                }
            }
            else
            {
                write2console(Modules.MessageSpammer, "Missing input", ConsoleColor.Yellow);
            }
        }
        private void messageSpam_Stop_BTN_Click(object sender, EventArgs e)
        {
            if(messageSpam)
            {
                messageSpam = false;
                write2console(Modules.MessageSpammer, "Stopped", ConsoleColor.Cyan);
            }
            else
                write2console(Modules.MessageSpammer, "Not running", ConsoleColor.Cyan);
        }

        // Nick changer
        private void nickChanger_BTN_Click(object sender, EventArgs e)
        {
            if(serverid.Text != "" && tokens.Count() > 0)
            {
                randomNicks = (nick.Text == "");

                if(!nickChanger)
                {
                    long sid;
                    try
                    {
                        sid = Int64.Parse(serverid.Text.Trim());
                    }
                    catch (FormatException)
                    {
                        write2console(Modules.NickChanger, "Error parsing server id", ConsoleColor.Yellow);
                        return;
                    }
                    write2console(Modules.NickChanger, "Started", ConsoleColor.Cyan);
                    nickChanger = true;
                    Start(() =>
                    {
                        string _nick;
                        while (nickChanger)
                        {
                            for (int i = 0; i <= tokens.Count() - 1; i++)
                            {
                                if (randomNicks)
                                    _nick = RandomString(randomNickLength);
                                else
                                    _nick = nick.Text;
                                libdiscord.DiscordResponse response = libdiscord.ChangeNickName(tokens[i], sid, _nick);
                                if (response.success)
                                    write2console(Modules.MessageSpammer, "Success", ConsoleColor.Green);
                                else
                                    write2console(Modules.MessageSpammer, response.status + ": " + response.reason, ConsoleColor.Red);
                                Thread.Sleep(pause);
                            }
                        }
                    });
                }
            }
            else
                write2console(Modules.NickChanger, "Missing input", ConsoleColor.Yellow);
        }
        private void nickChanger_Stop_BTN_Click(object sender, EventArgs e)
        {
            if (nickChanger)
            {
                nickChanger = false;
                write2console(Modules.NickChanger, "Stopped", ConsoleColor.Cyan);
            }
            else
                write2console(Modules.NickChanger, "Not running", ConsoleColor.Cyan);
        }
    }
}
