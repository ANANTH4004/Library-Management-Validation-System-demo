using BLL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace DataAccessLayer
{
    public class MemberDll
    {
        public bool InsertMember(MemberBll mb)
        {
            SqlConnection sql = new SqlConnection(ConfigurationManager.ConnectionStrings["ShoppingCnStr"].ConnectionString);
            SqlCommand cmd = new SqlCommand("insert into Member(Member_Id,Member_Name,Acc_Open_Date)valueS(@Member_Id ,@Member_Name , @Acc_Open_Date)",sql);

            cmd.Parameters.AddWithValue("@Member_Id", mb.MemberId);
            cmd.Parameters.AddWithValue("@Member_Name", mb.MemberName);
            cmd.Parameters.AddWithValue("@Acc_Open_Date", mb.OpenDate);
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
        public bool UpdateMember(MemberBll mb)
        {

            SqlConnection sql = new SqlConnection(ConfigurationManager.ConnectionStrings["ShoppingCnStr"].ConnectionString);
            SqlCommand cmdUpdate = new SqlCommand("[dbo].[sp_UpdateMember]", sql);
            cmdUpdate.CommandType = System.Data.CommandType.StoredProcedure;
            //cmd.Parameters.AddWithValue("@Member_id", mb.MemberId);
            cmdUpdate.Parameters.AddWithValue("@memberID", mb.MemberId);
            cmdUpdate.Parameters.AddWithValue("@memberName", mb.MemberName);
            cmdUpdate.Parameters.AddWithValue("@openDate", mb.OpenDate);
            cmdUpdate.Parameters.AddWithValue("@penalty", mb.Penalty);
            sql.Open();
            int ans = cmdUpdate.ExecuteNonQuery();
            bool status = false;
            if (ans > 0)
            {
                status = true;
            }

            sql.Close();
            sql.Dispose();
            return status;
        }

        //public bool Validation()
       
    }
}
