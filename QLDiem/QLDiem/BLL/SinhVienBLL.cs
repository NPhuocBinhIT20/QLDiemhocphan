using QLDiem.DAL;
using QLDiem.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLDiem.BLL
{
    internal class SinhVienBLL
    {
        public static List<SinhVien> GetList(long idhocphan)
        {
            QLDiemModel model = new QLDiemModel();
            return model.SinhViens.Where(e => e.IDHocPhan == idhocphan).ToList();
        }

        public static List<SinhVienVM> GetListVM()
        {
            QLDiemModel model = new QLDiemModel();
            var ls = model.SinhViens.Select(e => new SinhVienVM
            {
                ID = e.ID,
                IDStudent = e.IDStudent,
                FullName = e.FullName,
                DiemCC = e.DiemCC,
                DiemKT = e.DiemKT,
                DiemThi = e.DiemThi,
                IDHocPhan = (long)e.IDHocPhan,
                ClassName = e.HocPhans.TenHocPhan
            }).ToList();
            return ls;
        }

        public static KetQua insertsinhvien(SinhVienVM sinhvienvm)
        {
            QLDiemModel model = new QLDiemModel();
            var sv = model.SinhViens.Where(e => e.IDStudent == sinhvienvm.IDStudent).FirstOrDefault();
            if (sv != null)
                return KetQua.Trungmasv;
            else
            {
                sv = new SinhVien
                {
                    IDStudent = sinhvienvm.IDStudent,
                    FullName = sinhvienvm.FullName,
                    DiemCC = sinhvienvm.DiemCC,
                    DiemKT = sinhvienvm.DiemKT,
                    DiemThi = sinhvienvm.DiemThi,
                    IDHocPhan = sinhvienvm.IDHocPhan
                };
                model.SinhViens.Add(sv);
                model.SaveChanges();
                return KetQua.ThanhCong;
            }
        }

        public static KetQua UpdateSinhVien(SinhVienVM sinhvienvm)
        {
            QLDiemModel model = new QLDiemModel();
            //var sv = model.SinhViens.Where(e => e.ID != sinhvienvm.ID && e.IDHocPhan == sinhvienvm.IDHocPhan).FirstOrDefault();
            //if (sv != null)
            //    return KetQua.Trungmasv;
            //else
            //{
                var sv = model.SinhViens.Where(e => e.ID == sinhvienvm.ID).FirstOrDefault();
                sv.IDHocPhan = sinhvienvm.IDHocPhan;
                sv.FullName = sinhvienvm.FullName;
                sv.DiemCC = sinhvienvm.DiemCC;
                sv.DiemKT = sinhvienvm.DiemKT;
                sv.DiemThi = sinhvienvm.DiemThi;
                sv.IDHocPhan = sinhvienvm.IDHocPhan;
                model.SaveChanges();
                return KetQua.ThanhCong;
            //}
        }

        public static void DeleteSinhVien(long idstudent)
        {
            QLDiemModel model = new QLDiemModel();
            var sv = model.SinhViens.Where(e => e.ID == idstudent).FirstOrDefault();
            if (sv != null)
                model.SinhViens.Remove(sv);
            else
                throw new Exception("Không tồn tại sinh viên này");
            model.SaveChanges();
        }
    }
    public enum KetQua
    {
        Trungmasv,
        ThanhCong
    }
}
