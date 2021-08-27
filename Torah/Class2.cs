using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Torahapi
{
    public class HttpClientHelper

    {

        /// <summary>

        /// HttpClient Get

        /// </summary>

        ///<param name="url"> </param>

        /// <returns></returns>

        public static string Get(string url)

        {

            var http = HttpClientFactory.GetHttpClient();

            var response1 = http.GetAsync(url).Result;

            return response1.Content.ReadAsStringAsync().Result;

        }

        /// <summary>

        /// HttpClient  post

        /// [application/x-www-form-urlencoded]

        /// </summary>

        /// <param name="url"</param>

        /// <param name="data">:"userName=admin&pwd=123456"</param>

        /// <returns></returns>

        public static string PostForm(string url, string data)

        {

            var http = HttpClientFactory.GetHttpClient();

            var content = new StringContent(data, Encoding.UTF8, "application/x-www-form-urlencoded");

            var response = http.PostAsync(url, content).Result;

            return response.Content.ReadAsStringAsync().Result;

        }





        /// <summary>

        /// post
        /// Json [application/json]

        /// </summary>

        /// <param name="url"></param>

        /// <param name="data"> </param>

        /// <returns></returns>

        public static string PostJSON(string url, object data)

        {
            //
            //var body = new
            //{
            //    userNameOrEmailAddress = "admin",
            //    password = "123qwe"
            //};
            //string token = HttpClientHelper.PostJSON("https://localhost:44302/api/TokenAuth/Authenticate", body);

            var http = HttpClientFactory.GetHttpClient();

            var content = new StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(data), Encoding.UTF8, "application/json");

            var response = http.PostAsync(url, content).Result;

            return response.Content.ReadAsStringAsync().Result;

        }



    }
    public class HttpClientFactory

    {

        private static HttpClient _httpClient = null;



        /// <summary>

        /// </summary>

        static HttpClientFactory()

        {

            _httpClient = new System.Net.Http.HttpClient(new HttpClientHandler());

            _httpClient.Timeout = new TimeSpan(0, 0, 10);

            _httpClient.DefaultRequestHeaders.Connection.Add("keep-alive");

        }



        /// <summary>

        /// 

        /// </summary>

        /// <returns></returns>

        public static HttpClient GetHttpClient()

        {

            return _httpClient;

        }

    }
}
