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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //mo file anh
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //goi chuc nang mo anh
            OpenFileDialog open = new OpenFileDialog();
            //cho phep goi file
            open.Filter = "JPG file |*.jpg| PNG file|*.png";
            if(open.ShowDialog() == DialogResult.OK)
            {
                ChildForm frm = new ChildForm(open.FileName);
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void cascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);

        }

        private void hoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void verticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dentalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Size = new Size(965, 570);
            DentalPaymentForm dentalPaymentForm = new DentalPaymentForm();
            dentalPaymentForm.MdiParent = this;
            dentalPaymentForm.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
