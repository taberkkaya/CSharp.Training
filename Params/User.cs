using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Params
{
    public class User
    {
        public int Calculate(params int[] numbers)
        {
            return numbers.Sum();
        }
    }
}
