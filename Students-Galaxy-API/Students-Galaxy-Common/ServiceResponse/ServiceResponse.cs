using System.Net;
using System.Runtime.Serialization;

namespace Students_Galaxy_Common.ServiceResponse
{
    [Serializable]
    [DataContract]
    public class ServiceResponse
    {
        [DataMember]
        public int StatusCode { get; set; }

        [DataMember]
        public string StatusMessage { get; set; }

        [DataMember]
        public HttpStatusCode HttpStatus { get; set; }

        [DataMember]
        public string ReasonPhrase { get; set; }

        [DataMember]
        public object ResponseData { get; set; }
    }
}
