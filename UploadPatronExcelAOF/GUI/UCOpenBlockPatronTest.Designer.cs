namespace UploadPatronExcelAOF.GUI
{
    partial class UCOpenBlockPatronTest
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvDataBarcode = new System.Windows.Forms.DataGridView();
            this.dgvDataExcel = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnExcelDemo = new System.Windows.Forms.Button();
            this.btn_hd = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_browser = new System.Windows.Forms.Button();
            this.txt_taphuan = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.pb_TaiChinh = new System.Windows.Forms.PictureBox();
            this.btnPush = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvNotExist = new System.Windows.Forms.DataGridView();
            this.lbCountListExcel = new System.Windows.Forms.Label();
            this.lbCountHad = new System.Windows.Forms.Label();
            this.btn_excel_danhsach = new System.Windows.Forms.Button();
            this.btn_excel_danhsach_khongtontai = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataBarcode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataExcel)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_TaiChinh)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotExist)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvDataBarcode);
            this.groupBox3.Controls.Add(this.dgvDataExcel);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(3, 215);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(620, 312);
            this.groupBox3.TabIndex = 29;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "DANH SÁCH";
            // 
            // dgvDataBarcode
            // 
            this.dgvDataBarcode.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDataBarcode.Location = new System.Drawing.Point(6, 157);
            this.dgvDataBarcode.Name = "dgvDataBarcode";
            this.dgvDataBarcode.Size = new System.Drawing.Size(614, 149);
            this.dgvDataBarcode.TabIndex = 51;
            // 
            // dgvDataExcel
            // 
            this.dgvDataExcel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDataExcel.Location = new System.Drawing.Point(3, 18);
            this.dgvDataExcel.Name = "dgvDataExcel";
            this.dgvDataExcel.Size = new System.Drawing.Size(614, 133);
            this.dgvDataExcel.TabIndex = 50;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnExcelDemo);
            this.groupBox1.Controls.Add(this.btn_hd);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btn_browser);
            this.groupBox1.Controls.Add(this.txt_taphuan);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.pb_TaiChinh);
            this.groupBox1.Controls.Add(this.btnPush);
            this.groupBox1.Controls.Add(this.btnThoat);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(0, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(993, 209);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mở / Khóa bạn đọc";
            // 
            // btnExcelDemo
            // 
            this.btnExcelDemo.Location = new System.Drawing.Point(632, 66);
            this.btnExcelDemo.Margin = new System.Windows.Forms.Padding(2);
            this.btnExcelDemo.Name = "btnExcelDemo";
            this.btnExcelDemo.Size = new System.Drawing.Size(128, 36);
            this.btnExcelDemo.TabIndex = 115;
            this.btnExcelDemo.Text = "Dữ liệu mẫu";
            this.btnExcelDemo.UseVisualStyleBackColor = true;
            this.btnExcelDemo.Click += new System.EventHandler(this.Button1_Click);
            // 
            // btn_hd
            // 
            this.btn_hd.Location = new System.Drawing.Point(632, 107);
            this.btn_hd.Margin = new System.Windows.Forms.Padding(2);
            this.btn_hd.Name = "btn_hd";
            this.btn_hd.Size = new System.Drawing.Size(128, 35);
            this.btn_hd.TabIndex = 114;
            this.btn_hd.Text = "Hướng dẫn";
            this.btn_hd.UseVisualStyleBackColor = true;
            this.btn_hd.Click += new System.EventHandler(this.Btn_hd_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 110);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 25);
            this.label5.TabIndex = 112;
            this.label5.Text = "Tình trạng";
            // 
            // btn_browser
            // 
            this.btn_browser.Location = new System.Drawing.Point(452, 66);
            this.btn_browser.Margin = new System.Windows.Forms.Padding(2);
            this.btn_browser.Name = "btn_browser";
            this.btn_browser.Size = new System.Drawing.Size(171, 35);
            this.btn_browser.TabIndex = 111;
            this.btn_browser.Text = "Chọn tệp tin...";
            this.btn_browser.UseVisualStyleBackColor = true;
            this.btn_browser.Click += new System.EventHandler(this.Btn_browser_Click);
            // 
            // txt_taphuan
            // 
            this.txt_taphuan.Location = new System.Drawing.Point(152, 68);
            this.txt_taphuan.Margin = new System.Windows.Forms.Padding(2);
            this.txt_taphuan.Name = "txt_taphuan";
            this.txt_taphuan.Size = new System.Drawing.Size(298, 33);
            this.txt_taphuan.TabIndex = 110;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 70);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 25);
            this.label4.TabIndex = 109;
            this.label4.Text = "Chọn file";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(152, 108);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(298, 33);
            this.comboBox1.TabIndex = 108;
            // 
            // pb_TaiChinh
            // 
            this.pb_TaiChinh.Image = global::UploadPatronExcelAOF.Properties.Resources.library_logo;
            this.pb_TaiChinh.Location = new System.Drawing.Point(796, 20);
            this.pb_TaiChinh.Name = "pb_TaiChinh";
            this.pb_TaiChinh.Size = new System.Drawing.Size(160, 151);
            this.pb_TaiChinh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_TaiChinh.TabIndex = 20;
            this.pb_TaiChinh.TabStop = false;
            // 
            // btnPush
            // 
            this.btnPush.AutoSize = true;
            this.btnPush.BackColor = System.Drawing.Color.Green;
            this.btnPush.Enabled = false;
            this.btnPush.FlatAppearance.BorderSize = 0;
            this.btnPush.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPush.ForeColor = System.Drawing.Color.White;
            this.btnPush.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPush.Location = new System.Drawing.Point(452, 106);
            this.btnPush.Name = "btnPush";
            this.btnPush.Size = new System.Drawing.Size(171, 38);
            this.btnPush.TabIndex = 107;
            this.btnPush.Text = "Cập nhập";
            this.btnPush.UseVisualStyleBackColor = false;
            this.btnPush.Click += new System.EventHandler(this.BtnPush_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.AutoSize = true;
            this.btnThoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnThoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnThoat.FlatAppearance.BorderSize = 0;
            this.btnThoat.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.Color.White;
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoat.Location = new System.Drawing.Point(824, 171);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(111, 38);
            this.btnThoat.TabIndex = 14;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvNotExist);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(629, 215);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(364, 309);
            this.groupBox2.TabIndex = 30;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "DANH SÁCH KHÔNG TỒN TẠI";
            // 
            // dgvNotExist
            // 
            this.dgvNotExist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNotExist.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvNotExist.Location = new System.Drawing.Point(3, 18);
            this.dgvNotExist.Name = "dgvNotExist";
            this.dgvNotExist.Size = new System.Drawing.Size(358, 288);
            this.dgvNotExist.TabIndex = 51;
            // 
            // lbCountListExcel
            // 
            this.lbCountListExcel.AutoSize = true;
            this.lbCountListExcel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCountListExcel.Location = new System.Drawing.Point(3, 532);
            this.lbCountListExcel.Name = "lbCountListExcel";
            this.lbCountListExcel.Size = new System.Drawing.Size(76, 21);
            this.lbCountListExcel.TabIndex = 31;
            this.lbCountListExcel.Text = "Số lượng:";
            // 
            // lbCountHad
            // 
            this.lbCountHad.AutoSize = true;
            this.lbCountHad.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCountHad.Location = new System.Drawing.Point(628, 531);
            this.lbCountHad.Name = "lbCountHad";
            this.lbCountHad.Size = new System.Drawing.Size(76, 21);
            this.lbCountHad.TabIndex = 32;
            this.lbCountHad.Text = "Số lượng:";
            // 
            // btn_excel_danhsach
            // 
            this.btn_excel_danhsach.Enabled = false;
            this.btn_excel_danhsach.Location = new System.Drawing.Point(502, 528);
            this.btn_excel_danhsach.Margin = new System.Windows.Forms.Padding(2);
            this.btn_excel_danhsach.Name = "btn_excel_danhsach";
            this.btn_excel_danhsach.Size = new System.Drawing.Size(118, 28);
            this.btn_excel_danhsach.TabIndex = 59;
            this.btn_excel_danhsach.Text = "Export Excel";
            this.btn_excel_danhsach.UseVisualStyleBackColor = true;
            this.btn_excel_danhsach.Click += new System.EventHandler(this.Btn_excel_danhsach_Click_1);
            // 
            // btn_excel_danhsach_khongtontai
            // 
            this.btn_excel_danhsach_khongtontai.Enabled = false;
            this.btn_excel_danhsach_khongtontai.Location = new System.Drawing.Point(872, 527);
            this.btn_excel_danhsach_khongtontai.Margin = new System.Windows.Forms.Padding(2);
            this.btn_excel_danhsach_khongtontai.Name = "btn_excel_danhsach_khongtontai";
            this.btn_excel_danhsach_khongtontai.Size = new System.Drawing.Size(118, 28);
            this.btn_excel_danhsach_khongtontai.TabIndex = 60;
            this.btn_excel_danhsach_khongtontai.Text = "Export Excel";
            this.btn_excel_danhsach_khongtontai.UseVisualStyleBackColor = true;
            this.btn_excel_danhsach_khongtontai.Click += new System.EventHandler(this.Btn_excel_danhsach_khongtontai_Click);
            // 
            // UCOpenBlockPatronTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_excel_danhsach_khongtontai);
            this.Controls.Add(this.btn_excel_danhsach);
            this.Controls.Add(this.lbCountHad);
            this.Controls.Add(this.lbCountListExcel);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UCOpenBlockPatronTest";
            this.Size = new System.Drawing.Size(1000, 565);
            this.Load += new System.EventHandler(this.UCOpenBlockPatron_Load);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataBarcode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataExcel)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_TaiChinh)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotExist)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pb_TaiChinh;
        private System.Windows.Forms.Button btnPush;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbCountListExcel;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label lbCountHad;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnExcelDemo;
        private System.Windows.Forms.Button btn_hd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_browser;
        private System.Windows.Forms.TextBox txt_taphuan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView dgvDataExcel;
        private System.Windows.Forms.DataGridView dgvNotExist;
        private System.Windows.Forms.Button btn_excel_danhsach;
        private System.Windows.Forms.Button btn_excel_danhsach_khongtontai;
        private System.Windows.Forms.DataGridView dgvDataBarcode;
    }
}
