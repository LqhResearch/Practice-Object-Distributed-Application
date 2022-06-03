using System;
using System.Collections.Generic;
using System.Linq;

namespace WcfService
{
    public class Service1 : IService1
    {
        SQLDataContext db = new SQLDataContext();

        /// <summary>
        /// CT_DaoTao
        /// </summary>
        public List<CT_DaoTao> GetEducates()
        {
            return db.CT_DaoTaos.ToList();
        }

        public CT_DaoTao SearchEducate(string id)
        {
            return db.CT_DaoTaos.Where(e => e.MaCTDT == id).FirstOrDefault();
        }

        public List<CT_DaoTao> SearchKeywordEducates(string keyword)
        {
            return db.CT_DaoTaos.Where(e => e.MaCTDT == keyword || e.TenCTDT.Contains(keyword)).ToList();
        }

        public bool AddEducate(string id, string name)
        {
            CT_DaoTao e = new CT_DaoTao();
            e.MaCTDT = id;
            e.TenCTDT = name;

            try
            {
                db.CT_DaoTaos.InsertOnSubmit(e);
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool EditEducate(string id, string name)
        {
            CT_DaoTao e = SearchEducate(id);
            e.TenCTDT = name;

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

        public bool DeleteEducate(string id)
        {
            CT_DaoTao e = SearchEducate(id);
            try
            {
                db.CT_DaoTaos.DeleteOnSubmit(e);
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// KHOAHOC
        /// </summary>
        public List<KhoaHoc> GetCourses()
        {
            return db.KhoaHocs.ToList();
        }

        public KhoaHoc SearchCourse(string id)
        {
            return db.KhoaHocs.Where(c => c.MaKH == id).FirstOrDefault();
        }

        public List<KhoaHoc> SearchKeywordCourses(string keyword)
        {
            return db.KhoaHocs.Where(c => c.MaKH == keyword || c.MaKH.Contains(keyword)).ToList();
        }

        public bool AddCourse(string id, string name, string educate_id)
        {
            KhoaHoc c = new KhoaHoc();
            c.MaKH = id;
            c.TenKH = name;
            c.MaCTDT = educate_id;

            try
            {
                db.KhoaHocs.InsertOnSubmit(c);
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool EditCourse(string id, string name, string educate_id)
        {
            KhoaHoc c = SearchCourse(id);
            c.TenKH = name;
            c.MaCTDT = educate_id;

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

        public bool DeleteCourse(string id)
        {
            KhoaHoc c = SearchCourse(id);

            try
            {
                db.KhoaHocs.DeleteOnSubmit(c);
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// LOP
        /// </summary>
        public List<Lop> GetClasses()
        {
            return db.Lops.ToList();
        }

        public Lop SearchClass(string id)
        {
            return db.Lops.Where(c => c.MaLop == id).FirstOrDefault();
        }

        public List<Lop> SearchKeywordClasses(string keyword)
        {
            return db.Lops.Where(c => c.MaLop == keyword || c.TenLop.Contains(keyword)).ToList();
        }

        public bool AddClass(string id, string name, string course_id)
        {
            Lop c = new Lop();
            c.MaLop = id;
            c.TenLop = name;
            c.MaKH = course_id;

            try
            {
                db.Lops.InsertOnSubmit(c);
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool EditClass(string id, string name, string course_id)
        {
            Lop c = SearchClass(id);
            c.TenLop = name;
            c.MaKH = course_id;

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

        public bool DeleteClass(string id)
        {
            Lop c = SearchClass(id);
            try
            {
                db.Lops.DeleteOnSubmit(c);
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// MONHOC
        /// </summary>
        public List<MonHoc> GetSubjects()
        {
            return db.MonHocs.ToList();
        }

        public MonHoc SearchSubject(string id)
        {
            return db.MonHocs.Where(s => s.MaMH == id).FirstOrDefault();
        }

        public List<MonHoc> SearchKeywordSubjects(string keyword)
        {
            return db.MonHocs.Where(s => s.MaMH == keyword || s.TenMH.Contains(keyword)).ToList();
        }

        public bool AddSubject(string id, string name)
        {
            MonHoc s = new MonHoc();
            s.MaMH = id;
            s.TenMH = name;

            try
            {
                db.MonHocs.InsertOnSubmit(s);
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool EditSubject(string id, string name)
        {
            MonHoc s = SearchSubject(id);
            s.TenMH = name;

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

        public bool DeleteSubject(string id)
        {
            MonHoc s = SearchSubject(id);

            try
            {
                db.MonHocs.DeleteOnSubmit(s);
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
        public List<SinhVien> GetStudents()
        {
            return db.SinhViens.ToList();
        }

        public SinhVien SearchStudent(string id)
        {
            return db.SinhViens.Where(s => s.MaSV == id).FirstOrDefault();
        }

        public List<SinhVien> SearchKeywordStudents(string keyword)
        {
            return db.SinhViens.Where(s => s.MaSV == keyword || s.HoTen.Contains(keyword)).ToList();
        }

        public bool AddStudent(string id, string name, string gender, DateTime birth, string place, string class_id)
        {
            SinhVien s = new SinhVien();
            s.MaSV = id;
            s.HoTen = name;
            s.GioiTinh = gender;
            s.NgaySinh = birth;
            s.NoiSinh = place;
            s.MaLop = class_id;

            try
            {
                db.SinhViens.InsertOnSubmit(s);
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool EditStudent(string id, string name, string gender, DateTime birth, string place, string class_id)
        {
            SinhVien s = SearchStudent(id);
            s.HoTen = name;
            s.GioiTinh = gender;
            s.NgaySinh = birth;
            s.NoiSinh = place;
            s.MaLop = class_id;

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

        public bool DeleteStudent(string id)
        {
            SinhVien s = SearchStudent(id);

            try
            {
                db.SinhViens.DeleteOnSubmit(s);
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// KETQUATHI
        /// </summary>
        public List<KetQuaThi> GetExamResults()
        {
            return db.KetQuaThis.ToList();
        }

        public KetQuaThi SearchExamResult(string student_id, string subject_id, int times)
        {
            return db.KetQuaThis.Where(e => e.MaSV == student_id && e.MaMH == subject_id && e.LanThi == times).FirstOrDefault();
        }

        public List<KetQuaThi> SearchKeywordExamResults(string keyword)
        {
            return db.KetQuaThis.Where(e => e.MaSV == keyword || e.MaMH == keyword).ToList();
        }

        public bool AddExamResult(string student_id, string subject_id, int times, double point)
        {
            KetQuaThi e = new KetQuaThi();
            e.MaSV = student_id;
            e.MaMH = subject_id;
            e.LanThi = times;
            e.DiemThi = point;

            try
            {
                db.KetQuaThis.InsertOnSubmit(e);
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool EditExamResult(string student_id, string subject_id, int times, double point)
        {
            KetQuaThi e = SearchExamResult(student_id, subject_id, times);
            e.MaMH = subject_id;
            e.LanThi = times;
            e.DiemThi = point;

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

        public bool DeleteExamResult(string student_id, string subject_id, int times)
        {
            KetQuaThi e = SearchExamResult(student_id, subject_id, times);

            try
            {
                db.KetQuaThis.DeleteOnSubmit(e);
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
