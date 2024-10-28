using System.Globalization;
using Microsoft.AspNetCore.Mvc;

namespace CalculatorApi.Controllers.V1
{
    [ApiController]
    [Route("api/[controller]/v1")]
    public class CalculatorController : ControllerBase
    {
        private readonly ILogger<CalculatorController> _logger;

        public CalculatorController(ILogger<CalculatorController> logger)
        {
            _logger = logger;
        }

        [HttpGet("sum/{firstValue}/{secondValue}")]
        public IActionResult Sum(string firstValue, string secondValue)
        {
            if (IsNumber(firstValue) && IsNumber(secondValue))
            {
                double result = ConvertToNumber(firstValue) + ConvertToNumber(secondValue);
                return Ok(result.ToString());
            }
            return BadRequest("Request with invalid input");
        }

        [HttpGet("subtraction/{firstValue}/{secondValue}")]
        public IActionResult Subtraction(string firstValue, string secondValue)
        {
            if (IsNumber(firstValue) && IsNumber(secondValue))
            {
                double result = ConvertToNumber(firstValue) - ConvertToNumber(secondValue);
                return Ok(result.ToString());
            }
            return BadRequest("Request with invalid input");
        }

        [HttpGet("multiplication/{firstValue}/{secondValue}")]
        public IActionResult Multiplication(string firstValue, string secondValue)
        {
            if (IsNumber(firstValue) && IsNumber(secondValue))
            {
                double result = ConvertToNumber(firstValue) * ConvertToNumber(secondValue);
                return Ok(result.ToString());
            }
            return BadRequest("Request with invalid input");
        }

        [HttpGet("division/{firstValue}/{secondValue}")]
        public IActionResult Division(string firstValue, string secondValue)
        {
            if (IsNumber(firstValue) && IsNumber(secondValue))
            {
                double result = ConvertToNumber(firstValue) / ConvertToNumber(secondValue);
                return Ok(result.ToString());
            }
            return BadRequest("Request with invalid input");
        }                

        [HttpGet("percentage/{firstValue}/{secondValue}")]
        public IActionResult Percentage(string firstValue, string secondValue)
        {
            if (IsNumber(firstValue) && IsNumber(secondValue))
            {
                double result = ConvertToNumber(firstValue) * ConvertToNumber(secondValue) / 100;
                return Ok(result.ToString());
            }
            return BadRequest("Request with invalid input");
        }

        private bool IsNumber(string value) => double.TryParse(value, NumberStyles.Any, NumberFormatInfo.InvariantInfo, out _);

        private double ConvertToNumber(string value) => double.Parse(value.Replace(',', '.'), NumberFormatInfo.InvariantInfo);
        
    }
}