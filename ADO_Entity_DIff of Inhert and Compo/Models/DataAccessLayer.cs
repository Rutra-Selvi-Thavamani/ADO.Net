using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ADO_Entity_DIff_of_Inhert_and_Compo.Models
{
    public class DataAccessLayer
    {
        public string InsertData(PersonModel objperson)
        {
            SqlConnection con = null;
            string result = "";
            try
            {
                con = new SqlConnection(ConfigurationManager.ConnectionStrings["adoConnection"].ToString());
                SqlCommand cmd = new SqlCommand("Usp_InsertUpdateDelete_Person", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@BusinessEntityID", 0);
                cmd.Parameters.AddWithValue("@PersonType", objperson.PersonType);
                cmd.Parameters.AddWithValue("@FirstName", objperson.FirstName);
                cmd.Parameters.AddWithValue("@MiddleName", objperson.MiddleName);
                cmd.Parameters.AddWithValue("@LastName", objperson.LastName);
                cmd.Parameters.AddWithValue("@EmailPromotion", objperson.EmailPromotion);
                con.Open();
                result = cmd.ExecuteScalar().ToString();
                return result;
            }
            catch
            {
                return result = "";
            }
            finally
            {
                con.Close();
            }
        }

        //Update record
        public string UpdateData(PersonModel objperson)
        {
            SqlConnection con = null;
            string result = "";
            try
            {
                con = new SqlConnection(ConfigurationManager.ConnectionStrings["adoConnection"].ToString());
                SqlCommand cmd = new SqlCommand("Usp_InsertUpdateDelete_Person", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@BusinessEntityID", 0);
                cmd.Parameters.AddWithValue("@PersonType", objperson.PersonType);
                cmd.Parameters.AddWithValue("@FirstName", objperson.FirstName);
                cmd.Parameters.AddWithValue("@MiddleName", objperson.MiddleName);
                cmd.Parameters.AddWithValue("@LastName", objperson.LastName);
                cmd.Parameters.AddWithValue("@EmailPromotion", objperson.EmailPromotion);
                con.Open();
                result = cmd.ExecuteScalar().ToString();
                return result;
            }
            catch
            {
                return result = "";
            }
            finally
            {
                con.Close();
            }
        }
        //Delete Record
        public string DeleteData(PersonModel objperson)
        {
            SqlConnection con = null;
            string result = "";
            try
            {
                con = new SqlConnection(ConfigurationManager.ConnectionStrings["adoConnection"].ToString());
                SqlCommand cmd = new SqlCommand("Usp_InsertUpdateDelete_Person", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@BusinessEntityID", 0);
                cmd.Parameters.AddWithValue("@PersonType", objperson.PersonType);
                cmd.Parameters.AddWithValue("@FirstName", objperson.FirstName);
                cmd.Parameters.AddWithValue("@MiddleName", objperson.MiddleName);
                cmd.Parameters.AddWithValue("@LastName", objperson.LastName);
                cmd.Parameters.AddWithValue("@EmailPromotion", objperson.EmailPromotion);
                con.Open();
                result = cmd.ExecuteScalar().ToString();
                return result;
            }
            catch
            {
                return result = "";
            }
            finally
            {
                con.Close();
            }
        }
        //Get ALl Records

        public List<PersonModel> Selectalldata()
        {
            SqlConnection con = null;
            DataSet ds = null;
            List<PersonModel> personlist = null;
            try
            {
                con = new SqlConnection(ConfigurationManager.ConnectionStrings["adoConnection"].ToString());
                SqlCommand cmd = new SqlCommand("Usp_InsertUpdateDelete_Person", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@BusinessEntityID", null);
                cmd.Parameters.AddWithValue("@PersonType", null);
                cmd.Parameters.AddWithValue("@FirstName", null);
                cmd.Parameters.AddWithValue("@MiddleName", null);
                cmd.Parameters.AddWithValue("@LastName", null);
                cmd.Parameters.AddWithValue("@EmailPromotion", null);
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                ds = new DataSet();
                da.Fill(ds);
                personlist = new List<PersonModel>();
                for (int i=0; i<ds.Tables[0].Rows.Count; i++)
                {
                    PersonModel pobj = new PersonModel();
                    pobj.BusinessEntityID = Convert.ToInt32(ds.Tables[0].Rows[i]["BusinessEntityID"].ToString());
                    pobj.PersonType = ds.Tables[0].Rows[i]["PersonType"].ToString();
                    pobj.FirstName = ds.Tables[0].Rows[i]["FirstName"].ToString();
                    pobj.MiddleName = ds.Tables[0].Rows[i]["MiddleName"].ToString();
                    pobj.LastName = ds.Tables[0].Rows[i]["LastName"].ToString();
                    pobj.EmailPromotion = Convert.ToInt32(ds.Tables[0].Rows[i]["EmailPromotion"].ToString());
                    personlist.Add(pobj);
                }
                return personlist;
            }
            catch
            {
                return personlist;
            }
            finally
            {
                con.Close();
            }
        }

        //Get Data By Person ID
        public PersonModel SelectDataByID(string BusinessEntityID)
        {
            SqlConnection con = null;
            DataSet ds = null;
            PersonModel pobj = null;
            try
            {
                con = new SqlConnection(ConfigurationManager.ConnectionStrings["adoConnection"].ToString());
                SqlCommand cmd = new SqlCommand("Usp_InsertUpdateDelete_Person", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@BusinessEntityID", BusinessEntityID);
                cmd.Parameters.AddWithValue("@PersonType", null);
                cmd.Parameters.AddWithValue("@FirstName", null);
                cmd.Parameters.AddWithValue("@MiddleName", null);
                cmd.Parameters.AddWithValue("@LastName", null);
                cmd.Parameters.AddWithValue("@EmailPromotion", null);
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                ds = new DataSet();
                da.Fill(ds);
                for (int i=0; i<ds.Tables[0].Rows.Count; i++)
                {
                    pobj = new PersonModel();
                    pobj.BusinessEntityID = Convert.ToInt32(ds.Tables[0].Rows[i]["BusinessEntityID"].ToString());
                    pobj.PersonType = ds.Tables[0].Rows[i]["PersonType"].ToString();
                    pobj.FirstName = ds.Tables[0].Rows[i]["FirstName"].ToString();
                    pobj.MiddleName = ds.Tables[0].Rows[i]["MiddleName"].ToString();
                    pobj.LastName = ds.Tables[0].Rows[i]["LastName"].ToString();
                    pobj.EmailPromotion = Convert.ToInt32(ds.Tables[0].Rows[i]["EmailPromotion"].ToString());
                }
                return pobj;
            }
            catch
            {
                return pobj;
            }
            finally
            {
                con.Close();
            }
        }
    }
}