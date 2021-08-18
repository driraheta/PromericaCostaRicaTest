using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using WebApp.Models;
using Newtonsoft;
using System.Text;

namespace WebApp.Controllers
{
    public class UpdateController : Controller
    {
        private readonly ILogger<UpdateController> _logger;
        public IConfiguration Configuration { get; }

        public UpdateController(ILogger<UpdateController> logger, IConfiguration configuration)
        {
            _logger = logger;
            Configuration = configuration;
        }

        public async Task<IActionResult> Index(int id)
        {
            string endpoint = "Makes/" + id.ToString();
            Make make = new Make();

            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync(Configuration.GetValue<string>("api") + endpoint))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    make = JsonConvert.DeserializeObject<Make>(apiResponse);
                }
            }            
            return View(make);
        }

        [HttpPost]
        public async void Update([FromBody] Make make)
        {
            APIResult result = new APIResult();
            string endpoint = "Makes";
            var contenido = JsonConvert.SerializeObject(make);
            var requestContent = new StringContent(contenido, Encoding.UTF8, "application/json");

            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.PutAsync(Configuration.GetValue<string>("api") + endpoint, requestContent))
                {
                    var responseContent = await response.Content.ReadAsStringAsync();
                    result.StatusCode = response.StatusCode;
                    result.JSONResponse = responseContent;
                }
            }
        }



    }
}
