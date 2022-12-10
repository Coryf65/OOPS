namespace ClassLibraryExample
{
	public class Class1
	{
		public void Hello()
		{
			Console.WriteLine("Hello from Class Library Example");
		}

		internal void YouCannotAccessInZoo()
		{
			Console.WriteLine("you cannot see me..");
		}
	}
}