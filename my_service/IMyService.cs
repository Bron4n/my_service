using System.ServiceModel;

namespace WCFMyServiceLibrary
{
    [ServiceContract]
    public interface IMyService
    {
        [OperationContract]
        void WriteToFile(string text, string fileName = "text.txt");

        [OperationContract]
        string ReadFromFile(string fileName = "text.txt");
    }
}
