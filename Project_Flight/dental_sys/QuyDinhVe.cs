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
    public partial class QuyDinhVe : Form
    {
        public QuyDinhVe()
        {
            InitializeComponent();
        }

        private void QuyDinhVe_Load(object sender, EventArgs e)
        {
            guna2DataGridView1.Rows.Add(2);
            guna2DataGridView1.Rows[0].Cells[0].Value = "Tân Sân Nhất";
            guna2DataGridView1.Rows[0].Cells[1].Value = "TSN";
            guna2DataGridView1.Rows[0].Cells[2].Value = "6:35PM 18/04/2021";
            guna2DataGridView1.Rows[0].Cells[3].Value = Image.FromFile("photos\\giave.png");
            guna2DataGridView1.Rows[0].Cells[4].Value = "2:00";
            guna2DataGridView1.Rows[0].Cells[5].Value = "Nội Bài";
            guna2DataGridView1.Rows[0].Cells[6].Value = "SBN";
            guna2DataGridView1.Rows[0].Cells[7].Value = "Quy định giá";

            guna2DataGridView1.Rows[1].Cells[0].Value = "Nội Bài";
            guna2DataGridView1.Rows[1].Cells[1].Value = "SBN";
            guna2DataGridView1.Rows[1].Cells[2].Value = "8:35PM 24/04/2021";
            guna2DataGridView1.Rows[1].Cells[3].Value = Image.FromFile("photos\\giave.png");
            guna2DataGridView1.Rows[1].Cells[4].Value = "2:00";
            guna2DataGridView1.Rows[1].Cells[5].Value = "Tân Sân Nhất";
            guna2DataGridView1.Rows[1].Cells[6].Value = "TSN";
            guna2DataGridView1.Rows[1].Cells[7].Value = "Quy định giá";
        }
    }
}
