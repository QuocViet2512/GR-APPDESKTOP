using DoAn.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn
{
    public partial class Login : Form
    {
        Models.DATABASE data;
        public Login()
        {
            InitializeComponent();
            data = new Models.DATABASE();
        }
   
        private void setnull()//set rỗng 
        {
            tbxuser.ResetText();
            tbxpassword.ResetText();

        }
        
        public static TAIKHOAN move;//chuyển dữ liệu tài khoản
        private void login()//đăng nhập
        {
            List<TAIKHOAN> acc = data.TAIKHOAN.ToList();
            string username = tbxuser.Text;
            string password = tbxpassword.Text;
            bool checklog = false;
            TAIKHOAN ac;
            
            foreach (TAIKHOAN item in acc)
            {
                if ((string.Compare(item.TENTK, username, false) == 0)&&(string.Compare(item.MATKHAU, password, false) == 0)&&item.TKSTT==true)
                {
                        checklog = true;
                        ac = item;
                        Home home = new Home(ac);
                        move = ac;
                        this.Hide();
                        home.ShowDialog();
                        setnull();
                        this.Show();
                }
            }
            if (checklog == false)
            {

                MessageBox.Show("sai tài khoản hoặc mật khẩu", "thông báo");
            }

        }

        private void exit()// đóng ứng dụng
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }


        public class DisplayProfile // lấy thông tin người đăng nhập
        {
            public static string displayName;
            public static string displayCMND;
            public static string displaySDT;
            public static string displayRole;
            public static string displayNgaySinh;
            public static string displayUsername;
            public static string displayId;

        }
        private void GetProfile()
        {
            List < TAIKHOAN > listTK = data.TAIKHOAN.Where(c => c.TENTK.Equals(tbxuser.Text) && c.MATKHAU.Equals(tbxpassword.Text)).ToList();
            if (listTK.Count > 0)
            {
                DisplayProfile.displayId = listTK[0].NHANVIEN.MANV.ToString();
                DisplayProfile.displayName = listTK[0].NHANVIEN.TENNV.ToString();
                DisplayProfile.displayNgaySinh = listTK[0].NHANVIEN.NSINH.ToString();

                DisplayProfile.displayUsername = listTK[0].TENTK.ToString();

                DisplayProfile.displaySDT = listTK[0].NHANVIEN.SDT.ToString();

                DisplayProfile.displayCMND = listTK[0].NHANVIEN.CMND.ToString();
                DisplayProfile.displayRole = listTK[0].NHANVIEN.CHUCVU.TENCV.ToString();
            }
        }
        private void misspass()
        {
            QuenMatKhau qmk = new QuenMatKhau();
            qmk.ShowDialog();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            GetProfile();
            login();
        }

        private void btnout_Click(object sender, EventArgs e)
        {
            exit();
        }

        private void llbQuenmk_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            misspass();
        }
    }
}
