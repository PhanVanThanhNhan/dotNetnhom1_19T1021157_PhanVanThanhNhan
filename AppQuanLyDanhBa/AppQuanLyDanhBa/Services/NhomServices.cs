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
    public class NhomServices
    {
        /// <summary>
        /// Lấy tất cả danh sách nhóm
        /// </summary>
        /// <returns></returns>
        public static List<NhomViewModel> GetList()
        {
            var db = new AppDBContext();
            var rs = db.Nhoms.Select(e => new NhomViewModel
            {
                ID = e.ID,
                TenNhom = e.TenNhom
            }).ToList();
            return rs;
        }

        /// <summary>
        /// Lấy danh sách liên lạc với IDNhom = id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static List<NhomViewModel> GetByNhom(int id)
        {
            var list = GetList();
            var result = list.Where(t => t.ID == id).ToList();
            return result;
        }

        /// <summary>
        /// Thêm một nhóm
        /// </summary>
        /// <param name="nhom"></param>
        /// <returns></returns>
        public static KetQua AddNhom(Nhom nhom)
        {
            var db = new AppDBContext();
            var rs = db.Nhoms.Where(e => e.ID == nhom.ID).Count();
            if (rs > 0)
            {
                return KetQua.TrungMa;
            }
            else
            {
                db.Nhoms.Add(nhom);
                db.SaveChanges();
            }
            return KetQua.ThanhCong;
        }
        /// <summary>
        /// Xóa nhóm đã chọn
        /// </summary>
        /// <param name="nhom"></param>
        /// <returns></returns>
        public static KetQua RemoveNhom(NhomViewModel lop)
        {
            var db = new AppDBContext();
            var rs = db.Nhoms.Where(e => e.ID == lop.ID).FirstOrDefault();
            db.Nhoms.Remove(rs);
            db.SaveChanges();
            return KetQua.ThanhCong;
        }
    }
}
