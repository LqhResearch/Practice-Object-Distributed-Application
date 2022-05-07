using System;
using System.Collections.Generic;
using System.Linq;

namespace WcfService
{
    public class Service1 : IService1
    {
        SQLDataContext db = new SQLDataContext();
        public List<Lop> HienThiLop()
        {
            return db.Lops.ToList();
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

        public Lop TimLop(string maLop)
        {
            return db.Lops.Where(l => l.MaLop == maLop).FirstOrDefault();
        }

        public List<Lop> TimKiemLop(string keyword)
        {
            return db.Lops.Where(l => l.MaLop == keyword || l.TenLop.Contains(keyword)).ToList();
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
    }
}
