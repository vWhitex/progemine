using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CalculatorLib;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private CalculatorLib.Calculator calc = new CalculatorLib.Calculator();
        private void button21_Click_1(object sender, EventArgs e)
        {
            var btn = (sender as Button).Text;

            switch(btn)
            {
                case "=":
                    calc.KeyPress(Convert.ToChar(btn));
                    label2.Text = calc.Result.ToString();
                    break;
                case "DEL":
                    try { calc.KeyPress(Convert.ToChar('D')); label2.Text = label2.Text.Remove(label2.Text.Length - 1); }
                    catch(Exception ex) { }
                    break;
                case "AC":
                    calc.KeyPress(Convert.ToChar('C'));
                    label2.Text = "";
                    break;
                default:
                    label2.Text += btn;
                    calc.KeyPress(Convert.ToChar(btn));
                    break;
            }
        }

    }
}
