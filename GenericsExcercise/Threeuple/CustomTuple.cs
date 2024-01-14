﻿namespace Threeuple
{
    public class CustomTuple<T1, T2, T3>
    {
		private T1 item1;
		private T2 item2;
		private T3 item3;

		public T1 Item1
		{
			get { return item1;; }
			set { item1 = value; }
		}
        public T2 Item2
        {
            get { return item2; ; }
            set { item2 = value; }
        }

        public T3 Item3
        {
            get { return item3; ; }
            set { item3 = value; }
        }

        public override string ToString()
        {
            return $"{Item1} -> {Item2} -> {Item3}";
        }
    }
}
