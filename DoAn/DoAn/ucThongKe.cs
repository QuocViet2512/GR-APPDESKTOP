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

namespace DoAn
{
    public partial class ucThongKe : DevExpress.XtraEditors.XtraUserControl
    {
        private static ucThongKe instance;
        public static ucThongKe Instance
        {
            get
            {
                if (instance == null)
                    instance = new ucThongKe();
                return instance;
            }
        }

        public ucThongKe()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
