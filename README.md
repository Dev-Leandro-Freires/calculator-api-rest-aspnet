# calculator-api-rest-aspnet
API REST of a standard calculator using ASP.NET Core.
It includes endpoints with the mathematical operations: sum, subtraction, multiplication, division and percentage.


## Endpoints

### GET api/calculator/v1/sum/{firstValue}/{secondValue}
- **Description:** returns the result of the operation (firstValue + secondValue)
- **Example:** 
     `http://localhost:5198/api/calculator/v1/sum/3/5` 
     returns 8

### GET api/calculator/v1/subtraction/{firstValue}/{secondValue}
- **Description:** returns the result of the operation (firstValue - secondValue)
- **Example:** 
     `http://localhost:5198/api/calculator/v1/subtraction/100/89` 
     returns 11

### GET api/calculator/v1/multiplication/{firstValue}/{secondValue}
- **Description:** returns the result of the operation (firstValue x secondValue)
- **Example:** 
     `http://localhost:5198/api/calculator/v1/multiplication/8/6` 
     returns 48

### GET api/calculator/v1/division/{firstValue}/{secondValue}
- **Description:** returns the result of the operation (firstValue ÷ secondValue)
- **Example:** 
     `http://localhost:5198/api/calculator/v1/division/70/14` 
     returns 5

### GET api/calculator/v1/percentage/{firstValue}/{secondValue}
- **Description:** returns the result of (firstValue % of secondValue)
- **Example:** 
     `http://localhost:5198/api/calculator/v1/percentage/1/200` 
     returns 2