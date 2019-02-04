using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 *  Name:   Oscar Jara 
 *  Date:   2/1/19
 *  Class:  CSE 445
 */

namespace Part1_Form
{
    public partial class Form1 : Form
    {
        MyServiceReference.Service1Client proxy = new MyServiceReference.Service1Client();
        private int age;
        private string firstName, lastName;

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            age = int.Parse(textBox1.Text);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            firstName = textBox2.Text;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            lastName = textBox3.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("LoginID is: " + proxy.LoginID(age) + ". Password is: " + proxy.Password(firstName, lastName, age));
        }
    }
}
