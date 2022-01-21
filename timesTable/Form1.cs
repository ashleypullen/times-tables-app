using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace timesTable
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int answer = 0;
            int loopStart;
            int loopEnd;

            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                {
                    TextBox textBox = c as TextBox;
                    if (textBox.Text == string.Empty)
                    {
                        MessageBox.Show("Please enter some numbers");
                    }
                }
            }

            loopStart = int.Parse(txtBoxStart.Text);
            loopEnd = int.Parse(txtBoxEnd.Text);
            int multiply = int.Parse(txtBoxMultiply.Text);

            listBox1.Items.Clear();

            for (int i = loopStart; i <= loopEnd; i++)
            {
                answer = multiply * i;
                listBox1.Items.Add(i + " times " + multiply + "=" + answer.ToString());
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
