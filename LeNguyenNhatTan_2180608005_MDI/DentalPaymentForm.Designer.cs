namespace LeNguyenNhatTan_2180608005_MDI
{
    partial class DentalPaymentForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtTenKhach = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSuaGia = new System.Windows.Forms.Button();
            this.cbChupHinh = new System.Windows.Forms.CheckBox();
            this.lblGiaCaoVoi = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblTramTrang = new System.Windows.Forms.Label();
            this.lblChupHinh = new System.Windows.Forms.Label();
            this.lblGiaTayTrang = new System.Windows.Forms.Label();
            this.nudTram = new System.Windows.Forms.NumericUpDown();
            this.cbCaoVoi = new System.Windows.Forms.CheckBox();
            this.cbTayTrang = new System.Windows.Forms.CheckBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnTinhTien = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.lvDANHSACH = new System.Windows.Forms.ListView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnXOAHET = new System.Windows.Forms.Button();
            this.btnXOA = new System.Windows.Forms.Button();
            this.btnCAPNHAT = new System.Windows.Forms.Button();
            this.btnTINHTONG = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTram)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(124, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dental Payment Form";
            // 
            // txtTenKhach
            // 
            this.txtTenKhach.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenKhach.Location = new System.Drawing.Point(179, 61);
            this.txtTenKhach.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTenKhach.Name = "txtTenKhach";
            this.txtTenKhach.Size = new System.Drawing.Size(287, 26);
            this.txtTenKhach.TabIndex = 1;
            this.txtTenKhach.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTenKhach_KeyPress);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSuaGia);
            this.groupBox1.Controls.Add(this.cbChupHinh);
            this.groupBox1.Controls.Add(this.lblGiaCaoVoi);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.lblTramTrang);
            this.groupBox1.Controls.Add(this.lblChupHinh);
            this.groupBox1.Controls.Add(this.lblGiaTayTrang);
            this.groupBox1.Controls.Add(this.nudTram);
            this.groupBox1.Controls.Add(this.cbCaoVoi);
            this.groupBox1.Controls.Add(this.cbTayTrang);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(11, 103);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(475, 237);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dịch vụ";
            // 
            // btnSuaGia
            // 
            this.btnSuaGia.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaGia.Location = new System.Drawing.Point(325, 189);
            this.btnSuaGia.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSuaGia.Name = "btnSuaGia";
            this.btnSuaGia.Size = new System.Drawing.Size(86, 31);
            this.btnSuaGia.TabIndex = 12;
            this.btnSuaGia.Text = "Sửa giá";
            this.btnSuaGia.UseVisualStyleBackColor = true;
            this.btnSuaGia.Click += new System.EventHandler(this.btnSuaGia_Click);
            // 
            // cbChupHinh
            // 
            this.cbChupHinh.AutoSize = true;
            this.cbChupHinh.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbChupHinh.Location = new System.Drawing.Point(21, 111);
            this.cbChupHinh.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbChupHinh.Name = "cbChupHinh";
            this.cbChupHinh.Size = new System.Drawing.Size(110, 23);
            this.cbChupHinh.TabIndex = 3;
            this.cbChupHinh.Text = "Chụp Hình";
            this.cbChupHinh.UseVisualStyleBackColor = true;
            this.cbChupHinh.CheckedChanged += new System.EventHandler(this.cbCaoVoi_CheckedChanged_1);
            // 
            // lblGiaCaoVoi
            // 
            this.lblGiaCaoVoi.AutoSize = true;
            this.lblGiaCaoVoi.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGiaCaoVoi.Location = new System.Drawing.Point(321, 50);
            this.lblGiaCaoVoi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGiaCaoVoi.Name = "lblGiaCaoVoi";
            this.lblGiaCaoVoi.Size = new System.Drawing.Size(67, 19);
            this.lblGiaCaoVoi.TabIndex = 0;
            this.lblGiaCaoVoi.Text = "100.000";
            this.lblGiaCaoVoi.Click += new System.EventHandler(this.lblGiaCaoVoi_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(5, 151);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 19);
            this.label9.TabIndex = 0;
            this.label9.Text = "Trám răng:";
            // 
            // lblTramTrang
            // 
            this.lblTramTrang.AutoSize = true;
            this.lblTramTrang.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTramTrang.Location = new System.Drawing.Point(322, 151);
            this.lblTramTrang.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTramTrang.Name = "lblTramTrang";
            this.lblTramTrang.Size = new System.Drawing.Size(84, 19);
            this.lblTramTrang.TabIndex = 0;
            this.lblTramTrang.Text = "80.000/cái";
            // 
            // lblChupHinh
            // 
            this.lblChupHinh.AutoSize = true;
            this.lblChupHinh.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChupHinh.Location = new System.Drawing.Point(322, 113);
            this.lblChupHinh.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblChupHinh.Name = "lblChupHinh";
            this.lblChupHinh.Size = new System.Drawing.Size(67, 19);
            this.lblChupHinh.TabIndex = 0;
            this.lblChupHinh.Text = "200.000";
            // 
            // lblGiaTayTrang
            // 
            this.lblGiaTayTrang.AutoSize = true;
            this.lblGiaTayTrang.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGiaTayTrang.Location = new System.Drawing.Point(321, 80);
            this.lblGiaTayTrang.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGiaTayTrang.Name = "lblGiaTayTrang";
            this.lblGiaTayTrang.Size = new System.Drawing.Size(80, 19);
            this.lblGiaTayTrang.TabIndex = 0;
            this.lblGiaTayTrang.Text = "1.200.000";
            // 
            // nudTram
            // 
            this.nudTram.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudTram.Location = new System.Drawing.Point(109, 151);
            this.nudTram.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nudTram.Name = "nudTram";
            this.nudTram.Size = new System.Drawing.Size(90, 26);
            this.nudTram.TabIndex = 4;
            this.nudTram.ValueChanged += new System.EventHandler(this.nudTram_ValueChanged);
            // 
            // cbCaoVoi
            // 
            this.cbCaoVoi.AutoSize = true;
            this.cbCaoVoi.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCaoVoi.Location = new System.Drawing.Point(21, 48);
            this.cbCaoVoi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbCaoVoi.Name = "cbCaoVoi";
            this.cbCaoVoi.Size = new System.Drawing.Size(86, 23);
            this.cbCaoVoi.TabIndex = 3;
            this.cbCaoVoi.Text = "Cạo vôi";
            this.cbCaoVoi.UseVisualStyleBackColor = true;
            this.cbCaoVoi.CheckedChanged += new System.EventHandler(this.cbCaoVoi_CheckedChanged_1);
            // 
            // cbTayTrang
            // 
            this.cbTayTrang.AutoSize = true;
            this.cbTayTrang.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTayTrang.Location = new System.Drawing.Point(21, 80);
            this.cbTayTrang.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbTayTrang.Name = "cbTayTrang";
            this.cbTayTrang.Size = new System.Drawing.Size(104, 23);
            this.cbTayTrang.TabIndex = 3;
            this.cbTayTrang.Text = "Tẩy Trắng";
            this.cbTayTrang.UseVisualStyleBackColor = true;
            this.cbTayTrang.CheckedChanged += new System.EventHandler(this.cbCaoVoi_CheckedChanged_1);
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(37, 401);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(105, 41);
            this.btnThoat.TabIndex = 7;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 64);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên Khách Hàng:";
            // 
            // btnTinhTien
            // 
            this.btnTinhTien.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTinhTien.Location = new System.Drawing.Point(202, 402);
            this.btnTinhTien.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnTinhTien.Name = "btnTinhTien";
            this.btnTinhTien.Size = new System.Drawing.Size(105, 41);
            this.btnTinhTien.TabIndex = 6;
            this.btnTinhTien.Text = "Lưu";
            this.btnTinhTien.UseVisualStyleBackColor = true;
            this.btnTinhTien.Click += new System.EventHandler(this.btnTinhTien_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(42, 357);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 19);
            this.label7.TabIndex = 0;
            this.label7.Text = "Tổng tiền";
            // 
            // lblTongTien
            // 
            this.lblTongTien.AutoSize = true;
            this.lblTongTien.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongTien.Location = new System.Drawing.Point(228, 357);
            this.lblTongTien.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(41, 19);
            this.lblTongTien.TabIndex = 0;
            this.lblTongTien.Text = "........";
            this.lblTongTien.Click += new System.EventHandler(this.lblTongTien_Click);
            // 
            // lvDANHSACH
            // 
            this.lvDANHSACH.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvDANHSACH.FullRowSelect = true;
            this.lvDANHSACH.HideSelection = false;
            this.lvDANHSACH.Location = new System.Drawing.Point(514, 22);
            this.lvDANHSACH.Name = "lvDANHSACH";
            this.lvDANHSACH.Size = new System.Drawing.Size(339, 301);
            this.lvDANHSACH.TabIndex = 6;
            this.lvDANHSACH.UseCompatibleStateImageBehavior = false;
            this.lvDANHSACH.View = System.Windows.Forms.View.Details;
            this.lvDANHSACH.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.lvDANHSACH_ItemChecked);
            this.lvDANHSACH.SelectedIndexChanged += new System.EventHandler(this.lvDANHSACH_SelectedIndexChanged);
            this.lvDANHSACH.Click += new System.EventHandler(this.lvDANHSACH_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnXOAHET);
            this.groupBox2.Controls.Add(this.btnXOA);
            this.groupBox2.Controls.Add(this.btnCAPNHAT);
            this.groupBox2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(514, 342);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(316, 100);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cập nhật dịch vụ khách hàng";
            // 
            // btnXOAHET
            // 
            this.btnXOAHET.Location = new System.Drawing.Point(218, 39);
            this.btnXOAHET.Name = "btnXOAHET";
            this.btnXOAHET.Size = new System.Drawing.Size(81, 38);
            this.btnXOAHET.TabIndex = 11;
            this.btnXOAHET.Text = "Xóa hết";
            this.btnXOAHET.UseVisualStyleBackColor = true;
            this.btnXOAHET.Click += new System.EventHandler(this.btnXOAHET_Click);
            // 
            // btnXOA
            // 
            this.btnXOA.Location = new System.Drawing.Point(123, 39);
            this.btnXOA.Name = "btnXOA";
            this.btnXOA.Size = new System.Drawing.Size(75, 38);
            this.btnXOA.TabIndex = 10;
            this.btnXOA.Text = "Xóa";
            this.btnXOA.UseVisualStyleBackColor = true;
            this.btnXOA.Click += new System.EventHandler(this.btnXOA_Click);
            // 
            // btnCAPNHAT
            // 
            this.btnCAPNHAT.Location = new System.Drawing.Point(15, 39);
            this.btnCAPNHAT.Name = "btnCAPNHAT";
            this.btnCAPNHAT.Size = new System.Drawing.Size(93, 38);
            this.btnCAPNHAT.TabIndex = 8;
            this.btnCAPNHAT.Text = "Cập nhật";
            this.btnCAPNHAT.UseVisualStyleBackColor = true;
            this.btnCAPNHAT.Click += new System.EventHandler(this.btnCAPNHAT_Click);
            // 
            // btnTINHTONG
            // 
            this.btnTINHTONG.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTINHTONG.Location = new System.Drawing.Point(336, 401);
            this.btnTINHTONG.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnTINHTONG.Name = "btnTINHTONG";
            this.btnTINHTONG.Size = new System.Drawing.Size(105, 41);
            this.btnTINHTONG.TabIndex = 5;
            this.btnTINHTONG.Text = "Tính tiền";
            this.btnTINHTONG.UseVisualStyleBackColor = true;
            this.btnTINHTONG.Click += new System.EventHandler(this.btnTINHTONG_Click);
            // 
            // DentalPaymentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(865, 454);
            this.Controls.Add(this.btnTINHTONG);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lvDANHSACH);
            this.Controls.Add(this.btnTinhTien);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.lblTongTien);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtTenKhach);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "DentalPaymentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DentalPaymentForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DentalPaymentForm_FormClosing);
            this.Load += new System.EventHandler(this.DentalPaymentForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTram)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTenKhach;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.CheckBox cbChupHinh;
        private System.Windows.Forms.Label lblGiaCaoVoi;
        private System.Windows.Forms.Label lblGiaTayTrang;
        private System.Windows.Forms.NumericUpDown nudTram;
        private System.Windows.Forms.CheckBox cbCaoVoi;
        private System.Windows.Forms.CheckBox cbTayTrang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTramTrang;
        private System.Windows.Forms.Label lblChupHinh;
        private System.Windows.Forms.Button btnTinhTien;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnSuaGia;
        private System.Windows.Forms.ListView lvDANHSACH;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnXOAHET;
        private System.Windows.Forms.Button btnXOA;
        private System.Windows.Forms.Button btnCAPNHAT;
        private System.Windows.Forms.Button btnTINHTONG;
    }
}