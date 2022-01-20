using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        public bool AreDo = false;
        public char Dia;
        string SecondNumber = "";
        public int bitter=32;
        public int conversion = 10;
        public int prevconversion = 10;
        private void btn_1_Click(object sender, EventArgs e)
        {
            if (AreDo == false) textBox1.Text += "1";
            if (AreDo == true) SecondNumber += "1";
        }

        private void btn_0_Click(object sender, EventArgs e)
        {
            if (AreDo == false) textBox1.Text += "0";
            if (AreDo == true) SecondNumber += "0";

        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            if (AreDo == false) textBox1.Text += "2";
            if (AreDo == true) SecondNumber += "2";

        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            if (AreDo == false) textBox1.Text += "3";
            if (AreDo == true) SecondNumber += "3";

        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            if (AreDo == false) textBox1.Text += "4";
            if (AreDo == true) SecondNumber += "4";

        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            if (AreDo == false) textBox1.Text += "5";
            if (AreDo == true) SecondNumber += "5";

        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            if (AreDo == false) textBox1.Text += "6";
            if (AreDo == true) SecondNumber += "6";

        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            if (AreDo == false) textBox1.Text += "7";
            if (AreDo == true) SecondNumber += "7";

        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            if (AreDo == false) textBox1.Text += "8";
            if (AreDo == true) SecondNumber += "8";

        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            if (AreDo == false) textBox1.Text += "9";
            if (AreDo == true) SecondNumber += "9";

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //////////////////
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar != 8 && (e.KeyChar < 48 || e.KeyChar > 57)) e.Handled = true;
            if (AreDo == true)
            {
                if (e.KeyChar == 48) SecondNumber += "0";
                if (e.KeyChar == 49) SecondNumber += "1";
                if (e.KeyChar == 50) SecondNumber += "2";
                if (e.KeyChar == 51) SecondNumber += "3";
                if (e.KeyChar == 52) SecondNumber += "4";
                if (e.KeyChar == 53) SecondNumber += "5";
                if (e.KeyChar == 54) SecondNumber += "6";
                if (e.KeyChar == 55) SecondNumber += "7";
                if (e.KeyChar == 56) SecondNumber += "8";
                if (e.KeyChar == 57) SecondNumber += "9";
                e.Handled = true;
            }
            if (e.KeyChar == 43)
            {
                Dia = '+';
                AreDo = true;
            }
            if (e.KeyChar == 45)
            {
                Dia = '-';
                AreDo = true;
            }
            if (e.KeyChar == 42)
            {
                Dia = '*';
                AreDo = true;
            }
            if (e.KeyChar == 47)
            {
                Dia = '/';
                AreDo = true;
            }
            if (e.KeyChar == 13)
            {
                result();
            }
        }

        private void btn_plus_Click(object sender, EventArgs e)
        {
            Dia = '+';
            AreDo = true;
        }

        public string Left()
        {
            string result = "";

            if (SecondNumber != "")
            {
                if (conversion == 2)
                {
                    textBox1.Text = Convert.ToInt64(textBox1.Text, 2).ToString();
                    SecondNumber = Convert.ToInt64(SecondNumber, 2).ToString();
                }
                if (conversion == 8)
                {
                    textBox1.Text = Convert.ToInt64(textBox1.Text, 8).ToString();
                    SecondNumber = Convert.ToInt64(SecondNumber, 8).ToString();
                }
                if (conversion == 16)
                {
                    textBox1.Text = Convert.ToInt64(textBox1.Text, 16).ToString();
                    SecondNumber = Convert.ToInt64(SecondNumber, 16).ToString();
                }
                try
                {
                    if (bitter == 64)
                    {
                        Int64 a = Int64.Parse(textBox1.Text);
                        int b = Int32.Parse(SecondNumber);
                        Int64 c = a << b;
                        result = c.ToString();
                    }
                    if (bitter == 32)
                    {
                        Int32 a = Int32.Parse(textBox1.Text);
                        int b = Int32.Parse(SecondNumber);
                        Int32 c = a << b;
                        result = c.ToString();
                    }
                  

                }
                catch (OverflowException)
                {
                    result = "0";

                }
                catch (FormatException)
                {
                    textBox1.Text = "";
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
        public string Right()
        {
            string result = "";

            if (SecondNumber != "")
            {
                if (conversion == 2)
                {
                    textBox1.Text = Convert.ToInt64(textBox1.Text, 2).ToString();
                    SecondNumber = Convert.ToInt64(SecondNumber, 2).ToString();
                }
                if (conversion == 8)
                {
                    textBox1.Text = Convert.ToInt64(textBox1.Text, 8).ToString();
                    SecondNumber = Convert.ToInt64(SecondNumber, 8).ToString();
                }
                if (conversion == 16)
                {
                    textBox1.Text = Convert.ToInt64(textBox1.Text, 16).ToString();
                    SecondNumber = Convert.ToInt64(SecondNumber, 16).ToString();
                }
                try
                {
                    if (bitter == 64)
                    {
                        Int64 a = Int64.Parse(textBox1.Text);
                        int b = Int32.Parse(SecondNumber);
                        Int64 c = a >> b;
                        result = c.ToString();
                    }
                    if (bitter == 32)
                    {
                        Int32 a = Int32.Parse(textBox1.Text);
                        int b = Int32.Parse(SecondNumber);
                        Int32 c = a >> b;
                        result = c.ToString();
                    }
                  

                }
                catch (OverflowException)
                {
                    result = "So big number";

                }
                catch (FormatException)
                {
                    textBox1.Text = "";
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
        public string RoR32()
        {


            
        string result = "";
            if (conversion == 2)
            {
                textBox1.Text = Convert.ToInt64(textBox1.Text, 2).ToString();
               
            }
            if (conversion == 8)
            {
                textBox1.Text = Convert.ToInt64(textBox1.Text, 8).ToString();
               
            }
            if (conversion == 16)
            {
                textBox1.Text = Convert.ToInt64(textBox1.Text, 16).ToString();
                
            }
            try     
            {
               
                if (bitter == 64)
                {
                    Int64 a = Int64.Parse(textBox1.Text);
                    int b = 1;
                    Int64 c = (a >> b | (a << (64 - b)));
                    result = c.ToString();
                }
                if (bitter == 32)
                {
                    Int32 a = Int32.Parse(textBox1.Text);
                    int b = 1;
                    Int32 c = (a >> b | (a << (32 - b)));
                    result = c.ToString();
                }
               

                
            }
            catch (OverflowException)
            {
                textBox1.Text = "0";
              
            }
            catch (FormatException)
            {
                textBox1.Text = "";
           
            }
          
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
            
            return result;
        }
        public string RoL32()
        {
            string result = "";
            if (conversion == 2)
            {
                textBox1.Text = Convert.ToInt64(textBox1.Text, 2).ToString();
            }
            if (conversion == 8)
            {
                textBox1.Text = Convert.ToInt64(textBox1.Text, 8).ToString();
            }
            if (conversion == 16)
            {
                textBox1.Text = Convert.ToInt64(textBox1.Text, 16).ToString();
            }
            try
            {
                if (bitter == 64)
                {
                    Int64 a = Int64.Parse(textBox1.Text);
                    int b = 1;
                    Int64 c = (a << b | (a >> (64 - b)));
                    result = c.ToString();
                }
                if (bitter == 32)
                {
                    Int32 a = Int32.Parse(textBox1.Text);
                    int b = 1;
                    Int32 c = (a << b | (a >> (32 - b)));
                    result = c.ToString();
                }
            }
            catch (OverflowException)
            {
                textBox1.Text = "So big number";
              
            }
            catch (FormatException)
            {
                textBox1.Text = "";
             
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
        public string And()
        {
            string result = "";

            if (SecondNumber != "")
            {
                if (conversion == 2)
                {
                    textBox1.Text = Convert.ToInt64(textBox1.Text, 2).ToString();
                    SecondNumber = Convert.ToInt64(SecondNumber, 2).ToString();
                }
                if (conversion == 8)
                {
                    textBox1.Text = Convert.ToInt64(textBox1.Text, 8).ToString();
                    SecondNumber = Convert.ToInt64(SecondNumber, 8).ToString();
                }
                if (conversion == 16)
                {
                    textBox1.Text = Convert.ToInt64(textBox1.Text, 16).ToString();
                    SecondNumber = Convert.ToInt64(SecondNumber, 16).ToString();
                }
                try
                {
                    if(bitter ==64)
                    {
                        Int64 a = Int64.Parse(textBox1.Text);
                        Int64 b = Int64.Parse(SecondNumber);
                        Int64 c = a & b;
                        result = c.ToString();
                    }
                    if (bitter == 32)
                    {
                        Int32 a = Int32.Parse(textBox1.Text);
                        Int32 b = Int32.Parse(SecondNumber);
                        Int32 c = a & b;
                        result = c.ToString();
                    }
                }
                catch (OverflowException)
                {
                    result = "So big number";

                }
                catch (FormatException)
                {
                    textBox1.Text = "";
                }
            }
          

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
            
            return result;
        }
        public string XOR()
        {
            string result = "";

            if (SecondNumber != "")
            {
                if (conversion == 2)
                {
                    textBox1.Text = Convert.ToInt64(textBox1.Text, 2).ToString();
                    SecondNumber = Convert.ToInt64(SecondNumber, 2).ToString();
                }
                if (conversion == 8)
                {
                    textBox1.Text = Convert.ToInt64(textBox1.Text, 8).ToString();
                    SecondNumber = Convert.ToInt64(SecondNumber, 8).ToString();
                }
                if (conversion == 16)
                {
                    textBox1.Text = Convert.ToInt64(textBox1.Text, 16).ToString();
                    SecondNumber = Convert.ToInt64(SecondNumber, 16).ToString();
                }
                try
                {
                    if (bitter == 64)
                    {
                        Int64 a = Int64.Parse(textBox1.Text);
                        Int64 b = Int64.Parse(SecondNumber);
                        Int64 c = a ^ b;
                        result = c.ToString();
                    }
                    if (bitter == 32)
                    {
                        Int32 a = Int32.Parse(textBox1.Text);
                        Int32 b = Int32.Parse(SecondNumber);
                        Int32 c = a ^ b;
                        result = c.ToString();
                    }
                }
                catch (OverflowException)
                {
                    result = "So big number";

                }
                catch (FormatException)
                {
                    textBox1.Text = "";
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
        public string OR()
        {
            string result = "";

            if (SecondNumber != "")
            {
                if (conversion == 2)
                {
                    textBox1.Text = Convert.ToInt64(textBox1.Text, 2).ToString();
                    SecondNumber = Convert.ToInt64(SecondNumber, 2).ToString();
                }
                if (conversion == 8)
                {
                    textBox1.Text = Convert.ToInt64(textBox1.Text, 8).ToString();
                    SecondNumber = Convert.ToInt64(SecondNumber, 8).ToString();
                }
                if (conversion == 16)
                {
                    textBox1.Text = Convert.ToInt64(textBox1.Text, 16).ToString();
                    SecondNumber = Convert.ToInt64(SecondNumber, 16).ToString();
                }
                try
                {
                    if (bitter == 64)
                    {
                        Int64 a = Int64.Parse(textBox1.Text);
                        Int64 b = Int64.Parse(SecondNumber);
                        Int64 c = a | b;
                        result = c.ToString();
                    }
                    if (bitter == 32)
                    {
                        Int32 a = Int32.Parse(textBox1.Text);
                        Int32 b = Int32.Parse(SecondNumber);
                        Int32 c = a | b;
                        result = c.ToString();
                    }
                }
                catch (OverflowException)
                {
                    result = "So big number";

                }
                catch (FormatException)
                {
                    textBox1.Text = "";
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
        public string NOT()
        {
            string result = "";

            if (conversion == 2)
            {
                textBox1.Text = Convert.ToInt64(textBox1.Text, 2).ToString();
            }
            if (conversion == 8)
            {
                textBox1.Text = Convert.ToInt64(textBox1.Text, 8).ToString();
            }
            if (conversion == 16)
            {
                textBox1.Text = Convert.ToInt64(textBox1.Text, 16).ToString();
            }
            try
                {
                if (bitter == 64)
                {
                    Int64 c = Int64.Parse(textBox1.Text) - Int64.Parse(textBox1.Text) - Int64.Parse(textBox1.Text) - 1;
                    result = c.ToString();
                }
                if (bitter == 32)
                {
                    int c = Int32.Parse(textBox1.Text) - Int32.Parse(textBox1.Text) - Int32.Parse(textBox1.Text) - 1;
                    result = c.ToString();
                }
                }
                catch (OverflowException)
                {
                    result = "So big number";

                }
                catch (FormatException)
                {
                    textBox1.Text = "";
                }
                catch (ArgumentNullException)
                {
                    textBox1.Text = "";
                }
           
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
            
            return result;
        }
        public void result()
        {
            string result = "0";
            if (AreDo == true)
            {
                Dias dias=new Dias();
                if (Dia == '+') result = dias.Plus(textBox1.Text,SecondNumber,bitter,conversion);
                if (Dia == '-') result = dias.Minus(textBox1.Text, SecondNumber, bitter,conversion);
                if (Dia == '*') result = dias.Multi(textBox1.Text, SecondNumber,bitter,conversion);
                if (Dia == '/') result = dias.Divide(textBox1.Text, SecondNumber,bitter,conversion);
                if (Dia == '%') result = dias.Percent(textBox1.Text, SecondNumber,bitter,conversion);
                if (Dia == 'q') result = dias.Sqrt(textBox1.Text, SecondNumber,bitter,conversion);
                if (Dia == 'L') result = Left();
                if (Dia == 'R') result = Right();
                if (Dia == '>') result = RoR32().ToString();
                if (Dia =='<')  result = RoL32().ToString();
                if (Dia == '&') result = And();
                if (Dia == 'X') result = XOR();
                if (Dia == '|') result = OR();
                if (Dia == 'N') result = NOT();
                
            }
            textBox1.Text = result;
            Dia = '0';
            AreDo = false;
            SecondNumber = "";
        }
        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            btn_result.Enabled = true;
            string result = textBox1.Text;
            if(Dia=='l'&&textBox1.Text!="")
            {
                if(conversion==2)
                {
                    if(prevconversion==8)
                    {
                        long temp = Convert.ToInt64(textBox1.Text, 8);
                        textBox1.Text= Convert.ToString(temp, 2);
                    }
                    if(prevconversion==10)
                    {
                        textBox1.Text = Convert.ToString(Int64.Parse(textBox1.Text), 2);
                    }
                    if(prevconversion==16)
                    {
                        textBox1.Text = Convert.ToInt64(textBox1.Text, 16).ToString();
                        textBox1.Text = Convert.ToString(Int64.Parse(textBox1.Text), 2);
                    }
                    prevconversion = conversion;
                    
                }
                if (conversion == 8)
                {
                    if (prevconversion == 2)
                    {
                        long temp = Convert.ToInt64(textBox1.Text,2);
                        textBox1.Text = Convert.ToString(temp, 8);
                    }
                    if (prevconversion == 10 )
                    {
                        textBox1.Text = Convert.ToString(Int64.Parse(textBox1.Text), 8);
                    }
                    if(prevconversion==16)
                    {

                       
                        int x = Convert.ToInt32(textBox1.Text, 16);
                        textBox1.Text = Convert.ToString(x, 8);
                    }
                    prevconversion = conversion;
                }
                
                if (conversion == 10)
                {
                    if (prevconversion == 2)
                    {
                        
                        textBox1.Text = Convert.ToInt64(textBox1.Text, 2).ToString();
                    }
                    if (prevconversion == 8)
                    {
                        textBox1.Text = Convert.ToInt64(textBox1.Text, 8).ToString();
                    }
                    if (prevconversion == 16)
                    {
                        
                        textBox1.Text = Convert.ToInt64(textBox1.Text, 16).ToString();
                    }
                    prevconversion = conversion;
                }
                if (conversion == 16)
                {
                    if (prevconversion == 2)
                    {
                        long temp = Convert.ToInt64(textBox1.Text, 2);
                        textBox1.Text = Convert.ToString(temp, 16);
                    }
                    if (prevconversion == 8)
                    {
                        textBox1.Text = Convert.ToInt64(textBox1.Text, 8).ToString();
                        textBox1.Text = Convert.ToString(Int64.Parse(textBox1.Text), 16);
                    }
                    if (prevconversion == 10)
                    {

                        textBox1.Text = Convert.ToString(Int64.Parse(textBox1.Text), 16);
                    }
                    prevconversion = conversion;
                }
            }

        }
        private void btn_result_Click(object sender, EventArgs e)
        {
            result();
        }
        private void btn_minus_Click(object sender, EventArgs e)
        {
            Dia = '-';
            AreDo = true;
        }
        private void btn_x_Click(object sender, EventArgs e)
        {
            Dia = '*';
            AreDo = true;

        }
        private void btn_divide_Click_1(object sender, EventArgs e)
        {
            Dia = '/';
            AreDo = true;
        }
        private void btn_minusplus_Click(object sender, EventArgs e)
        {
            try
            { int a = Int32.Parse(textBox1.Text);
                int b = a;
                b = b - a - a;
                textBox1.Text = b.ToString();
            }
            catch(FormatException)
            {
                textBox1.Text = "";
            }
            catch (OverflowException)
            {
                textBox1.Text = "So big number";

            }
        }
        private void btn_Clear_Click(object sender, EventArgs e)
        {
            
            textBox1.Text = "";
            Dia = '0';
            AreDo = false;
            SecondNumber = "";
        }
        private void btn_CE_Click(object sender, EventArgs e)
        {
            SecondNumber = "";
        }
        private void btn_back_Click(object sender, EventArgs e)
        {
            try
            {
                if (AreDo == true)
                {
                    SecondNumber = SecondNumber.Remove(SecondNumber.Length - 1, 1);
                }
                if (AreDo == false)
                {
                    textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1, 1);
                }
            }
            catch(ArgumentOutOfRangeException)
            {
                textBox1.Text = "";
            }
        }
        private void btn_percent_Click(object sender, EventArgs e)
        {
            Dia = '%';
            AreDo = true;
        }
        private void btn_sqrt_Click(object sender, EventArgs e)
        {
            Dia = 'q';
            AreDo = true;
        }
        private void btn_LSH_Click(object sender, EventArgs e)
        {
            Dia = 'L';
            AreDo = true;
        }
        private void btn_RSH_Click(object sender, EventArgs e)
        {
            Dia = 'R';
            AreDo = true;
        }
        private void btn_ROR_Click(object sender, EventArgs e)
        {
            Dia = '>';
            AreDo = true;
        }
        private void btn_ROL_Click(object sender, EventArgs e)
        {
            Dia = '<';
            AreDo = true;
        }
        private void btn_AND_Click(object sender, EventArgs e)
        {
            Dia = '&';
            AreDo = true;
        }
        private void btn_XOR_Click(object sender, EventArgs e)
        {
            Dia = 'X';
            AreDo = true;
        }
        private void btn_OR_Click(object sender, EventArgs e)
        {
            Dia = '|';
            AreDo = true;
        }
        private void btn_NOT_Click(object sender, EventArgs e)
        {
            Dia = 'N';
            AreDo = true; 
        }
        private void choose_4b_CheckedChanged(object sender, EventArgs e)
        {
            bitter = 32;
        }
        private void choose_8b_CheckedChanged(object sender, EventArgs e)
        {
            bitter = 64;
        }
        private void btn_BIN_CheckedChanged(object sender, EventArgs e)
        {
            btn_result.Enabled = false;
            btn_A.Enabled = false;
            btn_B.Enabled = false;
            btn_C.Enabled = false;
            btn_D.Enabled = false;
            btn_E.Enabled = false;
            btn_F.Enabled = false;
            btn_2.Enabled = false;
            btn_3.Enabled = false;
            btn_4.Enabled = false;
            btn_5.Enabled = false;
            btn_6.Enabled = false;
            btn_7.Enabled = false;
            btn_8.Enabled = false;
            btn_9.Enabled = false;
            conversion = 2;
            Dia = 'l';
        }
        private void btn_OCT_CheckedChanged(object sender, EventArgs e)
        {
           
            btn_result.Enabled = false;
            btn_A.Enabled = false;
            btn_B.Enabled = false;
            btn_C.Enabled = false;
            btn_D.Enabled = false;
            btn_E.Enabled = false;
            btn_F.Enabled = false;
            btn_2.Enabled = true;
            btn_3.Enabled = true;
            btn_4.Enabled = true;
            btn_5.Enabled = true;
            btn_6.Enabled = true;
            btn_7.Enabled = true;
            btn_8.Enabled = false;
            btn_9.Enabled = false;
            conversion = 8;
            Dia = 'l';
        }
        private void Choose_DEC_CheckedChanged(object sender, EventArgs e)
        {
            btn_result.Enabled = false;
            btn_A.Enabled = false;
            btn_B.Enabled = false;
            btn_C.Enabled = false;
            btn_D.Enabled = false;
            btn_E.Enabled = false;
            btn_F.Enabled = false;
            btn_2.Enabled = true;
            btn_3.Enabled = true;
            btn_4.Enabled = true;
            btn_5.Enabled = true;
            btn_6.Enabled = true;
            btn_7.Enabled = true;
            btn_8.Enabled = true;
            btn_9.Enabled = true;
            conversion = 10;
            Dia = 'l';
        }
        private void choose_HEX_CheckedChanged(object sender, EventArgs e)
        {
            btn_A.Enabled = true;
            btn_B.Enabled = true;
            btn_C.Enabled = true;
            btn_D.Enabled = true;
            btn_E.Enabled = true;
            btn_F.Enabled = true;
            btn_2.Enabled = true;
            btn_3.Enabled = true;
            btn_4.Enabled = true;
            btn_5.Enabled = true;
            btn_6.Enabled = true;
            btn_7.Enabled = true;
            btn_8.Enabled = true;
            btn_9.Enabled = true;
            btn_result.Enabled = false;
            conversion = 16;
            Dia = 'l';
        }
        private void btn_A_Click(object sender, EventArgs e)
        {
            textBox1.Text += "a";
        }
        private void btn_B_Click(object sender, EventArgs e)
        {
            textBox1.Text += "b";
        }
        private void btn_C_Click(object sender, EventArgs e)
        {
            textBox1.Text += "c";
        }
        private void btn_D_Click(object sender, EventArgs e)
        {
            textBox1.Text += "d";
        }
        private void btn_E_Click(object sender, EventArgs e)
        {
            textBox1.Text += "e";
        }
        private void btn_F_Click(object sender, EventArgs e)
        {
            textBox1.Text += "f";
        }
        public string MMM="";
        public string secondMMM;
        public int MMMConversion=0;
        private void btn_MS_Click(object sender, EventArgs e)
        {
            MMM = textBox1.Text;
            MMMConversion = conversion;
        }

        private void btn_MR_Click(object sender, EventArgs e)
        {
            textBox1.Text = MMM;
           if(MMMConversion==16)
            {
                if(conversion==2)
                {
                    textBox1.Text = Convert.ToInt64(textBox1.Text, 16).ToString();
                    textBox1.Text = Convert.ToString(Int64.Parse(textBox1.Text), 2);
                }
                if(conversion==8)
                {
                    int x = Convert.ToInt32(textBox1.Text, 16);
                    textBox1.Text = Convert.ToString(x, 8);
                }
                if(conversion==10)
                {
                    textBox1.Text = Convert.ToInt64(textBox1.Text, 16).ToString();
                }
            }
            if (MMMConversion == 10)
            {
                if (conversion == 2)
                {
                    textBox1.Text = Convert.ToString(Int64.Parse(textBox1.Text), 2);
                }
                if (conversion == 8)
                {
                    textBox1.Text = Convert.ToString(Int64.Parse(textBox1.Text), 8);
                }
                if (conversion == 16)
                {
                    textBox1.Text = Convert.ToString(Int64.Parse(textBox1.Text), 16);
                }
            }
            if (MMMConversion == 8)
            {
                if (conversion == 2)
                {
                    long temp = Convert.ToInt64(textBox1.Text, 8);
                    textBox1.Text = Convert.ToString(temp, 2);
                }
                if (conversion == 10)
                {
                    textBox1.Text = Convert.ToInt64(textBox1.Text, 8).ToString();
                }
                if (conversion == 16)
                {
                    textBox1.Text = Convert.ToInt64(textBox1.Text, 8).ToString();
                    textBox1.Text = Convert.ToString(Int64.Parse(textBox1.Text), 16);
                }
            }
            if (MMMConversion == 2)
            {
                if (conversion == 8)
                {
                    long temp = Convert.ToInt64(textBox1.Text, 2);
                    textBox1.Text = Convert.ToString(temp, 8);
                }
                if (conversion == 10)
                {
                    textBox1.Text = Convert.ToInt64(textBox1.Text, 2).ToString();

                }
                if (conversion == 16)
                {
                    long temp = Convert.ToInt64(textBox1.Text, 2);
                    textBox1.Text = Convert.ToString(temp, 16);
                }
            }
        }

        private void btn_MC_Click(object sender, EventArgs e)
        {
            MMM = "";
        }

        private void btn_MP_Click(object sender, EventArgs e)
        {
            secondMMM = textBox1.Text;
            if (MMMConversion == 2)
            {
               MMM = Convert.ToInt64(MMM, 2).ToString();
                secondMMM = Convert.ToInt64(textBox1.Text, 2).ToString();
                MMMConversion = 10;
            }
            if (MMMConversion == 8)
            {
                MMM = Convert.ToInt64(MMM, 8).ToString();
                secondMMM = Convert.ToInt64(textBox1.Text, 8).ToString();
                MMMConversion = 10;
            }
            if (MMMConversion == 16)
            {
                MMM = Convert.ToInt64(MMM, 16).ToString();
                secondMMM = Convert.ToInt64(textBox1.Text, 16).ToString();
                MMMConversion = 10;
            }
           
                try
                {

                    if (bitter == 64)
                    {
                       
                        Int64 c = Int64.Parse(MMM) + Int64.Parse(secondMMM);
                    if (conversion == 2)
                    {
                       MMM = Convert.ToString(c, 2);
                    }
                    if (conversion == 8)
                    {
                        MMM = Convert.ToString(c, 8);

                    }
                    if (conversion == 16)
                    {
                        MMM = Convert.ToString(c, 16);

                    }
                   if(conversion==10) MMM = c.ToString();
                    }
                    if (bitter == 32)
                    {
                        Int32 c = Int32.Parse(MMM) + Int32.Parse(secondMMM);

                    if (conversion == 2)
                    {
                        MMM = Convert.ToString(c, 2);
                    }
                    if (conversion == 8)
                    {
                        MMM = Convert.ToString(c, 8);

                    }
                    if (conversion == 16)
                    {
                        MMM = Convert.ToString(c, 16);

                    }
                    if (conversion == 10) MMM = c.ToString();
                }

                }
                catch (OverflowException)
                {
                    textBox1.Text = "0";

                }
                catch (FormatException)
                {
                    textBox1.Text = "";
                }
            
        }

        private void btn_MM_Click(object sender, EventArgs e)
        {
            secondMMM = textBox1.Text;
            if (MMMConversion == 2)
            {
                MMM = Convert.ToInt64(MMM, 2).ToString();
                secondMMM = Convert.ToInt64(textBox1.Text, 2).ToString();
                MMMConversion = 10;
            }
            if (MMMConversion == 8)
            {
                MMM = Convert.ToInt64(MMM, 8).ToString();
                secondMMM = Convert.ToInt64(textBox1.Text, 8).ToString();
                MMMConversion = 10;
            }
            if (MMMConversion == 16)
            {
                MMM = Convert.ToInt64(MMM, 16).ToString();
                secondMMM = Convert.ToInt64(textBox1.Text, 16).ToString();
                MMMConversion = 10;
            }

            try
            {

                if (bitter == 64)
                {

                    Int64 c = Int64.Parse(MMM) - Int64.Parse(secondMMM);
                    if (conversion == 2)
                    {
                        MMM = Convert.ToString(c, 2);
                    }
                    if (conversion == 8)
                    {
                        MMM = Convert.ToString(c, 8);

                    }
                    if (conversion == 16)
                    {
                        MMM = Convert.ToString(c, 16);

                    }
                    if (conversion == 10) MMM = c.ToString();
                }
                if (bitter == 32)
                {
                    Int32 c = Int32.Parse(MMM) - Int32.Parse(secondMMM);

                    if (conversion == 2)
                    {
                        MMM = Convert.ToString(c, 2);
                    }
                    if (conversion == 8)
                    {
                        MMM = Convert.ToString(c, 8);

                    }
                    if (conversion == 16)
                    {
                        MMM = Convert.ToString(c, 16);

                    }
                    if (conversion == 10) MMM = c.ToString();
                }

            }
            catch (OverflowException)
            {
                textBox1.Text = "0";

            }
            catch (FormatException)
            {
                textBox1.Text = "";
            }
        }
    }
}
