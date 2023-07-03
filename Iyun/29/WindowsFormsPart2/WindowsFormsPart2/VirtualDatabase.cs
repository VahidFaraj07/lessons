using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsPart2
{
    public class VirtualDatabase
    {
        public static List<User> Users = new List<User>();

        static VirtualDatabase()
        {
            Users.Add(new User()
            {
                Id = 1,
                Name = "vahid",
                Surname = "faraj",
                Username = "v",
                Password = "f"
            });

            Users.Add(new User()
            {
                Id = 2,
                Name = "silver",
                Surname = "light",
                Username = "s",
                Password = "l"
            });
        }
    }
}
