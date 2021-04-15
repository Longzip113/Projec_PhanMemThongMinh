using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dental_sys.FormAdd;

namespace dental_sys
{
    public partial class TuyenBay : Form
    {
        public TuyenBay()
        {
            InitializeComponent();
        }

        private void TuyenBay_Load(object sender, EventArgs e)
        {
            guna2DataGridView1.Rows.Add(2);
            guna2DataGridView1.Rows[0].Cells[0].Value = "Tân Sân Nhất";
            guna2DataGridView1.Rows[0].Cells[1].Value = "TSN";
            guna2DataGridView1.Rows[0].Cells[2].Value = Image.FromFile("photos\\go.png");
            guna2DataGridView1.Rows[0].Cells[3].Value = "Nội Bài";
            guna2DataGridView1.Rows[0].Cells[4].Value = "SBN";

            guna2DataGridView1.Rows[1].Cells[0].Value = "Nội Bài";
            guna2DataGridView1.Rows[1].Cells[1].Value = "SBN";
            guna2DataGridView1.Rows[1].Cells[2].Value = Image.FromFile("photos\\go.png");
            guna2DataGridView1.Rows[1].Cells[3].Value = "Tân Sân Nhất";
            guna2DataGridView1.Rows[1].Cells[4].Value = "TSN";
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            FormThem a = new FormThem();
            a.Show();
        }
    }
}
