namespace WindowsFormsApplication2
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tentaisan = new System.Windows.Forms.TextBox();
            this.congty = new System.Windows.Forms.TextBox();
            this.giatien = new System.Windows.Forms.TextBox();
            this.thoigianbaohanh = new System.Windows.Forms.DateTimePicker();
            this.thoigiantrangbi = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmLoaitaisan = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tabledata = new System.Windows.Forms.DataGridView();
            this.them = new System.Windows.Forms.Button();
            this.timkiem = new System.Windows.Forms.Button();
            this.xoa = new System.Windows.Forms.Button();
            this.capnhat = new System.Windows.Forms.Button();
            this.txtTimkiem = new System.Windows.Forms.TextBox();
            this.lichsu = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.txt_mat_khau = new System.Windows.Forms.TextBox();
            this.txt_ten_nguoi_dung = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dangnhap = new System.Windows.Forms.Button();
            this.thoat = new System.Windows.Forms.Button();
            this.txt_giaitien_thue = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnDanhsanh = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.cmb_tim_kiem = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.timkiem_date1 = new System.Windows.Forms.DateTimePicker();
            this.timkiem_date2 = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabledata)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tentaisan
            // 
            this.tentaisan.Location = new System.Drawing.Point(197, 126);
            this.tentaisan.Name = "tentaisan";
            this.tentaisan.Size = new System.Drawing.Size(184, 20);
            this.tentaisan.TabIndex = 0;
            // 
            // congty
            // 
            this.congty.Location = new System.Drawing.Point(197, 178);
            this.congty.Name = "congty";
            this.congty.Size = new System.Drawing.Size(184, 20);
            this.congty.TabIndex = 1;
            // 
            // giatien
            // 
            this.giatien.Location = new System.Drawing.Point(168, 129);
            this.giatien.Name = "giatien";
            this.giatien.Size = new System.Drawing.Size(154, 20);
            this.giatien.TabIndex = 3;
            this.giatien.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // thoigianbaohanh
            // 
            this.thoigianbaohanh.Location = new System.Drawing.Point(168, 21);
            this.thoigianbaohanh.Name = "thoigianbaohanh";
            this.thoigianbaohanh.Size = new System.Drawing.Size(200, 20);
            this.thoigianbaohanh.TabIndex = 4;
            // 
            // thoigiantrangbi
            // 
            this.thoigiantrangbi.Enabled = false;
            this.thoigiantrangbi.Location = new System.Drawing.Point(168, 73);
            this.thoigiantrangbi.Name = "thoigiantrangbi";
            this.thoigiantrangbi.Size = new System.Drawing.Size(200, 20);
            this.thoigiantrangbi.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Tên tài sản";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(92, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Công ty sở hữu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(92, 241);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Loại tài sản";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Giá tiền";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Thời gian trang bị";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Thời gian bảo hành";
            // 
            // cmLoaitaisan
            // 
            this.cmLoaitaisan.FormattingEnabled = true;
            this.cmLoaitaisan.Items.AddRange(new object[] {
            "Tài sản cố định",
            "Tài sản cho thuê"});
            this.cmLoaitaisan.Location = new System.Drawing.Point(197, 234);
            this.cmLoaitaisan.Name = "cmLoaitaisan";
            this.cmLoaitaisan.Size = new System.Drawing.Size(184, 21);
            this.cmLoaitaisan.TabIndex = 12;
            this.cmLoaitaisan.SelectedIndexChanged += new System.EventHandler(this.cmLoaitaisan_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.thoigiantrangbi);
            this.groupBox1.Controls.Add(this.thoigianbaohanh);
            this.groupBox1.Controls.Add(this.giatien);
            this.groupBox1.Location = new System.Drawing.Point(466, 98);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(399, 186);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Đối với tài sản cố định";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(328, 132);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "VNĐ";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // tabledata
            // 
            this.tabledata.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tabledata.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.tabledata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tabledata.DefaultCellStyle = dataGridViewCellStyle2;
            this.tabledata.Location = new System.Drawing.Point(12, 344);
            this.tabledata.Name = "tabledata";
            this.tabledata.Size = new System.Drawing.Size(1081, 278);
            this.tabledata.TabIndex = 14;
            this.tabledata.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tabledata_CellContentClick);
            // 
            // them
            // 
            this.them.Location = new System.Drawing.Point(59, 48);
            this.them.Name = "them";
            this.them.Size = new System.Drawing.Size(75, 23);
            this.them.TabIndex = 15;
            this.them.Text = "Thêm";
            this.them.UseVisualStyleBackColor = true;
            this.them.Click += new System.EventHandler(this.them_Click);
            // 
            // timkiem
            // 
            this.timkiem.Location = new System.Drawing.Point(1018, 314);
            this.timkiem.Name = "timkiem";
            this.timkiem.Size = new System.Drawing.Size(75, 23);
            this.timkiem.TabIndex = 16;
            this.timkiem.Text = "Tìm kiếm";
            this.timkiem.UseVisualStyleBackColor = true;
            this.timkiem.Click += new System.EventHandler(this.timkiem_Click);
            // 
            // xoa
            // 
            this.xoa.Location = new System.Drawing.Point(327, 48);
            this.xoa.Name = "xoa";
            this.xoa.Size = new System.Drawing.Size(75, 23);
            this.xoa.TabIndex = 17;
            this.xoa.Text = "Xóa";
            this.xoa.UseVisualStyleBackColor = true;
            this.xoa.Click += new System.EventHandler(this.xoa_Click);
            // 
            // capnhat
            // 
            this.capnhat.Location = new System.Drawing.Point(183, 48);
            this.capnhat.Name = "capnhat";
            this.capnhat.Size = new System.Drawing.Size(75, 23);
            this.capnhat.TabIndex = 18;
            this.capnhat.Text = "Cập nhật";
            this.capnhat.UseVisualStyleBackColor = true;
            this.capnhat.Click += new System.EventHandler(this.capnhat_Click);
            // 
            // txtTimkiem
            // 
            this.txtTimkiem.Location = new System.Drawing.Point(106, 316);
            this.txtTimkiem.Name = "txtTimkiem";
            this.txtTimkiem.Size = new System.Drawing.Size(186, 20);
            this.txtTimkiem.TabIndex = 19;
            this.txtTimkiem.TextChanged += new System.EventHandler(this.txtTimkiem_TextChanged);
            // 
            // lichsu
            // 
            this.lichsu.Location = new System.Drawing.Point(449, 48);
            this.lichsu.Name = "lichsu";
            this.lichsu.Size = new System.Drawing.Size(75, 23);
            this.lichsu.TabIndex = 20;
            this.lichsu.Text = "Lịch sử";
            this.lichsu.UseVisualStyleBackColor = true;
            this.lichsu.Click += new System.EventHandler(this.lichsu_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(56, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Tên tài khoản";
            // 
            // txt_mat_khau
            // 
            this.txt_mat_khau.Location = new System.Drawing.Point(466, 15);
            this.txt_mat_khau.Name = "txt_mat_khau";
            this.txt_mat_khau.PasswordChar = '*';
            this.txt_mat_khau.Size = new System.Drawing.Size(241, 20);
            this.txt_mat_khau.TabIndex = 22;
            // 
            // txt_ten_nguoi_dung
            // 
            this.txt_ten_nguoi_dung.Location = new System.Drawing.Point(157, 15);
            this.txt_ten_nguoi_dung.Name = "txt_ten_nguoi_dung";
            this.txt_ten_nguoi_dung.Size = new System.Drawing.Size(184, 20);
            this.txt_ten_nguoi_dung.TabIndex = 23;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(370, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 13);
            this.label9.TabIndex = 24;
            this.label9.Text = "Mật khẩu";
            // 
            // dangnhap
            // 
            this.dangnhap.Location = new System.Drawing.Point(752, 13);
            this.dangnhap.Name = "dangnhap";
            this.dangnhap.Size = new System.Drawing.Size(75, 23);
            this.dangnhap.TabIndex = 25;
            this.dangnhap.Text = "Đăng nhập";
            this.dangnhap.UseVisualStyleBackColor = true;
            this.dangnhap.Click += new System.EventHandler(this.dangnhap_Click);
            // 
            // thoat
            // 
            this.thoat.Location = new System.Drawing.Point(870, 13);
            this.thoat.Name = "thoat";
            this.thoat.Size = new System.Drawing.Size(75, 23);
            this.thoat.TabIndex = 26;
            this.thoat.Text = "Thoát";
            this.thoat.UseVisualStyleBackColor = true;
            this.thoat.Click += new System.EventHandler(this.thoat_Click);
            // 
            // txt_giaitien_thue
            // 
            this.txt_giaitien_thue.Location = new System.Drawing.Point(88, 37);
            this.txt_giaitien_thue.Name = "txt_giaitien_thue";
            this.txt_giaitien_thue.Size = new System.Drawing.Size(184, 20);
            this.txt_giaitien_thue.TabIndex = 29;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(23, 40);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 13);
            this.label10.TabIndex = 30;
            this.label10.Text = "Giá tiền";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.txt_giaitien_thue);
            this.groupBox3.Location = new System.Drawing.Point(917, 105);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(289, 93);
            this.groupBox3.TabIndex = 32;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tài sản cho thuê";
            // 
            // btnDanhsanh
            // 
            this.btnDanhsanh.Location = new System.Drawing.Point(963, 204);
            this.btnDanhsanh.Name = "btnDanhsanh";
            this.btnDanhsanh.Size = new System.Drawing.Size(205, 23);
            this.btnDanhsanh.TabIndex = 33;
            this.btnDanhsanh.Text = "Danh sách tài sản";
            this.btnDanhsanh.UseVisualStyleBackColor = true;
            this.btnDanhsanh.Click += new System.EventHandler(this.btnDanhsanh_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(553, 319);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(27, 13);
            this.label11.TabIndex = 34;
            this.label11.Text = "Đến";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(298, 319);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(20, 13);
            this.label12.TabIndex = 35;
            this.label12.Text = "Từ";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // cmb_tim_kiem
            // 
            this.cmb_tim_kiem.FormattingEnabled = true;
            this.cmb_tim_kiem.Items.AddRange(new object[] {
            "Tài sản cố định",
            "Tài sản cho thuê"});
            this.cmb_tim_kiem.Location = new System.Drawing.Point(806, 316);
            this.cmb_tim_kiem.Name = "cmb_tim_kiem";
            this.cmb_tim_kiem.Size = new System.Drawing.Size(206, 21);
            this.cmb_tim_kiem.TabIndex = 36;
            this.cmb_tim_kiem.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(30, 319);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(47, 13);
            this.label13.TabIndex = 37;
            this.label13.Text = "Từ khóa";
            // 
            // timkiem_date1
            // 
            this.timkiem_date1.Location = new System.Drawing.Point(324, 316);
            this.timkiem_date1.Name = "timkiem_date1";
            this.timkiem_date1.Size = new System.Drawing.Size(200, 20);
            this.timkiem_date1.TabIndex = 38;
            // 
            // timkiem_date2
            // 
            this.timkiem_date2.Location = new System.Drawing.Point(600, 316);
            this.timkiem_date2.Name = "timkiem_date2";
            this.timkiem_date2.Size = new System.Drawing.Size(200, 20);
            this.timkiem_date2.TabIndex = 39;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1331, 634);
            this.Controls.Add(this.timkiem_date2);
            this.Controls.Add(this.timkiem_date1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.cmb_tim_kiem);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnDanhsanh);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.thoat);
            this.Controls.Add(this.dangnhap);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_ten_nguoi_dung);
            this.Controls.Add(this.txt_mat_khau);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lichsu);
            this.Controls.Add(this.txtTimkiem);
            this.Controls.Add(this.capnhat);
            this.Controls.Add(this.xoa);
            this.Controls.Add(this.timkiem);
            this.Controls.Add(this.them);
            this.Controls.Add(this.tabledata);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cmLoaitaisan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.congty);
            this.Controls.Add(this.tentaisan);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "Chương trình quản lí tài sản";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabledata)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tentaisan;
        private System.Windows.Forms.TextBox congty;
        private System.Windows.Forms.TextBox giatien;
        private System.Windows.Forms.DateTimePicker thoigianbaohanh;
        private System.Windows.Forms.DateTimePicker thoigiantrangbi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmLoaitaisan;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView tabledata;
        private System.Windows.Forms.Button them;
        private System.Windows.Forms.Button timkiem;
        private System.Windows.Forms.Button xoa;
        private System.Windows.Forms.Button capnhat;
        private System.Windows.Forms.TextBox txtTimkiem;
        private System.Windows.Forms.Button lichsu;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button thoat;
        private System.Windows.Forms.Button dangnhap;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_ten_nguoi_dung;
        private System.Windows.Forms.TextBox txt_mat_khau;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_giaitien_thue;
        private System.Windows.Forms.Button btnDanhsanh;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmb_tim_kiem;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker timkiem_date2;
        private System.Windows.Forms.DateTimePicker timkiem_date1;
    }
}

