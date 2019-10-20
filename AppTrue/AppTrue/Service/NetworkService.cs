using AppTrue.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace AppTrue.Service
{
    public class NetworkService
    {
        public static async Task<List<Transection>> GetTransection(string startDate, string endDate, string userId)
        {
            using (var client = new HttpClient())
            {
                try
                {
                    const string baseUrl = "http://ccp-info.com";
                    string function = "/QCAPI/api/GetData/getViewTransectionpara1" +
                        $"?Datest={startDate}&Dateen={endDate}&ID={userId}";
                    //   $"?Datest={"2019-09-01"}&Dateen={"2019-09-25"}&ID={"C000011"}";

                    client.BaseAddress = new Uri(baseUrl);
                    var response = await client.GetAsync(function);  // Get http method
                    response.EnsureSuccessStatusCode();

                    var stringResponse = await response.Content.ReadAsStringAsync();
                    List<Transection> result = JsonConvert.DeserializeObject<List<Transection>>(stringResponse);

                    return result;
                }
                catch (HttpRequestException e)
                {
                    Console.WriteLine($"Request exception: {e.Message}");
                }
            }
            return null;
        }


        public static async Task<List<category>> GetCategory()
        {
            using (var client = new HttpClient())
            {
                try
                {
                    const string baseUrl = "http://18.136.194.32";
                    string function = "/api/category";
                    //   $"?Datest={"2019-09-01"}&Dateen={"2019-09-25"}&ID={"C000011"}";

                    client.BaseAddress = new Uri(baseUrl);
                    var response = await client.GetAsync(function);  // Get http method
                    response.EnsureSuccessStatusCode();

                    var stringResponse = await response.Content.ReadAsStringAsync();
                    List<category> result = JsonConvert.DeserializeObject<List<category>>(stringResponse);

                    return result;
                }
                catch (HttpRequestException e)
                {
                    Console.WriteLine($"Request exception: {e.Message}");
                }
            }
            return null;
        }

        public static async Task<List<pronet>> GetPronet(string id)
        {
            using (var client = new HttpClient())
            {
                try
                {
                    const string baseUrl = "http://18.136.194.32";
                    string function = "/api/pronet/category/" + id+"";
                    //   $"?Datest={"2019-09-01"}&Dateen={"2019-09-25"}&ID={"C000011"}";

                    client.BaseAddress = new Uri(baseUrl);
                    var response = await client.GetAsync(function);  // Get http method
                    response.EnsureSuccessStatusCode();

                    var stringResponse = await response.Content.ReadAsStringAsync();
                    List<pronet> result = JsonConvert.DeserializeObject<List<pronet>>(stringResponse);

                    return result;
                }
                catch (HttpRequestException e)
                {
                    Console.WriteLine($"Request exception: {e.Message}");
                }
            }
            return null;
        }

        public static async Task<pronetDetail> GetPronetDetail(string id)
        {
            using (var client = new HttpClient())
            {
                try
                {
                    const string baseUrl = "http://18.136.194.32";
                    string function = "/api/pronet/" + id + "";
                    //   $"?Datest={"2019-09-01"}&Dateen={"2019-09-25"}&ID={"C000011"}";

                    client.BaseAddress = new Uri(baseUrl);
                    var response = await client.GetAsync(function);  // Get http method
                    response.EnsureSuccessStatusCode();

                    var stringResponse = await response.Content.ReadAsStringAsync();
                    pronetDetail result = JsonConvert.DeserializeObject<pronetDetail>(stringResponse);

                    return result;
                }
                catch (HttpRequestException e)
                {
                    Console.WriteLine($"Request exception: {e.Message}");
                }
            }
            return null;
        }
    }
}
