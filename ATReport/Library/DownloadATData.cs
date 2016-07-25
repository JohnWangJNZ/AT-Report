using System;
using System.Data;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web;
using System.Net.Http;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using ATReport.DAL;
using ATReport.Models;

namespace ATReport.Library
{
    public class DownloadATData
    {
        private const string SubscriptionKey = "90e9aa8d90194b65a8b49315837f8fbd";
        private ATDataContext context = new ATDataContext();

        public async Task<int> DownloadAgencyData()
        {
            var client = new HttpClient();
            var queryString = HttpUtility.ParseQueryString(string.Empty);

            // Request headers
            client.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", SubscriptionKey);
            
            // Request parameters
            queryString["callback"] = "";
            string uri = "https://api.at.govt.nz/v2/gtfs/agency?" + queryString;

            var response = await client.GetAsync(uri);
            string json = response.Content.ReadAsStringAsync().Result;

            // deserialize json string to datatable, default format is class object
            JObject jsonobject = (JObject)JsonConvert.DeserializeObject(json, typeof(JObject));
            DataTable dt = (DataTable)JsonConvert.DeserializeObject(Convert.ToString(jsonobject["response"]), typeof(DataTable));
            
            List<Agency> list = new List<Agency>();

            foreach(DataRow dr in dt.Rows)
            {
                // check if agency is already existed
                if (context.Agencies.Find(Convert.ToString(dr[0])) == null)
                {
                    list.Add(new Agency()
                    {
                        ID = Convert.ToString(dr[0]),
                        Name = Convert.ToString(dr[1]),
                        Url = Convert.ToString(dr[2]),
                        TimeZone = Convert.ToString(dr[3]),
                        Language = Convert.ToString(dr[4]),
                        Phone = Convert.ToString(dr[5]),
                        FareUrl = Convert.ToString(dr[6])
                    });
                }
            }

            if (list.Count > 0)
            {
                // add new records to database if list has records
                context.Agencies.AddRange(list);
                context.SaveChanges();
            }

            return list.Count;
        }
    }
}