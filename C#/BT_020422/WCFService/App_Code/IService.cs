using System.Runtime.Serialization;
using System.ServiceModel;

[ServiceContract]
public interface IService
{
    [OperationContract]
    double Calculate(int n1, char op, int n2);
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
