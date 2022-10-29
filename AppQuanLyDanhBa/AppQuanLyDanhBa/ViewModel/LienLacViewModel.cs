using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppQuanLyDanhBa.ViewModel
{
    public class LienLacViewModel
    {
        public enum KetQua
        {
            TrungMa,
            ThanhCong
        }
        public int ID { get; set; }
        public string Ten { get; set; }
        public string Email { get; set; }
        public string DiaChi { get; set; }
        public string Sdt { get; set; }
        public int? IDNhom { get; set; }
    }
}
