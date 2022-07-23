using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.ServiceModel;

namespace WcfService
{
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        string EvenNumber(int[] arr);

        [OperationContract]
        List<NHANVIEN> GetEmployee();

        [OperationContract]
        NHANVIEN SearchEmployee(string maNV);

        [OperationContract]
        bool AddEmployee(string maNV, string hoNV, string tenLopNV, string tenNV, DateTime ngaySinh, string phai, string diaChi, decimal hsLuong, string maNQL, int maPhong);

        [OperationContract]
        bool UpdateEmployee(string maNV, string hoNV, string tenLopNV, string tenNV, DateTime ngaySinh, string phai, string diaChi, decimal hsLuong, string maNQL, int maPhong);

        [OperationContract]
        bool DeleteEmployee(string maNV);

        [OperationContract]
        List<PHONGBAN> GetRoom();
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
