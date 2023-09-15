using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LeNguyenNhatTan_2180608005_MDI
{
    public partial class formSUAGIA : Form 
    {
        public string GiaHienTaiCV { get; set; }
        public string GiaHienTaiTT { get; set; }
        public string GiaHienTaiCH { get; set; }
        public string GiaHienTaiTR { get; set; }
        public string GiaMoiCAOVOI { get; private set; }
        public string GiaMoiTAYTRANG { get; private set; }
        public string GiaMoiCHUPHINH { get; private set; }
        public string GiaMoiTRAMRANG { get; private set; }
        public formSUAGIA()
        {
            InitializeComponent();
        }

        private void formSUAGIA_Load(object sender, EventArgs e)
        {
            txtGIAMOICV.Text = GiaHienTaiCV.ToString();
            txtGIAMOITAYTRANG.Text = GiaHienTaiTT.ToString();
            txtGIAMOICHUPHINH.Text = GiaHienTaiCH.ToString();
            txtGIAMOITRAMRANG.Text = GiaHienTaiTR.ToString();
            /*
            DentalPaymentForm den = new DentalPaymentForm();
            den.Show();
            txtGIAMOICV.Text = den.lbcaovoi.ToString();
            txtGIAMOITAYTRANG.Text = den.lbtaytrang.ToString();
            txtGIAMOICHUPHINH.Text = den.lbchuphinh.ToString();
            txtGIAMOITRAMRANG.Text = den.lbtramrang.ToString();
            den.Hide();
            */
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtGIAMOICV.Text == "" || txtGIAMOICHUPHINH.Text == "" || txtGIAMOITAYTRANG.Text == "" || txtGIAMOITRAMRANG.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập cập nhật giá tiền đầy đủ!", "thông báo!");
            }
            else
            {
                GiaMoiCAOVOI = txtGIAMOICV.Text ;
                GiaMoiTAYTRANG = txtGIAMOITAYTRANG.Text;
                GiaMoiCHUPHINH = txtGIAMOICHUPHINH.Text;
                GiaMoiTRAMRANG = txtGIAMOITRAMRANG.Text;
                DialogResult = DialogResult.OK;
            }
        }

        private void txtGIAMOICV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) )
            {
                e.Handled = true;
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void formSUAGIA_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn thoát thay đổi! ", "Xác Nhận thoát !", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void txtGIAMOICV_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
