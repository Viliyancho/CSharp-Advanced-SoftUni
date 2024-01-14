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

		public static void Method(List<Box<T>> boxes)
		{
			foreach (var item in boxes)
			{
				Console.WriteLine($"{typeof(T)}: {item.Text}");
			}
		}

	}
}
