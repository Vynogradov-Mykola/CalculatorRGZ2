using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Dias
    {
        public string Plus(string text,string SecondNumber, int bitter,int conversion)
        {

            string result = "";
            if (SecondNumber != "")
            {


                if(conversion==2)
                {
                    text = Convert.ToInt64(text, 2).ToString();
                    SecondNumber = Convert.ToInt64(SecondNumber, 2).ToString();
                }
                if(conversion==8)
                {
                    text = Convert.ToInt64(text, 8).ToString();
                    SecondNumber = Convert.ToInt64(SecondNumber, 8).ToString();
                }
                if(conversion==16)
                {
                    text = Convert.ToInt64(text, 16).ToString();
                    SecondNumber = Convert.ToInt64(SecondNumber, 16).ToString();
                }
                try
                {

                    if (bitter == 64)
                    {
                        Int64 a = Int64.Parse(text);
                        Int64 b = Int64.Parse(SecondNumber);
                        Int64 c = a + b;
                        result = c.ToString();
                    }
                    if (bitter == 32)
                    {
                        int a = Int32.Parse(text);
                        int b = Int32.Parse(SecondNumber);
                        int c = a + b;
                        result = c.ToString();
                    }
                  
                }
                catch (OverflowException)
                {
                    result = "0";

                }
                catch (FormatException)
                {
                    result = "";
                }
            }
            if (SecondNumber != "")
            {

                if (conversion == 2)
                {
                   result = Convert.ToString(Int64.Parse(result), 2);
                }
                if (conversion == 8)
                {
                    result = Convert.ToString(Int64.Parse(result), 8);
                }
                if (conversion == 16)
                {
                    result = Convert.ToString(Int64.Parse(result), 16);
                }
            }
                return result;
        }
        public string Minus(string text, string SecondNumber, int bitter,int conversion)
        {
            string result = "";

            if (SecondNumber != "")
            {
                if (conversion == 2)
                {
                    text = Convert.ToInt64(text, 2).ToString();
                    SecondNumber = Convert.ToInt64(SecondNumber, 2).ToString();
                }
                if (conversion == 8)
                {
                    text = Convert.ToInt64(text, 8).ToString();
                    SecondNumber = Convert.ToInt64(SecondNumber, 8).ToString();
                }
                if (conversion == 16)
                {
                    text = Convert.ToInt64(text, 16).ToString();
                    SecondNumber = Convert.ToInt64(SecondNumber, 16).ToString();
                }
                try
                {
                    if (bitter == 64)
                    {
                        Int64 a = Int64.Parse(text);
                        Int64 b = Int64.Parse(SecondNumber);
                        Int64 c = a - b;
                        result = c.ToString();
                    }
                    if (bitter == 32)
                    {
                        int a = Int32.Parse(text);
                        int b = Int32.Parse(SecondNumber);
                        int c = a - b;
                        result = c.ToString();
                    }
                 

                }
                catch (OverflowException)
                {
                    result = "0";

                }
                catch (FormatException)
                {
                    result = "";
                }
            }
            if (SecondNumber != "")
            {

                if (conversion == 2)
                {
                    result = Convert.ToString(Int64.Parse(result), 2);
                }
                if (conversion == 8)
                {
                    result = Convert.ToString(Int64.Parse(result), 8);
                }
                if (conversion == 16)
                {
                    result = Convert.ToString(Int64.Parse(result), 16);
                }
            }
            return result;
        }
        public string Multi(string text, string SecondNumber, int bitter,int conversion)
        {
            if (conversion == 2)
            {
                text = Convert.ToInt64(text, 2).ToString();
                SecondNumber = Convert.ToInt64(SecondNumber, 2).ToString();
            }
            if (conversion == 8)
            {
                text = Convert.ToInt64(text, 8).ToString();
                SecondNumber = Convert.ToInt64(SecondNumber, 8).ToString();
            }
            if (conversion == 16)
            {
                text = Convert.ToInt64(text, 16).ToString();
                SecondNumber = Convert.ToInt64(SecondNumber, 16).ToString();
            }
          
            string result = "";

            if (SecondNumber != "")
            {
                try
                {
                    if (bitter == 64)
                    {
                        Int64 a = Int64.Parse(text);
                        Int64 b = Int64.Parse(SecondNumber);
                        Int64 c = a * b;
                        result = c.ToString();
                    }
                    if (bitter == 32)
                    {
                        int a = Int32.Parse(text);
                        int b = Int32.Parse(SecondNumber);
                        int c = a * b;
                        result = c.ToString();
                    }
                 

                }
                catch (OverflowException)
                {
                    result = "0";

                }
                catch (FormatException)
                {
                    result = "";
                }
            }
            if (SecondNumber != "")
            {

                if (conversion == 2)
                {
                    result = Convert.ToString(Int64.Parse(result), 2);
                }
                if (conversion == 8)
                {
                    result = Convert.ToString(Int64.Parse(result), 8);
                }
                if (conversion == 16)
                {
                    result = Convert.ToString(Int64.Parse(result), 16);
                }
            }
            return result;
        }
        public string Divide(string text, string SecondNumber,int bitter,int conversion)
        {
            string result = "";

            if (SecondNumber != "")
            {
                if (conversion == 2)
                {
                    text = Convert.ToInt64(text, 2).ToString();
                    SecondNumber = Convert.ToInt64(SecondNumber, 2).ToString();
                }
                if (conversion == 8)
                {
                    text = Convert.ToInt64(text, 8).ToString();
                    SecondNumber = Convert.ToInt64(SecondNumber, 8).ToString();
                }
                if (conversion == 16)
                {
                    text = Convert.ToInt64(text, 16).ToString();
                    SecondNumber = Convert.ToInt64(SecondNumber, 16).ToString();
                }
                try
                {
                    if (bitter == 64)
                    {
                        Int64 a = Int64.Parse(text);
                        Int64 b = Int64.Parse(SecondNumber);
                        Int64 c = a / b;
                        result = c.ToString();
                    }
                    if (bitter == 32)
                    {
                        int a = Int32.Parse(text);
                        int b = Int32.Parse(SecondNumber);
                        int c = a / b;
                        result = c.ToString();
                    }
                 

                }
                catch (OverflowException)
                {
                    result = "0";

                }
                catch (DivideByZeroException)
                {
                    result = "Divide by zero exception";
                }
                catch (FormatException)
                {
                    result = "";
                }
            }
            if (SecondNumber != "")
            {

                if (conversion == 2)
                {
                    result = Convert.ToString(Int64.Parse(result), 2);
                }
                if (conversion == 8)
                {
                    result = Convert.ToString(Int64.Parse(result), 8);
                }
                if (conversion == 16)
                {
                    result = Convert.ToString(Int64.Parse(result), 16);
                }
            }
            return result;
        }
        public string Percent(string text, string SecondNumber,int bitter,int conversion)
        {
            string result = "";

            if (SecondNumber != "")
            {
                if (conversion == 2)
                {
                    text = Convert.ToInt64(text, 2).ToString();
                    SecondNumber = Convert.ToInt64(SecondNumber, 2).ToString();
                }
                if (conversion == 8)
                {
                    text = Convert.ToInt64(text, 8).ToString();
                    SecondNumber = Convert.ToInt64(SecondNumber, 8).ToString();
                }
                if (conversion == 16)
                {
                    text = Convert.ToInt64(text, 16).ToString();
                    SecondNumber = Convert.ToInt64(SecondNumber, 16).ToString();
                }
                try
                {
                    if (bitter == 64)
                    {
                        Int64 a = Int64.Parse(text);
                        Int64 b = Int64.Parse(SecondNumber);
                        Int64 c = a % b;
                        result = c.ToString();
                    }
                    if (bitter == 32)
                    {
                        int a = Int32.Parse(text);
                        int b = Int32.Parse(SecondNumber);
                        int c = a % b;
                        result = c.ToString();
                    }
                  

                }
                catch (OverflowException)
                {
                    result = "0";

                }
                catch (FormatException)
                {
                   result = "";
                }
            }
            if (SecondNumber != "")
            {

                if (conversion == 2)
                {
                    result = Convert.ToString(Int64.Parse(result), 2);
                }
                if (conversion == 8)
                {
                    result = Convert.ToString(Int64.Parse(result), 8);
                }
                if (conversion == 16)
                {
                    result = Convert.ToString(Int64.Parse(result), 16);
                }
            }
            return result;
        }
        public string Sqrt(string text, string SecondNumber,int bitter,int conversion)
        {
            string result = "";


            try
            {
                if (conversion == 2)
                {
                    text = Convert.ToInt64(text, 2).ToString();
                    SecondNumber = Convert.ToInt64(SecondNumber, 2).ToString();
                }
                if (conversion == 8)
                {
                    text = Convert.ToInt64(text, 8).ToString();
                    SecondNumber = Convert.ToInt64(SecondNumber, 8).ToString();
                }
                if (conversion == 16)
                {
                    text = Convert.ToInt64(text, 16).ToString();
                    SecondNumber = Convert.ToInt64(SecondNumber, 16).ToString();
                }
                if (bitter == 64)
                {
                    Int64 a = Int64.Parse(text);
                    double c = Convert.ToDouble(a);
                    c = Math.Sqrt(c);
                    result = Convert.ToInt64(c).ToString();
                }
                if (bitter == 32)
                {
                    int a = Int32.Parse(text);
                    double c = Convert.ToDouble(a);
                    c = Math.Sqrt(c);
                    result = Convert.ToInt32(c).ToString();
                }
              
             

            }
            catch (OverflowException)
            {
                result = "0";

            }
            catch (FormatException)
            {
                result = "";
            }
            catch (ArgumentException)
            {
                result = "";
            }
            if (SecondNumber != "")
            {

                if (conversion == 2)
                {
                    result = Convert.ToString(Int64.Parse(result), 2);
                 
                }
                if (conversion == 8)
                {
                    result = Convert.ToString(Int64.Parse(result), 8);
                }
                if (conversion == 16)
                {
                    result = Convert.ToString(Int64.Parse(result), 16);
                }
            }
            return result;
        }

    }
}
