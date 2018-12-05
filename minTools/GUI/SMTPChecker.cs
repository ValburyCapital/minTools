using System;
using minTools.Email;
using System.Windows.Forms;

namespace minTools.GUI
{
    public partial class SMTPChecker : Form
    {
        bool testConnectionPassed = false;
        public SMTPChecker()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void SMTPChecker_Load(object sender, EventArgs e)
        {
            clearLabels();
        }

        void clearLabels()
        {
            lblServerStatusAnswer.Text = lblCredentialsAnswer.Text = "";
        }

        private void btnTestServer_Click(object sender, EventArgs e)
        {
            clearLabels();

            lblServerStatusAnswer.Text = "Testing...";

            string hostname = tbHostname.Text;
            if (hostname.Trim().Equals(string.Empty))
            {
                lblServerStatusAnswer.Text = "Hostname required";
                return;
            }

            int portNum = getPortNum_ChangeTextboxIfIncorrect();

            lblServerStatusAnswer.Text = "Testing connection...";

            string outputMessage;
            if ((testConnectionPassed = new SMTPStatusChecker().testConnection(hostname, portNum, cbEnableSSL.Checked, out outputMessage)))
                lblServerStatusAnswer.Text = outputMessage;
            else
                lblServerStatusAnswer.Text = outputMessage;
        }

        int getPortNum_ChangeTextboxIfIncorrect()
        {
            int portNum, defaultPortNum = 25, defaultSSLPortNum = 465;

            if (!int.TryParse(tbPort.Text, out portNum))
                if (cbEnableSSL.Checked)                //couldnt convert
                    tbPort.Text = (portNum = defaultSSLPortNum).ToString(); //set all 3 at once
                else
                    tbPort.Text = (portNum = defaultPortNum).ToString();    //set all 3 at once

            return portNum;
        }

        private void btnTestCredentials_Click(object sender, EventArgs e)
        {
            //update labels using the click routine of testConnection
            btnTestServer_Click(sender, e);

            if (!testConnectionPassed)
                return;

            lblCredentialsAnswer.Text = "Testing...";
            string hostname = tbHostname.Text;
            int port = getPortNum_ChangeTextboxIfIncorrect();

            string user = tbUsername.Text;
            if (user.Trim().Equals(string.Empty))
            {
                lblCredentialsAnswer.Text = "Username required";
                return;
            }
            string pass = tbPassword.Text;
            if (pass.Trim().Equals(string.Empty))
            {
                lblCredentialsAnswer.Text = "Password required";
                return;
            }

            lblCredentialsAnswer.Text = "Testing credentials";

            string outputMessage;
            if (new SMTPStatusChecker().testCredentials(hostname, port, user, pass, cbEnableSSL.Checked, out outputMessage))
                lblCredentialsAnswer.Text = "Credentials valid";
            else
                lblCredentialsAnswer.Text = "Credentials invalid";
        }

        private void cbEnableSSL_CheckedChanged(object sender, EventArgs e)
        {

        }

    }
}

