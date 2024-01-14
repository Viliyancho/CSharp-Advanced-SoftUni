using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListyIteratorEx
{
    public class ListyIterator<T>
    {
		private int index = 0;
		private List<T> collection;



		public ListyIterator(List<T> collection)
		{
			this.collection = collection;
		}
		public List<T> Collection
        {
			get { return collection; }
			set { collection = value; }
		}
		public int Index
		{
			get { return index; }
			set { index = value; }
		}

		public bool Move()
		{
			if(Index + 1 < Collection.Count)
			{
                Index++;
				return true;
			}

			return false;
		}
        public bool HasNext()
        {
            if (Index + 1 < Collection.Count)
            {
                return true;
            }

            return false;
        }

		public void Print()
		{
			if(collection.Count> 0)
			{
				Console.WriteLine(Collection[Index]);
			}
			else
			{
				Console.WriteLine("Invalid Operation!");
			}
		}

    }
}
