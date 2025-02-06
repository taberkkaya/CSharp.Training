using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public class User : IUser
    {
        public string Name { get; set; }
        public int Id { get; set; }

        public void Register()
        {
            //User.Add
            Console.WriteLine("User.Add!");
        }

        public int SetAge()
        {
            throw new NotImplementedException();
        }
    }

    public class GoogleUser : IUser
    {
        public string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Register()
        {
            //register w Google account
            Console.WriteLine("register w Google account!");
        }

        public int SetAge()
        {
            throw new NotImplementedException();
        }
    }

    public interface IUser
    {
        string Name { get; set; }
        int Id { get; set; }
        int SetAge();
        void Register();
    }
}
