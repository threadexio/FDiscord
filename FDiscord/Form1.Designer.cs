namespace FDiscord
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tokenPanel = new System.Windows.Forms.Panel();
            this.tokenFilePath = new System.Windows.Forms.Label();
            this.tokenFileLabel = new System.Windows.Forms.Label();
            this.loadedTokensNumber = new System.Windows.Forms.Label();
            this.loadedTokensLabel = new System.Windows.Forms.Label();
            this.loadTokens_BTN = new System.Windows.Forms.Button();
            this.loadTokens_label = new System.Windows.Forms.Label();
            this.loadTokens = new System.Windows.Forms.OpenFileDialog();
            this.alwaysOnTop = new System.Windows.Forms.CheckBox();
            this.friendFloodPanel = new System.Windows.Forms.Panel();
            this.friendButton_BTN = new System.Windows.Forms.Button();
            this.userName = new System.Windows.Forms.TextBox();
            this.user_label = new System.Windows.Forms.Label();
            this.friendFloodLabel = new System.Windows.Forms.Label();
            this.serverFloodPanel = new System.Windows.Forms.Panel();
            this.serverFlood_BTN = new System.Windows.Forms.Button();
            this.serverInvite = new System.Windows.Forms.TextBox();
            this.serverInvite_label = new System.Windows.Forms.Label();
            this.serverFloodLabel = new System.Windows.Forms.Label();
            this.messageSpamPanel = new System.Windows.Forms.Panel();
            this.messageSpam_BTN = new System.Windows.Forms.Button();
            this.message = new System.Windows.Forms.TextBox();
            this.messageLabel = new System.Windows.Forms.Label();
            this.channedId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.messageSpamLabel = new System.Windows.Forms.Label();
            this.creditsLabel = new System.Windows.Forms.Label();
            this.console = new System.Windows.Forms.TextBox();
            this.messageSpam_Stop_BTN = new System.Windows.Forms.Button();
            this.tokenPanel.SuspendLayout();
            this.friendFloodPanel.SuspendLayout();
            this.serverFloodPanel.SuspendLayout();
            this.messageSpamPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tokenPanel
            // 
            this.tokenPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tokenPanel.Controls.Add(this.tokenFilePath);
            this.tokenPanel.Controls.Add(this.tokenFileLabel);
            this.tokenPanel.Controls.Add(this.loadedTokensNumber);
            this.tokenPanel.Controls.Add(this.loadedTokensLabel);
            this.tokenPanel.Controls.Add(this.loadTokens_BTN);
            this.tokenPanel.Controls.Add(this.loadTokens_label);
            this.tokenPanel.Location = new System.Drawing.Point(12, 12);
            this.tokenPanel.Name = "tokenPanel";
            this.tokenPanel.Size = new System.Drawing.Size(291, 288);
            this.tokenPanel.TabIndex = 0;
            // 
            // tokenFilePath
            // 
            this.tokenFilePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tokenFilePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.tokenFilePath.Location = new System.Drawing.Point(35, 253);
            this.tokenFilePath.Name = "tokenFilePath";
            this.tokenFilePath.Size = new System.Drawing.Size(249, 22);
            this.tokenFilePath.TabIndex = 5;
            // 
            // tokenFileLabel
            // 
            this.tokenFileLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tokenFileLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tokenFileLabel.Location = new System.Drawing.Point(3, 253);
            this.tokenFileLabel.Name = "tokenFileLabel";
            this.tokenFileLabel.Size = new System.Drawing.Size(35, 22);
            this.tokenFileLabel.TabIndex = 4;
            this.tokenFileLabel.Text = "File:";
            // 
            // loadedTokensNumber
            // 
            this.loadedTokensNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.loadedTokensNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.loadedTokensNumber.Location = new System.Drawing.Point(112, 226);
            this.loadedTokensNumber.Name = "loadedTokensNumber";
            this.loadedTokensNumber.Size = new System.Drawing.Size(172, 17);
            this.loadedTokensNumber.TabIndex = 3;
            this.loadedTokensNumber.Text = "0";
            // 
            // loadedTokensLabel
            // 
            this.loadedTokensLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.loadedTokensLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.loadedTokensLabel.Location = new System.Drawing.Point(3, 226);
            this.loadedTokensLabel.Name = "loadedTokensLabel";
            this.loadedTokensLabel.Size = new System.Drawing.Size(112, 17);
            this.loadedTokensLabel.TabIndex = 2;
            this.loadedTokensLabel.Text = "Loaded Tokens:";
            // 
            // loadTokens_BTN
            // 
            this.loadTokens_BTN.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.loadTokens_BTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loadTokens_BTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.loadTokens_BTN.Location = new System.Drawing.Point(3, 55);
            this.loadTokens_BTN.Name = "loadTokens_BTN";
            this.loadTokens_BTN.Size = new System.Drawing.Size(281, 49);
            this.loadTokens_BTN.TabIndex = 1;
            this.loadTokens_BTN.Text = "Open file";
            this.loadTokens_BTN.UseVisualStyleBackColor = true;
            this.loadTokens_BTN.Click += new System.EventHandler(this.loadTokens_BTN_Click);
            // 
            // loadTokens_label
            // 
            this.loadTokens_label.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.loadTokens_label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.loadTokens_label.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loadTokens_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.loadTokens_label.Location = new System.Drawing.Point(-2, -2);
            this.loadTokens_label.Name = "loadTokens_label";
            this.loadTokens_label.Size = new System.Drawing.Size(291, 40);
            this.loadTokens_label.TabIndex = 0;
            this.loadTokens_label.Text = "Load Tokens";
            this.loadTokens_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // loadTokens
            // 
            this.loadTokens.DefaultExt = "txt";
            this.loadTokens.FileName = "loadTokens";
            this.loadTokens.SupportMultiDottedExtensions = true;
            // 
            // alwaysOnTop
            // 
            this.alwaysOnTop.Appearance = System.Windows.Forms.Appearance.Button;
            this.alwaysOnTop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.alwaysOnTop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.alwaysOnTop.Location = new System.Drawing.Point(12, 315);
            this.alwaysOnTop.Name = "alwaysOnTop";
            this.alwaysOnTop.Size = new System.Drawing.Size(291, 43);
            this.alwaysOnTop.TabIndex = 7;
            this.alwaysOnTop.Text = "Always On Top";
            this.alwaysOnTop.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.alwaysOnTop.UseVisualStyleBackColor = true;
            this.alwaysOnTop.CheckedChanged += new System.EventHandler(this.alwaysOnTop_CheckedChanged);
            // 
            // friendFloodPanel
            // 
            this.friendFloodPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.friendFloodPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.friendFloodPanel.Controls.Add(this.friendButton_BTN);
            this.friendFloodPanel.Controls.Add(this.userName);
            this.friendFloodPanel.Controls.Add(this.user_label);
            this.friendFloodPanel.Controls.Add(this.friendFloodLabel);
            this.friendFloodPanel.Location = new System.Drawing.Point(319, 12);
            this.friendFloodPanel.Name = "friendFloodPanel";
            this.friendFloodPanel.Size = new System.Drawing.Size(269, 132);
            this.friendFloodPanel.TabIndex = 8;
            // 
            // friendButton_BTN
            // 
            this.friendButton_BTN.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.friendButton_BTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.friendButton_BTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.friendButton_BTN.Location = new System.Drawing.Point(3, 89);
            this.friendButton_BTN.Name = "friendButton_BTN";
            this.friendButton_BTN.Size = new System.Drawing.Size(259, 36);
            this.friendButton_BTN.TabIndex = 8;
            this.friendButton_BTN.Text = "Start";
            this.friendButton_BTN.UseVisualStyleBackColor = true;
            this.friendButton_BTN.Click += new System.EventHandler(this.friendButton_BTN_Click);
            // 
            // userName
            // 
            this.userName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.userName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.userName.Location = new System.Drawing.Point(53, 54);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(208, 21);
            this.userName.TabIndex = 7;
            // 
            // user_label
            // 
            this.user_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.user_label.Location = new System.Drawing.Point(3, 55);
            this.user_label.Name = "user_label";
            this.user_label.Size = new System.Drawing.Size(45, 22);
            this.user_label.TabIndex = 6;
            this.user_label.Text = "User:";
            // 
            // friendFloodLabel
            // 
            this.friendFloodLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.friendFloodLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.friendFloodLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.friendFloodLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.friendFloodLabel.Location = new System.Drawing.Point(-2, -2);
            this.friendFloodLabel.Name = "friendFloodLabel";
            this.friendFloodLabel.Size = new System.Drawing.Size(269, 40);
            this.friendFloodLabel.TabIndex = 6;
            this.friendFloodLabel.Text = "Friend Flood";
            this.friendFloodLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // serverFloodPanel
            // 
            this.serverFloodPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.serverFloodPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.serverFloodPanel.Controls.Add(this.serverFlood_BTN);
            this.serverFloodPanel.Controls.Add(this.serverInvite);
            this.serverFloodPanel.Controls.Add(this.serverInvite_label);
            this.serverFloodPanel.Controls.Add(this.serverFloodLabel);
            this.serverFloodPanel.Location = new System.Drawing.Point(319, 405);
            this.serverFloodPanel.Name = "serverFloodPanel";
            this.serverFloodPanel.Size = new System.Drawing.Size(269, 135);
            this.serverFloodPanel.TabIndex = 9;
            // 
            // serverFlood_BTN
            // 
            this.serverFlood_BTN.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.serverFlood_BTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.serverFlood_BTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.serverFlood_BTN.Location = new System.Drawing.Point(2, 90);
            this.serverFlood_BTN.Name = "serverFlood_BTN";
            this.serverFlood_BTN.Size = new System.Drawing.Size(259, 38);
            this.serverFlood_BTN.TabIndex = 9;
            this.serverFlood_BTN.Text = "Start";
            this.serverFlood_BTN.UseVisualStyleBackColor = true;
            this.serverFlood_BTN.Click += new System.EventHandler(this.serverFlood_BTN_Click);
            // 
            // serverInvite
            // 
            this.serverInvite.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.serverInvite.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.serverInvite.Location = new System.Drawing.Point(53, 51);
            this.serverInvite.Name = "serverInvite";
            this.serverInvite.Size = new System.Drawing.Size(209, 21);
            this.serverInvite.TabIndex = 9;
            // 
            // serverInvite_label
            // 
            this.serverInvite_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.serverInvite_label.Location = new System.Drawing.Point(3, 52);
            this.serverInvite_label.Name = "serverInvite_label";
            this.serverInvite_label.Size = new System.Drawing.Size(45, 22);
            this.serverInvite_label.TabIndex = 9;
            this.serverInvite_label.Text = "Invite:";
            // 
            // serverFloodLabel
            // 
            this.serverFloodLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.serverFloodLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.serverFloodLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.serverFloodLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.serverFloodLabel.Location = new System.Drawing.Point(-2, -2);
            this.serverFloodLabel.Name = "serverFloodLabel";
            this.serverFloodLabel.Size = new System.Drawing.Size(269, 39);
            this.serverFloodLabel.TabIndex = 9;
            this.serverFloodLabel.Text = "Server flood";
            this.serverFloodLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // messageSpamPanel
            // 
            this.messageSpamPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.messageSpamPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.messageSpamPanel.Controls.Add(this.messageSpam_Stop_BTN);
            this.messageSpamPanel.Controls.Add(this.messageSpam_BTN);
            this.messageSpamPanel.Controls.Add(this.message);
            this.messageSpamPanel.Controls.Add(this.messageLabel);
            this.messageSpamPanel.Controls.Add(this.channedId);
            this.messageSpamPanel.Controls.Add(this.label2);
            this.messageSpamPanel.Controls.Add(this.messageSpamLabel);
            this.messageSpamPanel.Location = new System.Drawing.Point(594, 12);
            this.messageSpamPanel.Name = "messageSpamPanel";
            this.messageSpamPanel.Size = new System.Drawing.Size(268, 528);
            this.messageSpamPanel.TabIndex = 10;
            // 
            // messageSpam_BTN
            // 
            this.messageSpam_BTN.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.messageSpam_BTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.messageSpam_BTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.messageSpam_BTN.Location = new System.Drawing.Point(3, 441);
            this.messageSpam_BTN.Name = "messageSpam_BTN";
            this.messageSpam_BTN.Size = new System.Drawing.Size(258, 36);
            this.messageSpam_BTN.TabIndex = 9;
            this.messageSpam_BTN.Text = "Start";
            this.messageSpam_BTN.UseVisualStyleBackColor = true;
            this.messageSpam_BTN.Click += new System.EventHandler(this.messageSpam_BTN_Click);
            // 
            // message
            // 
            this.message.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.message.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.message.Location = new System.Drawing.Point(3, 133);
            this.message.Multiline = true;
            this.message.Name = "message";
            this.message.Size = new System.Drawing.Size(258, 211);
            this.message.TabIndex = 10;
            // 
            // messageLabel
            // 
            this.messageLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.messageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.messageLabel.Location = new System.Drawing.Point(3, 108);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(258, 22);
            this.messageLabel.TabIndex = 11;
            this.messageLabel.Text = "Message:";
            // 
            // channedId
            // 
            this.channedId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.channedId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.channedId.Location = new System.Drawing.Point(3, 80);
            this.channedId.Name = "channedId";
            this.channedId.Size = new System.Drawing.Size(258, 21);
            this.channedId.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label2.Location = new System.Drawing.Point(3, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(258, 22);
            this.label2.TabIndex = 9;
            this.label2.Text = "Channel ID:";
            // 
            // messageSpamLabel
            // 
            this.messageSpamLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.messageSpamLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.messageSpamLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.messageSpamLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.messageSpamLabel.Location = new System.Drawing.Point(-2, -2);
            this.messageSpamLabel.Name = "messageSpamLabel";
            this.messageSpamLabel.Size = new System.Drawing.Size(268, 40);
            this.messageSpamLabel.TabIndex = 9;
            this.messageSpamLabel.Text = "Message spam";
            this.messageSpamLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // creditsLabel
            // 
            this.creditsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.creditsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.creditsLabel.Location = new System.Drawing.Point(319, 147);
            this.creditsLabel.Name = "creditsLabel";
            this.creditsLabel.Size = new System.Drawing.Size(263, 255);
            this.creditsLabel.TabIndex = 11;
            this.creditsLabel.Text = "By threadexio on Github";
            this.creditsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // console
            // 
            this.console.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.console.Location = new System.Drawing.Point(12, 364);
            this.console.Multiline = true;
            this.console.Name = "console";
            this.console.ReadOnly = true;
            this.console.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.console.Size = new System.Drawing.Size(301, 176);
            this.console.TabIndex = 12;
            this.console.TabStop = false;
            this.console.WordWrap = false;
            // 
            // messageSpam_Stop_BTN
            // 
            this.messageSpam_Stop_BTN.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.messageSpam_Stop_BTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.messageSpam_Stop_BTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.messageSpam_Stop_BTN.Location = new System.Drawing.Point(3, 483);
            this.messageSpam_Stop_BTN.Name = "messageSpam_Stop_BTN";
            this.messageSpam_Stop_BTN.Size = new System.Drawing.Size(258, 36);
            this.messageSpam_Stop_BTN.TabIndex = 12;
            this.messageSpam_Stop_BTN.Text = "Stop";
            this.messageSpam_Stop_BTN.UseVisualStyleBackColor = true;
            this.messageSpam_Stop_BTN.Click += new System.EventHandler(this.messageSpam_Stop_BTN_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(874, 552);
            this.Controls.Add(this.console);
            this.Controls.Add(this.creditsLabel);
            this.Controls.Add(this.messageSpamPanel);
            this.Controls.Add(this.serverFloodPanel);
            this.Controls.Add(this.friendFloodPanel);
            this.Controls.Add(this.alwaysOnTop);
            this.Controls.Add(this.tokenPanel);
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "FDiscord";
            this.tokenPanel.ResumeLayout(false);
            this.friendFloodPanel.ResumeLayout(false);
            this.friendFloodPanel.PerformLayout();
            this.serverFloodPanel.ResumeLayout(false);
            this.serverFloodPanel.PerformLayout();
            this.messageSpamPanel.ResumeLayout(false);
            this.messageSpamPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel tokenPanel;
        private System.Windows.Forms.Button loadTokens_BTN;
        private System.Windows.Forms.Label loadTokens_label;
        private System.Windows.Forms.OpenFileDialog loadTokens;
        private System.Windows.Forms.Label loadedTokensLabel;
        private System.Windows.Forms.Label loadedTokensNumber;
        private System.Windows.Forms.Label tokenFileLabel;
        private System.Windows.Forms.Label tokenFilePath;
        private System.Windows.Forms.CheckBox alwaysOnTop;
        private System.Windows.Forms.Panel friendFloodPanel;
        private System.Windows.Forms.TextBox userName;
        private System.Windows.Forms.Label user_label;
        private System.Windows.Forms.Label friendFloodLabel;
        private System.Windows.Forms.Button friendButton_BTN;
        private System.Windows.Forms.Panel serverFloodPanel;
        private System.Windows.Forms.Button serverFlood_BTN;
        private System.Windows.Forms.TextBox serverInvite;
        private System.Windows.Forms.Label serverInvite_label;
        private System.Windows.Forms.Label serverFloodLabel;
        private System.Windows.Forms.Panel messageSpamPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label messageSpamLabel;
        private System.Windows.Forms.Button messageSpam_BTN;
        private System.Windows.Forms.TextBox message;
        private System.Windows.Forms.Label messageLabel;
        private System.Windows.Forms.TextBox channedId;
        private System.Windows.Forms.Label creditsLabel;
        private System.Windows.Forms.TextBox console;
        private System.Windows.Forms.Button messageSpam_Stop_BTN;
    }
}

