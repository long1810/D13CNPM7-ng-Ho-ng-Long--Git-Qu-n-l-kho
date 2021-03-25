namespace CT_GT1
{
    partial class fm_kho
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
            this.label5 = new System.Windows.Forms.Label();
            this.flpkho = new System.Windows.Forms.FlowLayoutPanel();
            this.txtmak = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvkho = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.nubsl = new System.Windows.Forms.NumericUpDown();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvkho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nubsl)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(38, 37);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(241, 33);
            this.label5.TabIndex = 40;
            this.label5.Text = "Chọn kho cần nhập:";
            // 
            // flpkho
            // 
            this.flpkho.BackColor = System.Drawing.SystemColors.Info;
            this.flpkho.Location = new System.Drawing.Point(48, 77);
            this.flpkho.Name = "flpkho";
            this.flpkho.Size = new System.Drawing.Size(231, 206);
            this.flpkho.TabIndex = 39;
            // 
            // txtmak
            // 
            this.txtmak.AcceptsReturn = true;
            this.txtmak.Location = new System.Drawing.Point(175, 40);
            this.txtmak.Margin = new System.Windows.Forms.Padding(4);
            this.txtmak.Name = "txtmak";
            this.txtmak.Size = new System.Drawing.Size(160, 22);
            this.txtmak.TabIndex = 42;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(93, 40);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 17);
            this.label3.TabIndex = 41;
            this.label3.Text = "Mã kho: ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvkho);
            this.groupBox1.Controls.Add(this.txtmak);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(373, 37);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(710, 490);
            this.groupBox1.TabIndex = 43;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "phiếu nhập";
            // 
            // dgvkho
            // 
            this.dgvkho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvkho.Location = new System.Drawing.Point(8, 93);
            this.dgvkho.Margin = new System.Windows.Forms.Padding(4);
            this.dgvkho.Name = "dgvkho";
            this.dgvkho.RowHeadersWidth = 51;
            this.dgvkho.Size = new System.Drawing.Size(685, 389);
            this.dgvkho.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 322);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 55);
            this.label1.TabIndex = 44;
            this.label1.Text = "Số lượng hàng trong kho: ";
            // 
            // nubsl
            // 
            this.nubsl.Location = new System.Drawing.Point(174, 337);
            this.nubsl.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nubsl.Minimum = new decimal(new int[] {
            99,
            0,
            0,
            -2147483648});
            this.nubsl.Name = "nubsl";
            this.nubsl.Size = new System.Drawing.Size(120, 22);
            this.nubsl.TabIndex = 47;
            // 
            // fm_kho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1139, 565);
            this.Controls.Add(this.nubsl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.flpkho);
            this.Name = "fm_kho";
            this.Text = "fm_kho";
            this.Load += new System.EventHandler(this.fm_kho_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvkho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nubsl)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.FlowLayoutPanel flpkho;
        private System.Windows.Forms.TextBox txtmak;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvkho;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nubsl;
    }
}