using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class EmployeeBll
    {
		private int _empId;

		public int EmployeeId
		{
			get { return _empId;  }
			set { _empId = value; }
		}

		private string _lName;

		public string LastName
		{
			get { return _lName; }
			set 
			{
				if(value.Length > 20)
				{
					throw new Exception("Last Name Must be less than 20 Character");
				}
				else
				{
                    _lName = value;
                }
			}
		}

		private string _fName;

		public string FirstName
		{
			get { return _fName; }
			set 
			{
                if (value.Length > 10)
                {
                    throw new Exception("First Name Must be less than 10 Character");
                }
				else if (String.IsNullOrEmpty(value))
				{
					throw new Exception("First Name Can't be Null or Emplty");
				}
                else
                {
                    _fName = value;
                }
            }
		}

		private string _title;

		public string Title
		{
			get { return _title; }
			set { _title = value; }
		}

		private DateTime dateTime;

		public DateTime BirthDate
		{
			get { return dateTime; }
			set { dateTime = value; }
		}



	}

	public class BookBll
	{
		private int _bookNo;

		public int BookNo
		{
			get { return _bookNo; }
			set 
			{ 
				if(value.ToString().Length > 4)
				{
					throw new Exception("Enter a valid book Number");
				}
				else
				{
                    _bookNo = value;
                }
				
			}
		}

		private string _bookName;

		public string BookName
		{
			get { return _bookName; }
			set
			{
				if (String.IsNullOrEmpty(value))
				{
					throw new Exception("Book Name can't be Null or Emplty");
				}
				else
				{
                    _bookName = value;
                }
			
			}
		}
		public double Cost { get; set; }

		public string Category { get; set; }

		public string Author { get; set; }


	}
}
