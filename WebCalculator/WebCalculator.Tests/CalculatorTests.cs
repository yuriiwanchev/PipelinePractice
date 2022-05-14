using NUnit.Framework;

namespace WebCalculator.Tests;

[TestFixture]
public class Tests
{
    private Calculator _calculator = new Calculator();

    [Test]
    public void Add_5plus6_result11()
    {
        Assert.AreEqual(_calculator.Add(5, 6),11);
    }
    
    [Test]
    public void Multiply_5mult6_result30()
    {
        Assert.AreEqual(_calculator.Multiply(5, 6),30);
    }
    
    [Test]
    public void Subtract_5sub6_resultMinus1()
    {
        Assert.AreEqual(_calculator.Subtract(5, 6), -1);
    }
    
    [Test]
    public void Divide_30div6_result5()
    {
        Assert.AreEqual(_calculator.Divide(30, 6),5);
    }
}