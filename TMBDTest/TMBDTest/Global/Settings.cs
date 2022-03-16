using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TMBDTest.Global
{
    public static class Settings
    {
        public static string UrlAPI { get; set; }
        public static string ApiKey { get; set; }

        static Settings()
        {
            UrlAPI = string.Empty;
            ApiKey = string.Empty;
        }
    }
}
