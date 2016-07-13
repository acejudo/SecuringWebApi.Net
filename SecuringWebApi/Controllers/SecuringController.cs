using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Newtonsoft.Json;
using System.Configuration;
using System.Web;
using System.Diagnostics;
using System.Threading.Tasks;
using SecuringWebApi.CustomAttribute;

namespace SecuringWebApi.Controllers
{
    public class SecuringController : ApiController
    {
        // GET: APIKey
        [Route("Api/GetAPIKey")]
        [HttpGet]
        public string Get()
        {
            return "OK Only APIKey";
        }


        // GET: GetAuthorize
        [Authorize]
        [Route("Api/GetAuthorize")]
        [HttpGet]
        public string Auth()
        {
            return "OK APIKey + Authorize";
        }

        [Authorize]
        [RestrictIPsAttribute]
        [Route("Api/GetAuthorizeWithIp")]
        [HttpGet]
        public string AuthWithApi()
        {
            return "OK APIKey + Authorize + IpAuthorize";
        }
      
    }
}