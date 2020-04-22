using System;
using NUnit;
using NUnit.Framework;

namespace IntegerAppearingOddNumberOfTimes
{
	[TestFixture]
	public class NumberAppearingOddNumberOfTimes
	{
		[Test]
		public void GivenNumbers_ThatHasNumbersRecurringOddNumberOfTimes_ShouldReturnNumber()
		{
			//arrange
			var numbers = new int[] { 20, 1, -1, 2, -2, 3, 3, 5, 5, 1, 2, 4, 20, 4, -1, -2, 5 };
			//act
			var expected = 5;
			var actual = EvenOrOddRecurrenceOfNumber(numbers);

			//assert
			Assert.AreEqual(expected, actual);
		}

		private int EvenOrOddRecurrenceOfNumber(int[] numbers)
		{
			int count = 0;
			foreach(var num in numbers)
			{
				for (int i = 0; i < numbers.Length; i++)
				{
					if (num == numbers[i])
						count++;
				}
				if (count % 2 != 0)
					return num;
			}
			return 0;
		}
	}
}
