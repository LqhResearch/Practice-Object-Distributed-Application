using System.Collections.Generic;
using System.Runtime.Serialization;
using System.ServiceModel;

namespace WcfService
{
    [ServiceContract]
    public interface IService1
    {
        /// <summary>
        /// LOP
        /// </summary>
        [OperationContract]
        List<Lop> HienThiLop();

        [OperationContract]
        Lop TimLop(string maLop);

        [OperationContract]
        bool ThemLop(string maLop, string tenLop);

        [OperationContract]
        bool SuaLop(string maLop, string tenLop);

        [OperationContract]
        bool XoaLop(string maLop);

        [OperationContract]
        List<Lop> TimKiemLop(string keyword);

        /// <summary>
        /// SINHVIEN
        /// </summary>
        [OperationContract]
        List<SinhVien> HienThiSinhVien();

        [OperationContract]
        SinhVien TimSinhVien(string mssv);

        [OperationContract]
        bool ThemSinhVien(string mssv, string hoTen, string queQuan, int namSinh, string gioiTinh, string maLop);

        [OperationContract]
        bool SuaSinhVien(string mssv, string hoTen, string queQuan, int namSinh, string gioiTinh, string maLop);

        [OperationContract]
        bool XoaSinhVien(string mssv);

        [OperationContract]
        List<SinhVien> TimKiemSinhVien(string keyword);
    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
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
