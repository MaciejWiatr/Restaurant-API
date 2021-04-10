using System;
using Newtonsoft.Json;

namespace RestaurantAPI.Models
{
    public class ResponseErrorDto
    {
        [JsonProperty("error")]
        public string Error { get; set; }

        public ResponseErrorDto(Exception e)
        {
            Error = e.Message;
        }

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}
