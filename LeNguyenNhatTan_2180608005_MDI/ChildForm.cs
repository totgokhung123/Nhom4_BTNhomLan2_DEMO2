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
    public partial class ChildForm : Form
    {
        public ChildForm(string imageFile)
        {
            InitializeComponent();
            //lay hinh anh de hien thi
            ptbHinhAnh.Image = Image.FromFile(imageFile);
            Text = imageFile.Substring(imageFile.LastIndexOf('\\') + 1); 
        }
        public ChildForm()
        {
            InitializeComponent();
        }


    }
}
