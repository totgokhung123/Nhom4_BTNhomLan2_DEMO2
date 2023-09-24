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
    public partial class demo : Form
    {
        public demo()
        {
            InitializeComponent();
        }
        private string tukhoa = "";
        private void loaddemo()
        {
            List<CustomParameter> lstPara = new List<CustomParameter>();
            lstPara.Add(new CustomParameter()
            {
                key = "@tukhoa",
                value = tukhoa
            });
            dgvdemo.DataSource = new demodatabase().SelectData("selectalldemo", lstPara);
        }
        private void demo_Load(object sender, EventArgs e)
        {
            loaddemo();
        }
    }
}
