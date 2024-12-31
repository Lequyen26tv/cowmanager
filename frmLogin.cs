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
    public partial class frmLogin : Form
    {
        Login lg = new Login();
        public frmLogin()
        {
            InitializeComponent();
            this.Load += new System.EventHandler(this.frmLogin_Load);
        }

        void HienThiPhanQuyen()
        {
            DataTable dt = lg.LayPhanQuyen();
            cboVaiTro.DataSource = dt;
            cboVaiTro.DisplayMember = "TENPHANQUYEN";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            HienThiPhanQuyen();
        }
    }
}
