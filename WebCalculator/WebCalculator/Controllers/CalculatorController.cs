using Microsoft.AspNetCore.Mvc;

namespace WebCalculator.Controllers;

[ApiController]
[Route("/calculator")]
public class CalculatorController : ControllerBase
{
    private Calculator _calculator;
    
    public CalculatorController()
    {
        _calculator = new Calculator();
    }
    
    [HttpGet("add/{a}&{b}")]
    public string GetAddResult(int a, int b)
    {
        return $"Add {a} and {b}. Got {_calculator.Add(a, b)}!";
    }
    
    [HttpGet("subtract/{a}&{b}")]
    public string GetSubtractResult(int a, int b)
    {
        return $"Subtract {a} and {b}. Got {_calculator.Subtract(a, b)}!";
    }
    
    [HttpGet("multiply/{a}&{b}")]
    public string GetMultiplyResult(int a, int b)
    {
        return $"Multiply {a} and {b}. Got {_calculator.Multiply(a, b)}!";
    }
    
    [HttpGet("divide/{a}&{b}")]
    public string GetDivideResult(int a, int b)
    {
        return $"Divide {a} and {b}. Got {_calculator.Divide(a, b)}!";
    }
}