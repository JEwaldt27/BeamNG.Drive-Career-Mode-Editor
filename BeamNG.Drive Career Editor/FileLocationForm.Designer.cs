namespace BeamNG.Drive_Career_Editor
{
    partial class FileLocationForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblSelectedPath;
        private System.Windows.Forms.Button btnSelectFolder;

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
            lblSelectedPath = new Label();
            btnSelectFolder = new Button();
            SuspendLayout();
            // 
            // lblSelectedPath
            // 
            lblSelectedPath.AutoSize = true;
            lblSelectedPath.Location = new Point(12, 15);
            lblSelectedPath.Name = "lblSelectedPath";
            lblSelectedPath.Size = new Size(104, 15);
            lblSelectedPath.TabIndex = 0;
            lblSelectedPath.Text = "Current Directory: ";
            // 
            // btnSelectFolder
            // 
            btnSelectFolder.Location = new Point(12, 41);
            btnSelectFolder.Name = "btnSelectFolder";
            btnSelectFolder.Size = new Size(591, 23);
            btnSelectFolder.TabIndex = 1;
            btnSelectFolder.Text = "Select Folder";
            btnSelectFolder.UseVisualStyleBackColor = true;
            btnSelectFolder.Click += btnSelectFolder_Click;
            // 
            // FileLocationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(615, 76);
            Controls.Add(btnSelectFolder);
            Controls.Add(lblSelectedPath);
            Name = "FileLocationForm";
            Text = "File Location";
            Load += FileLocationForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
