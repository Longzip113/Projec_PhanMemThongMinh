using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL_DAL.Model
{
    public class ChuyenBayModel
    {
		private long Id;
		private long tuyenBayId;
		private long mayBayId;

		private String tenSanBayDi; 
		private String thanhPhoDi;
        private String codeDi;

        private String tenSanBayDen;
		private String thanhPhoDen;
        private String codeDen;

		private int thoiGianBay;
		private int ngayGio;

        private int? giaVeThuongGia;
        private int? giaVPhoThong;
        private String hangBay;


		private Boolean tinhTrang;

        public long id { get => Id; set => Id = value; }
        public long TuyenBayId { get => tuyenBayId; set => tuyenBayId = value; }
        public string TenSanBayDi { get => tenSanBayDi; set => tenSanBayDi = value; }
        public string ThanhPhoDi { get => thanhPhoDi; set => thanhPhoDi = value; }
        public string TenSanBayDen { get => tenSanBayDen; set => tenSanBayDen = value; }
        public string ThanhPhoDen { get => thanhPhoDen; set => thanhPhoDen = value; }
        public int ThoiGianBay { get => thoiGianBay; set => thoiGianBay = value; }
        public int NgayGio { get => ngayGio; set => ngayGio = value; }
        public bool TinhTrang { get => tinhTrang; set => tinhTrang = value; }
        public long MayBayId { get => mayBayId; set => mayBayId = value; }
        public int? GiaVeThuongGia { get => giaVeThuongGia; set => giaVeThuongGia = value; }
        public int? GiaVPhoThong { get => giaVPhoThong; set => giaVPhoThong = value; }
        public string HangBay { get => hangBay; set => hangBay = value; }
        public string CodeDi { get => codeDi; set => codeDi = value; }
        public string CodeDen { get => codeDen; set => codeDen = value; }
    }
}
