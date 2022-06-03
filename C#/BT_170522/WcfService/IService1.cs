using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.ServiceModel;

namespace WcfService
{
    [ServiceContract]
    public interface IService1
    {
        /// <summary>
        /// CT_DaoTao
        /// </summary>
        [OperationContract]
        List<CT_DaoTao> GetEducates();
        [OperationContract]
        CT_DaoTao SearchEducate(string id);
        [OperationContract]
        List<CT_DaoTao> SearchKeywordEducates(string keyword);
        [OperationContract]
        bool AddEducate(string id, string name);
        [OperationContract]
        bool EditEducate(string id, string name);
        [OperationContract]
        bool DeleteEducate(string id);

        /// <summary>
        /// KHOAHOC
        /// </summary>
        [OperationContract]
        List<KhoaHoc> GetCourses();
        [OperationContract]
        KhoaHoc SearchCourse(string id);
        [OperationContract]
        List<KhoaHoc> SearchKeywordCourses(string keyword);
        [OperationContract]
        bool AddCourse(string id, string name, string educate_id);
        [OperationContract]
        bool EditCourse(string id, string name, string educate_id);
        [OperationContract]
        bool DeleteCourse(string id);

        /// <summary>
        /// LOP
        /// </summary>
        [OperationContract]
        List<Lop> GetClasses();
        [OperationContract]
        Lop SearchClass(string id);
        [OperationContract]
        List<Lop> SearchKeywordClasses(string keyword);
        [OperationContract]
        bool AddClass(string id, string name, string course_id);
        [OperationContract]
        bool EditClass(string id, string name, string course_id);
        [OperationContract]
        bool DeleteClass(string id);

        /// <summary>
        /// MONHOC
        /// </summary>
        [OperationContract]
        List<MonHoc> GetSubjects();
        [OperationContract]
        MonHoc SearchSubject(string id);
        [OperationContract]
        List<MonHoc> SearchKeywordSubjects(string keyword);
        [OperationContract]
        bool AddSubject(string id, string name);
        [OperationContract]
        bool EditSubject(string id, string name);
        [OperationContract]
        bool DeleteSubject(string id);

        /// <summary>
        /// SINHVIEN
        /// </summary>
        [OperationContract]
        List<SinhVien> GetStudents();
        [OperationContract]
        SinhVien SearchStudent(string id);
        [OperationContract]
        List<SinhVien> SearchKeywordStudents(string keyword);
        [OperationContract]
        bool AddStudent(string id, string name, string gender, DateTime birth, string place, string class_id);
        [OperationContract]
        bool EditStudent(string id, string name, string gender, DateTime birth, string place, string class_id);
        [OperationContract]
        bool DeleteStudent(string id);

        /// <summary>
        /// KETQUATHI
        /// </summary>
        [OperationContract]
        List<KetQuaThi> GetExamResults();
        [OperationContract]
        KetQuaThi SearchExamResult(string student_id, string subject_id, int times);
        [OperationContract]
        List<KetQuaThi> SearchKeywordExamResults(string keyword);
        [OperationContract]
        bool AddExamResult(string student_id, string subject_id, int times, double point);
        [OperationContract]
        bool EditExamResult(string student_id, string subject_id, int times, double point);
        [OperationContract]
        bool DeleteExamResult(string student_id, string subject_id, int times);
    }

    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }
}
