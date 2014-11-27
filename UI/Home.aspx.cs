using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication2.AppCode;

namespace WebApplication2.UI
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            databaseConnection DC = new databaseConnection();
            lblHome.Text = DC.ExecuteQuery("select top 1 First_Name from Customer");
        }
    }
}