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
    public partial class ucKho : DevExpress.XtraEditors.XtraUserControl
    {
        private static ucKho instance;
        public static ucKho Instance
        {
            get
            {
                if (instance == null)
                    instance = new ucKho();
                return instance;
            }
        }
        public ucKho()
        {
            InitializeComponent();
        }
    }
}
