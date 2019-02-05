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
 * Name:    Oscar Jara
 * Date:    01/1/19
 * Class:   CSE 445
 */ 

namespace part_2
{
    public partial class Form1 : Form
    {
        ServiceReference_Encryption.ServiceClient encrypt = new ServiceReference_Encryption.ServiceClient();
        ServiceReference_Image.ServiceClient image = new ServiceReference_Image.ServiceClient();

        string userInput;
       
        
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                label3.Text = encrypt.Encrypt(textBox1.Text);
            } catch(Exception ec)
            {
                label3.Text = ec.Message.ToString();
            } try
            {
                label5.Text = encrypt.Decrypt(label3.Text);
            } catch (Exception dc)
            {
                label5.Text = dc.Message.ToString();
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            userInput = image.GetVerifierString(textBox2.Text);
            System.IO.Stream stream = image.GetImage(userInput);
            System.Drawing.Image image2 = System.Drawing.Image.FromStream(stream);
            Bitmap imageBitmap = (Bitmap)image2;

            pictureBox1.Width = imageBitmap.Width;
            pictureBox1.Image = imageBitmap;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string validate = textBox3.Text;

            if (validate == userInput)
            {
                label8.Text = "Correct! This is the right input";  
            } else
            {
                label8.Text = "Sorry, try again";
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
