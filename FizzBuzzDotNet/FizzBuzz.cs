namespace FizzBuzzDotNet;
public class FizzBuzz
{
	public string Execute(int input)
	{
		if (input % 3 == 0)
		{
			return "Fizz";
		}
		return input.ToString();
	}
}
