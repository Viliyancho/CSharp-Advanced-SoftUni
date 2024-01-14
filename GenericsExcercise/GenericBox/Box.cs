namespace GenericBox
{
    public class Box<T>
    {
		private int text;

		public int Text
		{
			get { return text; }
			set { text = value; }
		}

		public override string ToString()
		{
			return $"{typeof(int)}: {text}";
		}

	}
}
