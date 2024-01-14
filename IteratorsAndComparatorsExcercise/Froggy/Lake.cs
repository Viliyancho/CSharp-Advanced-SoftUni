using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Froggy
{
    public class Lake : IEnumerable<int>
    {
		private int[] stones;

        public Lake(int[] stones)
        {
            Stones = stones;
        }
		public int[] Stones
		{
			get { return stones; }
			set { stones = value; }
		}

        public IEnumerator<int> GetEnumerator()
        {
            for (int i = 0; i < Stones.Length; i++)
            {
                if(i % 2 == 0)
                {
                    yield return Stones[i];
                }
            }

            for (int i = Stones.Length - 1; i >= 0; i--)
            {
                if(i % 2 != 0)
                {
                    yield return Stones[i];
                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
