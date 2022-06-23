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

		Assert.Equal(FizzBuzz.FIZZ, fizzBuzz.Execute(3));
		Assert.Equal(FizzBuzz.FIZZ, fizzBuzz.Execute(6));
		Assert.Equal(FizzBuzz.FIZZ, fizzBuzz.Execute(9));
	}

	[Fact]
	public void FizzBuzz_InputIsMultipleOf5_ReturnBuzz()
	{
		var fizzBuzz = new FizzBuzz();

		Assert.Equal(FizzBuzz.BUZZ, fizzBuzz.Execute(5));
		Assert.Equal(FizzBuzz.BUZZ, fizzBuzz.Execute(10));
		Assert.Equal(FizzBuzz.BUZZ, fizzBuzz.Execute(20));
	}

	[Fact]
	public void FizzBuzz_InputIsMultipleOf3And5_ReturnFizzBuzz()
	{
		var fizzBuzz = new FizzBuzz();

		Assert.Equal(FizzBuzz.FIZZ_BUZZ, fizzBuzz.Execute(15));
		Assert.Equal(FizzBuzz.FIZZ_BUZZ, fizzBuzz.Execute(30));
		Assert.Equal(FizzBuzz.FIZZ_BUZZ, fizzBuzz.Execute(45));
	}
}