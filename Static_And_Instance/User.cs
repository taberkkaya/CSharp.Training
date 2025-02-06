using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_And_Instance
{
    public  class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public static class Auth
    {
        public static void Register()
        {
            Console.WriteLine("Registered");
        }
    }
}
