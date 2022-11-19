using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Contants
{
    //static tanımlama sebebim Messages sınıfında ram de ayrılan bir kısım olsun ve ben buna new lemeden ulaşabileyim.
    public static class Messages
    {
        public static string ProductAdded = "Ürün eklendi.";
        public static string ProductNameInvalid = "Ürün ismi geçersiz..";
    }
}
