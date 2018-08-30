using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using minTools.FTP;


namespace minTools
{
    public partial class MainForm : Form
    {
        public class MainFormData
        {
            public FolderTools ftGUI = new FolderTools();
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
        }

        void updateMacqFTPStatusLabel()
        {
           
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
