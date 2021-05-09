using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL_DAL.Model
{
    public class TuyenBayModel
    {
		private long Id;
		private long sanBayDiID;
		private long sanBayDenID;
		private Boolean tinhTrang;

		private String tenSanBayDi;
		private String thanhPhoDi;

		private String thanhPhoDen;
		private String tenSanBayDen;

        public long id { get => Id; set => Id = value; }
        public long SanBayDiID { get => sanBayDiID; set => sanBayDiID = value; }
        public long SanBayDenID { get => sanBayDenID; set => sanBayDenID = value; }
        public bool TinhTrang { get => tinhTrang; set => tinhTrang = value; }
        public string TenSanBayDi { get => tenSanBayDi; set => tenSanBayDi = value; }
        public string ThanhPhoDi { get => thanhPhoDi; set => thanhPhoDi = value; }
        public string ThanhPhoDen { get => thanhPhoDen; set => thanhPhoDen = value; }
        public string TenSanBayDen { get => tenSanBayDen; set => tenSanBayDen = value; }
    }
}
