namespace FizzBuzzDotNet;
public class FizzBuzz
{

	public static string FIZZ = "Fizz";
	public static string BUZZ = "Buzz";
	public static string FIZZ_BUZZ = "FizzBuzz";
	public string Execute(int input)
	{

		if (isMultipleOf3(input) && isMultipleOf5(input))
		{
			return FIZZ_BUZZ;
		}

		if (isMultipleOf3(input))
		{
			return FIZZ;
		}

		if (isMultipleOf5(input))
		{
			return BUZZ;
		}

		return input.ToString();
	}

	private bool isMultipleOf3(int input)
	{
		return input % 3 == 0;
	}

	private bool isMultipleOf5(int input)
	{
		return input % 5 == 0;
	}
}
