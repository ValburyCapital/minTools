using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using minTools.GUI.Macquarie;
using minTools.FTP;
using minTools.Valbury.Macquarie;

namespace minTools
{
    public partial class MainForm : Form
    {
        public class MainFormData
        {
            public FolderTools ftGUI = new FolderTools();
            public MacFTPChecker mftpcGUI = new MacFTPChecker();
        }

        MainFormData data = new MainFormData();

        public MainForm()
        {
            InitializeComponent();
            niSysTray.ShowBalloonTip(1000, "Wizzlers", "heerror", new ToolTipIcon());
        }

        private void folderToolsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (data.ftGUI.Visible == false)
                data.ftGUI = new FolderTools();
            data.ftGUI.Show();
        }

        private void fTPCheckerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showFTPChecker();
        }

        void showFTPChecker()
        {
            if (data.mftpcGUI.Visible == false)
                data.mftpcGUI = new MacFTPChecker();
            data.mftpcGUI.ShowDialog();
        }

        void updateMacqFTPStatusLabel()
        {
            //get ftp directory listing
            List<string> contents = FTPToolkit.getFTPDirectoryContents(
                Constants.MacFTPLocationSignedInAsMacquarie,
                Constants.MacFTPLocationUser,
                Constants.MacFTPLocationPass);

            int totalStatements = FilenameChecker.howManyClientStatements(contents, BusinessDay.GetLastBusinessDayDateTime(DateTime.Today))
                + FilenameChecker.howManyRawDataStatements(contents, BusinessDay.GetLastBusinessDayDateTime(DateTime.Today));
            lblMacqFTPStatusAnswer.Text = totalStatements.ToString() + " statements waiting";
        }


        private void MainForm_Load(object sender, EventArgs e)
        {
            updateMacqFTPStatusLabel();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            showFTPChecker();
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            //refresh the statements waiting label

        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }
    }
}
