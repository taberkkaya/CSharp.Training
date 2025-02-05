using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    public class User
    {
        public int Id { get; set; }
        private string Name { get; set; }
        protected int Age { get; set; }
    }
}
