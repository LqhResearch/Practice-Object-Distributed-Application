using System.Runtime.Serialization;
using System.ServiceModel;

[ServiceContract]
public interface IService
{
	[OperationContract]
	string DecToBin(int n);

	[OperationContract]
	double Sum1ToN(int n);

	[OperationContract]
	int Factorial(int n);

	[OperationContract]
	string PrintPrimeAToB(int a, int b);
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
