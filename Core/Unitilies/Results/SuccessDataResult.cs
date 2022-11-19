using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Unitilies.Results
{
    public class SuccessDataResult<T>:DataResult<T>
    {
        public SuccessDataResult(T data,string message):base(data,true,message)
        {

        }

        //mesaj işine girmek istemeyebilir.
        public SuccessDataResult(T data):base(data,true)
        {

        }


        //datayı default haliyle döndürmek isteyebilir.
        public SuccessDataResult(string message):base(default,true,message)
        {

        }

        public SuccessDataResult():base(default,true)
        {

        }
    }
}
