using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http;
using System.Threading.Tasks;
using WebApp.Models;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;

namespace WebApp.Controllers
{
    public class DetailController : Controller
    {
        private readonly ILogger<DetailController> _logger;
        public IConfiguration Configuration { get; }

        public DetailController(ILogger<DetailController> logger, IConfiguration configuration)
        {
            _logger = logger;
            Configuration = configuration;
        }

        public async Task<IActionResult> Index(int id)
        {
            string endpoint = "Patterns/" + id.ToString();
            List<Pattern> patterns = new List<Pattern>();

            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync(Configuration.GetValue<string>("api") + endpoint))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    patterns = JsonConvert.DeserializeObject<List<Pattern>>(apiResponse);
                }
            }

            return View(patterns);
        }






    }
}
