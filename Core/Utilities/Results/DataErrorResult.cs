using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    class DataErrorResult<T>:DataResult<T>
    {
        public DataErrorResult(T data, string message):base(data,false,message)
        {

        }
        public DataErrorResult(T data) : base(data, false)
        {

        }
    }
}
