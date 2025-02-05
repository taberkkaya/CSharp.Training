using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class User
    {
        public int SetAge()
        {
            return 1;
        }

        public int SetAge(int age)
        {
            return age;
        }

        public virtual int GetAge()
        {
            return 1;
        }
    }

    public class User2 : User
    {
        public override int GetAge()
        {
            return 15;
        }
    }
}
