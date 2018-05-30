namespace NguyenThiMinh_KHMT4_k10
{
    partial class XemDSMonHoc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XemDSMonHoc));
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaMon = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbTenMon = new System.Windows.Forms.ComboBox();
            this.btnTim = new System.Windows.Forms.Button();
            this.dgvDSMonHoc = new System.Windows.Forms.DataGridView();
            this.btnTimMaMon = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSMonHoc)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã môn";
            // 
            // txtMaMon
            // 
            this.txtMaMon.Location = new System.Drawing.Point(12, 48);
            this.txtMaMon.Name = "txtMaMon";
            this.txtMaMon.Size = new System.Drawing.Size(100, 20);
            this.txtMaMon.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(424, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên môn";
            // 
            // cbTenMon
            // 
            this.cbTenMon.FormattingEnabled = true;
            this.cbTenMon.Location = new System.Drawing.Point(424, 47);
            this.cbTenMon.Name = "cbTenMon";
            this.cbTenMon.Size = new System.Drawing.Size(121, 21);
            this.cbTenMon.TabIndex = 3;
            // 
            // btnTim
            // 
            this.btnTim.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnTim.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTim.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnTim.Location = new System.Drawing.Point(307, 8);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(75, 33);
            this.btnTim.TabIndex = 4;
            this.btnTim.Text = "Tìm tên môn";
            this.btnTim.UseVisualStyleBackColor = false;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // dgvDSMonHoc
            // 
            this.dgvDSMonHoc.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvDSMonHoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSMonHoc.Location = new System.Drawing.Point(93, 108);
            this.dgvDSMonHoc.Name = "dgvDSMonHoc";
            this.dgvDSMonHoc.Size = new System.Drawing.Size(367, 150);
            this.dgvDSMonHoc.TabIndex = 5;
            this.dgvDSMonHoc.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSMonHoc_CellContentClick);
            // 
            // btnTimMaMon
            // 
            this.btnTimMaMon.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnTimMaMon.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimMaMon.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnTimMaMon.Location = new System.Drawing.Point(146, 8);
            this.btnTimMaMon.Name = "btnTimMaMon";
            this.btnTimMaMon.Size = new System.Drawing.Size(75, 33);
            this.btnTimMaMon.TabIndex = 6;
            this.btnTimMaMon.Text = "Tìm mã môn";
            this.btnTimMaMon.UseVisualStyleBackColor = false;
            this.btnTimMaMon.Click += new System.EventHandler(this.btnTimMaMon_Click);
            // 
            // XemDSMonHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(557, 270);
            this.Controls.Add(this.btnTimMaMon);
            this.Controls.Add(this.dgvDSMonHoc);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.cbTenMon);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMaMon);
            this.Controls.Add(this.label1);
            this.Name = "XemDSMonHoc";
            this.Text = "XemDSMonHoc";
            this.Load += new System.EventHandler(this.XemDSMonHoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSMonHoc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaMon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbTenMon;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.DataGridView dgvDSMonHoc;
        private System.Windows.Forms.Button btnTimMaMon;
    }
}