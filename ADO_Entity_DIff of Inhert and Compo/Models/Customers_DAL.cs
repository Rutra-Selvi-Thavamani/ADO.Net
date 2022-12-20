using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ADO_Entity_DIff_of_Inhert_and_Compo.Models
{
    public class Customers_DAL
    {
        string conString = ConfigurationManager.ConnectionStrings["adoConnection"].ToString();
        

        //Get all sales
        public List<Customers> GetCustomers()
        {
            List<Customers> CustomersList = new List<Customers>();
            SqlConnection con = new SqlConnection(conString);
            SqlCommand cmd = new SqlCommand("spGetCustomers", con);
            cmd.CommandType = CommandType.StoredProcedure;
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Customers cust = new Customers();
                cust.CustomerID = Convert.ToInt32(dr.GetValue(0).ToString());
                cust.PersonID = Convert.ToInt32(dr.GetValue(0).ToString());
                cust.StoreID = Convert.ToInt32(dr.GetValue(0).ToString());
                cust.AccountNumber = Convert.ToInt32(dr.GetValue(0).ToString());
                CustomersList.Add(cust);
            }
            con.Close();

            return CustomersList;
        }
    }
}