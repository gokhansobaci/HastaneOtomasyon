using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace HastaneOtomasyon.Hasta.Models
{
    public class Cities
    {
        //Dictionary<K,V>: Anahtar değer ikilisi olarak tutar, adresleme yapmaz, anhtarla çığırılır.
        public Dictionary<string, string[]> AllCities = new Dictionary<string, string[]>();

        public Cities()
        {
            JObject obj = JObject.Parse(File.ReadAllText("cities_districts.json"));
            foreach (var city in obj)
            {
                List<string> districts = new List<string>();
                foreach (var district in (JArray)city.Value)
                {
                    districts.Add(district.ToString());
                }

                AllCities.Add(city.Key, districts.ToArray());
            }
        }
    }
}
