﻿using System;
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
    public partial class DanhSachNhanVien : Form
    {
        public DanhSachNhanVien()
        {
            InitializeComponent();
        }

        private void Patient_Load(object sender, EventArgs e)
        {
            guna2DataGridView1.Rows.Add(2);
            guna2DataGridView1.Rows[0].Cells[1].Value = Image.FromFile("photos\\1.png");
            guna2DataGridView1.Rows[0].Cells[2].Value = "Nguyễn Thành Long";
            guna2DataGridView1.Rows[0].Cells[3].Value = "0356614606";
            guna2DataGridView1.Rows[0].Cells[4].Value = "30286654";
            guna2DataGridView1.Rows[0].Cells[5].Value = "Longzip113";
            guna2DataGridView1.Rows[0].Cells[6].Value = "100";
            guna2DataGridView1.Rows[0].Cells[7].Value = "100,000,000";

            guna2DataGridView1.Rows[1].Cells[1].Value = Image.FromFile("photos\\1.png");
            guna2DataGridView1.Rows[1].Cells[2].Value = "Nguyễn Thành Long";
            guna2DataGridView1.Rows[1].Cells[3].Value = "0356614606";
            guna2DataGridView1.Rows[1].Cells[4].Value = "30286654";
            guna2DataGridView1.Rows[1].Cells[5].Value = "Longzip113";
            guna2DataGridView1.Rows[1].Cells[6].Value = "100";
            guna2DataGridView1.Rows[1].Cells[7].Value = "100,000,000";
        }
    }
}
