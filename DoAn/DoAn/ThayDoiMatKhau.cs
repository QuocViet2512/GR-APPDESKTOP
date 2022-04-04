using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DoAn.Models;
namespace DoAn
{
    public partial class ThayDoiMatKhau : DevExpress.XtraEditors.XtraForm
    {
        public ThayDoiMatKhau()
        {
            InitializeComponent();
            db = new Models.DATABASE();
            tk = new Models.TAIKHOAN();
            nv = new Models.NHANVIEN();
            setNull();
        }
        Models.DATABASE db;
        TAIKHOAN tk;
        NHANVIEN nv;

        private void setNull()
        {
            txtLoginName.Text = "";
            txtNewPass.Text = "";
            txtNewPassRepeat.Text = "";
            txtPass.Text = "";
           
        }

        private void updatePASS()
        {
            string ID = txtLoginName.Text;
            tk = db.TAIKHOAN.FirstOrDefault(c => c.TENTK == ID);
            List<TAIKHOAN> listTK = db.TAIKHOAN.Where(p => p.TENTK.Equals(txtLoginName.Text) && p.MATKHAU.Equals(txtPass.Text)).ToList();

            if (listTK.Count > 0)
            {
                if(txtNewPass.Text != txtNewPassRepeat.Text)
                {
                    MessageBox.Show("Mật khẩu không trùng nhau");
                }
                else
                {
                    tk.MATKHAU = txtNewPass.Text;
                    db.SaveChanges();
                    MessageBox.Show("Thay đổi thành công");
                }
            }
            else
            {
                MessageBox.Show("Sai tài khoản hoặc mật khẩu");
            }
            setNull();
        }
        private void huyUpdate()
        {
            setNull();

            DialogResult dr = MessageBox.Show("Hủy thay đổi mật khẩu? ",
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
            updatePASS();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            huyUpdate();
        }
    }
}