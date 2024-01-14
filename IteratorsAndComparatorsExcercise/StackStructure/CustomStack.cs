using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackStructure
{
    public class CustomStack<T> : IEnumerable<T>
    {
        private T[] items;
        private int index = 0;

        public int Index
        {
            get { return index; }
            set { index = value; }
        }

        public T[] Items
        {
            get { return items; }
            set { items = value; }
        }

        public void Push(T[] something)
        {
            if(Index + something.Length > Items.Length)
            {
                Items = new T[Items.Length * 2];
            }

            foreach (var item in something)
            {
                Items[Index] = item;
                Index++;
            }
        }
        public T Pop() 
        {
            if(Items.Length == 0)
            {
                Console.WriteLine("No elements");
                return default(T);
            }
            else
            {
            T som = Items[Index - 1];
            Items[Index - 1] = default(T);
            return som;
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = Items.Length - 1; i >= 0; i--)
            {
                yield return Items[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
