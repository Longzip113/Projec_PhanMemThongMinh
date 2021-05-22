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
using System.Globalization;

namespace dental_sys
{
    public partial class ChuyenBay : Form
    {
        ChuyenBayDLL_DAL chuyenBay = new ChuyenBayDLL_DAL("ChuyenBay");

        public ChuyenBay()
        {
            InitializeComponent();
        }

        private String converIntegerToData(int date)
        {
            DateTime dt;
            if (DateTime.TryParseExact(date.ToString(), "yyyyMMddhhmm",
                                      CultureInfo.InvariantCulture,
                                      DateTimeStyles.None, out dt))
            {
                Console.WriteLine(dt);
            }
            return dt.ToString("yyyy/MM/dd - hh:mm", CultureInfo.InvariantCulture);
        }

        private void ChuyenBay_Load(object sender, EventArgs e)
        {
            List<ChuyenBayModel> listCB = chuyenBay.GetModels();
            guna2DataGridView1.Rows.Add(listCB.Count);
            for (int i = 0; i < listCB.Count; i++)
            {
                guna2DataGridView1.Rows[i].Cells[0].Value = listCB[i].TenSanBayDi;
                guna2DataGridView1.Rows[i].Cells[1].Value = listCB[i].ThanhPhoDi;
                guna2DataGridView1.Rows[i].Cells[2].Value = converIntegerToData(listCB[i].NgayGio);
                guna2DataGridView1.Rows[i].Cells[3].Value = Image.FromFile("photos\\direct-flight.png");
                guna2DataGridView1.Rows[i].Cells[4].Value = listCB[i].ThoiGianBay;
                guna2DataGridView1.Rows[i].Cells[5].Value = listCB[i].TenSanBayDen;
                guna2DataGridView1.Rows[i].Cells[6].Value = listCB[i].ThanhPhoDen;
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            ThemChuyenBay themChuyenBay = new ThemChuyenBay();
            themChuyenBay.Show();
        }
    }
}
