using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyList<T> //buraya her şeyi koyabilirsin, çalışılacak özel bir tipin varlığına işaret eder, int, string, class vb.
    {
        T[] items; //methodun içerisinde değil, direk class'ın içerisinde her yerde çalışsın diye
        //ctor - buna constructor denir, MyList classını her new'lediğinde altındaki kod otomatik çalışır
        public MyList() //constructor
        {
            items = new T[0];
        }
        public void Add(T item) //sana T olarak ne verirsem tip odur
        {
            T[] tempArray = items; //geçici eleman, önceki elemanları içeren diziyi tut ki ben kaybetmeyeyim, başka eleman eklerken diğer elemanlarımı koru
            items = new T[items.Length+1]; //dizimin eleman sayısını 1 arttır
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }

            items[items.Length - 1] = item;
        }
    }
}
