using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary1;


namespace SBERMBANK
{
    public partial class Form1 : Form
    {
        void Display(string message)
        {
            MessageBox.Show(message);
        }
        void Print(string message)
        {
            listBox1.Items.Add(message);
        }
        Delegate3.Acc one;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            one = new Delegate3.Acc(Convert.ToInt32(textBox2.Text), textBox1.Text);
            one.Notify += Display;
            one.RegisterHandler(Print);
            one.Info(Convert.ToInt32(textBox2.Text), textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            one.Add(Convert.ToInt32(textBox3.Text));

        }

        private void button3_Click(object sender, EventArgs e)
        {
            one.Take(Convert.ToInt32(textBox3.Text));
        }
    }
}