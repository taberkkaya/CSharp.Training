using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class User : Test1
    {
        public int Id { get; set; }
        public int SetAge() {
            return 0;
        }
    }

    public class User2 : User
    {
        
    }

    public class Test1 : Test2 
    {
        public string Mail { get; set; }
    }

    public class Test2
    {
        public int Set()
        {
            return 0;
        }
    }
}
