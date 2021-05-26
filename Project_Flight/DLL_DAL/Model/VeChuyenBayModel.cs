using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL_DAL.Model
{
    public class VeChuyenBayModel
    {
        int Id;
        float DonGia;
        int ChuyenBayId;
        int HangVeId;

        public int id { get => Id; set => Id = value; }
        public float donGia { get => DonGia; set => DonGia = value; }
        public int chuyenBayID { get => ChuyenBayId; set => ChuyenBayId = value; }
        public int hangVeID { get => HangVeId; set => HangVeId = value; }
    }
}
