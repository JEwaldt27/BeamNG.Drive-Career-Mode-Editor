using System;
using System.IO;
using System.Windows.Forms;

namespace BeamNG.Drive_Career_Editor
{
    public partial class FileLocationForm : Form
    {
        public FileLocationForm()
        {
            InitializeComponent();
        }

        private void FileLocationForm_Load(object sender, EventArgs e)
        {
            // Load the saved file path if it exists
            if (File.Exists("filePath.txt"))
            {
                string savedPath = File.ReadAllText("filePath.txt");
                lblSelectedPath.Text = "Current Directory: " + savedPath;

                // Save the path to memory
                Program.FilePath = savedPath;
            }
        }

        private void btnSelectFolder_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
            {
                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    string selectedPath = folderBrowserDialog.SelectedPath;
                    lblSelectedPath.Text = "Current Directory: " + selectedPath;

                    // Save the path to memory
                    Program.FilePath = selectedPath;

                    // Save the path to a file
                    File.WriteAllText("filePath.txt", selectedPath);

                    // Find the most recent folder in the new path
                    FindMostRecentFolder();
                }
            }
        }

        private void FindMostRecentFolder()
        {
            string directoryPath = Program.FilePath;

            if (Directory.Exists(directoryPath))
            {
                var mostRecentFolder = new DirectoryInfo(directoryPath)
                    .GetDirectories()
                    .OrderByDescending(d => d.LastWriteTime)
                    .FirstOrDefault();

                if (mostRecentFolder != null)
                {
                    // Display the folder name in the label
                    lblSelectedPath.Text = $"Current Directory: {mostRecentFolder.Name}";
                }
                else
                {
                    lblSelectedPath.Text = "No folders found in the directory.";
                }
            }
            else
            {
                lblSelectedPath.Text = "The specified directory does not exist.";
            }
        }
    }
}
