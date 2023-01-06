using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsInto
{

    internal class MyList<T>                             // I used <T> to be compatible with any type. (Her tipe uyumlu olabilmesi için <T> kullandım.)
    {
        T[] items;                                       // Defining an array of type T. (T türünde bir dizi tanımlanır.)

        public MyList()                                  // Constructor method. (Yapıcı metodu.)
        {
            items = new T[0];                            // Creates an array with 0 elements. (0 elemanlı bir dizi oluşturur.)
        }

        public void Add(T item)                          // A T-type item is expected for the add function. (Ekleme işlevi için T tipi bir öğe bekleniyor)
        {
            T[] tempArray = items;                       // Creates a temporary array to hold the existing elements of the array. (Dizinin mevcut öğelerini tutmak için geçici bir dizi oluşturur.)
            items = new T[items.Length + 1];             // Increases the number of elements of the array by one. (Dizinin eleman sayısını bir arttırır.)

            for (int i = 0; i < tempArray.Length; i++)   // The return number of the for loop is equal to the number of elements of the temporary array. (For döngüsü geçici dizi'nin eleman sayısı kadar döner.)
            {
                items[i] = tempArray[i];                 // Elements in the temporary array are assigned to the items array. (Geçici dizideki öğeler, öğeler dizisine atanır.)
            }

            items[items.Length-1] = item;                // The data to be appended to the end of the items array is assigned. (Items dizisinin sonuna eklenecek veri atanır.)

            foreach (var x in items)                     // x, cycles through the items of the items array. (x, items dizisinin öğeleri arasında geçiş yapar.)
            {
                Console.WriteLine(x);                    // Prints all the elements of the array. (Dizinin tüm elemanlarını yazdırır.)
            }

        }
    }
}