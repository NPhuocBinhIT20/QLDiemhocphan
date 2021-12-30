
using QLDiem.DAL;
using QLDiem.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;  
using System.Threading.Tasks;

namespace QLDiem.BLL
{
    internal class HocPhanBLL
    {
        public static List<HocPhan> GetList()
        {
            QLDiemModel model = new QLDiemModel();
            //return model.LopHoc.ToList();
            return model.HocPhans.OrderBy(e => e.TenHocPhan).ToList();
        }

        public static List<HocPhanVM> GetListVM()
        {
            QLDiemModel model = new QLDiemModel();
            var ls = model.HocPhans.Select(e => new HocPhanVM
            {
                ID = e.ID,
                TenHocPhan = e.TenHocPhan,
                TotalStudent = e.SinhViens.Count() 
            }).ToList();
            return ls;
        }

        public static long GetIDHPVM(String TenHocPhan)
        {
            QLDiemModel model = new QLDiemModel();
            var ls = model.HocPhans.Where(e => e.TenHocPhan == TenHocPhan).FirstOrDefault();
            if (ls != null)
            {
                return ls.ID;
            }
            return 0;
        }

        public static void Delete(long idlop)
        {
            QLDiemModel model = new QLDiemModel();
            var lop = model.HocPhans.Where(e => e.ID == idlop).FirstOrDefault();
            if (lop != null)
                model.HocPhans.Remove(lop);
            else
                throw new Exception("Lớp học không tồn tại");
            model.SaveChanges();
        }

        public static KETQUA Insert(HocPhanVM hocphanVM)
        {
            QLDiemModel model = new QLDiemModel();
            var hocphan = model.HocPhans.Where(e => e.TenHocPhan == hocphanVM.TenHocPhan).FirstOrDefault();
            if (hocphan != null)
                return KETQUA.TenTrung;
            else
            {
                hocphan = new HocPhan
                {
                    TenHocPhan = hocphanVM.TenHocPhan
                };
                model.HocPhans.Add(hocphan);
                model.SaveChanges();
                return KETQUA.ThanhCong;
            }
        }

        public static KETQUA Update(HocPhanVM hocphanVM)
        {
            QLDiemModel model = new QLDiemModel();
            var hocphan = model.HocPhans.Where(e =>
            e.ID != hocphanVM.ID && e.TenHocPhan == hocphanVM.TenHocPhan).FirstOrDefault();
            if (hocphan != null)
                return KETQUA.TenTrung;
            else
            {
                hocphan = model.HocPhans.Where(e => e.ID == hocphanVM.ID).FirstOrDefault();
                hocphan.TenHocPhan = hocphanVM.TenHocPhan;
                model.SaveChanges();
                return KETQUA.ThanhCong;
            }
        }
    }
    public enum KETQUA
    {
        TenTrung,
        ThanhCong
    }
}
