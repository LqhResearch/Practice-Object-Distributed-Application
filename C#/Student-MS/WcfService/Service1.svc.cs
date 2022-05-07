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
    }
}
