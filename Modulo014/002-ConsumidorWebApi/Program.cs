using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Net.Http;
using System.Net.Http.Headers;


namespace _002_ConsumidorWebApi
{
    class Program
    {
        static void Main(string[] args)
        {
            RunAsync().Wait();

            Console.ReadKey();
        }

        private async static Task RunAsync()
        {
            using (var c = new HttpClient())
            {
                c.BaseAddress = new Uri("http://localhost:62871/");
                c.DefaultRequestHeaders.Accept.Clear();
                c.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage response = await c.GetAsync("api/Login");

                if (response.IsSuccessStatusCode)
                {
                    var logins = await response.Content.ReadAsAsync<IEnumerable<Login>>();

                    foreach (var item in logins.ToList())
                    {
                        Console.WriteLine("{0} - {1} - {2}", item.LoginId, item.LoginNome, item.LoginSenha);
                    }
                }
            }
        }
    }
}

//Install-Package Microsoft.AspNet.WebApi.Client