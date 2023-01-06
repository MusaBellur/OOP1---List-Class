using GenericsInto;
using System;

namespace MyApp 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyList<string> names = new MyList<string>();   // Creates a new list of type string. (String türünde yeni bir liste oluşturur.)

            names.Add("Musa");                             // Invokes the add function. (Ekle fonksiyonunu çağırır.)
            
        }
    }
}