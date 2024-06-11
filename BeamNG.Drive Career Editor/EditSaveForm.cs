using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace BeamNG.Drive_Career_Editor
{
    public partial class EditSaveForm : Form
    {
        private string jsonFilePath = string.Empty; // Initialize to an empty string
        private int moneyLineIndex = 135; // Line 136 in 0-based index
        private int bonusStarsLineIndex = 45; // Line 46 in 0-based index

        public EditSaveForm()
        {
            InitializeComponent();
        }

        private void EditSaveForm_Load(object sender, EventArgs e)
        {
            LoadFilePath();
            FindMostRecentFolder();
        }

        private void LoadFilePath()
        {
            // Load the saved file path if it exists
            if (File.Exists("filePath.txt"))
            {
                string savedPath = File.ReadAllText("filePath.txt");
                Program.FilePath = savedPath; // Also set it to the Program.FilePath for consistency
            }
            else
            {
                MessageBox.Show("filePath.txt not found. Please set the file location first.");
            }
        }

        private void FindMostRecentFolder()
        {
            string directoryPath = Program.FilePath; // Use the saved file path

            if (Directory.Exists(directoryPath))
            {
                var mostRecentFolder = new DirectoryInfo(directoryPath)
                    .GetDirectories()
                    .OrderByDescending(d => d.LastWriteTime)
                    .FirstOrDefault();

                if (mostRecentFolder != null)
                {
                    // Display the folder name in the label
                    lblEditingFolder.Text = $"Editing {mostRecentFolder.Name}";

                    // Read the float value from the JSON file
                    string careerFolderPath = Path.Combine(mostRecentFolder.FullName, "career");
                    jsonFilePath = Path.Combine(careerFolderPath, "playerAttributes.json");

                    if (Directory.Exists(careerFolderPath))
                    {
                        if (File.Exists(jsonFilePath))
                        {
                            try
                            {
                                string[] lines = File.ReadAllLines(jsonFilePath);
                                if (lines.Length > moneyLineIndex && lines.Length > bonusStarsLineIndex)
                                {
                                    // Read and set Money value
                                    string moneyLine = lines[moneyLineIndex];
                                    string moneyValueString = ExtractValue(moneyLine);

                                    if (float.TryParse(moneyValueString, out float moneyValue))
                                    {
                                        txtMoney.Text = moneyValue.ToString();
                                    }
                                    else
                                    {
                                        MessageBox.Show("Unable to parse the money value from the JSON file.");
                                    }

                                    // Read and set Bonus Stars value
                                    string bonusStarsLine = lines[bonusStarsLineIndex];
                                    string bonusStarsValueString = ExtractValue(bonusStarsLine);

                                    if (float.TryParse(bonusStarsValueString, out float bonusStarsValue))
                                    {
                                        txtBonusStars.Text = bonusStarsValue.ToString();
                                    }
                                    else
                                    {
                                        MessageBox.Show("Unable to parse the bonus stars value from the JSON file.");
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("The JSON file does not contain enough lines.");
                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show($"Error reading JSON file: {ex.Message}");
                            }
                        }
                        else
                        {
                            MessageBox.Show("playerAttributes.json file not found.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("career folder not found.");
                    }
                }
                else
                {
                    lblEditingFolder.Text = "No folders found in the directory.";
                }
            }
            else
            {
                lblEditingFolder.Text = "The specified directory does not exist.";
            }
        }

        private string ExtractValue(string line)
        {
            int startIndex = line.IndexOf(":") + 1;
            int endIndex = line.IndexOf(",");
            if (endIndex == -1) endIndex = line.Length;
            return line.Substring(startIndex, endIndex - startIndex).Trim().Trim('"');
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (float.TryParse(txtMoney.Text, out float newMoneyValue) && float.TryParse(txtBonusStars.Text, out float newBonusStarsValue))
            {
                try
                {
                    string[] lines = File.ReadAllLines(jsonFilePath);
                    if (lines.Length > moneyLineIndex && lines.Length > bonusStarsLineIndex)
                    {
                        // Update Money value
                        lines[moneyLineIndex] = $"\"value\": {newMoneyValue}";
                        // Update Bonus Stars value
                        lines[bonusStarsLineIndex] = $"\"value\": {newBonusStarsValue}";
                        File.WriteAllLines(jsonFilePath, lines);
                        MessageBox.Show("Values updated successfully.");
                    }
                    else
                    {
                        MessageBox.Show("The JSON file does not contain enough lines.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error updating JSON file: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Invalid values. Please enter valid numbers.");
            }
        }
    }
}
