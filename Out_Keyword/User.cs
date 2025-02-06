using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Out_Keyword
{
    public class User
    {
        public void SetAge(ref int age)
        {
            age += 10;
        }
        public void SetAge2(out int age)
        {
            age = 10;
        }
    }
}