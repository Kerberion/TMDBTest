using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using TMBDTest.Models;

namespace TMBDTest.Services
{
    public class ServiceClient : IServices
    {        

        private  IConfiguration _Configuration { get; set; }
        private string _urlAPI { get; set; }
        private string _apiKey { get; set; }
        public ServiceClient()
        {
            _urlAPI = Global.Settings.UrlAPI;
            _apiKey = Global.Settings.ApiKey;
        }
        //public async Task<TResponse> Get<TResponse>(string url)
        //{
        //    try
        //    {
        //        TResponse deserializer = default(TResponse);

        //        using (HttpClient client = new HttpClient())
        //        {
        //            client.BaseAddress = new Uri(_urlAPI + url);
        //            var response = await client.GetAsync(client.BaseAddress);
        //            response.EnsureSuccessStatusCode();

        //            if (response.StatusCode == HttpStatusCode.OK)
        //            {
        //                var responseString = await response.Content.ReadAsStringAsync();
        //                deserializer = JsonConvert.DeserializeObject<TResponse>(responseString);
        //            }
        //        }

        //        return deserializer;
        //    }
        //    catch (Exception)
        //    {
        //        return default(TResponse);
        //    }
        //}

        public async Task<GenericResponse<TResponse>> Get<TResponse>(string url, bool body)
        {
            var result = new GenericResponse<TResponse>();
            try
            {               
                TResponse deserializer = default(TResponse);

                using (HttpClient client = new HttpClient())
                {
                    client.BaseAddress = new Uri(_urlAPI + url);
                    var response = await client.GetAsync(client.BaseAddress);
                    response.EnsureSuccessStatusCode();
                    result.httpStatusCode = response.StatusCode;

                    if (response.StatusCode == HttpStatusCode.OK)
                    {
                        var responseString = await response.Content.ReadAsStringAsync();
                        deserializer = JsonConvert.DeserializeObject<TResponse>(responseString);
                    }
                }

                result.datos = deserializer;

                return result;
            }
            catch (Exception ex)
            {
                result.mensaje = ex.Message;
                return result;
            }
            
        }

        //public async Task<GenericResponse<TResponse>> Get<TResponse,TRequest>(TRequest request,string urlService)
        //{
        //    try
        //    {
        //        Y deserializer = default(Y);

        //        using (HttpClient client = new HttpClient())
        //        {
        //            var serializer = JsonConvert.SerializeObject(T);
        //            client.BaseAddress = new Uri(_urlAPI + urlService);
        //            StringContent content = new StringContent(serializer, Encoding.UTF8, "application/json");

        //            var response = await client.GetAsync(client.BaseAddress);

        //            //if (response.StatusCode == HttpStatusCode.Created)
        //            if (response.IsSuccessStatusCode)
        //            {
        //                var responseString = await response.Content.ReadAsStringAsync();
        //                deserializer = JsonConvert.DeserializeObject<Y>(responseString);
        //            }
        //        }

        //        return deserializer;
        //    }
        //    catch (Exception)
        //    {
        //        return default(Y);
        //    }
        //}


    }
}
