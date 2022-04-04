using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DoAn.Models;
namespace DoAn
{
    public partial class ucThongtincanhan : DevExpress.XtraEditors.XtraUserControl
    {
        private static ucThongtincanhan instance;
        public static ucThongtincanhan Instance
        {
            get
            {
                if (instance == null)
                    instance = new ucThongtincanhan();
                return instance;
            }
        }
        public ucThongtincanhan()
        {
            InitializeComponent();
            nv = new Models.NHANVIEN();
            db = new Models.DATABASE();
        }
        Models.NHANVIEN nv;
        Models.DATABASE db;
        private void ucThongtincanhan_Load(object sender, EventArgs e)
        {
            display();
        }
        private void display()
        {
            txtID.Text = Login.DisplayProfile.displayId;
            txtHotenNV.Text = Login.DisplayProfile.displayName;
            txtRole.Text = Login.DisplayProfile.displayRole;
            txtSDTNV.Text = Login.DisplayProfile.displaySDT;
            txtCMND.Text = Login.DisplayProfile.displayCMND;
            dtpNS.Text = Login.DisplayProfile.displayNgaySinh;
            txtUserName.Text = Login.DisplayProfile.displayUsername;
        }
        private void openUpdatePass()
        {
            ThayDoiMatKhau f = new ThayDoiMatKhau();
            f.ShowDialog();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            openUpdatePass();
        }
        private void updateAcc()
        {
            NHANVIEN editNV = db.NHANVIEN.FirstOrDefault(c => c.MANV == txtID.Text);
            editNV.SDT = txtSDTNV.Text;
            db.SaveChanges();
            MessageBox.Show("Cập nhập thành công");
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            updateAcc();
        }

        private void txtSDTNV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
