using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;
using System.Data.SqlClient;
using HashLibrary;
using System.Configuration;
using System.Text.RegularExpressions;
using WebApplication2.AppCode;
namespace WebApplication2.UI
{
    public partial class Tracker : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                OrderTracker.OrderStatus OD = new OrderTracker.OrderStatus();
                lblStatus.Text = OD.OrderTracker(Convert.ToInt32(txtOrderid.Text.Trim()));
            }
            catch
            {
                lblStatus.Text = "Could not Retrieve";
            }
        }
    }
}