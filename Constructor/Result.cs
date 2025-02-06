using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    public class Result<T>
    {
        public T Value { get; set; }
        public bool Status { get; set; }
        public string Message { get; set; }

        public Result(T value)
        {
            Value = value;
        }

        public Result(bool status, T value) : this(value)
        {
            Status = status;
        }

        public Result(bool status, string message, T value) : this(status, value)
        {
           Message = message;
        }

    }
}
