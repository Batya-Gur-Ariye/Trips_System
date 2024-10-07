using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Project_Trips_Forms
{
public enum Methods
{
    POST,
    PUT,
    DELETE
}
public class WebApiUtils
{
    #region Variables
    public string Url { get; private set; }
    public string Method { get; private set; }
    private int _timeOut = 100;
    private const int _minTimeOut = 10;

    #endregion

    #region Constructor

    public WebApiUtils()
    {
        Url = String.Empty;
        Method = String.Empty;
    }

    public WebApiUtils(string baseUrl)
    {
        Url = baseUrl;
        Method = String.Empty;
    }

    public WebApiUtils(string baseUrl, string methodName)
    {
        Url = baseUrl;
        Method = methodName;
    }
    #endregion

    #region Public methods

    public string Invoke(string methodName, string parameters, bool isJson = false, string username = null, string pwd = null)
    {
        Method = methodName;
        HttpClientHandler handler = null;
        if (!string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(pwd))
        {
            var credentials = new NetworkCredential(username, pwd);
            handler = new HttpClientHandler { Credentials = credentials };
        }
        else
        {
            handler = new HttpClientHandler();
            handler.UseDefaultCredentials = true;
        }
        using (var client = new HttpClient(handler))
        {

            client.BaseAddress = new Uri(Url);
            client.DefaultRequestHeaders.Accept.Clear();
            if (isJson)
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            else
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/xml"));
            HttpResponseMessage response = null;
            if (string.IsNullOrEmpty(parameters))
            {
                response = client.GetAsync(methodName).Result;
            }
            else
            {
                response = client.GetAsync(methodName + parameters).Result;
            }
            if (response.IsSuccessStatusCode)
                return response.Content.ReadAsStringAsync().Result;
            return string.Empty;
        }
    }

    public string Invoke(string methodName, JObject model, bool isJson = false, string username = null, string pwd = null)
    {
        try
        {
            HttpClientHandler handler = null;
            if (!string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(pwd))
            {
                var credentials = new NetworkCredential(username, pwd);
                handler = new HttpClientHandler { Credentials = credentials };
            }
            else
            {
                handler = new HttpClientHandler();
                handler.UseDefaultCredentials = true;
            }
            using (var client = new HttpClient(handler))
            {
                client.BaseAddress = new Uri(Url + methodName);
                client.DefaultRequestHeaders.Accept.Clear();
                HttpResponseMessage response = null;
                if (model != null)
                {
                    var content = new StringContent(model.ToString(), Encoding.UTF8, "application/json");
                    response = client.PostAsync("", content).Result;
                    if (response.IsSuccessStatusCode)
                        return response.Content.ReadAsStringAsync().Result;
                }
            }
        }
        catch (Exception ex)
        {
        }
        return string.Empty;
    }

        public string InvokeByMethod(Methods method, string methodName, JObject model, bool isJson = false, string username = null, string pwd = null)
        {
            try
            {
                HttpClientHandler handler = null;
                if (!string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(pwd))
                {
                    var credentials = new NetworkCredential(username, pwd);
                    handler = new HttpClientHandler { Credentials = credentials };
                }
                else
                {
                    handler = new HttpClientHandler();
                    handler.UseDefaultCredentials = true;
                }
                using (var client = new HttpClient(handler))
                {
                    client.BaseAddress = new Uri(Url + methodName);
                    client.DefaultRequestHeaders.Accept.Clear();
                    client.Timeout = TimeSpan.FromSeconds(_timeOut);
                    HttpResponseMessage response = null;
                    if (model != null)
                    {
                        var content = new StringContent(model.ToString(), Encoding.UTF8, "application/json");
                        switch (method)
                        {
                            case Methods.POST:
                                response = client.PostAsync("", content).Result;
                                break;
                            case Methods.PUT:
                                response = client.PutAsync("", content).Result;
                                break;
                            case Methods.DELETE:
                                response = client.DeleteAsync(methodName).Result;
                                break;
                        }

                        if (response.IsSuccessStatusCode)
                            return response.Content.ReadAsStringAsync().Result;
                    }
                }
            }
            catch (Exception ex)
            {

            }
            return string.Empty;
        }

        public void SetTimeout(int seconds)
    {
        if (seconds >= _minTimeOut) _timeOut = seconds;
    }

        internal Task<T> Invoke<T>(string v, string parameters)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}



