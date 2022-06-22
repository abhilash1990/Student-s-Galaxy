using System.Net;

namespace Students_Galaxy_Common.ServiceResponse
{
    public static class ResponseType
    {
        public static readonly string MsgSuccess = "Success";
        public static ServiceResponse Success(object responseData)
        {
            return new ServiceResponse
            {
                ReasonPhrase = MsgSuccess,
                HttpStatus = HttpStatusCode.OK,
                StatusCode = (int)HttpStatusCode.OK,
                StatusMessage = MsgSuccess,
                ResponseData = responseData
            };
        }
    }
}
