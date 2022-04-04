using System.Runtime.Serialization;
using System.ServiceModel;

[ServiceContract]
public interface IService
{
    /// <summary>
    /// Đề 1
    /// </summary>
    [OperationContract]
    string SingleEquation(int a, int b);

    [OperationContract]
    bool IsPrime(int n);

    /// <summary>
    /// Đề 2
    /// </summary>
    [OperationContract]
    string QuadraticEquation(int a, int b, int c);

    [OperationContract]
    int Factorial(int n);

    [OperationContract]
    string CheckOddEvenNumber(int n);

    /// <summary>
    /// Đề 3
    /// </summary>
    [OperationContract]
    bool IsTriangle(double a, double b, double c);

    [OperationContract]
    string TriangleName(double a, double b, double c);

    [OperationContract]
    double AverageTriangle(double a, double b, double c);
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
