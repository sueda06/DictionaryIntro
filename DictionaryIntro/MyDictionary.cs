using System;
using System.Collections.Generic;
using System.Text;

namespace DictionaryIntro
{
    class MyDictionary<T,S>
    {
        T[] items;
        S[] items2;
        public MyDictionary()
        {
            items = new T[0];
            items2 = new S[0];
        }
        public void Add(T item,S item2)
        {
            T[] tempArray = items;
            S[] tempArray2 = items2;
            items = new T[items.Length + 1];
            items2 = new S[items2.Length + 1];
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
                items2[i] = tempArray2[i];
            }
            items[Count - 1] = item;
            items2[Count - 1] = item2;
        }
        public int Count
        {
            get { return items.Length; }
        }
        public T[] Items
        {
            get { return items; }
        }
        public S[] Items2
        {
            get { return items2; }
        }
    }
}
