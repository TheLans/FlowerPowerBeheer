using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using Newtonsoft.Json;
using System.Collections.Specialized;
namespace FlowerPower1
{
    /*
    * API C# module.
    * This module communicates with your API.
    * The API class contains all the basic functions to communicate with the API.
    * Made by: Berend Hulshof.
    * API GIT: https://github.com/Hofkey/FlowerPowerAPI.git
    */
    public class api
    {
        protected static readonly string apiurl = "http://flowerpowerapi.azurewebsites.net/api/";
        // function to retrieve data from the api.
        // url: http://flowerpowerapi.azurewebsites.net/api/{$model}
        // url optional: http://flowerpowerapi.azurewebsites.net/api/{model}/{id|extrafilter}?{param1=value}&{param2=value}
        public static List<T> getData<T>(string model, int? id = null, string extraFilter = null, string[] extraFilterParams = null)
        {
            // create the communication to the model from the API.
            string apigeturl = apiurl;
            apigeturl += model;
            if (id != null)
                apigeturl += ("/" + id.ToString());
            if (extraFilter != null)
            {
                apigeturl += ("/" + extraFilter);
                if (extraFilterParams != null)
                {
                    apigeturl += ("?" + extraFilterParams[0] + "=" + extraFilterParams[1]);
                }
            }
            HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(apigeturl);
            request.Method = "GET";
            string resp;
            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            {
                Stream dataStream = response.GetResponseStream();
                StreamReader reader = new StreamReader(dataStream);
                resp = reader.ReadToEnd();
                reader.Close();
                dataStream.Close();
            }
            List<T> respData = null;
            respData = JsonConvert.DeserializeObject(resp) as List<T>;
            return respData;
        }
        // function to add data in the database through api.
        // url: http://flowerpowerapi.azurewebsites.net/api/{$model}
        // $obj: this will be filled with a JSON object which represents the model.
        public static List<T> postData<T>(string model, NameValueCollection obj, string optionalRoute = null)
        {
            // create the communication to the model from the API.
            string apiposturl = apiurl;
            apiposturl += model;
            if (optionalRoute != null)
                apiposturl += ("/" + optionalRoute);
            // prepare and execute the PUT function using the WebClient class.
            using (WebClient client = new WebClient())
            {
                client.Headers.Add(HttpRequestHeader.ContentType, "application/x-www-form-urlencoded");
                byte[] response = client.UploadValues(apiposturl, "POST", obj);
                var str = System.Text.Encoding.Default.GetString(response);
                return JsonConvert.DeserializeObject(str) as List<T>;
            }
        }
        // function to edit data in the database through api.
        // url: http://flowerpowerapi.azurewebsites.net/api/{$model}
        // $obj: this will be filled with a JSON object which represents the model.
        public static void putData(string model, NameValueCollection obj)
        {
            // create the communication to the model from the API.
            string apiposturl = apiurl;
            apiposturl += model;
            // prepare and execute the PUT function using the WebClient class.
            using (WebClient client = new WebClient())
            {
                client.Headers.Add(HttpRequestHeader.ContentType, "application/x-www-form-urlencoded");
                byte[] response = client.UploadValues(apiposturl, "PUT", obj);
            }
        }
        // function to delete data in the database through api.
        // url: http://flowerpowerapi.azurewebsites.net/api/{$model}
        // $obj: this will be filled with a JSON object which represents the model.
        public static void deleteData(string model, NameValueCollection obj)
        {
            // create the communication to the model from the API.
            string apiposturl = apiurl;
            apiposturl += model;
            // prepare and execute the PUT function using the WebClient class.
            using (WebClient client = new WebClient())
            {
                client.Headers.Add(HttpRequestHeader.ContentType, "application/x-www-form-urlencoded");
                byte[] response = client.UploadValues(apiposturl, "DELETE", obj);
            }
        }
    }
}