﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    public class User
    {
        public int Id { get; set; }
        public User(int id)
        {
            Id = id;
        }

        public User()
        {
            
        }      
        
        public User(int age, int id)
        {
            
        }
    }
}
