using CustomersApp.Domain.Errors;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Net;

namespace CustomersApp.Application.ErrorHandling
{
    public class ErrorResponse
    {
        public int StatusCode { get; set; }
        public string Message { get; set; }

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this, new JsonSerializerSettings
            {
                ContractResolver = new CamelCasePropertyNamesContractResolver()
            });
        }

        public ErrorResponse(int statusCode, string message)
        {
            StatusCode = statusCode;
            Message = message ?? GetDefaultMessageForStatusCode(statusCode);
        }

        private string GetDefaultMessageForStatusCode(int statusCode)
        {
            return statusCode switch
            {
                (int)HttpStatusCode.BadRequest => ErrorMessages.BadRequest,
                (int)HttpStatusCode.NotFound => ErrorMessages.NotFound,
                (int)HttpStatusCode.InternalServerError => ErrorMessages.InternalServerError,
            };
        }
    }
}
