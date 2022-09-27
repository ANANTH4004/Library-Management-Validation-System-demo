using BLL;
using Helper;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace ADOday2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Employee Management System");
           
            Helper.Helper helper = new Helper.Helper();
            Console.WriteLine("Menu");
            Console.WriteLine("-----");
            Console.WriteLine(" 1.Add New Book \n 2.Add Member \n 3.Update Member \n 4.Validation");
            int userchoice = Convert.ToInt32(Console.ReadLine());
            EmployeeBll emp = new EmployeeBll();
            BookBll b = new BookBll();
            MemberBll mb = new MemberBll();
            User user = new User();
            switch (userchoice)
            {
                case 1:

                    Console.WriteLine("Enter Book Number : ");

                     b.BookNo = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter Book Name :");
                    b.BookName = Console.ReadLine();
                    Console.WriteLine("Enter Author Name: ");
                    b.Author = Console.ReadLine();
                    Console.WriteLine("Enter Cost of this Book : ");
                    b.Cost = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Enter Book Category : ");
                    b.Category = Console.ReadLine();
                  
                    //Console.WriteLine("Enter firstname");
                    //emp.FirstName = Console.ReadLine().Trim();
                    //emp.FirstName = "Anand";
                    //emp.LastName = "balamurugan";
                    //emp.Title = "software developer";
                    //emp.BirthDate =Convert.ToDateTime("11-may-01");

                    //Console.WriteLine("Enter lastname");
                    //emp.LastName = Console.ReadLine().Trim();
                    //Console.WriteLine("Enter title");
                    //emp.Title = Console.ReadLine().Trim();
                    //Console.WriteLine("Enter birthdate");
                    //emp.BirthDate = Convert.ToDateTime(Console.ReadLine());

                    bool queryStatus = helper.AddBook(b);
                    if (queryStatus)
                    {
                        Console.WriteLine("Book added successfully.....");
                    }
                    else
                    {
                        Console.WriteLine("Some error occured...");
                    }
                    break;
                case 2:
                    Console.WriteLine("Enter Member Id");
                    mb.MemberId = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter Member Name: ");
                    mb.MemberName = Console.ReadLine();
                    Console.WriteLine("Enter Account Opennig Date:");
                    mb.OpenDate = Convert.ToDateTime(Console.ReadLine());
                     queryStatus = helper.AddMember(mb);
                    if (queryStatus)
                    {
                        Console.WriteLine("Member added successfully.....");
                    }
                    else
                    {
                        Console.WriteLine("Some error occured...");
                    }
                    break;
                case 3:
                    Console.WriteLine("Enter Member Id");
                    mb.MemberId = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter Member Name: ");
                    mb.MemberName = Console.ReadLine();
                    Console.WriteLine("Enter Account Opennig Date:");
                    mb.OpenDate = Convert.ToDateTime(Console.ReadLine());
                    Console.WriteLine("Enter Penalty amount : ");
                    mb.Penalty = double.Parse(Console.ReadLine());
                    queryStatus = helper.UpdateMember(mb);
                    if (queryStatus)
                    {
                        Console.WriteLine("Member Updated successfully.....");
                    }
                    else
                    {
                        Console.WriteLine("Some error occured...");
                    }

                    break;
                case 4:
                    Console.WriteLine("Enter User ID : ");
                    user.UserId = Console.ReadLine();
                    Console.WriteLine("Enter Password : ");
                    user.Password = Console.ReadLine();
                    helper.UserValidation(user);
                    break;
                default:
                    break;
            }
        }
    }
}
