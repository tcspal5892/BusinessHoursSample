using Newtonsoft.Json;

namespace CalendarApp.Entities
{
    public class DailyHours
    {
        [JsonProperty("business_name")]
        public string BusinessName { get; set; }

        [JsonProperty("operating_hours")]
        public Dictionary<string, Hours> OperatingHoursPerDay { get; set; }
    }
}
