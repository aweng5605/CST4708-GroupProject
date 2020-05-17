using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group_Project
{
    public class Database
    {
        SqlConnection connection;
        SqlDataAdapter adapter;

        public Database()
        {
            String connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"" + System.IO.Directory.GetCurrentDirectory() + "\\Comics.mdf\";Integrated Security=True;Connect Timeout=30";
            connection = new SqlConnection();
            connection.ConnectionString = connectionString;
            adapter = new SqlDataAdapter();
        }

        public bool login(String user, String pass)
        {
            SqlCommand select = new SqlCommand();
            select.CommandText = "Select * From Customer Where Username = @user AND Password = @pass;";
            select.Parameters.Add("@user", SqlDbType.VarChar);
            select.Parameters["@user"].Value = user;

            select.Parameters.Add("@pass", SqlDbType.VarChar);
            select.Parameters["@pass"].Value = pass;

            select.Connection = connection;

            DataTable dt = new DataTable();
            connection.Open();
            adapter.SelectCommand = select;

            adapter.Fill(dt);
            connection.Close();

            if (dt.Rows.Count < 1)
            {
                return false;
            }
            else
            {
                foreach (DataRow row in dt.Rows)
                {
                    Profile.FirstName = row["FirstName"].ToString();
                    Profile.LastName = row["LastName"].ToString();
                    Profile.CreditCard = row["CreditCard"].ToString();
                    Catalog.FirstName = row["FirstName"].ToString();
                    Catalog.LastName = row["LastName"].ToString();
                    Catalog.userName = row["Username"].ToString();
                    Catalog.userID = int.Parse(row["Id"].ToString());
                    Cart.FirstName = row["FirstName"].ToString();
                    Cart.LastName = row["LastName"].ToString();
                    Cart.userName = row["Username"].ToString();
                    //Profile.id = int.Parse(row["id"].ToString());
                }
                return true;
            }

        }

        public DataTable populateComics()
        {

            SqlCommand select = new SqlCommand();
            select.CommandText = "select * from Comic_info";
            select.Connection = connection;
            DataTable dt = new DataTable();
            connection.Open();
            adapter.SelectCommand = select;
            adapter.Fill(dt);
            connection.Close();
            return dt;
        }

        public DataTable populateComics(String input)
        {

            SqlCommand select = new SqlCommand();
            select.CommandText = "select * from Comic_info where Title = '" + input + "';";
            select.Connection = connection;
            DataTable dt = new DataTable();
            connection.Open();
            adapter.SelectCommand = select;
            adapter.Fill(dt);
            connection.Close();
            return dt;
        }

        public DataTable profile(String user)
        {
            SqlCommand select = new SqlCommand();
            select.CommandText = "select * from Customer where Username = '" + user + "';";
            select.Connection = connection;
            DataTable dt = new DataTable();
            connection.Open();
            adapter.SelectCommand = select;
            adapter.Fill(dt);
            connection.Close();
            return dt;
        }


        public void addToCart(int userID, int comicID)
        {
            SqlCommand insert = new SqlCommand();
            insert.CommandText = "INSERT INTO cart (UserID, ComicID) VALUES (" + userID + ",  " + comicID + ");";
            insert.Connection = connection;
            connection.Open();
            connection.Close();
        }


        public DataTable populateCart(int userID)
        {
            SqlCommand select = new SqlCommand();
            select.CommandText = "select Comic_Info.Id, Comic_Info.Title, Comic_Info.Price, Comic_Info.Link from  Comic_Info INNER JOIN Cart ON  Comic_Info.Id =  Cart.ComicID where Cart.UserID = " + userID + ";";
            select.Connection = connection;
            DataTable dt = new DataTable();
            connection.Open();
            adapter.SelectCommand = select;
            adapter.Fill(dt);
            connection.Close();
            return dt;
        }

        public void clearCart(int userID)
        {
            SqlCommand delete = new SqlCommand();
            delete.CommandText = "Delete FROM Cart where UserID = " + userID;
            delete.Connection = connection;
            connection.Open();
            delete.ExecuteNonQuery();
            connection.Close();
        }

        public void register(String username, String password, String fname, String lname, String cc)
        {
            SqlCommand insert = new SqlCommand();
            insert.CommandText = "INSERT INTO users (Username, Password, FirstName, LastName, CreditCard ) VALUES ('" + username + "',  '" + password + "',  '" + fname + "',  '" + lname + "', '" + cc + "');";
            insert.Connection = connection;
            connection.Open();
            insert.ExecuteNonQuery();
            connection.Close();
        }

    }
}
