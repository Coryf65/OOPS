namespace DungeonsOfDoom
{
	static class RandomUtils
	{
		// a seed of 100 is passed in, this way we could generate the same levels
		private static Random _random = new(100);

		public static int Percentage()
		{
			return _random.Next(1, 100 + 1); // 1 - 100
		}

		public static int DiceRoll(int sides)
		{
			return _random.Next(1, sides + 1);
		}
	}
}