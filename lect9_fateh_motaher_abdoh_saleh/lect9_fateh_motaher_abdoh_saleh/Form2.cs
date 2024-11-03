using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lect9_fateh_motaher_abdoh_saleh
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text.Trim());
            listBox2.Items.Add(textBox2.Text.Trim());
           listBox3.Items.Add(textBox3.Text.Trim());
            if (radioButton1.Checked)
                listBox4.Items.Add(radioButton1.Text);
            else if (radioButton2.Checked)
                listBox4.Items.Add(radioButton2.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Remove(listBox1.SelectedItem);
            listBox2.Items.Remove(listBox2.SelectedItem);
            listBox3.Items.Remove(listBox3.SelectedItem);
            listBox4.Items.Remove( listBox4.SelectedItem );
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            listBox4.Items.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items[listBox1.SelectedIndex] = textBox1.Text;
            listBox2.Items[listBox2.SelectedIndex] = textBox2.Text;
            listBox3.Items[listBox3.SelectedIndex] = textBox3.Text;
            if (radioButton1.Checked)
                listBox4.Items[listBox4.SelectedIndex] = radioButton1.Text;
            else if (radioButton2.Checked)
                listBox4.Items[listBox4.SelectedIndex] = radioButton2.Text;
            
        }
private void myclick(object sender,EventArgs e)
        {
          
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_MouseEnter(object sender, EventArgs e)
        {
            listBox1.SelectedItem =listBox2.SelectedItem=listBox3.SelectedItem=listBox4.SelectedItem;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            listBox1.SelectedIndex = listBox2.SelectedIndex = listBox3.SelectedIndex = listBox4.SelectedIndex = -1;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
