using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1
{
    public class Calculator
    {

        public Calculator() { }

        public double DoOperation(double num1, double num2, string op)
        {
            double result = double.NaN;
            // Default value// Use a switch statement to do the math.
            switch (op)
            {
                case "a":
                    result = Add(num1, num2);
                    break;
                case "s":
                    result = Subtract(num1, num2);
                    break;
                case "m":
                    result = Multiply(num1, num2);
                    break;
                case "d":
                    // Ask the user to enter a non-zero divisor.
                    result = Divide(num1, num2);
                    break;
                    // Return text for an incorrect option entry.default:break
            }
            return result;
        }
        public double Add(double num1, double num2)
        {
            return (num1 + num2);
        }
        public double Subtract(double num1, double num2)
        {
            return (num1 - num2);
        }
        public double Multiply(double num1, double num2)
        {
            return (num1 * num2);
        }
        public double Divide(double num1, double num2)
        {
            if (num1 == 0 && num2 == 0)
                return 1;
            else if (num2 == 0)
                return double.PositiveInfinity;
            return (num1 / num2);
        }
        public double Availability(double mttf, double mttr)
        {
            return (mttf / (mttf+mttr));
        }
        public double MTBF(double mttf, double mttr)
        {
            return (mttf + mttr);
        }

        public int Factorial(int num)
        {
            if (num < 0)
                throw new System.ArgumentException("Cannot factorial negative number");

            int fnum = 1;
            for(int i=num; i>=1; i--)
            {
                fnum = fnum * i;
            }
            return fnum;
        }

        public double TriangleArea(double height, double base_of_triangle)
        {
            if (height < 0 || base_of_triangle < 0)
                throw new System.ArgumentException("Triangles have no negative height or base");
            return 0.5 * height * base_of_triangle;
        }
    }
}
