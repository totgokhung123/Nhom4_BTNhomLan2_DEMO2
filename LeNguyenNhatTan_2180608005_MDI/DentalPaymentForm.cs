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
    public partial class DentalPaymentForm : Form
    {
        public DentalPaymentForm()
        {

            InitializeComponent();
            lvDANHSACH.Columns.Add("Tên Khách hàng", 250);
            lvDANHSACH.Columns.Add("Tổng tiền", 150);
            lvDANHSACH.Columns.Add("Cạo vôi");
            lvDANHSACH.Columns.Add("Tẩy trắng");
            lvDANHSACH.Columns.Add("Chụp hình");
            lvDANHSACH.Columns.Add("Số lượng răng trám");


        }
        public string lbcaovoi { get; private set; }
        public string lbtaytrang { get; private set; }
        public string lbchuphinh { get; private set; }
        public string lbtramrang { get; private set; }


        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void DentalPaymentForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn thoát! ", "Xác Nhận thoát !", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
        //ham check nguoi dung
        public bool checkNull()
        {
            if(txtTenKhach.Text ==  "" || 
              (cbCaoVoi.Checked == false && 
               cbChupHinh.Checked == false && 
               cbTayTrang.Checked == false && 
               nudTram.Value <= 0))
            {
                return true;
            }
            return false;
        }
        public float tongTien()
        {
            float tong = 0, tienChupHinh = 0, tienTayTrang = 0, tienTramRang = 0, tienCaoVoi = 0;
            if(cbCaoVoi.Checked)
            {
                tienCaoVoi = float.Parse(lblGiaCaoVoi.Text.Replace(".", string.Empty));
            }
            if (cbChupHinh.Checked)
            {
                tienChupHinh = float.Parse(lblChupHinh.Text.Replace(".", string.Empty));
            }
            if (cbTayTrang.Checked)
            {
                tienTayTrang = float.Parse(lblGiaTayTrang.Text.Replace(".", string.Empty));
            }
            if (nudTram.Value > 0)
            {
                float gia = float.Parse(lblTramTrang.Text.Replace(".", string.Empty).Replace("/cái", string.Empty));
                int soluong = int.Parse(nudTram.Value.ToString());
                tienTramRang = gia * soluong;   
            }
            tong = tienCaoVoi + tienChupHinh + tienTayTrang + tienTramRang;
            return tong;    
        }
        private void btnTinhTien_Click(object sender, EventArgs e)
        {
            if (txtTenKhach.Text == "")
            {
                MessageBox.Show("Bạn hãy nhập tên khách hàng!", "Thông báo");

            }
            else if (cbCaoVoi.Checked == false && cbChupHinh.Checked == false && cbTayTrang.Checked == false && nudTram.Value <= 0)
            {
                MessageBox.Show("Bạn hãy chọn dịch vụ!", "Thông báo");
            }
            else if (lblTongTien.Text == "........" || lblTongTien.Text == "")
            {
                MessageBox.Show("Bạn chưa tính tiền!!!", "thông báo !!");
                btnTINHTONG.Select();
            }
            else
            {
                ListViewItem item = new ListViewItem(txtTenKhach.Text);
                item.SubItems.Add(lblTongTien.Text);
                item.SubItems.Add(cbCaoVoi.Checked ? "có" : "không");
                item.SubItems.Add(cbTayTrang.Checked ? "có" : "không");
                item.SubItems.Add(cbChupHinh.Checked ? "có" : "không");
                item.SubItems.Add(nudTram.Value.ToString());
                lvDANHSACH.Items.Add(item);

                txtTenKhach.Clear();
                cbCaoVoi.Checked = false;
                cbTayTrang.Checked = false;
                cbChupHinh.Checked = false;
                nudTram.Value = 0;
                lblTongTien.Text = "........";
                // lvDANHSACH.Items.Add( txtTenKhach.Text.ToString()  + lblTongTien.Text.ToString());

            }

        }

        private void DentalPaymentForm_Load(object sender, EventArgs e)
        {
            
        }

        private void lblTongTien_Click(object sender, EventArgs e)
        {

        }

        private void btnSuaGia_Click(object sender, EventArgs e)
        {
            formSUAGIA suagiaform = new formSUAGIA();
            suagiaform.GiaHienTaiCV = lblGiaCaoVoi.Text.Replace(".", string.Empty).ToString();
            suagiaform.GiaHienTaiTT = lblGiaTayTrang.Text.Replace(".", string.Empty).ToString();
            suagiaform.GiaHienTaiCH = lblChupHinh.Text.Replace(".", string.Empty).ToString();
            suagiaform.GiaHienTaiTR = lblTramTrang.Text.Replace(".", string.Empty).Replace("/cái",string.Empty).ToString();
            DialogResult result = suagiaform.ShowDialog();

            if(result == DialogResult.OK)
            {
                string giamoicv = suagiaform.GiaMoiCAOVOI;
                string giamoitt = suagiaform.GiaMoiTAYTRANG;
                string giamoich = suagiaform.GiaMoiCHUPHINH;
                string giamoitr = suagiaform.GiaMoiTRAMRANG;
                lblGiaCaoVoi.Text = FormatGiaTiengViet(giamoicv.ToString());
                lblGiaTayTrang.Text = FormatGiaTiengViet(giamoitt.ToString());
                lblChupHinh.Text = FormatGiaTiengViet(giamoich.ToString());
                lblTramTrang.Text = FormatGiaTiengViet(giamoitr.ToString())+"/cái";
            }
        }
        private string FormatGiaTiengViet(string gia)
        {
            string giaChuoi = gia.ToString();
            int doDai = giaChuoi.Length;
            string ketQua = "";

            for (int i = 0; i < doDai; i++)
            {
                ketQua += giaChuoi[i];
                if ((doDai - i - 1) % 3 == 0 && i != doDai - 1)
                {
                    ketQua += ".";
                }
            }

            return ketQua;
        }

        private void btnXOA_Click(object sender, EventArgs e)
        {
            if(lvDANHSACH.SelectedItems.Count > 0)
            {
                while (lvDANHSACH.SelectedItems.Count > 0)
                {
                    // ListViewItem selectedItem = lvDANHSACH.SelectedItems[i];
                    lvDANHSACH.Items.RemoveAt(lvDANHSACH.SelectedItems[0].Index);
                }
            }
            else if (lvDANHSACH.SelectedItems.Count == 0)
            {
                MessageBox.Show("Bạn chưa chọn khách hàng để xóa!", "Thông báo!");
            }
            else
            {
                MessageBox.Show("Không có khách hàng để xóa!", "Thông báo!");
            }
        }

        private void lvDANHSACH_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (lvDANHSACH.SelectedItems.Count > 0)
            {
                foreach (ListViewItem item in lvDANHSACH.Items)
                {
                    if (item.Selected)
                    {
                        // Lấy thông tin từ mục
                        txtTenKhach.Text = item.SubItems[0].Text.ToString();
                        lblTongTien.Text = item.SubItems[1].Text.ToString();
                        if (item.SubItems[2].Text == "có")
                        {
                            cbCaoVoi.Checked = true;
                        }
                        else
                        {
                            cbCaoVoi.Checked= false;
                        }
                        if (item.SubItems[3].Text == "có")
                        {
                            cbTayTrang.Checked = true;
                        }
                        else
                        {
                            cbTayTrang.Checked = false;
                        }
                        if (item.SubItems[4].Text == "có")
                        {
                            cbChupHinh.Checked = true;
                        }
                        else
                        {
                            cbChupHinh.Checked = false;
                        }
                        nudTram.Value = decimal.Parse(item.SubItems[5].Text.ToString());
                    }
                }
            }
        }

        private void btnXOAHET_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn xóa hết! ", "Xác Nhận xóa !", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                lvDANHSACH.Items.Clear();
            }
            else
            {
                return;
            }
        }

        private void btnCAPNHAT_Click(object sender, EventArgs e)
        {
            
            if(lvDANHSACH.Items.Count <= 0)
            {
                MessageBox.Show("Không có danh sách khách hàng để cập nhật!","thông báo!!");
            }
            else if(lvDANHSACH.SelectedItems.Count <= 0)
            {
                MessageBox.Show("Bạn chưa chọn khách hàng để cập nhật", "thông báo!!");
            }
            else if (lblTongTien.Text == "........")
            {
                MessageBox.Show("Bạn chưa tính tổng tiền!!", "thông báo!");
                btnTINHTONG.Select();
            }
            else
            {
                string tenKhachHangcapnhat = txtTenKhach.Text;
                float tiencapnhat = float.Parse(lblTongTien.Text.ToString());
                string caoVoi = cbCaoVoi.Checked ? "có" : "không";
                string tayTrang = cbTayTrang.Checked ? "có" : "không";
                string chupHinh = cbChupHinh.Checked ? "có" : "không";
                string tramRang = nudTram.Value.ToString();
                // Lặp qua tất cả các mục trong ListView và kiểm tra xem mục có được chọn hay không
                foreach (ListViewItem item in lvDANHSACH.Items)
                {
                    if (item.Selected)
                    {
                        // Lấy thông tin từ mục
                        string tenKhachHangCu = item.SubItems[0].Text.ToString();
                        float tongTienCu = float.Parse(item.SubItems[1].Text);
                        string caoVoiCu = item.SubItems[2].Text.ToString();
                        string tayTrangCu = item.SubItems[3].Text.ToString();
                        string chupHinhCu = item.SubItems[4].Text.ToString();
                        string tramRangCu = item.SubItems[5].Text.ToString();
                        // Kiểm tra và cập nhật thông tin mục

                        if (tenKhachHangCu != tenKhachHangcapnhat)
                        {
                            item.SubItems[0].Text = tenKhachHangcapnhat;
                            item.SubItems[2].Text = caoVoi;
                            item.SubItems[3].Text = tayTrang;
                            item.SubItems[4].Text = chupHinh;
                            item.SubItems[5].Text = tramRang;
                        }
                        else if(tongTienCu != tiencapnhat)
                        {
                            item.SubItems[1].Text = tiencapnhat.ToString();
                            item.SubItems[2].Text = caoVoi;
                            item.SubItems[3].Text = tayTrang;
                            item.SubItems[4].Text = chupHinh;
                            item.SubItems[5].Text = tramRang;
                        }
                    }
                        
                }
            }
            
        }

        public int tongTienDemo()
        {
            int tong = 0;
            return tong;
        }

        private void btnTINHTONG_Click(object sender, EventArgs e)
        {
                //siuuuuuuuuuuuuuuuu  cvwdvwevwev         
                
                lblTongTien.Text = string.Empty;
                lblTongTien.Text = tongTien().ToString();
        }

        private void txtTenKhach_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void cbCaoVoi_CheckedChanged_1(object sender, EventArgs e)
        {
            if(cbCaoVoi.Checked == false || cbChupHinh.Checked == false || cbTayTrang.Checked == false)
            {
                lblTongTien.Text = "........";
            }
            else
            {
                lblTongTien.Text = "........";
            }
        }

        private void nudTram_ValueChanged(object sender, EventArgs e)
        {
            if (nudTram.Value == 0)
            {
                lblTongTien.Text = "........";
            }
            else
            {
                lblTongTien.Text = "........";
            }
        }

        private void lblGiaCaoVoi_Click(object sender, EventArgs e)
        {

        }

        private void lvDANHSACH_Click(object sender, EventArgs e)
        {
            
        }

        private void lvDANHSACH_ItemChecked(object sender, ItemCheckedEventArgs e)
        {

        }
        //srgwsergwergwrgwrgwergwrgerg
    }
}
