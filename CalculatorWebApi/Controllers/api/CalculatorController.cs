using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CalculatorWebApi.Controllers.api
{
    public class CalculatorController : ApiController
    {
        // GET api/<controller>

        [HttpGet]
        public double Calculate(double firstvalue, double secondvalue, string operation)
        {
            if (secondvalue == 0 && operation.ToLower() == "divide")
            {
                var message = string.Format("Cannot divide by Zero");
                throw new DivideByZeroException(message);
            }
            double output = 0;
            switch (operation.ToLower())
            {
                case "add":
                    output = firstvalue + secondvalue;
                    break;
                case "substract":
                    output = firstvalue - secondvalue;
                    break;
                case "multiply":
                    output = firstvalue * secondvalue;
                    break;
                case "divide":
                    output = firstvalue / secondvalue;
                    break;
            }
            return output;
        }
    }
}