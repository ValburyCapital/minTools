using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using minTools.Macquarie;
using minTools.FTP;

namespace minTools.GUI.Macquarie
{
    public partial class MacFTPChecker : Form
    {
        public MacFTPChecker()
        {
            InitializeComponent();
        }

       
        void updateLabels(int csvTotalAmount, int csvEstimatedAmount, int pdfTotalAmount, int pdfEstimatedAmount)
        {
            lblStatementFTPLocation.Text = Constants.MacFTPLocationSignedInAsMacquarie;
            lblEstimatedCSVAnswer.Text = csvEstimatedAmount.ToString();
            lblEstimatedCSVTotalAnswer.Text = csvTotalAmount.ToString();
            lblEstimatedPDFAnswer.Text = pdfEstimatedAmount.ToString();
            lblEstimatedPDFTotalAnswer.Text = pdfTotalAmount.ToString();
        }

        void updateListbox(List<string> directoryListing)
        {
            lbFTPContents.Items.Clear();
            foreach (string file in directoryListing)
                lbFTPContents.Items.Add(file);
        }

        void updateButtons(int csvAmount, int pdfAmount)
        {
            if(pdfAmount != 0)
                btnLaunchPDFTask.Enabled = true;
            else
                btnLaunchPDFTask.Enabled = false;

            if(csvAmount != 0)
                btnLaunchCSVTask.Enabled = true;
            else
                btnLaunchCSVTask.Enabled = false;
        }

        void updateFromFTP()
        {
            //get ftp directory listing
            List<string> contents = FTPToolkit.getFTPDirectoryContents(
                minTools.Macquarie.Constants.MacFTPLocationSignedInAsMacquarie,
                minTools.Macquarie.Constants.MacFTPLocationUser,
                minTools.Macquarie.Constants.MacFTPLocationPass);

            //figure out how many statements in total we have for either type
            int csvAmount = FilenameChecker.howManyRawDataStatements(contents);
            int csvEstimatedAmount = FilenameChecker.howManyRawDataStatements(contents, dtpRawData.Value);
            int pdfAmount = FilenameChecker.howManyClientStatements(contents);
            int pdfEstimatedAmount = FilenameChecker.howManyClientStatements(contents, dtpClientStatements.Value);

            //update gui
            updateLabels(csvAmount, csvEstimatedAmount, pdfAmount, pdfEstimatedAmount);
            updateListbox(contents);
            updateButtons(csvEstimatedAmount, pdfEstimatedAmount);
        }

        private void MacFTPChecker_Load(object sender, EventArgs e)
        {
            //as a default, set the date times to today
            dtpClientStatements.Value = dtpRawData.Value = minTools.Macquarie.BusinessDay.GetLastBusinessDayDateTime(DateTime.Today);

            updateFromFTP();
        }

        private void dtpClientStatements_ValueChanged(object sender, EventArgs e)
        {
            updateFromFTP();
        }

        private void dtpRawData_ValueChanged(object sender, EventArgs e)
        {
            updateFromFTP();
        }

        private void btnLaunchPDFTask_Click(object sender, EventArgs e)
        {
            new minTools.ScheduledTaskRemoteLauncher().launchRemoteTask("SERLONSCRIPT01", "macquarie");
        }
    }
}
