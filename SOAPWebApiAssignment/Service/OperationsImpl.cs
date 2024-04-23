using Microsoft.AspNetCore.Http.HttpResults;
using SOAPWebApiAssignment.Model.Request;
using SOAPWebApiAssignment.Model.Response;
using System.ServiceModel;

namespace SOAPWebApiAssignment.Service
{
    public class OperationsImpl : IOperations
    {
        public OutputResponse Add(InputRequest request)
        {
            return new OutputResponse {Output = request.Operand1 + request.Operand2 } ;
        }

        public OutputResponse Divide(InputRequest request)
        {
            return new OutputResponse { Output = request.Operand1 / request.Operand2, IsSuccessful = true };
        }

        public OutputResponse Multiply(InputRequest request)
        {
            return new OutputResponse { Output = request.Operand1 * request.Operand2 };
        }

        public OutputResponse Subtract(InputRequest request)
        {
            return new OutputResponse { Output = request.Operand1 - request.Operand2 };
        }
    }
}
