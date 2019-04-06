using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binodata.Utility.Component.AdapterModel
{
    public class ModelStateError
    {
        /// <summary>
        /// 索引鍵
        /// </summary>
        public string Key { get; set; }

        /// <summary>
        /// 錯誤訊息
        /// </summary>
        public string ErrorMessage { get; set; }
    }
}
