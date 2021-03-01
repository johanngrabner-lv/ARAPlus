using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;

namespace ARAPlus.ApiConsumerConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ReadLine();
            Console.WriteLine("Hello World!");
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:44327/api/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));

            List<Stichprobe> stichprobe = null;
            string path = "Stichprobe";
            HttpResponseMessage response = client.GetAsync(path).Result;
            if (response.IsSuccessStatusCode)
            {
                stichprobe = response.Content.ReadAsAsync<List<Stichprobe>>().Result;
            }



            stichprobe[0].Name = "Geändert über Console";

            HttpResponseMessage responsePut =  client.PutAsJsonAsync
                ($"Stichprobe/{stichprobe[0].StichprobeId}", stichprobe[0]).Result;
            response.EnsureSuccessStatusCode();

            // Deserialize the updated product from the response body.
            var s = responsePut.Content.ReadAsAsync<Stichprobe>().Result;
            Console.WriteLine(s.Name);



        }
    }
}
