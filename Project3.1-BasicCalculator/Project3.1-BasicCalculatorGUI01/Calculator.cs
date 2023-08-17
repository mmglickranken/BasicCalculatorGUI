using System;

namespace Project3._1_BasicCalculatorGUI01
{
    public class Calculator
    {
        // *************************************************************************************************************

        // Declare and initialize private Calculator class instance variables:
        // displayString will hold the answer as a string, that will currently display into the label.
        private string displayString = "";

        // isNewValue will control the numeric entry, using a Boolean value.
        private bool isNewValue;

        // hasDecimalPoint will track whether the display string has a decimal point, using a Boolean value.
        private bool hasDecimalPoint;

        // operand1 will store the value of the first operand as a decimal.
        private decimal operand1;

        // operand2 will store the value of the second operand as a decimal.
        private decimal operand2;

        // op will hold all seven constants (mathematical operations) as an enumeration.
        private enum Operation
        {
            Add, Subtract, Multiply, Divide, SquareRoot, Reciprocal, None
        };

        // This is the enumeration variable. This Operation type that will store a member of the Operation enumeration.
        private Operation operation;

        // *************************************************************************************************************

        // The following is the empty constructor.
        public Calculator()
        {
            Clear();
        }

        public void Clear()
        {
            displayString = "";

            isNewValue      = false;
            hasDecimalPoint = false;

            operand1 = 0;
            operand2 = 0;

            operation = Operation.None;
        }

        // The following is the properties. Line #56 will default lblAnswer to "0".
        public string DisplayString => string.IsNullOrEmpty(displayString) ? "0" : displayString;

        // This is a less efficient way to write line #56.
        //public string DisplayString()
        //{
        //    //return string.IsNullOrEmpty(displayString) ? "0" : displayString;
        //}

        // displayValue will be used to convert the string from lblAnswer to a decimal value.
        private Decimal displayValue => Convert.ToDecimal(DisplayString);

        // The following is the methods.
        public void Append(string contents)
        {
            if (isNewValue)
            {
                displayString = "";
        
                hasDecimalPoint = false;
                isNewValue      = false;
            }

            // If the original value of lblAnswer is "0", do not allow for more 0s to immediately be inputted.
            displayString += (displayString == "0" && contents == "0") ? "" : contents;
        }

        public void RemoveLastCharacter()
        {
            // First, make sure that there is a character to remove.
            if (!isNewValue)
            {
                int len       = displayString.Length - 1;
                displayString = displayString.Substring(0, len);
            }

            // Second, see if displayString is now empty. If it is empty, set isNewValue to true.
            if (string.IsNullOrEmpty(displayString))
            {
                isNewValue = true;
            }

            // Finally, if the character that was removed was the decimal point, set hasDecimalPoint to false.
            if (!displayString.Contains("."))
            {
                hasDecimalPoint = false;
            }
        }

        // This method will reverse the sign of the displayValue.
        public void ToggleSign() => displayString = (-displayValue).ToString();

        public void AddDecimalPoint()
        {
            // First, verify that there is not already a decimal point.
            if (!hasDecimalPoint)
            {
                if (isNewValue)
                {
                    displayString = "";

                    hasDecimalPoint = false;
                    isNewValue      = false;

                    Append("0.");
                }

                else
                {
                    Append(".");
                }

                hasDecimalPoint = true;
            }
        }

        public void Add()
        {
            SetValuesForOperation(Operation.Add);
        }

        public void Subtract()
        {
            SetValuesForOperation(Operation.Subtract);
        }

        public void Multiply()
        {
            SetValuesForOperation(Operation.Multiply);
        }

        public void Divide()
        {
            SetValuesForOperation(Operation.Divide);
        }

        public void SquareRoot()
        {
            SetValuesForOperation(Operation.SquareRoot);
        }

        public void Reciprocal()
        {
            SetValuesForOperation(Operation.Reciprocal);
        }

        public void Equals()
        {
            decimal calculatedValue = 0.0m;
                    operand2        = displayValue;

            switch (operation)
            {
                case Operation.Add:
                    calculatedValue = operand1 + operand2;
                    break;

                case Operation.Subtract:
                    calculatedValue = operand1 - operand2;
                    break;

                case Operation.Multiply:
                    calculatedValue = operand1 * operand2;
                    break;

                case Operation.Divide:
                    calculatedValue = operand1 / operand2;
                    break;

                default: break;
            }

            displayString = calculatedValue.ToString();

            isNewValue      =  true;
            hasDecimalPoint = false;

            operand1 = 0;
            operand2 = 0;

            operation = Operation.None;
        }

        // This method will handle SquareRoot as well as Reciprocal.
        private void SetValuesForOperation(Operation op)
        {
            operation = op;
            operand1  = displayValue;

            decimal calculatedValue = 0.0m;

            switch (operation)
            {
                case Operation.SquareRoot:
                    calculatedValue = (Decimal)Math.Sqrt(Convert.ToDouble(operand1));
                    break;

                case Operation.Reciprocal:
                    calculatedValue = 1 / operand1;
                    break;

                default:
                    break;
            }

            displayString = calculatedValue.ToString();

            isNewValue      =  true;
            hasDecimalPoint = false;

            operand1 = 0;
            operand2 = 0;

            operation = Operation.None;
        }
    }
}
