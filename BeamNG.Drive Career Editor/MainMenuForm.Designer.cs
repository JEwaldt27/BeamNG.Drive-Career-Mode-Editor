namespace BeamNG.Drive_Career_Editor
{
    partial class MainMenuForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnOpenFileLocationForm;
        private System.Windows.Forms.Button btnOpenEditSaveForm;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            btnOpenFileLocationForm = new Button();
            btnOpenEditSaveForm = new Button();
            SuspendLayout();
            // 
            // btnOpenFileLocationForm
            // 
            btnOpenFileLocationForm.Location = new Point(14, 14);
            btnOpenFileLocationForm.Margin = new Padding(4, 3, 4, 3);
            btnOpenFileLocationForm.Name = "btnOpenFileLocationForm";
            btnOpenFileLocationForm.Size = new Size(303, 27);
            btnOpenFileLocationForm.TabIndex = 0;
            btnOpenFileLocationForm.Text = "Change File Location";
            btnOpenFileLocationForm.UseVisualStyleBackColor = true;
            btnOpenFileLocationForm.Click += btnOpenFileLocationForm_Click;
            // 
            // btnOpenEditSaveForm
            // 
            btnOpenEditSaveForm.Location = new Point(14, 47);
            btnOpenEditSaveForm.Margin = new Padding(4, 3, 4, 3);
            btnOpenEditSaveForm.Name = "btnOpenEditSaveForm";
            btnOpenEditSaveForm.Size = new Size(303, 27);
            btnOpenEditSaveForm.TabIndex = 1;
            btnOpenEditSaveForm.Text = "Edit Game Save";
            btnOpenEditSaveForm.UseVisualStyleBackColor = true;
            btnOpenEditSaveForm.Click += btnOpenEditSaveForm_Click;
            // 
            // MainMenuForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(333, 87);
            Controls.Add(btnOpenEditSaveForm);
            Controls.Add(btnOpenFileLocationForm);
            Margin = new Padding(4, 3, 4, 3);
            Name = "MainMenuForm";
            Text = "Main Menu";
            ResumeLayout(false);
        }
    }
}
