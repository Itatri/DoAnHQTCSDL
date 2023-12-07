using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
namespace Demo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-F8192VD\QUOCTHAI;Initial Catalog=QLCuaHangDienTu2;Integrated Security=True");
            try
            {
                con.Open();
                string tk = txtTK.Text;
                string mk = txtMK.Text;
                string sql = "select * form TAIKHOAN where MANV = '"+tk+"' and MATKHAU = '"+mk+"'";
                SqlCommand cmd = new SqlCommand(sql, con);
                SqlDataReader dta = cmd.ExecuteReader();
                if(dta.Read() == true)
                {
                    MessageBox.Show("Đăng nhập thành công");
                }
                else
                {
                    MessageBox.Show("Đăng nhập thất bại");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("lỗi kết nối");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
