using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL;

namespace DataAccessLayer
{
    public class UserDal
    {
        public void ValidateUser(User user)
        {
            SqlConnection sql = new SqlConnection(ConfigurationManager.ConnectionStrings["ShoppingCnStr"].ConnectionString);
            
            SqlCommand valid = new SqlCommand("[dbo].[sp_FindPassword]", sql);
            valid.CommandType = System.Data.CommandType.StoredProcedure;
            valid.Parameters.AddWithValue("@p_UserId", user.UserId);
            SqlParameter p1 = new SqlParameter();
            p1.ParameterName = "@p_Password";
            p1.SqlDbType = System.Data.SqlDbType.VarChar;
            p1.Size = 20;
            p1.Direction = System.Data.ParameterDirection.Output;
            valid.Parameters.Add(p1);
            sql.Open();
            valid.ExecuteNonQuery();
          string ans = p1.Value.ToString();
           // Console.WriteLine("Answer : " + ans);
            if(ans == user.Password)
            {
                Console.WriteLine("Valid User...");
                BookDal.ShowAllBooks();
            }
            else
            {
                Console.WriteLine("Wrong Password..");
            }

            // SqlParameter param = new SqlParameter("@p_UserId", SqlDbType.VarChar);
            // param.Direction = ParameterDirection.Input;
            // param.Size = 10;
            // param.Value =user.UserId;

            // valid.Parameters.Add(param);

            // SqlParameter retval = valid.Parameters.Add("@p_Password", SqlDbType.VarChar);
            // retval.Size = 20;
            // retval.Direction = ParameterDirection.Output;
            //// valid.Parameters.Add(retval);

            // valid.ExecuteScalar(); // MISSING
            // string retunvalue = (string)valid.Parameters["@p_Password"].Value;
            //cmd.Parameters.AddWithValue("@Member_id", mb.MemberId);
            //SqlParameter returnParameter = valid.Parameters.Add("@result", SqlDbType.Bit);
            //returnParameter.Direction = ParameterDirection.ReturnValue;
            //valid.Parameters.AddWithValue("@p_UserId", user.UserId);
            // valid.Parameters.AddWithValue("@p_Password", user.Password);

            // SqlParameter sqlParam = new SqlParameter("@result", DbType.Boolean);
            //bool? IsSuccess = sql.usp_CheckEmailMobile(all params).FirstOrDefault().Result;
            //SqlParameter parmOUT = new SqlParameter("@result", SqlDbType.Bit);
            //parmOUT.Direction = ParameterDirection.Output;
            //valid.Parameters.Add(parmOUT);
            //valid.ExecuteNonQuery();
            //int returnVALUE = (int)valid.Parameters["@result"].Value;
            //Console.WriteLine("Password : " + retunvalue);
            //bool status = false;
             
           //if(returnVALUE == 0)
           // {
           //     Console.WriteLine("Not Valid");
           // }
           //if(returnVALUE > 0)
           // {
           //     Console.WriteLine("Valid");
           // }
           // valid.ExecuteNonQuery();
            //bool id = (bool)returnParameter.Value;
            sql.Close();
            sql.Dispose();
           
           
          //  return status;
        }
    }
    
}
