using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL;
using System.Configuration;
using System.Net.Configuration;

namespace DataAccessLayer
{
    public class BookDal
    {
        public bool InsertBook(BookBll b)
        {
            SqlConnection sql = new SqlConnection(ConfigurationManager.ConnectionStrings["ShoppingCnStr"].ConnectionString);
            SqlCommand cmd = new SqlCommand("insert into Book(Book_No,Book_Name,Author,Cost,Category) values(@Book_No,@Book_Name,@Author,@Cost,@Category)", sql);
            cmd.Parameters.AddWithValue("@Book_No", b.BookNo);
            cmd.Parameters.AddWithValue("@Book_Name", b.BookName);
            cmd.Parameters.AddWithValue("@Author", b.Author);
            cmd.Parameters.AddWithValue("@Cost", b.Cost);
            cmd.Parameters.AddWithValue("@Category", b.Category);
            sql.Open();
            int ans = cmd.ExecuteNonQuery();
            bool status = false;
            if (ans > 0)
            {   
                status = true;
            }

            sql.Close();
            sql.Dispose();
            return status;
        }
        static public void ShowAllBooks()
        {
            SqlConnection sql = new SqlConnection(ConfigurationManager.ConnectionStrings["ShoppingCnStr"].ConnectionString);
            SqlCommand cmd = new SqlCommand("select * from Book", sql);
           
            sql.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Console.WriteLine("Bokk No : " + dr[0] + "  Book Name : " + dr[1]);
            
            }
           

            sql.Close();
            sql.Dispose();
        }
    }
}
