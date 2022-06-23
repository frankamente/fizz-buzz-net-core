using FizzBuzzDotNet;
namespace FizzBuzzDotNet.UnitTests;
public class FizzBuzzShould
{

	[Fact]
	public void FizzBuzz_InputIsNoMultipleOf3Neither5_ReturnSameNumber()
	{
		var fizzBuzz = new FizzBuzz();

		Assert.Equal("1", fizzBuzz.Execute(1));
		Assert.Equal("2", fizzBuzz.Execute(2));
		Assert.Equal("4", fizzBuzz.Execute(4));
	}

	[Fact]
	public void FizzBuzz_InputIsMultipleOf3_ReturnFizz()
	{
		var fizzBuzz = new FizzBuzz();

		Assert.Equal("Fizz", fizzBuzz.Execute(3));
		Assert.Equal("Fizz", fizzBuzz.Execute(6));
		Assert.Equal("Fizz", fizzBuzz.Execute(9));
	}
}