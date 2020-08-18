using Newtonsoft.Json.Linq;
using pre_qualification_web.Models;
using pre_qualification_web.Services;

using System.Web.Http;

namespace pre_qualification_web.Controllers
{
    public class TimeController : ApiController
    {
        public TimeService timeService;
        public TimeController()
        {
            this.timeService = new TimeService();
        }

        public Time[] Get()
        {
            return this.timeService.GetAllData();
        }

        public JArray Post()
        { 
            return this.timeService.PostData();
        }
    }
}
