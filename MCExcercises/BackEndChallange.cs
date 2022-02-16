using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MCExcercises
{
    public class BackEndChallange
    {
        public void EvaluateObjectAsync()
        {
            var requestUri = "https://coderbyte.com/api/challenges/json/json-cleaning";
            HttpClient httpClient = new HttpClient();

            string responsString;
            string URL = requestUri;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(URL);
            request.ContentType = "application/json; charset=utf-8";
            request.Headers["Authorization"] = "Basic " + Convert.ToBase64String(Encoding.GetEncoding("ISO-8859-1").GetBytes("username:password"));
            request.PreAuthenticate = true;
            HttpWebResponse response = request.GetResponse() as HttpWebResponse;
            using (Stream responseStream = response.GetResponseStream())
            {
                StreamReader reader = new StreamReader(responseStream, Encoding.UTF8);
                responsString = reader.ReadToEnd();
            }
            var json = JToken.Parse(responsString);

            //foreach (var jsonObjet in json)
            //{
                //var x = json.Value ;
             var answer =  RemoveJson(json);
            //}

            Console.WriteLine(responsString);

        }

        static JToken RemoveJson(JToken node)
        {
            bool removed = true;
  
            try
            {
               // var x = node.Children();
                if (node.Children().Any())
                {
                    //RemoveJson(node.SelectToken(node.Children().ToString()));
                    foreach (var item in node)
                    {

                        RemoveJson(item);

                    }

                }
                else
                {
                   var x = ((JProperty)(node.Parent)).Value;

                    var str = Regex.Replace(node.ToString(), @"(?: ?[(\[][^)\]]+.)*$", "");

                    if (str.Contains("N/A") || str.Contains("-") || string.IsNullOrWhiteSpace(str.ToString()))
                    {
                        node.Parent.Remove();

                    }
                }

                
                
            }
            catch (Exception)
            {
                removed = false;
            }

            return node;
           // Console.WriteLine(node);
        }

      
    }
}
