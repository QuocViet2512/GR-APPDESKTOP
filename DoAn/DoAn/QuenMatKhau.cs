using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DoAn.Models;
namespace DoAn
{
    public partial class QuenMatKhau : Form
    {
        public QuenMatKhau()
        {
            InitializeComponent();
            db = new Models.DATABASE();
            tk = new TAIKHOAN();
            nv = new NHANVIEN();
        }

        Models.DATABASE db;
        Models.TAIKHOAN tk;
        Models.NHANVIEN nv;

        private void setNull()
        {
            txtCMND.Text = "";
            txtLoginName_ResetPass.Text = "";
            txtMaNV.Text = "";
            txtNewPass_Repeat.Text = "";
            txtNewPass_RP.Text = "";
            txtSDT_resetPass.Text = "";

        }
        private void resetPass()
        {
            List<TAIKHOAN> listTK = db.TAIKHOAN.Where(c => c.TENTK == txtLoginName_ResetPass.Text && c.NHANVIEN.MANV == txtMaNV.Text && c.NHANVIEN.SDT == txtSDT_resetPass.Text
                                                         && c.NHANVIEN.CMND == txtCMND.Text).ToList();
            if (listTK.Count > 0)
            {
                if(txtNewPass_RP.Text != txtSDT_resetPass.Text)
                {
                    MessageBox.Show("Mật khẩu và nhập lại mật khẩu không trùng nhau");
                }
                else
                {
                    tk.MATKHAU = txtNewPass_RP.Text;
                    db.SaveChanges();
                    MessageBox.Show("Thay đổi thành công");
                }
            }
            else
            {
                MessageBox.Show("Sai thông tin");
            }
            setNull();
        }

        private void huyReset()
        {
            setNull();

            DialogResult dr = MessageBox.Show("Hủy reset mật khẩu? ",
                                                     "Quay về",
                                                     MessageBoxButtons.YesNo,
                                                     MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            resetPass();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            huyReset();
        }
    }
}
