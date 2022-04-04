using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DoAn.Models;

namespace DoAn
{

    public partial class ucBan : UserControl
    {
        private static ucBan instance;
        public static ucBan Instance
        {
            get
            {
                if (instance == null)
                    instance = new ucBan();
                return instance;
            }
        }

        Models.DATABASE data;
        public ucBan()
        {
            InitializeComponent();
            data = new Models.DATABASE();
            loadtable();
        }
        public void loadtable()
        {
            flpBan.Controls.Clear();
            List<BANAN> listban = data.BANAN.ToList();

            foreach (BANAN item in listban)
            {
                if (item.BANSTT == true)
                {
                    Button bt = new Button();
                    {
                        bt.Width = 80;
                        bt.Height = 80;
                        flpBan.Controls.Add(bt);
                        bt.Text = item.TENBAN + Environment.NewLine + item.TRANGTHAI;
                        if (item.TRANGTHAI.Equals("Trống"))
                        {
                            bt.BackColor = Color.DodgerBlue;
                        }
                        else
                        {

                            bt.BackColor = Color.Gray;
                        }

                    }
                    bt.Click += bt_Click;
                    bt.Tag = item;

                }
            }

        }

        private void selectban()
        {

        }
        private void bt_Click(object sender, EventArgs e)
        {

            int idtable = ((sender as Button).Tag as BANAN).MABAN;
            Datmon datmon = new Datmon(this);
            datmon.ltvlistoder.Tag = (sender as Button).Tag;
            datmon.showbill(idtable);
            datmon.ShowDialog();

        }
    }
}
