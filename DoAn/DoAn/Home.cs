using DevExpress.XtraBars;
using DoAn.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DoAn
{
    public partial class Home : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        Models.DATABASE data;
        private TAIKHOAN ac;

        public TAIKHOAN Ac { get => ac; set => ac = value; }

        public Home(TAIKHOAN acc)
        {
            InitializeComponent();
            data = new Models.DATABASE();
            Ac = acc;
            timer1.Start();
            setlevel();
        }
         public Home()
        {
            InitializeComponent();
        }
       
        private void setdefault()
        {
            ucNguyenlieu.Instance.Visible = false;
            ucKho.Instance.Visible = false;
            ucDatMon.Instance.Visible = false;
            ucMonan.Instance.Visible = false;
            ucNhanvien.Instance.Visible = false;
            ucTaikhoan.Instance.Visible = false;
            ucThongKe.Instance.Visible = false;
            ucThongtincanhan.Instance.Visible = false;
            
        } 

        private void openDM()
        {
            setdefault();
            ucDatMon.Instance.Visible = true;
            if (!Container.Controls.Contains(ucDatMon.Instance))
            {
                Container.Controls.Add(ucDatMon.Instance);
                ucDatMon.Instance.Dock = DockStyle.Fill;
                ucDatMon.Instance.BringToFront();
            }
            ucDatMon.Instance.BringToFront();
        }

        private void openTTCN()//cách mở 2
        {
            setdefault();
            ucThongtincanhan.Instance.Visible = true;
            if (!Container.Controls.Contains(ucThongtincanhan.Instance))
            {
                ucThongtincanhan ttcn = new ucThongtincanhan();
                Container.Controls.Add(ttcn);
                ttcn.Dock = DockStyle.Fill;
                ttcn.BringToFront();
            }
        }

        private void openKHO()
        {
            setdefault();
            ucKho.Instance.Visible = true;
            if (!Container.Controls.Contains(ucKho.Instance))
            {
                Container.Controls.Add(ucKho.Instance);
                ucKho.Instance.Dock = DockStyle.Fill;
                ucKho.Instance.BringToFront();
            }
            ucKho.Instance.BringToFront();
        }

        private void openMA()
        {
            setdefault();
            ucMonan.Instance.Visible = true;
            if (!Container.Controls.Contains(ucMonan.Instance))
            {
                Container.Controls.Add(ucMonan.Instance);
                ucMonan.Instance.Dock = DockStyle.Fill;
                ucMonan.Instance.BringToFront();
            }
            ucMonan.Instance.BringToFront();
        }
  
        private void openTK()
        {
            setdefault();
            ucTaikhoan.Instance.Visible = true;
            if (!Container.Controls.Contains(ucTaikhoan.Instance))
            {
                Container.Controls.Add(ucTaikhoan.Instance);
                ucTaikhoan.Instance.Dock = DockStyle.Fill;
                ucTaikhoan.Instance.BringToFront();
                
            }
            ucTaikhoan.Instance.BringToFront();
        }

        private void openDT()
        {
            setdefault();
            ucThongKe.Instance.Visible = true;
            if (!Container.Controls.Contains(ucThongKe.Instance))
            {
                Container.Controls.Add(ucThongKe.Instance);
                ucThongKe.Instance.Dock = DockStyle.Fill;
                ucThongKe.Instance.BringToFront();
            }
            ucThongKe.Instance.BringToFront();
        }
    
        private void openNL()
        {
            setdefault();
            ucNguyenlieu.Instance.Visible = true;
            if (!Container.Controls.Contains(ucNguyenlieu.Instance))
            {
                Container.Controls.Add(ucNguyenlieu.Instance);
                ucNguyenlieu.Instance.Dock = DockStyle.Fill;
                ucNguyenlieu.Instance.BringToFront();
            }
           ucNguyenlieu.Instance.BringToFront();
        }

        private void openNV()
        {
            setdefault();
            ucNhanvien.Instance.Visible = true;
            if (!Container.Controls.Contains(ucNhanvien.Instance))
            {
                Container.Controls.Add(ucNhanvien.Instance);
                ucNhanvien.Instance.Dock = DockStyle.Fill;
                ucNhanvien.Instance.BringToFront();
            }
            ucNhanvien.Instance.BringToFront();
        }

        private void acNhanvien_Click(object sender, EventArgs e)
        {
            openNV();
        }

        private void acNguyenlieu_Click(object sender, EventArgs e)
        {
            openNL();
        }

        private void acTaikhoan_Click_1(object sender, EventArgs e)
        {
            openTK();
        }

        private void acThongKe_Click(object sender, EventArgs e)
        {
            openDT();
        }

        private void acMonan_Click(object sender, EventArgs e)
        {
            openMA();
        }

        private void acKho_Click(object sender, EventArgs e)
        {
            openKHO();
        }

        private void acTaiKhoan_Click(object sender, EventArgs e)
        {
            openTTCN();
        }

        private void acDatMon_Click(object sender, EventArgs e)
        {
            openDM();
        }
        //----------------------------------------------------------------------------------------------------------//

        private void setlevel()//Phân quyền
        {
            List<NHANVIEN> nv = data.NHANVIEN.ToList();
            username.Caption = "    XIN CHÀO: " + Ac.TENHIENTHI + "(" + Ac.MANV + ")";
            int chucvu = 0;
           
            foreach (NHANVIEN item in nv)
            {
                if (Ac.MANV == item.MANV)
                {
                    chucvu = item.MACV;
                }
            }
            switch (chucvu)
            {
                case 2://Thu ngân
                    acAdmin.Enabled = false;
                    Kho.Enabled = false;
                    break;
                case 3://kiểm kho
                    acAdmin.Enabled = false;
                    acDatMon.Enabled = false;
                    break;

                default:
                    break;
            }

        }
              
        private void setNameAndTime()//set tên người sử dụng và thời gian 
        {
            if (username.Caption.Length > 10)
            {
                username.Caption = username.Caption.Substring(username.Caption.Length - 1, 1) + username.Caption.Substring(0, username.Caption.Length - 1);
            }
            Time.Caption = DateTime.Now.ToString();
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            setNameAndTime();
        }

        private void accordionControlElement1_Click(object sender, EventArgs e)
        {
            setdefault();
            ucBan.Instance.Visible = true;
            if (!Container.Controls.Contains(ucBan.Instance))
            {
                Container.Controls.Add(ucBan.Instance);
                ucBan.Instance.Dock = DockStyle.Fill;
                ucBan.Instance.BringToFront();
            }
            ucBan.Instance.BringToFront();
        }
    }
}
