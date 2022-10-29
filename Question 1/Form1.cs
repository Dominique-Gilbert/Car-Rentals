using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Question_1
{
    public partial class frm1 : Form
    {
        //Declaring the Values of the car Styles.
        const double num1 = 19.95;
        const double num2 = 24.95;
        const double num3 = 39.05;
        public frm1()
        {
            InitializeComponent();
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Checking if the combo box contains COMPACT.
                if ((string)this.cmb.SelectedItem == "COMPACT")
            {
                //Checking which radio button the user selected.
                if (rb1.Checked == true) 
                {
                    lbl1.Text = "Total is $" + Convert.ToString(num1 * 1);
                
                }
                if (rb2.Checked == true)
                {
                    lbl1.Text = "Total is $" + Convert.ToString(num1 * 2);

                }
                if (rb3.Checked == true)
                {
                    lbl1.Text = "Total is $" + Convert.ToString(num1 * 3);

                }
                if (rb4.Checked == true)
                {
                    lbl1.Text = "Total is $" + Convert.ToString(num1 * 4);

                }
                if (rb5.Checked == true)
                {
                    lbl1.Text = "Total is $" + Convert.ToString(num1 * 5);

                }
                if (rb6.Checked == true)
                {
                    lbl1.Text = "Total is $" + Convert.ToString(num1 * 6);

                }

            }
            //Checking if the combo box contains STANDARD.
            if ((string)this.cmb.SelectedItem == "STANDARD")
            {
                //Checking which radio button the user selected.
                if (rb1.Checked == true)
                {
                    lbl1.Text = "Total is $" + Convert.ToString(num2 * 1);

                }
                if (rb2.Checked == true)
                {
                    lbl1.Text = "Total is $" + Convert.ToString(num2 * 2);

                }
                if (rb3.Checked == true)
                {
                    lbl1.Text = "Total is $" + Convert.ToString(num2 * 3);

                }
                if (rb4.Checked == true)
                {
                    lbl1.Text = "Total is $" + Convert.ToString(num2 * 4);

                }
                if (rb5.Checked == true)
                {
                    lbl1.Text = "Total is $" + Convert.ToString(num2 * 5);

                }
                if (rb6.Checked == true)
                {
                    lbl1.Text = "Total is $" + Convert.ToString(num2 * 6);

                }
            }
            //Checking if the combo box contains LUXURY.
            if ((string)this.cmb.SelectedItem == "LUXURY")
            {
                //Checking which radio button the user selected.
                if (rb1.Checked == true)
                {
                    lbl1.Text = "Total is $" + Convert.ToString(num3 * 1);

                }
                if (rb2.Checked == true)
                {
                    lbl1.Text = "Total is $" + Convert.ToString(num3 * 2);

                }
                if (rb3.Checked == true)
                {
                    lbl1.Text = "Total is $" + Convert.ToString(num3 * 3);

                }
                if (rb4.Checked == true)
                {
                    lbl1.Text = "Total is $" + Convert.ToString(num3 * 4);

                }
                if (rb5.Checked == true)
                {
                    lbl1.Text = "Total is $" + Convert.ToString(num3 * 5);

                }
                if (rb6.Checked == true)
                {
                    lbl1.Text = "Total is $" + Convert.ToString(num3 * 6);

                }
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            //This closes the application in the Exit button.
            this.Close();
        }
    }
}
