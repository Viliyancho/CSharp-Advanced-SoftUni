using System.Data;

namespace GenericSwapMethod
{
    public class Box<T>
    {
		private T text;

		public T Text
		{
			get { return text; }
			set { text = value; }
		}

		public static int Method<T>(List<Box<T>> boxes, T element) where T : IComparable<T>
		{
			int count = 0;
			foreach (var item in boxes)
			{
				if(item.Text.CompareTo(element) == 1)
				{
					count++;
				}
			}

			return count;
		}

	}
}
