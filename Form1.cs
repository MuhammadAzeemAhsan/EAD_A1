using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bcsf20a006_Assignment1
{
    public partial class Form1 : Form
    {
        private string[] subjects = { "EAD", "AI", "ML", "English", "Computer Science", "Bussiness Writing" };

        public Form1()
        {
            InitializeComponent();
            comboBox1.DataSource = subjects;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

      

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
                
                string fName = textBox1.Text.ToString().Trim();
                fName = Regex.Replace(fName, @"\s+", " ");
                string lName = textBox2.Text.ToString().Trim();
                lName = Regex.Replace(lName, @"\s+", " ");
                bool preReqClear = checkBox1.Checked;
                string subject = comboBox1.SelectedItem as string;


            

           
                

                string result = $"First Name: {fName}\nLast Name: {lName}\nSelected Subject: {subject}\nPrerequisite Clear: {preReqClear}";

            
                label4.Text = result;


        }

        private void label4_Click(object sender, EventArgs e)
        {

        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
