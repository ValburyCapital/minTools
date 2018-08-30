using System;
using minTools;
using System.IO;
using System.Windows.Forms;

namespace minTools
{
    public partial class FolderTools : Form
    {
        public class FolderToolsData
        {
            public FolderToolsData()
            {
                pathName = "";
            }
            public string pathName;
        } 
        public FolderToolsData data = new FolderToolsData();

        public FolderTools()
        {
            InitializeComponent();
        }

        private void FolderTools_Load(object sender, EventArgs e)
        {
            //select the first item in Comoboxes
            comboDateModified.SelectedIndex = comboKeywords.SelectedIndex = comboFileSize.SelectedIndex = 0;
        }
        
        void setFolder(string path)
        {
            //check folder is valid
            if (!Directory.Exists(path))
            {
                gbSearchOptions.Enabled = false;
                return;
            }

            //save details
            tbFolderName.Text = data.pathName = path;

            updateFileCount();

            //enable disabled groupbox
            gbSearchOptions.Enabled = true;
        }

        void updateFileCount()
        {
            //we have a valid folder, enumerate files within
            int count = Directory.GetFiles(data.pathName).Length;
            lbFilesInFolderAmount.Text = count.ToString();

            lbEstimatedMatchesAmount.Text = new FolderToolsCollection.BatchRenamer().getFilesAfterFiltering(createOptionsFromGUISelections()).Count.ToString();
        }

        FolderToolsCollection.BatchOptions createOptionsFromGUISelections()
        {
            FolderToolsCollection.BatchOptions output = new FolderToolsCollection.BatchOptions();

            if (cbDateModified.Checked)
                switch (comboDateModified.SelectedItem.ToString())
                {
                    case "On this day":
                        output.dmOptions = FolderToolsCollection.DateModifiedFilterOptions.OnThisDay;
                        break;
                    case "Before this day":
                        output.dmOptions = FolderToolsCollection.DateModifiedFilterOptions.BeforeThisDay;
                        break;
                    case "On or before this day":
                        output.dmOptions = FolderToolsCollection.DateModifiedFilterOptions.OnOrBeforeThisDay;
                        break;
                    case "After this day":
                        output.dmOptions = FolderToolsCollection.DateModifiedFilterOptions.AfterThisDay;
                        break;
                    case "On or after this day":
                        output.dmOptions = FolderToolsCollection.DateModifiedFilterOptions.OnOrAfterThisDay;
                        break;
                }

            if (cbFileSize.Checked)
            {
                switch(comboFileSize.SelectedItem.ToString())
                {
                    case "Kb":
                        output.sizeOptions = FolderToolsCollection.FileSizeSizeOptions.Kb;
                        break;

                    case "Mb":
                        output.sizeOptions = FolderToolsCollection.FileSizeSizeOptions.Mb;
                        break;

                    case "Gb":
                        output.sizeOptions = FolderToolsCollection.FileSizeSizeOptions.Gb;
                        break;
                }
                output.fileSize = (double)numericUpDown1.Value;
            }

            if (cbKeywords.Checked)
            {
                switch (comboKeywords.SelectedItem.ToString())
                {
                    case "contains":
                        output.keywordOptions = FolderToolsCollection.KeywordFilterOptions.Contains;
                        break;

                    case "starts with":
                        output.keywordOptions = FolderToolsCollection.KeywordFilterOptions.StartsWith;
                        break;

                    default:
                        output.keywordOptions = FolderToolsCollection.KeywordFilterOptions.None;
                        break;
                }
                output.keywords = tbKeywords.Text;
            }

            output.searchLocation = tbFolderName.Text;

            return output;
        }

        private void btnChooseFolder_Click(object sender, EventArgs e)
        {
            var FD = new FolderBrowserDialog();
            if (FD.ShowDialog() != DialogResult.OK)
                return;
            string pathToOpen = FD.SelectedPath;

            setFolder(pathToOpen);
        }

        private void gbFileRename_Enter(object sender, EventArgs e)
        {

        }

        private void cbKeywords_CheckedChanged(object sender, EventArgs e)
        {
            if (cbKeywords.Checked)
                comboKeywords.Enabled = tbKeywords.Enabled = true;
            else
                comboKeywords.Enabled = tbKeywords.Enabled = false;

            updateFileCount();
        }

        private void cbDateModified_CheckedChanged(object sender, EventArgs e)
        {
            if (cbDateModified.Checked)
                comboDateModified.Enabled = dtpDateModified.Enabled = true;
            else
                comboDateModified.Enabled = dtpDateModified.Enabled = false;
            updateFileCount();
        }

        private void tbFolderName_TextChanged(object sender, EventArgs e)
        {
            if (Directory.Exists(tbFolderName.Text))
                setFolder(tbFolderName.Text);
            else
                gbSearchOptions.Enabled = false;

            updateFileCount();
        }

        private void cbFileSize_CheckedChanged(object sender, EventArgs e)
        {
            if (cbFileSize.Checked)
                comboFileSize.Enabled = numericUpDown1.Enabled = true;
            else
                comboFileSize.Enabled = numericUpDown1.Enabled = false;

            updateFileCount();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void tbKeywords_TextChanged(object sender, EventArgs e)
        {
            updateFileCount();
        }
    }
}
