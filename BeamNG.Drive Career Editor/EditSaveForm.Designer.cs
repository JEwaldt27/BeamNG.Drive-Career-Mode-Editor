namespace BeamNG.Drive_Career_Editor
{
    partial class EditSaveForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblMoney;
        private System.Windows.Forms.TextBox txtMoney;
        private System.Windows.Forms.Label lblEditingFolder;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblBonusStars;
        private System.Windows.Forms.TextBox txtBonusStars;

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
            this.lblMoney = new System.Windows.Forms.Label();
            this.txtMoney = new System.Windows.Forms.TextBox();
            this.lblEditingFolder = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblBonusStars = new System.Windows.Forms.Label();
            this.txtBonusStars = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblMoney
            // 
            this.lblMoney.AutoSize = true;
            this.lblMoney.Location = new System.Drawing.Point(12, 45);
            this.lblMoney.Name = "lblMoney";
            this.lblMoney.Size = new System.Drawing.Size(50, 15);
            this.lblMoney.TabIndex = 0;
            this.lblMoney.Text = "Money:";
            // 
            // txtMoney
            // 
            this.txtMoney.Location = new System.Drawing.Point(68, 42);
            this.txtMoney.Name = "txtMoney";
            this.txtMoney.Size = new System.Drawing.Size(100, 23);
            this.txtMoney.TabIndex = 1;
            // 
            // lblEditingFolder
            // 
            this.lblEditingFolder.AutoSize = true;
            this.lblEditingFolder.Location = new System.Drawing.Point(12, 15);
            this.lblEditingFolder.Name = "lblEditingFolder";
            this.lblEditingFolder.Size = new System.Drawing.Size(110, 15);
            this.lblEditingFolder.TabIndex = 2;
            this.lblEditingFolder.Text = "Editing {most recent folder}";
            // 
            // lblBonusStars
            // 
            this.lblBonusStars.AutoSize = true;
            this.lblBonusStars.Location = new System.Drawing.Point(12, 74);
            this.lblBonusStars.Name = "lblBonusStars";
            this.lblBonusStars.Size = new System.Drawing.Size(70, 15);
            this.lblBonusStars.TabIndex = 3;
            this.lblBonusStars.Text = "Bonus Stars:";
            // 
            // txtBonusStars
            // 
            this.txtBonusStars.Location = new System.Drawing.Point(88, 71);
            this.txtBonusStars.Name = "txtBonusStars";
            this.txtBonusStars.Size = new System.Drawing.Size(100, 23);
            this.txtBonusStars.TabIndex = 4;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(68, 100);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 23);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // EditSaveForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(200, 140);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtBonusStars);
            this.Controls.Add(this.lblBonusStars);
            this.Controls.Add(this.lblEditingFolder);
            this.Controls.Add(this.txtMoney);
            this.Controls.Add(this.lblMoney);
            this.Name = "EditSaveForm";
            this.Text = "Edit Save";
            this.Load += new System.EventHandler(this.EditSaveForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
