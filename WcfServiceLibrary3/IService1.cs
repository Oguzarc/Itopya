using System;
using System.ServiceModel;

namespace GettingStartedLib
{
    [ServiceContract(Namespace = "http://Microsoft.ServiceModel.Samples")]
    public interface ICalculator
    {
        
        [OperationContract]
        bool Kontrol(string name);
        [OperationContract]
        bool Kontrolcvv(string name);
        [OperationContract]
        bool Kontroldate(string name);
        [OperationContract]
        bool Kontrolay(string name);
    }
}