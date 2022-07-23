using System;
using System.Collections.Generic;
using System.Linq;

namespace WcfService
{
    public class Service1 : IService1
    {
        public string EvenNumber(int[] arr)
        {
            string str = "";
            for (int i = 0; i < arr.Length; i++)
                if (arr[i] > 0 && arr[i] % 2 == 0 && arr[i] != 8)
                    str += arr[i] + "  ";
            return str;
        }

        SQLDataContext db = new SQLDataContext();

        public List<NHANVIEN> GetEmployee()
        {
            return db.NHANVIENs.ToList();
        }

        public bool AddEmployee(string maNV, string hoNV, string tenLopNV, string tenNV, DateTime ngaySinh, string phai, string diaChi, decimal hsLuong, string maNQL, int maPhong)
        {
            NHANVIEN nv = new NHANVIEN();
            nv.MANV = maNV;
            nv.HONV = hoNV;
            nv.TENLOTNV = tenLopNV;
            nv.TENNV = tenNV;
            nv.NGAYSINH = ngaySinh;
            nv.PHAI = phai;
            nv.DIACHI = diaChi;
            nv.HSLUONG = hsLuong;
            nv.MANQL = maNQL;
            nv.MAPHONG = maPhong;

            try
            {
                db.NHANVIENs.InsertOnSubmit(nv);
                db.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public NHANVIEN SearchEmployee(string maNV)
        {
            return db.NHANVIENs.Where(e => e.MANV == maNV).FirstOrDefault();
        }

        public bool UpdateEmployee(string maNV, string hoNV, string tenLopNV, string tenNV, DateTime ngaySinh, string phai, string diaChi, decimal hsLuong, string maNQL, int maPhong)
        {
            NHANVIEN nv = SearchEmployee(maNV);
            nv.HONV = hoNV;
            nv.TENLOTNV = tenLopNV;
            nv.TENNV = tenNV;
            nv.NGAYSINH = ngaySinh;
            nv.PHAI = phai;
            nv.DIACHI = diaChi;
            nv.HSLUONG = hsLuong;
            nv.MANQL = maNQL;
            nv.MAPHONG = maPhong;

            try
            {
                db.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool DeleteEmployee(string maNV)
        {
            NHANVIEN nv = SearchEmployee(maNV);

            try
            {
                db.NHANVIENs.DeleteOnSubmit(nv);
                db.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public List<PHONGBAN> GetRoom()
        {
            return db.PHONGBANs.ToList();
        }
    }
}
