using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiplicationTable
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Do you want to exit? ", "ExitAPP", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            inputfield.Focus();


        }

        private void Reset_Button(object sender, EventArgs e)
        {
            
            if(MessageBox.Show("Do you want to exit? ", "EXIT", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                ListField.Items.Clear();
                inputfield.Text = "";
                inputfield.Focus();
            }
        }

        private void ListField_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int i = 0;
            int t = 0;
            t = Convert.ToInt32(inputfield.Text);

            for( i = 0; i < 13; i++)
            {
                ListField.Items.Add(i + "x" + t + "=" + (i * t));
            }
        }
    }
}
