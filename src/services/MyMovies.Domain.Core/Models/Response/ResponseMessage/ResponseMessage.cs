using MyMovies.Domain.Core.Fixed;
using System.Collections.Generic;

namespace MyMovies.Domain.Core.Models.Response.ResponseMessage
{
    public class ResponseMessage
    {
        public bool Success { get; set; }
        public StatusCodeEnum StatusCode { get; set; }
        public object Data { get; set; }
        public string Message { get; set; }
        public IEnumerable<string> Errors { get; set; }

        public static ResponseMessage Ok(object dado) =>
            Criar(true, StatusCodeEnum.Ok, dado, null, null);

        public static ResponseMessage ErrorValidation(object data, string error) =>
            CriarComUnicoErro(false, StatusCodeEnum.Error, data, ResponseMessageError.RequestWithError, error);

        private static ResponseMessage Criar(bool isSuccess, StatusCodeEnum statusCode, object data, string message, IEnumerable<string> errors)
        {
            return new ResponseMessage
            {
                Success = isSuccess,
                StatusCode = statusCode,
                Message = message,
                Data = data,
                Errors = errors
            };
        }

        private static ResponseMessage CriarComUnicoErro(bool isSuccess, StatusCodeEnum statusCode, object data, string message, string error) =>
            Criar(isSuccess, statusCode, data, message, new List<string> { error });
    }
}
