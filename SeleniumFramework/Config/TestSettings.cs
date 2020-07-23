using Newtonsoft.Json;
using SeleniumFramework.Base;

namespace SeleniumFramework.Config
{
    [JsonObject("testSettings")]
    public class TestSettings
    {
        [JsonProperty("name")]
        public string name { get; set; }

        [JsonProperty("sut")]
        public string sut { get; set; }

        [JsonProperty("browser")]
        public BrowserType browser { get; set; }
    }

    [JsonObject("testData")]
    public class TestData
    {
        [JsonProperty("username")]
        public string username { get; set; }

        [JsonProperty("checkboxtitle")]
        public string checkboxtitle { get; set; }

        [JsonProperty("radiobuttontitle")]
        public string radiobuttontitle { get; set; }

        [JsonProperty("simpleformtitle")]
        public string simpleformtitle { get; set; }
    }
}
