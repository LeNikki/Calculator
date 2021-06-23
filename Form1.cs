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
        double value = 0;  
        string operand = "";
        bool process = false;
        public Calculator()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Will set function for each number button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Number (object sender, EventArgs e)
        {
            if  ((Output.Text == "0") || (process == true))
            {  Output.Clear();  }       //will clear the screen
            process = false;            //to keep on screen next input after operation
            Button bt = (Button)sender;
            Output.Text = Output.Text + bt.Text; //shows what is on the text box 
                                                 //+ new button to be clicked
        }
        
        /// <summary>
        /// This will determine which operations are pressed.
        /// Added to events of each operation buttons.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Operator_Click(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            operand = bt.Text; //will hold the operation clicked                               
            process = true;    //if an operator is toggled
            value = Double.Parse(Output.Text); //will convert what's on text box to double to perform it arithmetically
        }
        private void Calculator_Load(object sender, EventArgs e)
        {

        }
        //Result text box
        private void Output_TextChanged(object sender, EventArgs e)
        {

        }
        
        private void btnEquals_Click(object sender, EventArgs e) //if equals is toggled
        {
            process = false; // sets back to false to accept new operations
            switch (operand)
            {
                case "+":                 
                    Output.Text = ($"{ value + Double.Parse(Output.Text) }");
                    break;
                case "-":
                    Output.Text = ($"{value - Double.Parse(Output.Text)}");
                    break;
                case "*":
                    Output.Text = ($"{value * Double.Parse(Output.Text)}");
                    break;
                case "/":
                    Output.Text = ($"{value / Double.Parse(Output.Text)}");
                    break;
                case "%":
                    Output.Text = ($"{(value/100)*Double.Parse(Output.Text)}");
                    break;
                default: break;
            }//switch 
            
        }


        private void btnDot_Click(object sender, EventArgs e)
        {
            Number(sender, e);
        }
        private void btnZero_Click(object sender, EventArgs e)
        {
            Number(sender, e);
        }
        private void btnOne_Click(object sender, EventArgs e)
        {
            Number(sender, e);
        }
        private void btnTwo_Click(object sender, EventArgs e)
        {
            Number(sender, e);
        }
        private void btnThree_Click(object sender, EventArgs e)
        {
            Number(sender, e);
        }
        private void btnFour_Click(object sender, EventArgs e)
        {
            Number(sender, e);
        }
        private void btnFive_Click(object sender, EventArgs e)
        {
            Number(sender, e);
        }
        private void btnSix_Click(object sender, EventArgs e)
        {
            Number(sender, e);
        }

        private void btnSeven_Click(object sender, EventArgs e)
        {
           Number(sender, e);
        }

        private void btnEight_Click(object sender, EventArgs e)
        {
            Number(sender, e);
        }

        private void btnNine_Click(object sender, EventArgs e)
        {
            Number(sender, e);
        }

        //CLEAR SCREEN
        private void btnClear_Click(object sender, EventArgs e)
        {
            Output.Clear();
            Output.Text = "0";
        }

        //BACKSPACE
        private void btnBackspace_Click(object sender, EventArgs e)
        {
            if ((Output.Text.Length != 0))
            { Output.Text = Output.Text.Substring(0, Output.Text.Length - 1); }
            else
            {
                Output.Text = "0";
            }
        }

    }
}
