using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Web.Services;
using WebApplication2.AppCode;
namespace WebApplication2
{
    /// <summary>
    /// Summary description for Menu
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    //[System.Web.Script.Services.ScriptService]
    public class Menu : System.Web.Services.WebService
    {
        databaseConnection DB = new databaseConnection();
        [WebMethod]
        public  DataTable UtdMenu(string Day)
        {
            DataTable dt = new DataTable();
            return dt;
        }
    }
}
