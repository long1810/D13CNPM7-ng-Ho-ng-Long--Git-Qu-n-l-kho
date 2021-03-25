namespace CT_GT1
{
    partial class fmthongkencc
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
            this.btnthongkencc = new System.Windows.Forms.Button();
            this.cmbncc = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvnhacc = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvnhacc)).BeginInit();
            this.SuspendLayout();
            // 
            // btnthongkencc
            // 
            this.btnthongkencc.Location = new System.Drawing.Point(445, 37);
            this.btnthongkencc.Name = "btnthongkencc";
            this.btnthongkencc.Size = new System.Drawing.Size(107, 43);
            this.btnthongkencc.TabIndex = 0;
            this.btnthongkencc.Text = "Thống kê";
            this.btnthongkencc.UseVisualStyleBackColor = true;
            this.btnthongkencc.Click += new System.EventHandler(this.btnthongkencc_Click);
            // 
            // cmbncc
            // 
            this.cmbncc.FormattingEnabled = true;
            this.cmbncc.Location = new System.Drawing.Point(287, 49);
            this.cmbncc.Name = "cmbncc";
            this.cmbncc.Size = new System.Drawing.Size(121, 21);
            this.cmbncc.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(172, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nhà cung cấp";
            // 
            // dgvnhacc
            // 
            this.dgvnhacc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvnhacc.Location = new System.Drawing.Point(22, 136);
            this.dgvnhacc.Name = "dgvnhacc";
            this.dgvnhacc.Size = new System.Drawing.Size(821, 221);
            this.dgvnhacc.TabIndex = 3;
            // 
            // fmthongkencc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 378);
            this.Controls.Add(this.dgvnhacc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbncc);
            this.Controls.Add(this.btnthongkencc);
            this.Name = "fmthongkencc";
            this.Text = "fmthongkencc";
            this.Load += new System.EventHandler(this.fmthongkencc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvnhacc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnthongkencc;
        private System.Windows.Forms.ComboBox cmbncc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvnhacc;
    }
}