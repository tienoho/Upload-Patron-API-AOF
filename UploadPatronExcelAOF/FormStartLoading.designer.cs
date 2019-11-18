namespace UploadPatronExcelAOF
{
    partial class FormStartLoading
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormStartLoading));
            this.labelError = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.lbLoad = new System.Windows.Forms.Label();
            this.pictureError = new System.Windows.Forms.PictureBox();
            this.picLoader = new System.Windows.Forms.PictureBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.pictureError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLoader)).BeginInit();
            this.SuspendLayout();
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.BackColor = System.Drawing.Color.Transparent;
            this.labelError.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelError.ForeColor = System.Drawing.Color.Red;
            this.labelError.Location = new System.Drawing.Point(515, 175);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(174, 29);
            this.labelError.TabIndex = 11;
            this.labelError.Text = "Lỗi kết nối rồi!!!";
            // 
            // btnExit
            // 
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Red;
            this.btnExit.Location = new System.Drawing.Point(759, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(41, 29);
            this.btnExit.TabIndex = 12;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // lbLoad
            // 
            this.lbLoad.AutoSize = true;
            this.lbLoad.BackColor = System.Drawing.Color.Transparent;
            this.lbLoad.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLoad.ForeColor = System.Drawing.Color.LimeGreen;
            this.lbLoad.Location = new System.Drawing.Point(305, 374);
            this.lbLoad.Name = "lbLoad";
            this.lbLoad.Size = new System.Drawing.Size(200, 26);
            this.lbLoad.TabIndex = 13;
            this.lbLoad.Text = "Đang tải dữ liệu ...";
            // 
            // pictureError
            // 
            this.pictureError.BackColor = System.Drawing.Color.Transparent;
            this.pictureError.Image = global::UploadPatronExcelAOF.Properties.Resources.tweek_error;
            this.pictureError.Location = new System.Drawing.Point(0, 0);
            this.pictureError.Name = "pictureError";
            this.pictureError.Size = new System.Drawing.Size(800, 418);
            this.pictureError.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureError.TabIndex = 10;
            this.pictureError.TabStop = false;
            this.pictureError.Visible = false;
            // 
            // picLoader
            // 
            this.picLoader.Image = global::UploadPatronExcelAOF.Properties.Resources.Simple_Loader;
            this.picLoader.Location = new System.Drawing.Point(0, 0);
            this.picLoader.Name = "picLoader";
            this.picLoader.Size = new System.Drawing.Size(800, 418);
            this.picLoader.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picLoader.TabIndex = 9;
            this.picLoader.TabStop = false;
            this.picLoader.Visible = false;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundWorker1_DoWork);
            // 
            // FormStartLoading
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 418);
            this.Controls.Add(this.lbLoad);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.pictureError);
            this.Controls.Add(this.picLoader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormStartLoading";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormStartLoading";
            ((System.ComponentModel.ISupportInitialize)(this.pictureError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLoader)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbLoad;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.PictureBox pictureError;
        private System.Windows.Forms.PictureBox picLoader;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}