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
        private int beamXPLineIndex = 33; // Line 34 in 0-based index
        private int adventurerLineIndex = 9; // Line 10 in 0-based index
        private int apexRacingLineIndex = 19; // Line 20 in 0-based index
        private int crawlLineIndex = 55; // Line 56 in 0-based index
        private int criminalLineIndex = 65; // Line 66 in 0-based index
        private int deliveryLineIndex = 75; // Line 76 in 0-based index
        private int laborerLineIndex = 100; // Line 101 in 0-based index
        private int vehicleDeliveryLineIndex = 200; // Line 201 in 0-based index

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
                                if (lines.Length > moneyLineIndex && lines.Length > bonusStarsLineIndex && lines.Length > beamXPLineIndex && lines.Length > adventurerLineIndex &&
                                    lines.Length > apexRacingLineIndex && lines.Length > crawlLineIndex && lines.Length > criminalLineIndex && lines.Length > deliveryLineIndex &&
                                    lines.Length > laborerLineIndex && lines.Length > vehicleDeliveryLineIndex)
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

                                    // Read and set BeamXP value
                                    string beamXPLine = lines[beamXPLineIndex];
                                    string beamXPValueString = ExtractValue(beamXPLine);

                                    if (float.TryParse(beamXPValueString, out float beamXPValue))
                                    {
                                        txtBeamXP.Text = beamXPValue.ToString();
                                    }
                                    else
                                    {
                                        MessageBox.Show("Unable to parse the BeamXP value from the JSON file.");
                                    }

                                    // Read and set Adventurer value
                                    string adventurerLine = lines[adventurerLineIndex];
                                    string adventurerValueString = ExtractValue(adventurerLine);

                                    if (float.TryParse(adventurerValueString, out float adventurerValue))
                                    {
                                        txtAdventurer.Text = adventurerValue.ToString();
                                    }
                                    else
                                    {
                                        MessageBox.Show("Unable to parse the adventurer value from the JSON file.");
                                    }

                                    // Read and set Apex Racing value
                                    string apexRacingLine = lines[apexRacingLineIndex];
                                    string apexRacingValueString = ExtractValue(apexRacingLine);

                                    if (float.TryParse(apexRacingValueString, out float apexRacingValue))
                                    {
                                        txtApexRacing.Text = apexRacingValue.ToString();
                                    }
                                    else
                                    {
                                        MessageBox.Show("Unable to parse the Apex Racing value from the JSON file.");
                                    }

                                    // Read and set Crawl value
                                    string crawlLine = lines[crawlLineIndex];
                                    string crawlValueString = ExtractValue(crawlLine);

                                    if (float.TryParse(crawlValueString, out float crawlValue))
                                    {
                                        txtCrawl.Text = crawlValue.ToString();
                                    }
                                    else
                                    {
                                        MessageBox.Show("Unable to parse the Crawl value from the JSON file.");
                                    }

                                    // Read and set Criminal value
                                    string criminalLine = lines[criminalLineIndex];
                                    string criminalValueString = ExtractValue(criminalLine);

                                    if (float.TryParse(criminalValueString, out float criminalValue))
                                    {
                                        txtCriminal.Text = criminalValue.ToString();
                                    }
                                    else
                                    {
                                        MessageBox.Show("Unable to parse the Criminal value from the JSON file.");
                                    }

                                    // Read and set Delivery value
                                    string deliveryLine = lines[deliveryLineIndex];
                                    string deliveryValueString = ExtractValue(deliveryLine);

                                    if (float.TryParse(deliveryValueString, out float deliveryValue))
                                    {
                                        txtDelivery.Text = deliveryValue.ToString();
                                    }
                                    else
                                    {
                                        MessageBox.Show("Unable to parse the Delivery value from the JSON file.");
                                    }

                                    // Read and set Laborer value
                                    string laborerLine = lines[laborerLineIndex];
                                    string laborerValueString = ExtractValue(laborerLine);

                                    if (float.TryParse(laborerValueString, out float laborerValue))
                                    {
                                        txtLaborer.Text = laborerValue.ToString();
                                    }
                                    else
                                    {
                                        MessageBox.Show("Unable to parse the Laborer value from the JSON file.");
                                    }

                                    // Read and set Vehicle Delivery value
                                    string vehicleDeliveryLine = lines[vehicleDeliveryLineIndex];
                                    string vehicleDeliveryValueString = ExtractValue(vehicleDeliveryLine);

                                    if (float.TryParse(vehicleDeliveryValueString, out float vehicleDeliveryValue))
                                    {
                                        txtVehicleDelivery.Text = vehicleDeliveryValue.ToString();
                                    }
                                    else
                                    {
                                        MessageBox.Show("Unable to parse the Vehicle Delivery value from the JSON file.");
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
            if (float.TryParse(txtMoney.Text, out float newMoneyValue) && float.TryParse(txtBonusStars.Text, out float newBonusStarsValue) &&
                float.TryParse(txtBeamXP.Text, out float newBeamXPValue) && float.TryParse(txtAdventurer.Text, out float newAdventurerValue) &&
                float.TryParse(txtApexRacing.Text, out float newApexRacingValue) && float.TryParse(txtCrawl.Text, out float newCrawlValue) &&
                float.TryParse(txtCriminal.Text, out float newCriminalValue) && float.TryParse(txtDelivery.Text, out float newDeliveryValue) &&
                float.TryParse(txtLaborer.Text, out float newLaborerValue) && float.TryParse(txtVehicleDelivery.Text, out float newVehicleDeliveryValue))
            {
                try
                {
                    string[] lines = File.ReadAllLines(jsonFilePath);
                    if (lines.Length > moneyLineIndex && lines.Length > bonusStarsLineIndex && lines.Length > beamXPLineIndex && lines.Length > adventurerLineIndex &&
                        lines.Length > apexRacingLineIndex && lines.Length > crawlLineIndex && lines.Length > criminalLineIndex && lines.Length > deliveryLineIndex &&
                        lines.Length > laborerLineIndex && lines.Length > vehicleDeliveryLineIndex)
                    {
                        // Update Money value
                        lines[moneyLineIndex] = $"\"value\": {newMoneyValue}";
                        // Update Bonus Stars value
                        lines[bonusStarsLineIndex] = $"\"value\": {newBonusStarsValue}";
                        // Update BeamXP value
                        lines[beamXPLineIndex] = $"\"value\": {newBeamXPValue}";
                        // Update Adventurer value
                        lines[adventurerLineIndex] = $"\"value\": {newAdventurerValue}";
                        // Update Apex Racing value
                        lines[apexRacingLineIndex] = $"\"value\": {newApexRacingValue}";
                        // Update Crawl value
                        lines[crawlLineIndex] = $"\"value\": {newCrawlValue}";
                        // Update Criminal value
                        lines[criminalLineIndex] = $"\"value\": {newCriminalValue}";
                        // Update Delivery value
                        lines[deliveryLineIndex] = $"\"value\": {newDeliveryValue}";
                        // Update Laborer value
                        lines[laborerLineIndex] = $"\"value\": {newLaborerValue}";
                        // Update Vehicle Delivery value
                        lines[vehicleDeliveryLineIndex] = $"\"value\": {newVehicleDeliveryValue}";
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
