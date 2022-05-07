﻿using System.Collections.Generic;
using System.Runtime.Serialization;
using System.ServiceModel;

namespace WcfService
{
    [ServiceContract]
    public interface IService1
    {
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