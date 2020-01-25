using Newtonsoft.Json;
using System;
using System.IO;
using System.Net;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace uuscountries

{
    class Program
    {
        static void Main(string[] args)
        {
            string url = "https://restcountries.eu/rest/v2/name/eesti";

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";

            var webResponse = request.GetResponse();
            var webStream = webResponse.GetResponseStream();

            using (var responseReader = new StreamReader(webStream))
            {
                var response = responseReader.ReadToEnd();
                //kontroliks:
                //Console.WriteLine(response);
                var countries = JsonConvert.DeserializeObject<List<CountryDetails.Country>>(response);
                foreach (var maa in countries)
                {
                    Console.WriteLine($"nimi: {maa.Name}");
                    Console.WriteLine($"pealinn: {maa.Capital}");
                    Console.WriteLine($"cioc: {maa.Cioc}");
                    Console.WriteLine($"regioon: {maa.Region}");                    
                    Console.WriteLine($"elanikkond: {maa.Population}");
                    
                    foreach (var keel in maa.Languages)
                    {
                        Console.WriteLine($"keel:{keel.Name}");
                    }
                    foreach (var domeen in maa.TopLevelDomain)
                    {
                        Console.WriteLine($"domeen:{maa.TopLevelDomain[0]}");
                    }
                }            



            }
        }
    }
}