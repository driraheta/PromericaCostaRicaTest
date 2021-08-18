using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Models
{
    public class APIResult
    {
        public System.Net.HttpStatusCode StatusCode { get; set; }
        public string JSONResponse { get; set; }
    }
}
