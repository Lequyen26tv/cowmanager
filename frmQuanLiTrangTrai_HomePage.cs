using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiTrangTraiBoSua
{
    public partial class frmQuanLiTrangTrai_HomePage : Form
    {
        public frmQuanLiTrangTrai_HomePage()
        {
            InitializeComponent();
        }
        private Form currentFormChild;
        private void OpenChildForm(Form childForm)
        {
            if(currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelBody.Controls.Add(childForm);
            panelBody.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }


        private void frmQuanLiTrangTrai_HomePage_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmQuanLiDangNhap());
            lbTitle.Text = btnQuanLiDangNhap.Text;
        }

        private void btnQuanLiNhanVien_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmQuanLiNhanvien());
            lbTitle.Text= btnQuanLiNhanVien.Text;
        }
    }
}
