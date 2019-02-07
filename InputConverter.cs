using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleCalculator
{
    class InputConverter
    {

        public double ConvertInputToNumberic(string textInput)
        {
            double convertedNumber;
            if (!double.TryParse(textInput, out convertedNumber))
            {
                throw new ArgumentException("Expected a number value.");
            }
            return convertedNumber;
        }

    }
}
