using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _06.Calculator
{
    public partial class _default : System.Web.UI.Page
    {
        private static Mode mode;
        private static decimal number;
        private static bool cleanTb;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                this.TbResult.Text = "0";
                mode = Mode.Nothing;
                number = 0;
                cleanTb = false;
            }
        }

        protected void BtnEquals_Click(object sender, EventArgs e)
        {
            CalculatePreviousState(true);
        }

        protected void Btn_Click(object sender, EventArgs e)
        {
            if (cleanTb)
            {
                this.TbResult.Text = "";
                cleanTb = false;
            }
            string BtnId = ((Button)sender).ID;
            decimal num = GetNumber(BtnId);
            if (this.TbResult.Text == "0")
            {
                this.TbResult.Text = num.ToString();
            }
            else
            {
                this.TbResult.Text = TbResult.Text + num;
            }
        }

        private decimal GetNumber(string BtnId)
        {
            decimal num = 0;
            switch (BtnId)
            {
                case "Btn1":
                    num = 1;
                    break;
                case "Btn2":
                    num = 2;
                    break;
                case "Btn3":
                    num = 3;
                    break;
                case "Btn4":
                    num = 4;
                    break;
                case "Btn5":
                    num = 5;
                    break;
                case "Btn6":
                    num = 6;
                    break;
                case "Btn7":
                    num = 7;
                    break;
                case "Btn8":
                    num = 8;
                    break;
                case "Btn9":
                    num = 9;
                    break;
                case "BtnPI":
                    num = (decimal)Math.PI;
                    break;
                default:
                    break;
            }
            return num;
        }

        protected void BtnClear_Click(object sender, EventArgs e)
        {
            this.TbResult.Text = "";
            mode = Mode.Nothing;
            this.TbResult.Text = "0";
        }

        protected void BtnOperation_Click(object sender, EventArgs e)
        {
            string BtnId = ((Button)sender).ID;
            switch (BtnId)
            {
                case "BtnPlus":
                    Plus();
                    break;
                case "BtnMinus":
                    Minus();
                    break;
                case "BtnMultiply":
                    Multiply();
                    break;
                case "BtnDevide":
                    Devide();
                    break;
                case "BtnSqrt":
                    Sqrt();
                    break;
            }
            cleanTb = true;
        }

        private void Sqrt()
        {
            number = Decimal.Parse(this.TbResult.Text);
            TbResult.Text = Math.Sqrt((double)number).ToString();
        }

        private void Multiply()
        {
            CalculatePreviousState();
            mode = Mode.Multiply;
        }

        private void Devide()
        {
            CalculatePreviousState();
            mode = Mode.Devide;
        }

        private void Minus()
        {
            CalculatePreviousState();
            mode = Mode.Minus;
        }

        private void Plus()
        {
            CalculatePreviousState();
            mode = Mode.Plus;
        }

        private void CalculatePreviousState(bool equal = false)
        {
            decimal result = 0;
            decimal currNumber = Decimal.Parse(this.TbResult.Text);
            try
            {
                switch (mode)
                {
                    case Mode.Nothing:
                        number = Decimal.Parse(this.TbResult.Text);
                        result = number;
                        break;
                    case Mode.Plus:
                        result = number + currNumber;
                        break;
                    case Mode.Minus:
                        result = number - currNumber;
                        break;
                    case Mode.Multiply:
                        result = number * currNumber;
                        break;
                    case Mode.Devide:
                        if (currNumber != 0)
                        {
                            result = number / currNumber;
                        }
                        else
                        {
                            throw new DivideByZeroException();
                        }
                        break;
                    case Mode.Sqrt:
                        result = (decimal)Math.Sqrt((double)number);
                        break;
                }
                this.TbResult.Text = result.ToString();
                number = result;
                if (equal)
                {
                    mode = Mode.Nothing;
                    number = 0;
                }
            }
            catch (DivideByZeroException)
            {
                this.TbResult.Text = "Cannot devide by 0";
            }
        }

    }
}