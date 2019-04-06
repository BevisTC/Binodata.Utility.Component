using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binodata.Utility.Component.ConfigurationHandler
{
    public interface IConfigureService
    {
        string GetConfigByKey(string key);
    }
}
