namespace Calculator.Tests;

public class CalculatorTests
{
    [Fact]
    public void TestAdd()
    {
        Assert.Equal(6L, Add.Eval(1L, 5L));
    }
    [Fact]
    public void TestSubstract()
    {
        Assert.Equal(7L, Subtract.Eval(8L, 1L));
    }
    [Fact]
    public void TestMult()
    {
        Assert.Equal(6L, Multiply.Eval(2L, 3L));
    }

    [Fact]
    public void TestDivide()
    {
        Assert.Equal(3L, Divide.Eval(12L, 4L));
    }

    [Fact]
    public void TestAddOperation()
    {
        Assert.Equal(8, Evaluator.Eval("+", 6, 2));
    }
    [Fact]
    public void TestSubstractOperation()
    {
        Assert.Equal(4, Evaluator.Eval("-", 6, 2));
    }
    [Fact]
    public void TestMultiplyOperation()
    {
        Assert.Equal(12, Evaluator.Eval("*", 6, 2));
    }
    [Fact]
    public void TestDevideOperation()
    {
        Assert.Equal(2, Evaluator.Eval("/", 10, 5));
    }
	[Fact]
	public void TestSequentialOperations()
	{
		float result1 = Evaluator.Eval("+", 4, 2);
		float result2 = Evaluator.Eval("*", result1, 2);
		Assert.Equal(12, result2);
	}
}