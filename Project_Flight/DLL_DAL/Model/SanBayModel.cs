using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL_DAL.Model
{
    public class SanBayModel
    {
		private long Id;
		private String code;
		private String tenThanhPho;
		private String tenSanBay;
		private String quocGia;
		private Boolean tinhTrang;

        public string Code { get => code; set => code = value; }
        public long id { get => Id; set => Id = value; }
        public string TenThanhPho { get => tenThanhPho; set => tenThanhPho = value; }
        public string TenSanBay { get => tenSanBay; set => tenSanBay = value; }
        public string QuocGia { get => quocGia; set => quocGia = value; }
        public bool TinhTrang { get => tinhTrang; set => tinhTrang = value; }
    }
}
