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
    public partial class ucDatMon : DevExpress.XtraEditors.XtraUserControl
    {
        private static ucDatMon instance;
        public static ucDatMon Instance
        {
            get
            {
                if (instance == null)
                    instance = new ucDatMon();
                return instance;
            }
        }
        Models.DATABASE db;
      
        public ucDatMon()
        {
            InitializeComponent();
            db = new Models.DATABASE();
            loadMenu();
            setButton(true);
            nullDH();
            nullALL();
            autoMenu();

        }
        private void setButton(bool val)
        {
            btnThanhToan.Enabled = !val;
            if (lsvDonHang.Items.Count > 0)
            {
                btnSuaSL.Enabled = val;
                btnHuyMon.Enabled = val;
            }
            else
            {
                btnSuaSL.Enabled = !val;
                btnHuyMon.Enabled = !val;
            }
        }
        private void nullDH()
        {
            txtMon.Text = "";
            numSoLuong.Value = 1;
        }
        private void nullALL()
        {
            txtMon.Text = "";
            txtTienNhan.Text = "";
            txtTienThua.Text = "";
            txtTongCong.Text = "";
            numSoLuong.Value = 1;

        }
        private void loadMenu()
        {
            lsvDonHang.Items.Clear();
            List<MONAN> listMenu = db.MONAN.ToList();
            foreach(MONAN mn in listMenu)
            {
                if(mn.MAstatus == true)
                {
                    string[] row = { mn.MaMon, mn.TenMon, mn.Gia.ToString() };
                    ListViewItem item = new ListViewItem(row);
                    lsvMenu.Items.Add(item);
                }
            }
        }

        private void findMenu()
        {
            List<MONAN> listlm = db.MONAN.ToList();

            if (txtFindMenu.Text != "")
            {
                string info = txtFindMenu.Text;
                foreach (MONAN lnl in listlm)
                {
                    if (string.Compare(info, lnl.MaMon.ToString(), true) == 0 || string.Compare(info, lnl.TenMon, true) == 0 || string.Compare(info, lnl.Gia.ToString(), true) == 0)
                    {
                        lsvMenu.Items.Clear();

                        if (lnl.MAstatus == true)
                        {
                            string[] ds = { lnl.MaMon, lnl.TenMon, lnl.LOAIMON.ToString(), lnl.Gia.ToString() };
                            ListViewItem item = new ListViewItem(ds);
                            lsvMenu.Items.Add(item);
                        }
                    }
                }
            }
            else
            {
                lsvMenu.Items.Clear();
                loadMenu();
            }
        }
        private void autoMenu()
        {
            List<MONAN> listMenu = db.MONAN.ToList();
            foreach (MONAN item in listMenu)
            {
                if (item.MAstatus == true)
                {
                    txtFindMenu.AutoCompleteCustomSource.Add(item.MaMon);
                    txtFindMenu.AutoCompleteCustomSource.Add(item.TenMon);
                    txtFindMenu.AutoCompleteCustomSource.Add(item.Gia.ToString());
                }
            }
        }
        private void showMenu()
        {
            if (lsvMenu.SelectedItems.Count > 0)
            {
                txtMon.Text = lsvMenu.SelectedItems[0].SubItems[1].Text;
            }
        }
        private void showDH()
        {
            if (lsvDonHang.SelectedItems.Count > 0)
            {
                txtMon.Text = lsvDonHang.Items[0].SubItems[2].Text;
                numSoLuong.Value = Int32.Parse(lsvDonHang.Items[0].SubItems[4].Text);
            }
        }

        private void tinhHD()
        {
            decimal sum = 0;
            foreach(ListViewItem item in lsvDonHang.Items)
            {
                sum += decimal.Parse(item.SubItems[3].Text) * Int32.Parse(item.SubItems[4].Text);
            }

            txtTongCong.Text = sum.ToString();
        }

        private void themMon()
        {
           
            if(txtMon.Text == "")
            {
                return;
            }
            else
            {
                ListViewItem item = new ListViewItem();
                item.Text = (lsvDonHang.Items.Count + 1).ToString();
                item.SubItems.Add(lsvMenu.SelectedItems[0].Text);
                item.SubItems.Add(txtMon.Text);
                item.SubItems.Add(lsvMenu.SelectedItems[0].SubItems[2].Text);
                item.SubItems.Add(numSoLuong.Value.ToString());

                lsvDonHang.Items.Add(item);

                tinhHD();
            }
        }

        private  void suaMon()
        {
            if (lsvDonHang.SelectedItems.Count > 0)
            {
                if(lsvDonHang.SelectedItems != null)
                {
                    ListViewItem item = lsvDonHang.SelectedItems[0];
                    item.SubItems[4].Text = numSoLuong.Value.ToString();

                }
                tinhHD();
                setButton(true);
                nullDH();
            }
            else
            {
                MessageBox.Show("Chọn món để sửa");
            }

        }
        private void huyHD()
        {
            if (lsvDonHang.Items.Count > 0)
            {
                DialogResult dr = MessageBox.Show("Xác nhận hủy đơn hàng ? ", "Hủy đơn hàng", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    lsvDonHang.Items.Clear();
                    nullALL();
                    setButton(true);
                }
            }
            else
            {
                nullALL();
                MessageBox.Show("Hóa đơn không có món");
            }
        }

        private void xoaMon()
        {
            if(lsvDonHang.SelectedItems.Count>0)
            {
                int sl = Int32.Parse(lsvDonHang.Items[lsvDonHang.SelectedIndices[0]].SubItems[4].Text);
                decimal gia = decimal.Parse(lsvDonHang.Items[lsvDonHang.SelectedIndices[0]].SubItems[3].Text);

                decimal sum = decimal.Parse(txtTongCong.Text) - (sl * gia);
                txtTongCong.Text = sum.ToString();

                lsvDonHang.Items.RemoveAt(lsvDonHang.SelectedIndices[0]);
                setButton(true);
                nullDH();
            }
            else
            {
                MessageBox.Show("Chọn món cần xóa");
            }
        }
        bool addHD;
       
        private void thanhToan()
        {
            decimal tongHD = decimal.Parse(txtTongCong.Text);
            decimal tienNhan = decimal.Parse(txtTienNhan.Text);
            decimal tienTra = tienNhan - tongHD;
            txtTienNhan.Text = tienTra.ToString();

            DONHANG dh = new DONHANG();

            dh.NgayXuat = DateTime.Now;
            dh.TongHD = tongHD;
            dh.TienThu = tienNhan;
            dh.TienTra = tienTra;
            dh.MaNV = Login.DisplayProfile.displayId;
            

            db.DONHANG.Add(dh);

            foreach(ListViewItem item in lsvDonHang.Items)
            {
                CTHD cthd = new CTHD();
                cthd.MaHD = dh.MaHD;
                cthd.TenMon = item.SubItems[2].Text;
                cthd.MaMon = item.SubItems[1].Text;
                cthd.SoLuong = Int32.Parse(item.SubItems[4].Text);              
                db.CTHD.Add(cthd);
            }
          
            db.SaveChanges();

            lsvDonHang.Items.Clear();

            nullDH();
            setButton(true);

            MessageBox.Show("Đã thanh toán");
        }
        
      
        private void btnThem_Click(object sender, EventArgs e)
        {
            themMon();
        }

        private void btnSuaSL_Click(object sender, EventArgs e)
        {
            suaMon();
        }

        private void btnHuyMon_Click(object sender, EventArgs e)
        {
            xoaMon();
        }

        private void btnHuyHD_Click(object sender, EventArgs e)
        {
            huyHD();
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            thanhToan();
        }

        private void txtFindMenu_TextChanged(object sender, EventArgs e)
        {
            findMenu();
        }

        private void lsvMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            showMenu();
        }

        private void lsvDonHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            showDH();
        }

        private void txtTienNhan_KeyDown(object sender, KeyEventArgs e)
        {
          
        }

        private void chbKhuyemMai_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void txtTongCong_TextChanged(object sender, EventArgs e)
        {
           
        }
        private void enableThanhToan()
        {
            if (string.IsNullOrEmpty(txtTienNhan.Text))
            {
                return;
            }
            else
            {
                if((decimal.Parse(txtTienNhan.Text))>= decimal.Parse(txtTongCong.Text))
                {
                    setButton(false);
                }
                else
                {
                    setButton(true);
                }
            }
        }

        private void txtTienNhan_TextChanged(object sender, EventArgs e)
        {
            enableThanhToan();
        }

        private void numSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
