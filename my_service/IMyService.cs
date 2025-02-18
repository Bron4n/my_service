using System.ServiceModel;

namespace WCFMyServiceLibrary
{
    [ServiceContract]
    public interface IMyService
    {
        [OperationContract]
        void WriteToFile(string text);

        [OperationContract]
        string ReadFromFile();
    }
}
