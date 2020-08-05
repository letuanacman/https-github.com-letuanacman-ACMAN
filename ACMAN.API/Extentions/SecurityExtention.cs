using ACMAN.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;

namespace ACMAN.API.Extentions
{
    public class SecurityExtention
    {
        public static ConnectStringInfo GetPackageService(string stringObject)
        {
            return new JavaScriptSerializer().Deserialize<ConnectStringInfo>(stringObject);
        }

        public static string GetPackageServiceJson(ConnectStringInfo obj)
        {
            
            return new JavaScriptSerializer().Serialize(obj);
        }
    }
}