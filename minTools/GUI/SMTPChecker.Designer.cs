namespace minTools.GUI
{
    partial class SMTPChecker
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbEnableSSL = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbPort = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbHostname = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnTestServer = new System.Windows.Forms.Button();
            this.btnTestCredentials = new System.Windows.Forms.Button();
            this.lblCredentialsAnswer = new System.Windows.Forms.Label();
            this.lblServerStatusAnswer = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbEnableSSL);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tbPort);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbHostname);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(388, 76);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SMTP Server";
            // 
            // cbEnableSSL
            // 
            this.cbEnableSSL.AutoSize = true;
            this.cbEnableSSL.Location = new System.Drawing.Point(192, 47);
            this.cbEnableSSL.Name = "cbEnableSSL";
            this.cbEnableSSL.Size = new System.Drawing.Size(82, 17);
            this.cbEnableSSL.TabIndex = 6;
            this.cbEnableSSL.Text = "Enable SSL";
            this.cbEnableSSL.UseVisualStyleBackColor = true;
            this.cbEnableSSL.CheckedChanged += new System.EventHandler(this.cbEnableSSL_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(73, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Port:";
            // 
            // tbPort
            // 
            this.tbPort.Location = new System.Drawing.Point(108, 45);
            this.tbPort.Name = "tbPort";
            this.tbPort.Size = new System.Drawing.Size(78, 20);
            this.tbPort.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "SMTP Hostname:";
            // 
            // tbHostname
            // 
            this.tbHostname.Location = new System.Drawing.Point(108, 19);
            this.tbHostname.Name = "tbHostname";
            this.tbHostname.Size = new System.Drawing.Size(270, 20);
            this.tbHostname.TabIndex = 0;
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(76, 45);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(302, 20);
            this.tbPassword.TabIndex = 1;
            this.tbPassword.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // tbUsername
            // 
            this.tbUsername.Location = new System.Drawing.Point(76, 19);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(302, 20);
            this.tbUsername.TabIndex = 2;
            this.tbUsername.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Username:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Password:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.tbPassword);
            this.groupBox2.Controls.Add(this.tbUsername);
            this.groupBox2.Location = new System.Drawing.Point(12, 94);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(388, 80);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Credentials";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnTestServer);
            this.groupBox3.Controls.Add(this.btnTestCredentials);
            this.groupBox3.Controls.Add(this.lblCredentialsAnswer);
            this.groupBox3.Controls.Add(this.lblServerStatusAnswer);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(12, 180);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(388, 72);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Results";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // btnTestServer
            // 
            this.btnTestServer.Location = new System.Drawing.Point(303, 11);
            this.btnTestServer.Name = "btnTestServer";
            this.btnTestServer.Size = new System.Drawing.Size(75, 23);
            this.btnTestServer.TabIndex = 6;
            this.btnTestServer.Text = "Test";
            this.btnTestServer.UseVisualStyleBackColor = true;
            this.btnTestServer.Click += new System.EventHandler(this.btnTestServer_Click);
            // 
            // btnTestCredentials
            // 
            this.btnTestCredentials.Location = new System.Drawing.Point(303, 40);
            this.btnTestCredentials.Name = "btnTestCredentials";
            this.btnTestCredentials.Size = new System.Drawing.Size(75, 23);
            this.btnTestCredentials.TabIndex = 5;
            this.btnTestCredentials.Text = "Test";
            this.btnTestCredentials.UseVisualStyleBackColor = true;
            this.btnTestCredentials.Click += new System.EventHandler(this.btnTestCredentials_Click);
            // 
            // lblCredentialsAnswer
            // 
            this.lblCredentialsAnswer.AutoSize = true;
            this.lblCredentialsAnswer.Location = new System.Drawing.Point(86, 45);
            this.lblCredentialsAnswer.Name = "lblCredentialsAnswer";
            this.lblCredentialsAnswer.Size = new System.Drawing.Size(104, 13);
            this.lblCredentialsAnswer.TabIndex = 4;
            this.lblCredentialsAnswer.Text = "lblCredentialsAnswer";
            // 
            // lblServerStatusAnswer
            // 
            this.lblServerStatusAnswer.AutoSize = true;
            this.lblServerStatusAnswer.Location = new System.Drawing.Point(86, 16);
            this.lblServerStatusAnswer.Name = "lblServerStatusAnswer";
            this.lblServerStatusAnswer.Size = new System.Drawing.Size(113, 13);
            this.lblServerStatusAnswer.TabIndex = 3;
            this.lblServerStatusAnswer.Text = "lblServerStatusAnswer";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Credentials:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Server Status:";
            // 
            // SMTPChecker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 258);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "SMTPChecker";
            this.Text = "SMTPChecker";
            this.Load += new System.EventHandler(this.SMTPChecker_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.TextBox tbHostname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbPort;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox cbEnableSSL;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblCredentialsAnswer;
        private System.Windows.Forms.Label lblServerStatusAnswer;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnTestServer;
        private System.Windows.Forms.Button btnTestCredentials;
    }
}