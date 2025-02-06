using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    public class User
    {
        private string _name;
        public int Id { get; set; }
        public string Name { get;}

        public string Properties { 
            get { return _name; } 
            set { _name = value + " lorem"; } 
        }

        private string _test;
        public string Test {
            get => _test;
            set => _test = value;
        }

        private string _firstName;
        private string _lastName;

        public User()
        {
            
        }

        public User(string firstName, string lastName)
        {
            _firstName = firstName;
            _lastName = lastName;   
        }

        public string FullName => $"{_firstName} {_lastName}";

            

    }
}
