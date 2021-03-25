namespace CT_GT1
{
    partial class fm_hoadon
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint2 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(43823D, 0D);
            this.btnlammoi = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bnttim = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvhd = new System.Windows.Forms.DataGridView();
            this.txttim = new System.Windows.Forms.TextBox();
            this.Nha = new System.Windows.Forms.GroupBox();
            this.nudthanhtien = new System.Windows.Forms.NumericUpDown();
            this.cmbkh = new System.Windows.Forms.ComboBox();
            this.dtpngaynhap = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtma = new System.Windows.Forms.TextBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvhd)).BeginInit();
            this.Nha.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudthanhtien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnlammoi
            // 
            this.btnlammoi.Location = new System.Drawing.Point(17, 450);
            this.btnlammoi.Margin = new System.Windows.Forms.Padding(4);
            this.btnlammoi.Name = "btnlammoi";
            this.btnlammoi.Size = new System.Drawing.Size(100, 55);
            this.btnlammoi.TabIndex = 18;
            this.btnlammoi.Text = "làm mới";
            this.btnlammoi.UseVisualStyleBackColor = true;
            this.btnlammoi.Click += new System.EventHandler(this.btnlammoi_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(913, 450);
            this.button6.Margin = new System.Windows.Forms.Padding(4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(100, 55);
            this.button6.TabIndex = 23;
            this.button6.Text = "thoát";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(425, 450);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(100, 55);
            this.btnXoa.TabIndex = 24;
            this.btnXoa.Text = "xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(152, 450);
            this.btnthem.Margin = new System.Windows.Forms.Padding(4);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(100, 55);
            this.btnthem.TabIndex = 21;
            this.btnthem.Text = "thêm ";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bnttim);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.dgvhd);
            this.groupBox2.Controls.Add(this.txttim);
            this.groupBox2.Location = new System.Drawing.Point(430, 31);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(725, 388);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hiển thị";
            // 
            // bnttim
            // 
            this.bnttim.Location = new System.Drawing.Point(312, 7);
            this.bnttim.Margin = new System.Windows.Forms.Padding(4);
            this.bnttim.Name = "bnttim";
            this.bnttim.Size = new System.Drawing.Size(100, 55);
            this.bnttim.TabIndex = 18;
            this.bnttim.Text = "tim ";
            this.bnttim.UseVisualStyleBackColor = true;
            this.bnttim.Click += new System.EventHandler(this.bnttim_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(57, 31);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Mã PN";
            // 
            // dgvhd
            // 
            this.dgvhd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvhd.Location = new System.Drawing.Point(8, 74);
            this.dgvhd.Margin = new System.Windows.Forms.Padding(4);
            this.dgvhd.Name = "dgvhd";
            this.dgvhd.RowHeadersWidth = 51;
            this.dgvhd.Size = new System.Drawing.Size(709, 306);
            this.dgvhd.TabIndex = 11;
            this.dgvhd.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvhd_CellClick);
            // 
            // txttim
            // 
            this.txttim.Location = new System.Drawing.Point(156, 23);
            this.txttim.Margin = new System.Windows.Forms.Padding(4);
            this.txttim.Name = "txttim";
            this.txttim.Size = new System.Drawing.Size(132, 22);
            this.txttim.TabIndex = 9;
            // 
            // Nha
            // 
            this.Nha.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.Nha.Controls.Add(this.nudthanhtien);
            this.Nha.Controls.Add(this.cmbkh);
            this.Nha.Controls.Add(this.dtpngaynhap);
            this.Nha.Controls.Add(this.label4);
            this.Nha.Controls.Add(this.label3);
            this.Nha.Controls.Add(this.label2);
            this.Nha.Controls.Add(this.label1);
            this.Nha.Controls.Add(this.txtma);
            this.Nha.Location = new System.Drawing.Point(65, 31);
            this.Nha.Margin = new System.Windows.Forms.Padding(4);
            this.Nha.Name = "Nha";
            this.Nha.Padding = new System.Windows.Forms.Padding(4);
            this.Nha.Size = new System.Drawing.Size(357, 388);
            this.Nha.TabIndex = 19;
            this.Nha.TabStop = false;
            this.Nha.Text = "Xuất hàng";
            // 
            // nudthanhtien
            // 
            this.nudthanhtien.Location = new System.Drawing.Point(155, 237);
            this.nudthanhtien.Margin = new System.Windows.Forms.Padding(4);
            this.nudthanhtien.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.nudthanhtien.Name = "nudthanhtien";
            this.nudthanhtien.Size = new System.Drawing.Size(160, 22);
            this.nudthanhtien.TabIndex = 10;
            // 
            // cmbkh
            // 
            this.cmbkh.FormattingEnabled = true;
            this.cmbkh.Location = new System.Drawing.Point(155, 156);
            this.cmbkh.Margin = new System.Windows.Forms.Padding(4);
            this.cmbkh.Name = "cmbkh";
            this.cmbkh.Size = new System.Drawing.Size(147, 24);
            this.cmbkh.TabIndex = 9;
            // 
            // dtpngaynhap
            // 
            this.dtpngaynhap.CustomFormat = "MM/dd/yyyy";
            this.dtpngaynhap.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpngaynhap.Location = new System.Drawing.Point(155, 113);
            this.dtpngaynhap.Margin = new System.Windows.Forms.Padding(4);
            this.dtpngaynhap.Name = "dtpngaynhap";
            this.dtpngaynhap.Size = new System.Drawing.Size(147, 22);
            this.dtpngaynhap.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 237);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Thanh tiền";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 166);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Khách hàng: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 121);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "ngày nhập";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 75);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã Hóa Đơn:";
            // 
            // txtma
            // 
            this.txtma.Location = new System.Drawing.Point(155, 66);
            this.txtma.Margin = new System.Windows.Forms.Padding(4);
            this.txtma.Name = "txtma";
            this.txtma.Size = new System.Drawing.Size(132, 22);
            this.txtma.TabIndex = 0;
            // 
            // chart1
            // 
            this.chart1.BorderlineWidth = 0;
            chartArea2.BorderWidth = 3;
            chartArea2.CursorX.LineWidth = 0;
            chartArea2.CursorY.LineWidth = 10;
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(65, 589);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.MarkerSize = 67;
            series2.Name = "Tiền nhập";
            dataPoint2.IsValueShownAsLabel = false;
            series2.Points.Add(dataPoint2);
            series2.XValueMember = "ngaynhap";
            series2.YValueMembers = "tienNhap";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(1541, 293);
            this.chart1.TabIndex = 25;
            this.chart1.Text = "chart1";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(632, 536);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(219, 32);
            this.label6.TabIndex = 11;
            this.label6.Text = "Thống kê hóa đơn";
            // 
            // fm_hoadon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1698, 894);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.btnlammoi);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.Nha);
            this.Name = "fm_hoadon";
            this.Text = "fm_hoadon";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.fm_hoadon_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvhd)).EndInit();
            this.Nha.ResumeLayout(false);
            this.Nha.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudthanhtien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnlammoi;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button bnttim;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvhd;
        private System.Windows.Forms.TextBox txttim;
        private System.Windows.Forms.GroupBox Nha;
        private System.Windows.Forms.NumericUpDown nudthanhtien;
        private System.Windows.Forms.DateTimePicker dtpngaynhap;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtma;
        private System.Windows.Forms.ComboBox cmbkh;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label6;
    }
}