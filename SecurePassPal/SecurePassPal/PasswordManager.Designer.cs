namespace SecurePassPal
{
    partial class PasswordManager
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BtnDeleteRecords = new System.Windows.Forms.Button();
            this.BtnSaveProgress = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(25, 22);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(866, 543);
            this.dataGridView1.TabIndex = 1;
            // 
            // BtnDeleteRecords
            // 
            this.BtnDeleteRecords.Location = new System.Drawing.Point(709, 600);
            this.BtnDeleteRecords.Name = "BtnDeleteRecords";
            this.BtnDeleteRecords.Size = new System.Drawing.Size(182, 23);
            this.BtnDeleteRecords.TabIndex = 2;
            this.BtnDeleteRecords.Text = "Delete Selected Records";
            this.BtnDeleteRecords.UseVisualStyleBackColor = true;
            this.BtnDeleteRecords.Click += new System.EventHandler(this.BtnDeleteRecords_Click);
            // 
            // BtnSaveProgress
            // 
            this.BtnSaveProgress.Location = new System.Drawing.Point(535, 600);
            this.BtnSaveProgress.Name = "BtnSaveProgress";
            this.BtnSaveProgress.Size = new System.Drawing.Size(168, 23);
            this.BtnSaveProgress.TabIndex = 3;
            this.BtnSaveProgress.Text = "Save Progress";
            this.BtnSaveProgress.UseVisualStyleBackColor = true;
            this.BtnSaveProgress.Click += new System.EventHandler(this.BtnSaveProgress_Click);
            // 
            // PasswordManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 643);
            this.Controls.Add(this.BtnSaveProgress);
            this.Controls.Add(this.BtnDeleteRecords);
            this.Controls.Add(this.dataGridView1);
            this.Name = "PasswordManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PasswordManager";
            this.Load += new System.EventHandler(this.PasswordManager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BtnDeleteRecords;
        private System.Windows.Forms.Button BtnSaveProgress;
    }
}