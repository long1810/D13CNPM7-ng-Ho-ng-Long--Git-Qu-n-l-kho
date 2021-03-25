namespace CT_GT1
{
    partial class fmthongkensx
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
            this.cmbmansx = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btntknsx = new System.Windows.Forms.Button();
            this.dgvnsx = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvnsx)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbmansx
            // 
            this.cmbmansx.FormattingEnabled = true;
            this.cmbmansx.Location = new System.Drawing.Point(167, 44);
            this.cmbmansx.Name = "cmbmansx";
            this.cmbmansx.Size = new System.Drawing.Size(130, 21);
            this.cmbmansx.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nhà sản xuất ";
            // 
            // btntknsx
            // 
            this.btntknsx.Location = new System.Drawing.Point(416, 47);
            this.btntknsx.Name = "btntknsx";
            this.btntknsx.Size = new System.Drawing.Size(128, 46);
            this.btntknsx.TabIndex = 2;
            this.btntknsx.Text = "Thống kê";
            this.btntknsx.UseVisualStyleBackColor = true;
            this.btntknsx.Click += new System.EventHandler(this.btntknsx_Click);
            // 
            // dgvnsx
            // 
            this.dgvnsx.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvnsx.Location = new System.Drawing.Point(12, 117);
            this.dgvnsx.Name = "dgvnsx";
            this.dgvnsx.Size = new System.Drawing.Size(753, 266);
            this.dgvnsx.TabIndex = 3;
            // 
            // fmnsx
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 400);
            this.Controls.Add(this.dgvnsx);
            this.Controls.Add(this.btntknsx);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbmansx);
            this.Name = "fmnsx";
            this.Text = "fmnsx";
            this.Load += new System.EventHandler(this.fmnsx_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvnsx)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbmansx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btntknsx;
        private System.Windows.Forms.DataGridView dgvnsx;
    }
}