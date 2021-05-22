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
using DLL_DAL;
using DLL_DAL.Model;

namespace dental_sys
{
    public partial class NhanVien : Form
    {
        NhanVienDLL_DAL nhanVien = new NhanVienDLL_DAL("USER");

        public NhanVien()
        {
            InitializeComponent();
        }

        private void Patient_Load(object sender, EventArgs e)
        {
            List<NhanVienModel> listNV = nhanVien.GetModels();
            guna2DataGridView1.Rows.Add(listNV.Count);

            for (int i = 0; i < listNV.Count; i++)
            {
                guna2DataGridView1.Rows[i].Cells[0].Value = Image.FromFile("photos\\user.png");
                guna2DataGridView1.Rows[i].Cells[1].Value = listNV[i].HoTen; //"Nguyễn Thành Long";
                guna2DataGridView1.Rows[i].Cells[2].Value = listNV[i].SDT; //"0356614606";
                guna2DataGridView1.Rows[i].Cells[3].Value = listNV[i].CMND; //"30286654";
                guna2DataGridView1.Rows[i].Cells[4].Value = listNV[i].TaiKhoan; //"Longzip113";
                guna2DataGridView1.Rows[i].Cells[5].Value = listNV[i].SoVeBan; //"100";
                guna2DataGridView1.Rows[i].Cells[6].Value = listNV[i].TongDoanhThu; //"100,000,000";
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            ThemNhanVien add = new ThemNhanVien();
            add.Show();
        }
    }
}
