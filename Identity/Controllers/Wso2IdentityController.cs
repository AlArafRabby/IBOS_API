using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Identity.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Wso2IdentityController : ControllerBase
    {
        [HttpPost]
        [Route("GetToken")]
        public async Task<IActionResult> GetToken([FromQuery] string username,string password,string securitykey)
        {
            var handler = new HttpClientHandler();
            handler.ServerCertificateCustomValidationCallback = (requestMessage, certificate, chain, policyErrors) => true;

            using (var httpClient = new HttpClient(handler))
            {
                using (var request = new HttpRequestMessage(new HttpMethod("POST"), "https://172.17.17.119:8243/token"))
                {
                    request.Headers.TryAddWithoutValidation("Authorization", "Basic "+ securitykey);

                    request.Content = new StringContent("grant_type=password&username="+ username + "&password="+ password);
                    request.Content.Headers.ContentType = new MediaTypeHeaderValue("application/x-www-form-urlencoded");

                    var response = await httpClient.SendAsync(request);

                    string result = response.Content.ReadAsStringAsync().Result;
                    return Ok(result);
                }
            }
            
        }


        }
}