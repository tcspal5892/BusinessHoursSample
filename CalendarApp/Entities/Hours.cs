using Newtonsoft.Json;

namespace CalendarApp.Entities
{
    public class Hours
    {
        [JsonProperty("open")]
        public string Open { get; set; }

        [JsonProperty("close")]
        public string Close { get; set; }
    }
}