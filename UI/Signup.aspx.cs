using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication2.AppCode;

namespace WebApplication2.UI
{
    public partial class Signup : System.Web.UI.Page
    {
        databaseConnection DB = new databaseConnection();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                lblErr.Text = "";
                lblErr.Visible = false;
            }
        }

        protected void btnCreate_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text == txtConfPass.Text)
            {
                if (DB.CheckEmail(txtEmail.Text.Trim()) == false)
                {
                    DB.InsertProfile(txtFname.Text.Trim(), txtLname.Text.Trim(), txtMname.Text.Trim(), txtAddr2.Text.Trim(), txtCity.Text.Trim(), txtState.Text.Trim(), txtPhone.Text.Trim(), txtZip.Text.Trim(), txtEmail.Text.Trim(), txtPassword.Text.Trim());
                    Response.Redirect("./Login.aspx", false);
                }
                else
                {
                    lblErr.Visible = true;
                    lblErr.Text = "email already exists";
                    txtEmail.Text = "";
                }
            }
            else
            {
                lblErr.Visible = true;
                lblErr.Text = "Password do not match";
                txtPassword.Text = "";
                txtConfPass.Text = "";
                txtConfPass.Text = "";

            }
        }
    }
}