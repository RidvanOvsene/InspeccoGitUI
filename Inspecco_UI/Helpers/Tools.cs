using Microsoft.Extensions.Configuration;
using System;

namespace Inspecco_UI.Helpers
{
    public class Tools
    {
        private static IConfigurationRoot _configuration;


        public static string GetApiUrl
        {
            get
            {
                _configuration ??= new ConfigurationBuilder()
                .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                .AddJsonFile("appsettings.json")
                .Build();
                return _configuration.GetSection("BaseUrl:Value").Value;
            }
        }
    }
}
