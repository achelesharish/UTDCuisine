using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data;
using WebApplication2.AppCode;
using System.Data.SqlClient;
using System.Configuration;


namespace WebApplication2
{
    /// <summary>
    /// Summary description for OrderStatus
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    [System.Web.Script.Services.ScriptService]
    public class OrderStatus : System.Web.Services.WebService
    {
        databaseConnection DB = new databaseConnection();
        [WebMethod]
        public string OrderTracker(int orderid)
        {
            return DB.orderTracker(orderid).ToString();
        }
        
         
    }
}
