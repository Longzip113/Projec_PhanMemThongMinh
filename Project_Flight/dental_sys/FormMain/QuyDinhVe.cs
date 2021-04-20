using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dental_sys.UserControls;

namespace dental_sys
{
    public partial class QuyDinhVe : Form
    {
        public QuyDinhVe()
        {
            InitializeComponent();
        }

        private void loadItem()
        {
            itemdatve[] list = new itemdatve[20];

            for (int i = 0; i < list.Length; i++)
            {
                list[i] = new itemdatve();
                list[i].Noiden = "Hồ Chí Minh (SGN)";
                list[i].Noidi = "Hà Nội (HAN)";
                if (i < 5)
                {
                    list[i].Img = Properties.Resources.logo_bamboo;
                }
                else if (i < 10)
                {
                    list[i].Img = Properties.Resources.logo_vietjet;
                }
                if (flowLayoutPanel1.Controls.Count < 0)
                {
                    flowLayoutPanel1.Controls.Clear();
                }
                else
                {
                    flowLayoutPanel1.Controls.Add(list[i]);
                }
            }
        }

        private void QuyDinhVe_Load(object sender, EventArgs e)
        {
            loadItem();
        }
    }
}
