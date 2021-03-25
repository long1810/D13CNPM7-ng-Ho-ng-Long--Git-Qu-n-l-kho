namespace CT_GT1
{
    partial class fmthongkeNhap
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
            this.dtp_ngaynhap = new System.Windows.Forms.DateTimePicker();
            this.btnngay = new System.Windows.Forms.Button();
            this.btnthang = new System.Windows.Forms.Button();
            this.btnnam = new System.Windows.Forms.Button();
            this.dgcphieunhap = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.nubtongtien = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.nudsoluiong = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgcphieunhap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nubtongtien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudsoluiong)).BeginInit();
            this.SuspendLayout();
            // 
            // dtp_ngaynhap
            // 
            this.dtp_ngaynhap.CustomFormat = "MM/dd/yyyy";
            this.dtp_ngaynhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_ngaynhap.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_ngaynhap.Location = new System.Drawing.Point(70, 50);
            this.dtp_ngaynhap.Name = "dtp_ngaynhap";
            this.dtp_ngaynhap.Size = new System.Drawing.Size(200, 26);
            this.dtp_ngaynhap.TabIndex = 0;
            this.dtp_ngaynhap.Value = new System.DateTime(2020, 1, 30, 0, 0, 0, 0);
            this.dtp_ngaynhap.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // btnngay
            // 
            this.btnngay.Location = new System.Drawing.Point(315, 25);
            this.btnngay.Name = "btnngay";
            this.btnngay.Size = new System.Drawing.Size(87, 51);
            this.btnngay.TabIndex = 2;
            this.btnngay.Text = "theo ngày";
            this.btnngay.UseVisualStyleBackColor = true;
            this.btnngay.Click += new System.EventHandler(this.btnngay_Click);
            // 
            // btnthang
            // 
            this.btnthang.Location = new System.Drawing.Point(435, 25);
            this.btnthang.Name = "btnthang";
            this.btnthang.Size = new System.Drawing.Size(87, 51);
            this.btnthang.TabIndex = 3;
            this.btnthang.Text = "theo tháng";
            this.btnthang.UseVisualStyleBackColor = true;
            this.btnthang.Click += new System.EventHandler(this.btnthang_Click);
            // 
            // btnnam
            // 
            this.btnnam.Location = new System.Drawing.Point(551, 25);
            this.btnnam.Name = "btnnam";
            this.btnnam.Size = new System.Drawing.Size(87, 51);
            this.btnnam.TabIndex = 4;
            this.btnnam.Text = "theo năm";
            this.btnnam.UseVisualStyleBackColor = true;
            this.btnnam.Click += new System.EventHandler(this.btnnam_Click);
            // 
            // dgcphieunhap
            // 
            this.dgcphieunhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgcphieunhap.Location = new System.Drawing.Point(51, 104);
            this.dgcphieunhap.Name = "dgcphieunhap";
            this.dgcphieunhap.Size = new System.Drawing.Size(696, 186);
            this.dgcphieunhap.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(462, 323);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "Tổng tiền nhập ";
            // 
            // nubtongtien
            // 
            this.nubtongtien.Location = new System.Drawing.Point(627, 327);
            this.nubtongtien.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.nubtongtien.Name = "nubtongtien";
            this.nubtongtien.Size = new System.Drawing.Size(120, 20);
            this.nubtongtien.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(66, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "DD/MM/YY";
            // 
            // nudsoluiong
            // 
            this.nudsoluiong.Location = new System.Drawing.Point(224, 323);
            this.nudsoluiong.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.nudsoluiong.Name = "nudsoluiong";
            this.nudsoluiong.Size = new System.Drawing.Size(120, 20);
            this.nudsoluiong.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 319);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(211, 24);
            this.label3.TabIndex = 9;
            this.label3.Text = "Tổng Số lượng đã nhập";
            // 
            // fmthongkeNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 410);
            this.Controls.Add(this.nudsoluiong);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nubtongtien);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgcphieunhap);
            this.Controls.Add(this.btnnam);
            this.Controls.Add(this.btnthang);
            this.Controls.Add(this.btnngay);
            this.Controls.Add(this.dtp_ngaynhap);
            this.Name = "fmthongkeNhap";
            this.Text = "fmthongkeNhap";
            this.Load += new System.EventHandler(this.fmthongkeNhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgcphieunhap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nubtongtien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudsoluiong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtp_ngaynhap;
        private System.Windows.Forms.Button btnngay;
        private System.Windows.Forms.Button btnthang;
        private System.Windows.Forms.Button btnnam;
        private System.Windows.Forms.DataGridView dgcphieunhap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nubtongtien;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudsoluiong;
        private System.Windows.Forms.Label label3;
    }
}