﻿using RestSharp;

namespace APIMiniProject
{
    public class WeatherMapBaseAPI
    {
        private IRestClient _client;

        public WeatherMapBaseAPI()
        {
            _client = new RestClient(WeatherMapConfigReader.BaseUrl);
        }

        public IRestResponse Execute(RestRequest request)
        {
            return _client.Execute(request);
        }

        public IRestResponse Execute(RestRequest request, RestSharp.Method method)
        {
            return _client.Execute(request, method);
        }
    }
}
