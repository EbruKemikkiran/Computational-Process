using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Computational_Process
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double number1, number2;
            double exponent1;


            number1 = Convert.ToDouble(textBox1.Text);
            number2 = Convert.ToDouble(textBox2.Text);


            exponent1 = Math.Pow(number1, number2);
            label3.Text = exponent1.ToString();
        }

    }
}


///////Double Calculator

//int number1;
//int square;
//number1 = Convert.ToInt32(textBox1.Text);

//square = number1 * number1;
//label3.Text = square.ToString();

/////// ////


/// Square           

//double number1, number2;
//double exponent1;


//number1 = Convert.ToDouble(textBox1.Text);
//number2 = Convert.ToDouble(textBox2.Text);

//exponent1 = Math.Pow(number1, number2);
//label3.Text = exponent1.ToString();
///////////


//////////  Squart
//private void button2_Click(object sender, EventArgs e)
//{
// double number3;
// double sqrt;

// number3 = Convert.ToDouble(textBox3.Text);


//  sqrt = Math.Sqrt(number3);
//  label6.Text = sqrt.ToString();
//}
///////////


//////MODE
/// private void button1_Click(object sender, EventArgs e)
// {
    //int number1, number2;
    //int mode;


   // number1 = Convert.ToInt32(textBox1.Text);
   // number2 = Convert.ToInt32(textBox2.Text);


   // mode = number1% number2;
   // label3.Text = mode.ToString();