using Microsoft.Ajax.Utilities;
using Newtonsoft.Json.Linq;
using pre_qualification_web.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Web;
using System.Web.Helpers;
using System.Web.Services.Description;

namespace pre_qualification_web.Services
{
    public class TimeService
    {
        public Time[] GetAllData()
        {
            WebClient client = new WebClient();
            string datajson = client.DownloadString("http://worldclockapi.com/api/json/utc/now");
            var convert = Newtonsoft.Json.JsonConvert.DeserializeObject<Time>(datajson);

            return new Time[]
            {
                new Time
                {
                    CurrentDateTime = convert.CurrentDateTime,
                    TimeZoneName = convert.TimeZoneName
                }
            };
        }

        public JArray PostData()
        {
            JArray array = new JArray();
            DateTime now = DateTime.Now;
            
            array.Add("curentDateTime:"+now);
            var json = array;

            return json;
        }
    }
}
