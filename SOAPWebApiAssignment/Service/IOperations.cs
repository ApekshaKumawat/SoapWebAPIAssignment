using SOAPWebApiAssignment.Model.Request;
using SOAPWebApiAssignment.Model.Response;
using System.ServiceModel;

namespace SOAPWebApiAssignment.Service
{
    [ServiceContract]
    public interface IOperations
    {
        [OperationContract]
        OutputResponse Add(InputRequest request);
        [OperationContract]
        OutputResponse Subtract(InputRequest request);
        [OperationContract]
        OutputResponse Multiply(InputRequest request);
        [OperationContract]
        OutputResponse Divide(InputRequest request);
    }
}
