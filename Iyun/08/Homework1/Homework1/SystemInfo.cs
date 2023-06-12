using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1
{
    public class SystemInfo
    {
        public DateTime CreateDate { get; set; }
        public DateTime? EditDate { get; set; }
        public DateTime? DeleteDate { get; set; }

        public int CreateUser { get; set; }
        public int EditUser { get; set; }
        public int DeleteUser { get; set; }

        public bool IsDeleted { get; set; }

    }
}
