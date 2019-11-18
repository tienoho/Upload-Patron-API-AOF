namespace UploadPatronExcelAOF
{
    partial class ControlMainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ControlMainForm));
            this.label7 = new System.Windows.Forms.Label();
            this._pnlLeft = new System.Windows.Forms.Panel();
            this.btnRenamePic = new System.Windows.Forms.Button();
            this.btnRest = new System.Windows.Forms.Button();
            this.btnOpenBlock = new System.Windows.Forms.Button();
            this.lbStatus = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddPatron = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lblInformation = new System.Windows.Forms.Label();
            this._pnlRight = new System.Windows.Forms.Panel();
            this.danhMucToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ConvertPicToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataPatronToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trơGiupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinPhiênBanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.liênHêToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.càiĐặtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serverDatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serverAlephToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this._pnlLeft.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label7.Location = new System.Drawing.Point(12, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(178, 29);
            this.label7.TabIndex = 45;
            this.label7.Text = "TRANG CHÍNH";
            // 
            // _pnlLeft
            // 
            this._pnlLeft.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this._pnlLeft.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this._pnlLeft.Controls.Add(this.btnRenamePic);
            this._pnlLeft.Controls.Add(this.btnRest);
            this._pnlLeft.Controls.Add(this.btnOpenBlock);
            this._pnlLeft.Controls.Add(this.lbStatus);
            this._pnlLeft.Controls.Add(this.label1);
            this._pnlLeft.Controls.Add(this.btnAddPatron);
            this._pnlLeft.Controls.Add(this.label5);
            this._pnlLeft.Location = new System.Drawing.Point(12, 56);
            this._pnlLeft.Name = "_pnlLeft";
            this._pnlLeft.Size = new System.Drawing.Size(178, 577);
            this._pnlLeft.TabIndex = 46;
            // 
            // btnRenamePic
            // 
            this.btnRenamePic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRenamePic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRenamePic.Image = global::UploadPatronExcelAOF.Properties.Resources.no_image_icon;
            this.btnRenamePic.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnRenamePic.Location = new System.Drawing.Point(25, 268);
            this.btnRenamePic.Name = "btnRenamePic";
            this.btnRenamePic.Size = new System.Drawing.Size(125, 97);
            this.btnRenamePic.TabIndex = 54;
            this.btnRenamePic.Text = "Chuyển đổi tên ảnh";
            this.btnRenamePic.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRenamePic.UseVisualStyleBackColor = true;
            this.btnRenamePic.Click += new System.EventHandler(this.BtnRenamePic_Click);
            this.btnRenamePic.MouseLeave += new System.EventHandler(this.BtnRenamePic_MouseLeave);
            this.btnRenamePic.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BtnRenamePic_MouseMove);
            // 
            // btnRest
            // 
            this.btnRest.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRest.Image = global::UploadPatronExcelAOF.Properties.Resources.reset_50x48;
            this.btnRest.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnRest.Location = new System.Drawing.Point(25, 475);
            this.btnRest.Name = "btnRest";
            this.btnRest.Size = new System.Drawing.Size(125, 82);
            this.btnRest.TabIndex = 52;
            this.btnRest.Text = "Làm mới dữ liệu";
            this.btnRest.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRest.UseVisualStyleBackColor = true;
            this.btnRest.Click += new System.EventHandler(this.btnRest_Click);
            this.btnRest.MouseLeave += new System.EventHandler(this.btnRest_MouseLeave);
            this.btnRest.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnRest_MouseMove);
            // 
            // btnOpenBlock
            // 
            this.btnOpenBlock.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOpenBlock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenBlock.Image = global::UploadPatronExcelAOF.Properties.Resources.output_onlinepngtools__1_;
            this.btnOpenBlock.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnOpenBlock.Location = new System.Drawing.Point(27, 161);
            this.btnOpenBlock.Name = "btnOpenBlock";
            this.btnOpenBlock.Size = new System.Drawing.Size(125, 101);
            this.btnOpenBlock.TabIndex = 51;
            this.btnOpenBlock.Text = "Mở/Khóa bạn đọc";
            this.btnOpenBlock.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnOpenBlock.UseVisualStyleBackColor = true;
            this.btnOpenBlock.Click += new System.EventHandler(this.BtnOpenBlock_Click);
            this.btnOpenBlock.MouseLeave += new System.EventHandler(this.BtnOpenBlock_MouseLeave);
            this.btnOpenBlock.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BtnOpenBlock_MouseMove);
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbStatus.ForeColor = System.Drawing.Color.Black;
            this.lbStatus.Location = new System.Drawing.Point(1, 439);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(102, 24);
            this.lbStatus.TabIndex = 50;
            this.lbStatus.Text = "Trạng Thái";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(31, 404);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 24);
            this.label1.TabIndex = 49;
            this.label1.Text = "Trạng Thái";
            // 
            // btnAddPatron
            // 
            this.btnAddPatron.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddPatron.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddPatron.ForeColor = System.Drawing.Color.Black;
            this.btnAddPatron.Image = global::UploadPatronExcelAOF.Properties.Resources.customer_service_icon_48x48;
            this.btnAddPatron.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAddPatron.Location = new System.Drawing.Point(27, 52);
            this.btnAddPatron.Name = "btnAddPatron";
            this.btnAddPatron.Size = new System.Drawing.Size(125, 103);
            this.btnAddPatron.TabIndex = 2;
            this.btnAddPatron.Text = "Thêm Người dùng";
            this.btnAddPatron.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAddPatron.UseVisualStyleBackColor = true;
            this.btnAddPatron.Click += new System.EventHandler(this.btnAddPatron_Click);
            this.btnAddPatron.MouseLeave += new System.EventHandler(this._btNhanVien_MouseLeave);
            this.btnAddPatron.MouseMove += new System.Windows.Forms.MouseEventHandler(this._btNhanVien_MouseMove);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label5.Location = new System.Drawing.Point(30, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 29);
            this.label5.TabIndex = 38;
            this.label5.Text = "Danh Mục";
            // 
            // lblInformation
            // 
            this.lblInformation.AutoSize = true;
            this.lblInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblInformation.ForeColor = System.Drawing.Color.Black;
            this.lblInformation.Location = new System.Drawing.Point(556, 28);
            this.lblInformation.Name = "lblInformation";
            this.lblInformation.Size = new System.Drawing.Size(91, 24);
            this.lblInformation.TabIndex = 48;
            this.lblInformation.Text = "Xin chào ";
            // 
            // _pnlRight
            // 
            this._pnlRight.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this._pnlRight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._pnlRight.Location = new System.Drawing.Point(196, 56);
            this._pnlRight.Name = "_pnlRight";
            this._pnlRight.Size = new System.Drawing.Size(1000, 577);
            this._pnlRight.TabIndex = 47;
            // 
            // danhMucToolStripMenuItem
            // 
            this.danhMucToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.ConvertPicToolStripMenuItem,
            this.dataPatronToolStripMenuItem});
            this.danhMucToolStripMenuItem.Name = "danhMucToolStripMenuItem";
            this.danhMucToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.danhMucToolStripMenuItem.Text = "Danh Mục";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Image = global::UploadPatronExcelAOF.Properties.Resources.home;
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.homeToolStripMenuItem.Text = "Trang Chính";
            this.homeToolStripMenuItem.Click += new System.EventHandler(this.HomeToolStripMenuItem_Click);
            // 
            // ConvertPicToolStripMenuItem
            // 
            this.ConvertPicToolStripMenuItem.Image = global::UploadPatronExcelAOF.Properties.Resources.no_image_icon;
            this.ConvertPicToolStripMenuItem.Name = "ConvertPicToolStripMenuItem";
            this.ConvertPicToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.ConvertPicToolStripMenuItem.Text = "Chuyển đổi ảnh người dùng";
            // 
            // dataPatronToolStripMenuItem
            // 
            this.dataPatronToolStripMenuItem.Name = "dataPatronToolStripMenuItem";
            this.dataPatronToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.dataPatronToolStripMenuItem.Text = "Data Patron";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.trơGiupToolStripMenuItem,
            this.thôngTinPhiênBanToolStripMenuItem,
            this.liênHêToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // trơGiupToolStripMenuItem
            // 
            this.trơGiupToolStripMenuItem.Name = "trơGiupToolStripMenuItem";
            this.trơGiupToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.trơGiupToolStripMenuItem.Text = "Trợ Giúp";
            // 
            // thôngTinPhiênBanToolStripMenuItem
            // 
            this.thôngTinPhiênBanToolStripMenuItem.Name = "thôngTinPhiênBanToolStripMenuItem";
            this.thôngTinPhiênBanToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.thôngTinPhiênBanToolStripMenuItem.Text = "Thông Tin Phiên Bản";
            // 
            // liênHêToolStripMenuItem
            // 
            this.liênHêToolStripMenuItem.Name = "liênHêToolStripMenuItem";
            this.liênHêToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.liênHêToolStripMenuItem.Text = "Liên Hệ";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.danhMucToolStripMenuItem,
            this.càiĐặtToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1209, 24);
            this.menuStrip1.TabIndex = 44;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // càiĐặtToolStripMenuItem
            // 
            this.càiĐặtToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.serverDatabaseToolStripMenuItem,
            this.serverAlephToolStripMenuItem});
            this.càiĐặtToolStripMenuItem.Name = "càiĐặtToolStripMenuItem";
            this.càiĐặtToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.càiĐặtToolStripMenuItem.Text = "Cài Đặt";
            // 
            // serverDatabaseToolStripMenuItem
            // 
            this.serverDatabaseToolStripMenuItem.Image = global::UploadPatronExcelAOF.Properties.Resources.database;
            this.serverDatabaseToolStripMenuItem.Name = "serverDatabaseToolStripMenuItem";
            this.serverDatabaseToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.serverDatabaseToolStripMenuItem.Text = "Server Database";
            // 
            // serverAlephToolStripMenuItem
            // 
            this.serverAlephToolStripMenuItem.Image = global::UploadPatronExcelAOF.Properties.Resources.mindtouch;
            this.serverAlephToolStripMenuItem.Name = "serverAlephToolStripMenuItem";
            this.serverAlephToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.serverAlephToolStripMenuItem.Text = "Server Aleph";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // ControlMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1209, 635);
            this.Controls.Add(this.label7);
            this.Controls.Add(this._pnlLeft);
            this.Controls.Add(this.lblInformation);
            this.Controls.Add(this._pnlRight);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ControlMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AOF Block Upload Patron";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Control_FormClosed);
            this.Load += new System.EventHandler(this.ControlMainForm_Load);
            this._pnlLeft.ResumeLayout(false);
            this._pnlLeft.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ToolStripMenuItem serverDatabaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem càiĐặtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serverAlephToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem danhMucToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ConvertPicToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataPatronToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trơGiupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinPhiênBanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem liênHêToolStripMenuItem;
        private System.Windows.Forms.Label lblInformation;
        private System.Windows.Forms.Panel _pnlRight;
        private System.Windows.Forms.Button btnRest;
        private System.Windows.Forms.Button btnOpenBlock;
        private System.Windows.Forms.Label lbStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddPatron;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel _pnlLeft;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnRenamePic;
    }
}