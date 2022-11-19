using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Unitilies.Results
{
    public class ErrorDataResult<T> : DataResult<T>
    {
        public ErrorDataResult(T data, string message) : base(data, false, message)
        {

        }

        //mesaj işine girmek istemeyebilir.
        public ErrorDataResult(T data) : base(data, false)
        {

        }


        //datayı default haliyle döndürmek isteyebilir.
        public ErrorDataResult(string message) : base(default, false, message)
        {

        }

        public ErrorDataResult() : base(default, false)
        {

        }
    }
}
