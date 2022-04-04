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
    public partial class Datmon : Form
    {
        Models.DATABASE data;
        public Datmon(ucBan ban)
        {
            InitializeComponent();
            data = new Models.DATABASE();
        }

        public void showbill(int idtable)
        {
            ltvlistoder.Items.Clear();
            txbTotal.ResetText();
            List<CTHD> listinfo = data.CTHD.ToList();
            List<MONAN> listma = data.MONAN.ToList();
            List<DONHANG> listdh = data.DONHANG.ToList();
            ListViewItem ltv;
            double total = 0;
            double tongtien = 0;
          
            foreach (DONHANG dh in listdh)
            {
                if (dh.MaBan == idtable)
                {

                    foreach (CTHD item in listinfo)
                    {
                        foreach (MONAN item1 in listma)
                        {
                            if (item.MaMon == item1.MaMon)
                            {
                            
                                string[] chitiet = { item.TenMon, item.SoLuong.ToString(), item1.Gia.ToString(), (tongtien = Convert.ToDouble(item1.Gia * item.SoLuong)).ToString() };
                                ltv = new ListViewItem(chitiet);
                                ltvlistoder.Items.Add(ltv);
                                total += Convert.ToDouble(tongtien);
                            }
                        }
                    }
                }
            }
            

        
            //discount1 = total * dis();
            //tbxdiscount.Text = (-discount1).ToString("#,###");
            //double t = total - discount1;
            txbTotal.Text = total.ToString("#,###");
        }

        private void ltvfoodsmenu_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
