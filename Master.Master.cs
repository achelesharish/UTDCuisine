using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["member"] != null)
            {
                if (Session["member"].ToString() == "true")
                {
                    btn_logout.Visible = true;
                    btn_signin.Visible = false;
                }
            }
        }

        protected void btn_order_Click(object sender, EventArgs e)
        {
            Response.Redirect("./OnlineOrder.aspx", false);
        }

        protected void btn_menu_Click(object sender, EventArgs e)
        {
            Response.Redirect("./Menu.aspx", false);
        }

        protected void btn_location_Click(object sender, EventArgs e)
        {
            Response.Redirect("./Location.aspx", false);
        }

        protected void btn_favorite_Click(object sender, EventArgs e)
        {
            Response.Redirect("./Favorites.aspx", false);
        }

        protected void btn_profile_Click(object sender, EventArgs e)
        {
            Response.Redirect("./Profile.aspx", false);
        }

        protected void btn_signin_Click(object sender, EventArgs e)
        {
            Response.Redirect("./Login.aspx", false);
        }

        protected void btn_signup_Click(object sender, EventArgs e)
        {
            Response.Redirect("./Signup.aspx", false);
        }

        protected void btn_home_Click(object sender, EventArgs e)
        {
            Response.Redirect("./Home.aspx", false);
        }

        protected void btn_tracker_Click(object sender, EventArgs e)
        {
            Response.Redirect("./Tracker.aspx", false);
        }

        protected void btn_logout_Click(object sender, EventArgs e)
        {
            Session.Clear();
            Response.Redirect("./Home.aspx");

        }
    }
}