using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace pre_qualification_web.Models
{
    public class Time
    {
        [Newtonsoft.Json.JsonProperty("currentDateTime")]
        public string CurrentDateTime { get; set; }

        [Newtonsoft.Json.JsonProperty("timeZoneName")]
        public string TimeZoneName { get; set; }

    }
}