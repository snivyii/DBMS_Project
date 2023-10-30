namespace QuanLyCuaHangTienLoi
{
    partial class FTTSP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FTTSP));
            btnThoat = new Button();
            gvTinhTrangAH = new DataGridView();
            MaSP = new DataGridViewTextBoxColumn();
            MaTinhTrang = new DataGridViewTextBoxColumn();
            SoLuongAnhHuong = new DataGridViewTextBoxColumn();
            btnSuaTTSP = new Button();
            btnXoaTTSP = new Button();
            btnThemTTSP = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtMaSP = new TextBox();
            txtMaTinhTrang = new TextBox();
            txtSoLuongAnhHuong = new TextBox();
            ((System.ComponentModel.ISupportInitialize)gvTinhTrangAH).BeginInit();
            SuspendLayout();
            // 
            // btnThoat
            // 
            btnThoat.BackColor = Color.White;
            btnThoat.FlatStyle = FlatStyle.Flat;
            btnThoat.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnThoat.ForeColor = Color.White;
            btnThoat.Image = (Image)resources.GetObject("btnThoat.Image");
            btnThoat.Location = new Point(1250, 23);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(48, 49);
            btnThoat.TabIndex = 38;
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click;
            // 
            // gvTinhTrangAH
            // 
            gvTinhTrangAH.BackgroundColor = Color.White;
            gvTinhTrangAH.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gvTinhTrangAH.Columns.AddRange(new DataGridViewColumn[] { MaSP, MaTinhTrang, SoLuongAnhHuong });
            gvTinhTrangAH.Location = new Point(54, 64);
            gvTinhTrangAH.Name = "gvTinhTrangAH";
            gvTinhTrangAH.RowHeadersWidth = 51;
            gvTinhTrangAH.RowTemplate.Height = 29;
            gvTinhTrangAH.Size = new Size(619, 498);
            gvTinhTrangAH.TabIndex = 39;
            gvTinhTrangAH.CellDoubleClick += gvTinhTrangAH_CellDoubleClick;
            // 
            // MaSP
            // 
            MaSP.DataPropertyName = "MaSP";
            MaSP.HeaderText = "Mã sản phẩm";
            MaSP.MinimumWidth = 6;
            MaSP.Name = "MaSP";
            MaSP.Width = 180;
            // 
            // MaTinhTrang
            // 
            MaTinhTrang.DataPropertyName = "MaTinhTrang";
            MaTinhTrang.HeaderText = "Mã tình trạng";
            MaTinhTrang.MinimumWidth = 6;
            MaTinhTrang.Name = "MaTinhTrang";
            MaTinhTrang.Width = 180;
            // 
            // SoLuongAnhHuong
            // 
            SoLuongAnhHuong.DataPropertyName = "SoLuongAnhHuong";
            SoLuongAnhHuong.HeaderText = "Số lượng ảnh hưởng";
            SoLuongAnhHuong.MinimumWidth = 6;
            SoLuongAnhHuong.Name = "SoLuongAnhHuong";
            SoLuongAnhHuong.Width = 200;
            // 
            // btnSuaTTSP
            // 
            btnSuaTTSP.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnSuaTTSP.Location = new Point(936, 385);
            btnSuaTTSP.Name = "btnSuaTTSP";
            btnSuaTTSP.Size = new Size(140, 48);
            btnSuaTTSP.TabIndex = 42;
            btnSuaTTSP.Text = "Sửa";
            btnSuaTTSP.UseVisualStyleBackColor = true;
            btnSuaTTSP.Click += btnSuaTTSP_Click;
            // 
            // btnXoaTTSP
            // 
            btnXoaTTSP.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnXoaTTSP.Location = new Point(1134, 385);
            btnXoaTTSP.Name = "btnXoaTTSP";
            btnXoaTTSP.Size = new Size(140, 48);
            btnXoaTTSP.TabIndex = 41;
            btnXoaTTSP.Text = "Xóa";
            btnXoaTTSP.UseVisualStyleBackColor = true;
            btnXoaTTSP.Click += btnXoaTTSP_Click;
            // 
            // btnThemTTSP
            // 
            btnThemTTSP.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnThemTTSP.Location = new Point(733, 385);
            btnThemTTSP.Name = "btnThemTTSP";
            btnThemTTSP.Size = new Size(140, 48);
            btnThemTTSP.TabIndex = 40;
            btnThemTTSP.Text = "Thêm";
            btnThemTTSP.UseVisualStyleBackColor = true;
            btnThemTTSP.Click += btnThemTTSP_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(733, 85);
            label1.Name = "label1";
            label1.Size = new Size(158, 31);
            label1.TabIndex = 43;
            label1.Text = "Mã sản phẩm:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(733, 184);
            label2.Name = "label2";
            label2.Size = new Size(159, 31);
            label2.TabIndex = 44;
            label2.Text = "Mã tình trạng:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(733, 290);
            label3.Name = "label3";
            label3.Size = new Size(229, 31);
            label3.TabIndex = 45;
            label3.Text = "Số lượng ảnh hưởng:";
            // 
            // txtMaSP
            // 
            txtMaSP.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtMaSP.Location = new Point(924, 82);
            txtMaSP.Name = "txtMaSP";
            txtMaSP.Size = new Size(315, 38);
            txtMaSP.TabIndex = 46;
            // 
            // txtMaTinhTrang
            // 
            txtMaTinhTrang.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtMaTinhTrang.Location = new Point(924, 177);
            txtMaTinhTrang.Name = "txtMaTinhTrang";
            txtMaTinhTrang.Size = new Size(315, 38);
            txtMaTinhTrang.TabIndex = 47;
            // 
            // txtSoLuongAnhHuong
            // 
            txtSoLuongAnhHuong.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtSoLuongAnhHuong.Location = new Point(968, 287);
            txtSoLuongAnhHuong.Name = "txtSoLuongAnhHuong";
            txtSoLuongAnhHuong.Size = new Size(271, 38);
            txtSoLuongAnhHuong.TabIndex = 48;
            // 
            // FTTSP
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1310, 624);
            Controls.Add(txtSoLuongAnhHuong);
            Controls.Add(txtMaTinhTrang);
            Controls.Add(txtMaSP);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnSuaTTSP);
            Controls.Add(btnXoaTTSP);
            Controls.Add(btnThemTTSP);
            Controls.Add(gvTinhTrangAH);
            Controls.Add(btnThoat);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FTTSP";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ThemTTSP";
            Paint += ThemTTSP_Paint;
            MouseDown += ThemTTSP_MouseDown;
            ((System.ComponentModel.ISupportInitialize)gvTinhTrangAH).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnThoat;
        private DataGridView gvTinhTrangAH;
        private DataGridViewTextBoxColumn MaSP;
        private DataGridViewTextBoxColumn MaTinhTrang;
        private DataGridViewTextBoxColumn SoLuongAnhHuong;
        private Button btnSuaTTSP;
        private Button btnXoaTTSP;
        private Button btnThemTTSP;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtMaSP;
        private TextBox txtMaTinhTrang;
        private TextBox txtSoLuongAnhHuong;
    }
}