using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;

namespace Helper
{
    
    public class Helper
    {
        MemberDll mdal = null;
        BookDal bdal = null;
        EmployeeDal dal = null;
        UserDal udal = null;
        public Helper()
        {
            dal = new EmployeeDal();
            bdal = new BookDal();
            mdal = new MemberDll();
            udal = new UserDal();
        }
        public bool AddMember(MemberBll mb)
        {
            return mdal.InsertMember(mb);
        }
        public bool AddBook(BookBll b)
        {
            return bdal.InsertBook(b);
        }
       
        public bool AddEmployee(EmployeeBll emp)
        {
            return dal.InsertEmployee(emp);
        }
        public bool UpdateMember(MemberBll mb)
        {
            return mdal.UpdateMember(mb);
        }
        public void UserValidation(User user)
        {
             udal.ValidateUser(user);
        }

    }
}
