namespace Arke
{
    partial class NameBox
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ServerBox = new System.Windows.Forms.TextBox();
            this.PortBox = new System.Windows.Forms.TextBox();
            this.RealNameBox = new System.Windows.Forms.TextBox();
            this.NickBox = new System.Windows.Forms.TextBox();
            this.PasswordBox = new System.Windows.Forms.TextBox();
            this.ConnectButton = new System.Windows.Forms.Button();
            this.ChannelBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Server";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Port";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Real Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nick";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Password";
            // 
            // ServerBox
            // 
            this.ServerBox.Location = new System.Drawing.Point(84, 6);
            this.ServerBox.Name = "ServerBox";
            this.ServerBox.Size = new System.Drawing.Size(188, 20);
            this.ServerBox.TabIndex = 5;
            this.ServerBox.Text = "irc.esper.net";
            // 
            // PortBox
            // 
            this.PortBox.Location = new System.Drawing.Point(84, 43);
            this.PortBox.Name = "PortBox";
            this.PortBox.Size = new System.Drawing.Size(188, 20);
            this.PortBox.TabIndex = 6;
            this.PortBox.Text = "6667";
            // 
            // RealNameBox
            // 
            this.RealNameBox.Location = new System.Drawing.Point(84, 80);
            this.RealNameBox.Name = "RealNameBox";
            this.RealNameBox.Size = new System.Drawing.Size(188, 20);
            this.RealNameBox.TabIndex = 7;
            this.RealNameBox.Text = "JefeTest";
            // 
            // NickBox
            // 
            this.NickBox.Location = new System.Drawing.Point(84, 117);
            this.NickBox.Name = "NickBox";
            this.NickBox.Size = new System.Drawing.Size(188, 20);
            this.NickBox.TabIndex = 8;
            this.NickBox.Text = "JefeTest";
            // 
            // PasswordBox
            // 
            this.PasswordBox.Location = new System.Drawing.Point(84, 154);
            this.PasswordBox.Name = "PasswordBox";
            this.PasswordBox.PasswordChar = '*';
            this.PasswordBox.Size = new System.Drawing.Size(188, 20);
            this.PasswordBox.TabIndex = 9;
            // 
            // ConnectButton
            // 
            this.ConnectButton.Location = new System.Drawing.Point(105, 217);
            this.ConnectButton.Name = "ConnectButton";
            this.ConnectButton.Size = new System.Drawing.Size(75, 23);
            this.ConnectButton.TabIndex = 10;
            this.ConnectButton.Text = "Connect!";
            this.ConnectButton.UseVisualStyleBackColor = true;
            this.ConnectButton.Click += new System.EventHandler(this.ConnectButton_Click);
            // 
            // ChannelBox
            // 
            this.ChannelBox.Location = new System.Drawing.Point(84, 191);
            this.ChannelBox.Name = "ChannelBox";
            this.ChannelBox.Size = new System.Drawing.Size(188, 20);
            this.ChannelBox.TabIndex = 12;
            this.ChannelBox.Text = "#jefe323";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 194);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Channel";
            // 
            // NameBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 255);
            this.Controls.Add(this.ChannelBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ConnectButton);
            this.Controls.Add(this.PasswordBox);
            this.Controls.Add(this.NickBox);
            this.Controls.Add(this.RealNameBox);
            this.Controls.Add(this.PortBox);
            this.Controls.Add(this.ServerBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "NameBox";
            this.Text = "Connect";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ServerBox;
        private System.Windows.Forms.TextBox PortBox;
        private System.Windows.Forms.TextBox RealNameBox;
        private System.Windows.Forms.TextBox NickBox;
        private System.Windows.Forms.TextBox PasswordBox;
        private System.Windows.Forms.Button ConnectButton;
        private System.Windows.Forms.TextBox ChannelBox;
        private System.Windows.Forms.Label label6;
    }
}