using System.Runtime.Serialization;
using System.ServiceModel;

[ServiceContract]
public interface IService
{
    /// <summary>
    /// Đề số 1
    /// </summary>
    [OperationContract]
    string Count_Div2_NotDiv4(int[] arr);
    [OperationContract]
    int[] SortOddNumberDescending(int[] arr);
    [OperationContract]
    int SumOddNumber(int[] arr);
    [OperationContract]
    string PrintArray(int[] arr);

    /// <summary>
    /// Đề số 2
    /// </summary>
    [OperationContract]
    string Count_Div4_Div5(int[] arr);
    [OperationContract]
    int[] SortEvenNumberAscending(int[] arr);
    [OperationContract]
    double Average(int[] arr);

    /// <summary>
    /// Đề số 3
    /// </summary>
    [OperationContract]
    string Count_PrintOddNumber(int[] arr);
    [OperationContract]
    string Count_PrintEvenNumber(int[] arr);
    [OperationContract]
    int[] Sort_OddNumberDescending_EvenNumberAscending(int[] arr);
    [OperationContract]
    int SumArray(int[] arr);

    /// <summary>
    /// Đề số 4
    /// </summary>
    [OperationContract]
    bool IsPrime(int n);
    [OperationContract]
    string Count_Sum_Prime(int[] arr);
    [OperationContract]
    int[] Sort_EvenNumberAscending_OddNumberDescending(int[] arr);
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
