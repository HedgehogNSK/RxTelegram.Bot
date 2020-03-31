using System.Net;
using RxTelegram.Bot.Interface.BaseTypes;

namespace RxTelegram.Bot.Exceptions
{
    public class ApiException : GeneralApiException
    {
        public string Description { get; }

        public ResponseParameters ApiResponseParameters { get; }

        public ErrorCode? ErrorCode { get; }

        public ApiException(HttpStatusCode statusCode, string description, ResponseParameters apiResponseParameters, ErrorCode? errorCode) : base(statusCode)
        {
            Description = description;
            ApiResponseParameters = apiResponseParameters;
            ErrorCode = errorCode;
        }
    }
}
