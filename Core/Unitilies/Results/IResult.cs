using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Unitilies.Results
{
    //Results dosyası içinceki soyut interface olarak düşün.
    //Temel voidler için başlangıç.
    public interface IResult
    {
        bool Success { get; }

        string Message { get; }
    }
}
