using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class MemberBll
    {
        public int MemberId { get; set; }
        public string MemberName { get; set; }
        public DateTime OpenDate { get; set; }
        public int MaxAllow { get; set; }
        public double Penalty { get; set; }

    }
}
