using Newtonsoft.Json;
using System;

namespace OBilet.API.Model.Response
{
    class APIResponse<T> where T : class
    {
        public string Status { get; set; }
        public T Data { get; set; }
        public string Message { get; set; }

        [JsonProperty("user-message")]
        public string UserMessage { get; set; }

        [JsonProperty("api-request-id")]
        public Guid? ApiRequestId { get; set; }
        public string Controller { get; set; }

        [JsonProperty("client-request-id")]
        public Guid? ClientRequestId { get; set; }

        [JsonProperty("web-correlation-id")]
        public Guid? WebCorrelationId { get; set; }

        [JsonProperty("correlation-id")]
        public Guid CorrelationId { get; set; }
    }
}