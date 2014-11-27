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
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        private bool ValidateCredentials(string userName, string password)
        {

            Boolean ret = false;
            if (userName.Length <= 50 && password.Length <= 50)
            {
                
                    databaseConnection db = new databaseConnection();
                    if(db.Login(userName, password))
                    ret = true;
            }
            else
            {
                ret = false;
            }
            return ret;
        }
        public bool IsAlphaNumeric(string text)
        {
            return Regex.IsMatch(text, "^[a-zA-Z0-9]+$");
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            if (ValidateCredentials(txtEmail.Text.Trim(), txtPass.Text.Trim()))
            {
                Session["user"] = "";
                Session["member"] = "true";
                Response.Redirect("./Home.aspx");
                
            }
            else 
            {
                lblErr.Visible = true;
            }
        }
    }
}