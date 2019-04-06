using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binodata.Utility.Component.ConfigurationHandler
{
    public class ConfigureService : IConfigureService
    {
        private NameValueCollection GetApplicationSettings()
        {
            var applicationSettings = ConfigurationManager.GetSection("appSettings") as NameValueCollection;
            return applicationSettings;
        }

        public string GetConfigByKey(string key)
        {
            NameValueCollection collection = GetApplicationSettings();
            return collection[key];
        }
    }
}
