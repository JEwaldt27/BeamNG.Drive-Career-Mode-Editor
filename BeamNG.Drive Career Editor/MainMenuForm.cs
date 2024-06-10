using System;
using System.Windows.Forms;

namespace BeamNG.Drive_Career_Editor
{
    public partial class MainMenuForm : Form
    {
        public MainMenuForm()
        {
            InitializeComponent();
        }

        private void btnOpenFileLocationForm_Click(object sender, EventArgs e)
        {
            FileLocationForm fileLocationForm = new FileLocationForm();
            fileLocationForm.Show();
        }

        private void btnOpenEditSaveForm_Click(object sender, EventArgs e)
        {
            EditSaveForm editSaveForm = new EditSaveForm();
            editSaveForm.Show();
        }
    }
}
