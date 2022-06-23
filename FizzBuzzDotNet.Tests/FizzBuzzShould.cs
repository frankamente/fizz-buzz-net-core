using FizzBuzzDotNet;
namespace FizzBuzzDotNet.UnitTests;
public class FizzBuzzShould
{

	[Fact]
	public void FizzBuzz_InputIs1_Return1()
	{
		var fizzBuzz = new FizzBuzz();
		String result = fizzBuzz.Execute(1);

		Assert.Equal("1", result);
	}
}