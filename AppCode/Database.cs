using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using System.Collections;

namespace WebApplication2.AppCode
{
    public class databaseConnection
    {
        String ConStr = ConfigurationManager.ConnectionStrings["UTDCuisine"].ConnectionString;

        public string ExecuteQuery(string query)
        {
            string str = "";
            SqlConnection sqlConnection = new SqlConnection(ConStr);
            SqlCommand cmd = new SqlCommand();
            SqlDataReader reader;

            cmd.CommandText = query;
            cmd.CommandType = CommandType.Text;
            cmd.Connection = sqlConnection;

            sqlConnection.Open();

            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                str = reader.GetString(0);
            }
            sqlConnection.Close();
            return str;
        }
        public Boolean Login(string user, string pass)
        {

            SqlConnection sqlConnection = new SqlConnection(ConStr);
            SqlDataAdapter MyDataAdapter = new SqlDataAdapter("LoginAuth", sqlConnection);
            MyDataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            MyDataAdapter.SelectCommand.Parameters.Add(new SqlParameter("@userName", SqlDbType.VarChar, 50));
            MyDataAdapter.SelectCommand.Parameters["@userName"].Value = user;

            MyDataAdapter.SelectCommand.Parameters.Add(new SqlParameter("@passsword", SqlDbType.VarChar, 25));
            MyDataAdapter.SelectCommand.Parameters["@passsword"].Value = pass;

            MyDataAdapter.SelectCommand.Parameters.Add(new SqlParameter("@auth", SqlDbType.Bit));
            MyDataAdapter.SelectCommand.Parameters["@auth"].Direction = ParameterDirection.Output;

            DataSet DS = new DataSet();
            MyDataAdapter.Fill(DS, "Login");
            
            bool auth = false;
            auth = Convert.ToBoolean(MyDataAdapter.SelectCommand.Parameters[2].Value);

            return auth;
        }

        public string orderTracker(int Orderid)
        {

            SqlConnection sqlConnection = new SqlConnection(ConStr);
            SqlDataAdapter MyDataAdapter = new SqlDataAdapter("orderStatusDetail", sqlConnection);
            MyDataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            MyDataAdapter.SelectCommand.Parameters.Add(new SqlParameter("@orderid", SqlDbType.Int));
            MyDataAdapter.SelectCommand.Parameters["@orderid"].Value = Orderid;

            
            DataSet DS = new DataSet();
            MyDataAdapter.Fill(DS, "orderStatusDetail");

            string orderDetail = "";
            orderDetail = DS.Tables[0].Rows[0][0].ToString();

            return orderDetail;
        }

        public Boolean CheckEmail(string email)
        {
            SqlConnection sqlConnection = new SqlConnection(ConStr);
            SqlDataAdapter MyDataAdapter = new SqlDataAdapter("GetEmailStatus", sqlConnection);
            MyDataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            MyDataAdapter.SelectCommand.Parameters.Add(new SqlParameter("@email", SqlDbType.VarChar, 50));
            MyDataAdapter.SelectCommand.Parameters["@email"].Value = email;


            DataSet DS = new DataSet();
            MyDataAdapter.Fill(DS, "GetEmailStatus");

            Boolean emailStatus = false;
            emailStatus = Convert.ToBoolean(DS.Tables[0].Rows[0][0]);

            return emailStatus;
        }

        public void InsertProfile(string txtFname, string txtLname, string txtMname, string txtAddr2, string txtCity, string txtState, string Phone,string zip, string Email, string Password)
        {
            SqlConnection sqlConnection = new SqlConnection(ConStr);
            SqlDataAdapter MyDataAdapter = new SqlDataAdapter("InsertProfile", sqlConnection);
            MyDataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            MyDataAdapter.SelectCommand.Parameters.Add(new SqlParameter("@Fname", SqlDbType.VarChar,20));
            MyDataAdapter.SelectCommand.Parameters["@Fname"].Value = txtFname;
            MyDataAdapter.SelectCommand.Parameters.Add(new SqlParameter("@Lname", SqlDbType.VarChar,20));
            MyDataAdapter.SelectCommand.Parameters["@Lname"].Value = txtLname;
            MyDataAdapter.SelectCommand.Parameters.Add(new SqlParameter("@Mname", SqlDbType.VarChar,20));
            MyDataAdapter.SelectCommand.Parameters["@Mname"].Value = txtMname;
            MyDataAdapter.SelectCommand.Parameters.Add(new SqlParameter("@Addr", SqlDbType.VarChar,200));
            MyDataAdapter.SelectCommand.Parameters["@Addr"].Value = txtAddr2;
            MyDataAdapter.SelectCommand.Parameters.Add(new SqlParameter("@city", SqlDbType.VarChar,50));
            MyDataAdapter.SelectCommand.Parameters["@city"].Value = txtCity;
            MyDataAdapter.SelectCommand.Parameters.Add(new SqlParameter("@state", SqlDbType.VarChar,20));
            MyDataAdapter.SelectCommand.Parameters["@state"].Value = txtState;
            MyDataAdapter.SelectCommand.Parameters.Add(new SqlParameter("@phone", SqlDbType.VarChar,12));
            MyDataAdapter.SelectCommand.Parameters["@phone"].Value = Phone;
            MyDataAdapter.SelectCommand.Parameters.Add(new SqlParameter("@zip", SqlDbType.VarChar,10));
            MyDataAdapter.SelectCommand.Parameters["@zip"].Value = zip;
            MyDataAdapter.SelectCommand.Parameters.Add(new SqlParameter("@email", SqlDbType.VarChar,50));
            MyDataAdapter.SelectCommand.Parameters["@email"].Value = Email;
            MyDataAdapter.SelectCommand.Parameters.Add(new SqlParameter("@pass", SqlDbType.VarChar,25));
            MyDataAdapter.SelectCommand.Parameters["@pass"].Value = Password;
            DataTable dt = new DataTable();
            int rowsAffected = MyDataAdapter.Fill(dt);

        }
        
    }
}