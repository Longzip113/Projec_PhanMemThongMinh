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
using DLL_DAL.Model;
using DLL_DAL;

namespace dental_sys
{
    public partial class TuyenBay : Form
    {
        TuyenBayDLL_DAL tuyenBay = new TuyenBayDLL_DAL();
        public TuyenBay()
        {
            InitializeComponent();
        }

        private void TuyenBay_Load(object sender, EventArgs e)
        {
            List<TuyenBayModel> tuyenBayModels = tuyenBay.GetTuyenBayModels();

            guna2DataGridView1.Rows.Add(tuyenBayModels.Count);
            for (int i = 0; i < tuyenBayModels.Count; i++)
            {
                guna2DataGridView1.Rows[i].Cells[0].Value = tuyenBayModels[i].TenSanBayDi;
                guna2DataGridView1.Rows[i].Cells[1].Value = tuyenBayModels[i].ThanhPhoDi;
                guna2DataGridView1.Rows[i].Cells[2].Value = Image.FromFile("photos\\go.png");
                guna2DataGridView1.Rows[i].Cells[3].Value = tuyenBayModels[i].TenSanBayDen;
                guna2DataGridView1.Rows[i].Cells[4].Value = tuyenBayModels[i].ThanhPhoDen;
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            FormThem a = new FormThem();
            a.Show();
        }
    }
}
