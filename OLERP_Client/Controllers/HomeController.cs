using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using OLERP_Client.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace OLERP_Client.Controllers
{
    public class HomeController : Controller
    {
      //  HttpClientHandler _httpClientHandler = new HttpClientHandler();
        private readonly ILogger<HomeController> _logger;
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
           // _httpClientHandler.ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) => { return true; };
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> procLogins(UserLogin _UserLogin)
        {
            //DashboardController dashboard = new DashboardController();
            using (var httpClient = new HttpClient())
            {
                StringContent content = new StringContent(JsonConvert.SerializeObject(_UserLogin), Encoding.UTF8, "application/json");
             using (var response = await httpClient.PostAsync("https://localhost:44358/api/Login/procLogins",content))
                {
                    string token = await response.Content.ReadAsStringAsync();

                    // HttpContext.Session.SetString("JWToken", token); 

                    httpClient.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);
                    //List<UserModel> register = new List<UserModel>();
                    using (var response1 = await httpClient.GetAsync("https://localhost:44358/api/User/Public"))
                    {
                        string apiResponse = await response1.Content.ReadAsStringAsync();
                        // string register = JsonConvert.DeserializeObject<UserModel>(apiResponse).ToString();

                        //return RedirectToAction("Privacy", "Home");
                        TempData["login"] = apiResponse;
                        return Redirect("~/Dashboard/Index");
                    }
                }
                return Redirect("~/Dashboard/Index");

            }
               
        }
        /*
        public async Task<IActionResult> GetAllPlayers()
        {
            string token = null;
            var strToken = HttpContext.Session.GetString("JwToken");
            if (string.IsNullOrWhiteSpace(strToken))
            {
                token = await CreateToken();
            }
            else
            {
                token = strToken;
            }
            List<UserModel> players = new List<UserModel>();
            var request = new HttpRequestMessage(HttpMethod.Get, "https://localhost:44358/api/User/Sellers");
            var client = _clientFactory.CreateClient();
            request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", token);
            HttpResponseMessage response = await client.SendAsync(request, HttpCompletionOption.ResponseHeadersRead);
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                var apiString = await response.Content.ReadAsStringAsync();
                players = JsonConvert.DeserializeObject<List<UserModel>>(apiString);

            }
            return View(players);
        }
        */
        //[HttpPost]
        //public async Task<UserLogin> AddUpdateRegister(UserLogin _UserLogin)
        //{

        //    using (var httpClient = new HttpClient(_httpClientHandler))
        //    {
        //        StringContent content = new StringContent(JsonConvert.SerializeObject(_UserLogin), Encoding.UTF8, "application/json");
        //        if (_register.Id > 0)
        //        {
        //            using (var response = await httpClient.PutAsync("https://localhost:44396/api/Registers/" + _register.Id, content))
        //            {
        //                string apiResponse = await response.Content.ReadAsStringAsync();
        //                register = JsonConvert.DeserializeObject<Register>(apiResponse);
        //            }
        //        }
        //        else
        //        {
        //            using (var response = await httpClient.PostAsync("https://localhost:44396/api/Registers/", content))
        //            {
        //                string apiResponse = await response.Content.ReadAsStringAsync();
        //                register = JsonConvert.DeserializeObject<Register>(apiResponse);
        //            }
        //        }

        //    }

        //    return register;

        //}


        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
