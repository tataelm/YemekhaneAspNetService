using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using Newtonsoft.Json;

namespace MakelYemekhaneWebService
{
    /// <summary>
    /// Summary description for YemekhaneWS
    /// </summary>
    [WebService(Namespace = "http://85.105.238.124/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class YemekhaneWS : System.Web.Services.WebService
    {
        DBHelper dbhelper = new DBHelper();

        [WebMethod]
        public string getAllGunlukMenu()
        {            
            return JsonConvert.SerializeObject(dbhelper.getAllGunlukMenu());
        }
    }
}
