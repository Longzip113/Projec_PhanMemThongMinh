using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dental_sys
{
    public partial class SanBay : Form
    {
        public SanBay()
        {
            InitializeComponent();
        }


        private void SanBay_Load(object sender, EventArgs e)
        {
            guna2DataGridView1.Rows.Add(2);
            guna2DataGridView1.Rows[0].Cells[0].Value = Image.FromFile("photos\\flight.png");
            guna2DataGridView1.Rows[0].Cells[1].Value = "Tân Sân Nhất";
            guna2DataGridView1.Rows[0].Cells[2].Value = "TSN";
            guna2DataGridView1.Rows[0].Cells[3].Value = "TP.HCM";
            guna2DataGridView1.Rows[0].Cells[4].Value = "Việt Nam";

            guna2DataGridView1.Rows[1].Cells[0].Value = Image.FromFile("photos\\flight.png");
            guna2DataGridView1.Rows[1].Cells[1].Value = "Nôi Bài";
            guna2DataGridView1.Rows[1].Cells[2].Value = "SNB";
            guna2DataGridView1.Rows[1].Cells[3].Value = "Hà Nội";
            guna2DataGridView1.Rows[1].Cells[4].Value = "Việt Nam";
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            ThemSanBay themsanbay = new ThemSanBay();
            themsanbay.Show();
        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
