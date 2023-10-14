
namespace Carculator
{
    public partial class Form1 : Form
    {
        private bool buttonClicked = false;
        private bool dot_clicked = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void zero_bt_Click(object sender, EventArgs e)
        {
            if (!buttonClicked)
                num1.Text += "0";
            else if (buttonClicked)
            {
                num2.Text += "0";
            }
        }

        private void dot_bt_Click(object sender, EventArgs e)
        {

            if (!buttonClicked && !dot_clicked)
                num1.Text += ".";
            else if (buttonClicked && !dot_clicked)
            {
                num2.Text += ".";
            }
            dot_clicked = true;
        }

        private void equal_bt_Click(object sender, EventArgs e)
        {
            if (num1.Text != null && num2.Text != null)
            {
                if (operation.Text == "+")
                {
                    result.Text = Convert.ToString(Convert.ToDouble(num1.Text) + Convert.ToDouble(num2.Text));
                    operation.Text = "";
                    num2.Text = "";
                    num1.Text = result.Text;
                }
                else if (operation.Text == "-")
                {
                    result.Text = Convert.ToString(Convert.ToDouble(num1.Text) - Convert.ToDouble(num2.Text));
                    operation.Text = "";
                    num2.Text = "";
                    num1.Text = result.Text;
                }
                else if (operation.Text == "x")
                {
                    result.Text = Convert.ToString(Convert.ToDouble(num1.Text) * (Convert.ToDouble(num2.Text)));
                    operation.Text = "";
                    num2.Text = "";
                    num1.Text = result.Text;
                }
                else if (operation.Text == "/")
                {
                    result.Text = Convert.ToString(Convert.ToDouble(num1.Text) / Convert.ToDouble(num2.Text));
                    operation.Text = "";
                    num2.Text = "";
                    num1.Text = result.Text;
                }
            }
        }

        private void bolme_Click(object sender, EventArgs e)
        {
            dot_clicked = false;
            buttonClicked = true;
            if (result.Text != "")
            {
                operation.Text = "/";
                num1.Text = result.Text;
                num2.Text = "";
                result.Text = "";
            }

            else if (result.Text == "")
            {
                if (operation.Text == "")
                {
                    operation.Text = "/";
                }
                else if (num2.Text == "")
                {
                    operation.Text = "/";
                }
                else if (operation.Text == "+")
                {
                    if (num1.Text != null && num2.Text != null)
                    {

                        num1.Text = Convert.ToString(Convert.ToDouble(num1.Text) + Convert.ToDouble(num2.Text));
                        operation.Text = "/";
                        num2.Text = "";
                    }
                }

                else if (operation.Text == "-")
                {
                    if (num1.Text != null && num2.Text != null)
                    {
                        operation.Text = "/";
                        num1.Text = Convert.ToString(Convert.ToDouble(num1.Text) - Convert.ToDouble(num2.Text));
                        num2.Text = "";
                    }
                }

                else if (operation.Text == "x")
                {
                    if (num1.Text != null && num2.Text != null)
                    {
                        operation.Text = "/";
                        num1.Text = Convert.ToString(Convert.ToDouble(num1.Text) * Convert.ToDouble(num2.Text));
                        num2.Text = "";
                    }
                }

                else if (operation.Text == "/")
                {
                    if (num1.Text != null && num2.Text != null)
                    {
                        operation.Text = "/";
                        num1.Text = Convert.ToString(Convert.ToDouble(num1.Text) / Convert.ToDouble(num2.Text));
                        num2.Text = "";
                    }
                }
            }
        }

        private void nine_Click(object sender, EventArgs e)
        {
            if (!buttonClicked)
                num1.Text += "9";
            else if (buttonClicked)
            {
                num2.Text += "9";
            }
        }

        private void eight_Click(object sender, EventArgs e)
        {
            if (!buttonClicked)
                num1.Text += "8";
            else if (buttonClicked)
            {
                num2.Text += "8";
            }
        }

        private void seven_Click(object sender, EventArgs e)
        {
            if (!buttonClicked)
                num1.Text += "7";
            else if (buttonClicked)
            {
                num2.Text += "7";
            }
        }

        private void six_Click(object sender, EventArgs e)
        {
            if (!buttonClicked)
                num1.Text += "6";
            else if (buttonClicked)
            {
                num2.Text += "6";
            }
        }

        private void five_Click(object sender, EventArgs e)
        {
            if (!buttonClicked)
                num1.Text += "5";
            else if (buttonClicked)
            {
                num2.Text += "5";
            }
        }


        private void four_Click(object sender, EventArgs e)
        {
            if (!buttonClicked)
                num1.Text += "4";
            else if (buttonClicked)
            {
                num2.Text += "4";
            }
        }

        private void three_Click(object sender, EventArgs e)
        {
            if (!buttonClicked)
                num1.Text += "3";
            else if (buttonClicked)
            {
                num2.Text += "3";
            }
        }

        private void two_Click(object sender, EventArgs e)
        {
            if (!buttonClicked)
                num1.Text += "2";
            else if (buttonClicked)
            {
                num2.Text += "2";
            }


        }

        private void one_Click(object sender, EventArgs e)
        {
            if (!buttonClicked)
                num1.Text += "1";
            else if (buttonClicked)
            {
                num2.Text += "1";
            }
        }

