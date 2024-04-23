using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SOAPWebApiAssignment.Model.Request;
using SOAPWebApiAssignment.Model.Response;
using SOAPWebApiAssignment.Service;
using System.ServiceModel;
using System.Net;
using ServiceReference1;

namespace SOAPWebApiAssignment.Controllers
{
    public class OperationsController : Controller
    {
        [HttpGet]
        [Route("addition")]
        public async Task<ServiceReference1.OutputResponse> AddAsync(ServiceReference1.InputRequest request)
        {
            ServiceReference1.IOperations operation = new OperationsClient(OperationsClient.EndpointConfiguration.BasicHttpBinding_IOperations);
            ServiceReference1.OutputResponse response = await operation.AddAsync(request);
            response.IsSuccessful = true;
            return response;
        }

        [HttpGet]
        [Route("subtraction")]
        public async Task<ServiceReference1.OutputResponse> SubtractAsync(ServiceReference1.InputRequest request)
        {
            ServiceReference1.IOperations operation = new OperationsClient(OperationsClient.EndpointConfiguration.BasicHttpBinding_IOperations);
            ServiceReference1.OutputResponse response = await operation.SubtractAsync(request);
            response.IsSuccessful = true;
            return response;
        }

        [HttpGet]
        [Route("multiplication")]
        public async Task<ServiceReference1.OutputResponse> MultiplyAsync(ServiceReference1.InputRequest request)
        {
            ServiceReference1.IOperations operation = new OperationsClient(OperationsClient.EndpointConfiguration.BasicHttpBinding_IOperations);
            ServiceReference1.OutputResponse response = await operation.MultiplyAsync(request);
            response.IsSuccessful = true;
            return response;
        }

        [HttpGet]
        [Route("division")]
        public async Task<ServiceReference1.OutputResponse> DivideAsync(ServiceReference1.InputRequest request)
        {
            try
            {
                ServiceReference1.IOperations operation = new OperationsClient(OperationsClient.EndpointConfiguration.BasicHttpBinding_IOperations);

                if(request.Operand2 == 0)
                {
                    throw new DivideByZeroException("DivideByZero");
                }
                
                return await operation.DivideAsync(request);
            }
            catch (DivideByZeroException ex)
            {
                return new ServiceReference1.OutputResponse
                {
                    IsSuccessful = false,
                    ErrorMessage = ex.Message,
                    Output = double.MinValue
                };


            }
        }

    }
}
