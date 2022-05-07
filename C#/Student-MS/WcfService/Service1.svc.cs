using System.Collections.Generic;
using System.Linq;

namespace WcfService
{
    public class Service1 : IService1
    {
        SQLDataContext db = new SQLDataContext();

        /// <summary>
        /// LOP
        /// </summary>
        public List<Lop> HienThiLop()
        {
            return db.Lops.ToList();
        }

        public Lop TimLop(string maLop)
        {
            return db.Lops.Where(l => l.MaLop == maLop).FirstOrDefault();
        }

        public List<Lop> TimKiemLop(string keyword)
        {
            return db.Lops.Where(l => l.MaLop == keyword || l.TenLop.Contains(keyword)).ToList();
        }

        public bool ThemLop(string maLop, string tenLop)
        {
            Lop l = new Lop();
            l.MaLop = maLop;
            l.TenLop = tenLop;

            try
            {
                db.Lops.InsertOnSubmit(l);
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool SuaLop(string maLop, string tenLop)
        {
            Lop l = TimLop(maLop);
            l.TenLop = tenLop;

            try
            {
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool XoaLop(string maLop)
        {
            Lop l = TimLop(maLop);

            try
            {
                db.Lops.DeleteOnSubmit(l);
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// SINHVIEN
        /// </summary>
        public List<SinhVien> HienThiSinhVien()
        {
            return db.SinhViens.ToList();
        }
        public SinhVien TimSinhVien(string mssv)
        {
            return db.SinhViens.Where(sv => sv.MSSV == mssv).FirstOrDefault();
        }

        public List<SinhVien> TimKiemSinhVien(string keyword)
        {
            return db.SinhViens.Where(sv => sv.MSSV == keyword || sv.HoTen.Contains(keyword)).ToList();
        }

        public bool ThemSinhVien(string mssv, string hoTen, string queQuan, int namSinh, string gioiTinh, string maLop)
        {
            SinhVien sv = new SinhVien();
            sv.MSSV = mssv;
            sv.HoTen = hoTen;
            sv.QueQuan = queQuan;
            sv.NamSinh = namSinh;
            sv.GioiTinh = gioiTinh;
            sv.MaLop = maLop;

            try
            {
                db.SinhViens.InsertOnSubmit(sv);
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool SuaSinhVien(string mssv, string hoTen, string queQuan, int namSinh, string gioiTinh, string maLop)
        {
            SinhVien sv = TimSinhVien(mssv);
            sv.MSSV = mssv;
            sv.HoTen = hoTen;
            sv.QueQuan = queQuan;
            sv.NamSinh = namSinh;
            sv.GioiTinh = gioiTinh;
            sv.MaLop = maLop;

            try
            {
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool XoaSinhVien(string mssv)
        {
            SinhVien sv = TimSinhVien(mssv);

            try
            {
                db.SinhViens.DeleteOnSubmit(sv);
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