        private void plus_Click(object sender, EventArgs e)
        {
            dot_clicked = false;
            buttonClicked = true;
            if (result.Text != "")
            {
                operation.Text = "+";
                num1.Text = result.Text;
                num2.Text = "";
                result.Text = "";
            }

            else if (result.Text == "")
            {
                if (operation.Text == "")
                {
                    operation.Text = "+";
                }
                else if (num2.Text == "")
                {
                    operation.Text = "+";
                }
                else if (operation.Text == "+")
                {
                    if (num1.Text != null && num2.Text != null)
                    {

                        num1.Text = Convert.ToString(Convert.ToDouble(num1.Text) + Convert.ToDouble(num2.Text));
                        operation.Text = "+";
                        num2.Text = "";
                    }
                }

                else if (operation.Text == "-")
                {
                    if (num1.Text != null && num2.Text != null)
                    {
                        operation.Text = "+";
                        num1.Text = Convert.ToString(Convert.ToDouble(num1.Text) - Convert.ToDouble(num2.Text));
                        num2.Text = "";
                    }
                }

                else if (operation.Text == "x")
                {
                    if (num1.Text != null && num2.Text != null)
                    {
                        operation.Text = "+";
                        num1.Text = Convert.ToString(Convert.ToDouble(num1.Text) * Convert.ToDouble(num2.Text));
                        num2.Text = "";
                    }
                }

                else if (operation.Text == "/")
                {
                    if (num1.Text != null && num2.Text != null)
                    {
                        operation.Text = "+";
                        num1.Text = Convert.ToString(Convert.ToDouble(num1.Text) / Convert.ToDouble(num2.Text));
                        num2.Text = "";
                    }
                }
            }
        }

        private void minus_Click(object sender, EventArgs e)
        {
            dot_clicked = false;
            buttonClicked = true;
            if (result.Text != "")
            {
                operation.Text = "-";
                num1.Text = result.Text;
                num2.Text = "";
                result.Text = "";
            }

            else if (result.Text == "")
            {
                if (operation.Text == "")
                {
                    operation.Text = "-";
                }
                else if (num2.Text == "")
                {
                    operation.Text = "-";
                }
                else if (operation.Text == "+")
                {
                    if (num1.Text != null && num2.Text != null)
                    {
                        num1.Text = Convert.ToString(Convert.ToDouble(num1.Text) + Convert.ToDouble(num2.Text));
                        operation.Text = "-";
                        num2.Text = "";
                    }
                }

                else if (operation.Text == "-")
                {
                    if (num1.Text != null && num2.Text != null)
                    {
                        operation.Text = "-";
                        num1.Text = Convert.ToString(Convert.ToDouble(num1.Text) - Convert.ToDouble(num2.Text));
                        num2.Text = "";
                    }
                }

                else if (operation.Text == "x")
                {
                    if (num1.Text != null && num2.Text != null)
                    {
                        operation.Text = "-";
                        num1.Text = Convert.ToString(Convert.ToDouble(num1.Text) * Convert.ToDouble(num2.Text));
                        num2.Text = "";
                    }
                }

                else if (operation.Text == "/")
                {
                    if (num1.Text != null && num2.Text != null)
                    {
                        operation.Text = "-";
                        num1.Text = Convert.ToString(Convert.ToDouble(num1.Text) / Convert.ToDouble(num2.Text));
                        num2.Text = "";
                    }
                }
            }
        }

        private void vurma_Click(object sender, EventArgs e)
        {
            dot_clicked = false;
            buttonClicked = true;
            if (result.Text != "")
            {
                operation.Text = "x";
                num1.Text = result.Text;
                num2.Text = "";
                result.Text = "";
            }

            else if (result.Text == "")
            {
                if (operation.Text == "")
                {
                    operation.Text = "x";
                }
                else if (num2.Text == "")
                {
                    operation.Text = "x";
                }
                else if (operation.Text == "+")
                {
                    if (num1.Text != null && num2.Text != null)
                    {

                        num1.Text = Convert.ToString(Convert.ToDouble(num1.Text) + Convert.ToDouble(num2.Text));
                        operation.Text = "x";
                        num2.Text = "";
                    }
                }

                else if (operation.Text == "-")
                {
                    if (num1.Text != null && num2.Text != null)
                    {
                        operation.Text = "x";
                        num1.Text = Convert.ToString(Convert.ToDouble(num1.Text) - Convert.ToDouble(num2.Text));
                        num2.Text = "";
                    }
                }

                else if (operation.Text == "x")
                {
                    if (num1.Text != null && num2.Text != null)
                    {
                        operation.Text = "x";
                        num1.Text = Convert.ToString(Convert.ToDouble(num1.Text) * Convert.ToDouble(num2.Text));
                        num2.Text = "";
                    }
                }

                else if (operation.Text == "/")
                {
                    if (num1.Text != null && num2.Text != null)
                    {
                        operation.Text = "x";
                        num1.Text = Convert.ToString(Convert.ToDouble(num1.Text) / Convert.ToDouble(num2.Text));
                        num2.Text = "";
                    }
                }
            }
        }

        private void faiz_Click(object sender, EventArgs e)
        {

        }

        private void vergul_Click(object sender, EventArgs e)
        {

        }

        private void clear_Click(object sender, EventArgs e)
        {
            num1.Text = "";
            num2.Text = "";
            operation.Text = "";
            result.Text = "";
            dot_clicked = false;
            buttonClicked = false;
        }


    }
}