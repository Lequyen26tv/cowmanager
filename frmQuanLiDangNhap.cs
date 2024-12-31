using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiTrangTraiBoSua
{
    public partial class frmQuanLiDangNhap : Form
    {
        QuanLiDangNhap ql = new QuanLiDangNhap();
        public frmQuanLiDangNhap()
        {
            InitializeComponent();

        }

        public void ThemTaiKhoang()
        {
            string ten = txtTenDangNhap.Text;
            string matkhau = txtMatKhau.Text;
            string tenphanquuyen = cboPhanQuyen.Text;
            int capdophanquyen = Convert.ToInt32(cboCapDoPhanQuyen.Text);
            ql.ThemUserDangNhap(ten, matkhau, tenphanquuyen, capdophanquyen);
            MessageBox.Show("Thêm tài khoảng thành công!");
        }




        private void button1_Click(object sender, EventArgs e)
        {
            ThemTaiKhoang();
        }
    }
}
