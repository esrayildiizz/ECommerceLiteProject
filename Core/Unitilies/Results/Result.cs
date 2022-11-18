using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Unitilies.Results
{
    // Results dosyası içinceki somut class olarak düşün.
    public class Result : IResult
    {
        //constructor metotun kendi içinde başka yapılarla çalışmasına mükemmel bir örnek.
        //ilk result çalıştığında ben ikincisininde çalışmasını istiyorsam : koyup istediğimi yani ikinciyi(tek parametreliyi) yazabilirim.
        public Result(bool success, string message):this(success)
        {
            Message = message;
        }
        public Result(bool success)
        {
            Success = success;
        }

        public bool Success { get; }
        public string Message { get; }
    }
}
