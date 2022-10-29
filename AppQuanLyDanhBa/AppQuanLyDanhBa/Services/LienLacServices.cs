using AppQuanLyDanhBa.Model;
using AppQuanLyDanhBa.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static AppQuanLyDanhBa.ViewModel.LienLacViewModel;

namespace AppQuanLyDanhBa.Services
{
    public class LienLacServices
    {
        /// <summary>
        /// Lấy toàn bộ sinh viên
        /// </summary>
        /// <returns></returns>
        public static List<LienLacViewModel> GetList()
        {
            var db = new AppDBContext();
            var rs = db.LienLacs.Select(e => new LienLacViewModel
            {
                ID = e.ID,
                Ten = e.Ten,
                DiaChi = e.DiaChi,
                Email = e.Email,
                Sdt = e.Sdt,
                IDNhom = e.IDNhom

            }).ToList();
            return rs;

        }
        public static List<LienLacViewModel> GetList(int idNhom)
        {
            var db = new AppDBContext();
            var rs = db.LienLacs
                .Where(e => e.IDNhom == idNhom)
                .Select(e => new LienLacViewModel
                {
                    ID = e.ID,
                    Ten = e.Ten,
                    DiaChi = e.DiaChi,
                    Email = e.Email,
                    Sdt = e.Sdt,
                    IDNhom = e.IDNhom,
                }).ToList();
            return rs;
        }
        public static KetQua AddLienLac(LienLac ll)
        {
            var db = new AppDBContext();
            var count = db.LienLacs.Where(e => e.ID == ll.ID).Count();
            if (count > 0)
            {
                return KetQua.TrungMa;
            }
            else
            {
                db.LienLacs.Add(ll);
                db.SaveChanges();
                return KetQua.ThanhCong;
            }

        }
        public static KetQua RemoveLienLac(LienLacViewModel lien)
        {
            var db = new AppDBContext();
            var lienlac = db.LienLacs.Where(e => e.ID == lien.ID).FirstOrDefault();
            db.LienLacs.Remove(lienlac);
            db.SaveChanges();
            return KetQua.ThanhCong;
        }
    
        //Tìm kiếm Liên Lạc
        public static List<LienLacViewModel> FindLienLac(string giaTriTimKiem, NhomViewModel n)
        {
            var db = new AppDBContext();
            var rs = db.LienLacs.Where(e => e.IDNhom == n.ID).
                                Where(e => e.Ten.Contains(giaTriTimKiem)
                                        || e.DiaChi.Contains(giaTriTimKiem)
                                        || e.Email.Contains(giaTriTimKiem)
                                        || e.Sdt.Contains(giaTriTimKiem))
                                .Select(e => new LienLacViewModel
                                {
                                    ID = e.ID,
                                    Ten = e.Ten,
                                    Email = e.Email,
                                    Sdt = e.Sdt,
                                    IDNhom = e.IDNhom,
                                    DiaChi = e.DiaChi
                                }).ToList();
            return rs;
        }
    }
}
