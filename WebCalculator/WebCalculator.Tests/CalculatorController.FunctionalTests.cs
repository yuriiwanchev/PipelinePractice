using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace WebCalculator.Tests;

[TestFixture]
public class CalculatorControllerFunctionalTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void GetAdd_1plus2_getResponse()
    {
        using var browser = new ChromeDriver();
        browser.Navigate().GoToUrl("https://localhost:5001/calculator/add/1&2");
        Assert.AreEqual("Add 1 and 2. Got 3!", browser.FindElement(By.TagName("body")).Text);
    }
    
    [Test]
    public void GetSubtract_6sub4_getResponse()
    {
        using var browser = new ChromeDriver();
        browser.Navigate().GoToUrl("https://localhost:5001/calculator/subtract/6&4");
        Assert.AreEqual("Subtract 6 and 4. Got 2!", browser.FindElement(By.TagName("body")).Text);
    }
    
    [Test]
    public void GetMultiply_8mult8_getResponse()
    {
        using var browser = new ChromeDriver();
        browser.Navigate().GoToUrl("https://localhost:5001/calculator/multiply/8&8");
        Assert.AreEqual("Multiply 8 and 8. Got 64!", browser.FindElement(By.TagName("body")).Text);
    }
    
    [Test]
    public void GetDivide_8div2_getResponse()
    {
        using var browser = new ChromeDriver();
        browser.Navigate().GoToUrl("https://localhost:5001/calculator/divide/8&2");
        Assert.AreEqual("Divide 8 and 2. Got 4!", browser.FindElement(By.TagName("body")).Text);
    }
}