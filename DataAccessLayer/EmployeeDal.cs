using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL;
using System.Data.SqlClient;
using System.Configuration;
namespace DataAccessLayer
{
    public class EmployeeDal
    {

        public List<EmployeeBll> EmpList()
        {
            return null;
        }
        /// <summary>
        ///     Insert into Employee table the data for First Name ,lastName , title ,Birthdate
        ///     EmpId is Identity field so it can't be inserted
        /// </summary>
        /// <param name="emp"></param>
        public bool InsertEmployee(EmployeeBll emp)
        {
            SqlConnection sql = new SqlConnection(ConfigurationManager.ConnectionStrings["NorthwindCnStr"].ConnectionString);
          
            SqlCommand cmd = new SqlCommand("insert into employees(lastname,firstname,title,birthdate) values(@lastname,@firstname,@title,@birthdate)",sql);
            cmd.Parameters.AddWithValue("@lastname", emp.LastName);
            cmd.Parameters.AddWithValue("@firstname", emp.FirstName);
            cmd.Parameters.AddWithValue("@title", emp.Title);
            cmd.Parameters.AddWithValue("@birthdate", emp.BirthDate);
            sql.Open();
            int ans = cmd.ExecuteNonQuery();
            bool status = false;
            if(ans > 0)
            {
                status = true;
            }
          
            sql.Close();
            sql.Dispose();
            return status;

        }
        public void UpdateEmployee(EmployeeBll emp)
        {

        }
        public void DeleteEmployee(EmployeeBll emp)
        {

        }
        public EmployeeBll FindEmployee(EmployeeBll emp)
        {
            return null;
        }

    }
}
