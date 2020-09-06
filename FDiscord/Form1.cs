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
        public Form1()
        {
            InitializeComponent();
        }

        /// Variables
        int i = 0;
        bool messageSpam = false;
        List<string> tokens = new List<string>();
        private delegate void SafeCallDelegate(string text);

        /// Thread stuff
        public static Thread Start(Action action)
        {
            Thread thread = new Thread(() => { action(); });
            thread.Start();
            return thread;
        }

        private void write2console(string text)
        {
            if (console.InvokeRequired)
            {
                var d = new SafeCallDelegate(write2console);
                console.Invoke(d, new object[] { text });
            }
            else
            {
                console.Text += Environment.NewLine + "[" + DateTime.Now.ToString("h:mm:ss") + "] " + text;
            }
        }

        /// Form code

        // Always on top button code
        private void alwaysOnTop_CheckedChanged(object sender, EventArgs e)
        {
            Form1.ActiveForm.TopMost = alwaysOnTop.Checked;
        }

        //  Open token file
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

        // Friend flood works
        private void friendButton_BTN_Click(object sender, EventArgs e)
        {
            if(userName.Text != "" && tokens.Count() > 0)
            {
                // Run the loop in another thread so the UI doesn't become unresponsive
                Start(() =>
                {
                    for (int i = 0; i <= tokens.Count()-1; i++)
                    {
                        string response = libdiscord.SendFriendRequest(tokens[i], userName.Text);
                        if (response.Contains("StatusCode: 20"))
                        {
                            write2console("Success");
                        }
                        else if(response.Contains("StatusCode: 401"))
                        {
                            write2console("Unauthorized");
                        }
                        else if(response.Contains("StatusCode: 429"))
                        {
                            write2console("Rate limited");
                        }
                        else
                        {
                            write2console(response);
                        }
                    }
                });
            }
            else
            {
                write2console("Missing input");
            }
        }

        // Server flood works
        private void serverFlood_BTN_Click(object sender, EventArgs e)
        {
            if (serverInvite.Text != "" && tokens.Count() > 0)
            {
                // Run the loop in another thread so the UI doesn't become unresponsive
                Start(() =>
                {
                    for (int i = 0; i <= tokens.Count() - 1; i++)
                    {
                        string response = libdiscord.JoinServer(tokens[i], serverInvite.Text);
                        if (response.Contains("StatusCode: 20"))
                        {
                            write2console("Success");
                        }
                        else if (response.Contains("StatusCode: 401"))
                        {
                            write2console("Unauthorized");
                        }
                        else if (response.Contains("StatusCode: 429"))
                        {
                            write2console("Rate limited");
                        }
                        else
                        {
                            write2console(response);
                        }
                    }
                });
            }
            else
            {
                write2console("Missing input");
            }
        }


        private void messageSpam_BTN_Click(object sender, EventArgs e)
        {
            if(channedId.Text != "" && message.Text != "" && tokens.Count() > 0)
            {
                messageSpam = true;
                Start(() =>
                {
                    while (messageSpam)
                    {
                        for (int i = 0; i <= tokens.Count() - 1; i++)
                        {
                            string response = libdiscord.SendMsg(tokens[i], channedId.Text, message.Text);
                            if (response.Contains("StatusCode: 20"))
                            {
                                write2console("Success");
                            }
                            else if (response.Contains("StatusCode: 401"))
                            {
                                write2console("Unauthorized");
                            }
                            else if (response.Contains("StatusCode: 429"))
                            {
                                write2console("Rate limited");
                            }
                            else
                            {
                                write2console(response);
                            }
                            Thread.Sleep(650);
                        }
                    }
                });
            }
            else
            {
                write2console("Missing input");
            }
        }

        private void messageSpam_Stop_BTN_Click(object sender, EventArgs e)
        {
            messageSpam = false;
        }
    }
}
