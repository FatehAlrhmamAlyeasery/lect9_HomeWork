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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            setenable();
            Height = groupBox1.Top + 40;
            Random r = new Random();
            for (int i = 0; i < 10; i++)
            {
                int n = r.Next(100);
                listBox1.Items.Add(n);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() != null)
            {
                if (!isnumeric(textBox1.Text.Trim()))
                {
                    if (!isrepeat(listBox1, textBox1.Text.Trim()))
                    {
                        listBox1.Items.Add(textBox1.Text.Trim());
                        textBox1.Clear();
                        textBox1.Focus();
                    }
                    else
                        MessageBox.Show("العنصر موجود");
                }
                else
                {
                    MessageBox.Show("القيمة المدخلة ليست رقما");
                    textBox1.Focus();
                }
            }

        }
        private void setenable()
        {
            button2.Enabled = listBox1.Items.Count > -1;
        }
        private bool isnumeric(string s)
        {
            if (s == null)
                return true;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] < 48 || s[i] > 57)
                    return true;

            }
            return false;
        }
        private bool isrepeat(ListBox l, string s)
        {
            if (l.Items.Contains(s))
                return true;
            return false;
        }
        private void button15_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int c = listBox1.SelectedItems.Count;
            for (int i = 0; i < c; i++)
            {
                if (!isrepeat(listBox2, listBox1.SelectedItems[i].ToString()))
                {
                    listBox2.Items.Add(listBox1.SelectedItems[i]);
                    listBox1.Items.Remove(listBox1.SelectedItems[i]);
                }
                else
                {

                    listBox1.Items.Remove(listBox1.SelectedItems[i]);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int c = listBox1.SelectedItems.Count;
            for (int i = 0; i < c; i++)
            {
                if (!listBox2.Items.Contains(listBox1.SelectedItems[i]))
                    listBox2.Items.Add(listBox1.SelectedItems[i]);
                listBox1.Items.Remove(listBox1.SelectedItems[i]);
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            sortlistbox(listBox1);
        }
        private void sortlistbox(ListBox l)
        {
            int c = l.Items.Count;
            for (int i = 0; i < c; i++)
            {
                for (int j = i + 1; j < c; j++)
                {
                    int n = Convert.ToInt32(l.Items[i]);
                    int m = Convert.ToInt32(l.Items[j]);
                    if (n < m)
                    {
                        int temp = n;
                        l.Items[i] = m;
                        l.Items[j] = temp;
                    }
                }
            }
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            int c = listBox1.Items.Count;
            for (int i = 0; i < c; i++)
            {
                listBox2.Items.Add(listBox1.Items[listBox1.Items.Count - 1]);
                listBox1.Items.Remove(listBox1.Items[listBox1.Items.Count - 1]);
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            listBox1.SelectedIndex = -1;
            if (radioButton1.Checked)
            {
                int c = listBox1.Items.Count;
                for (int i = 0; i <c; i++)
                {
                    if (Convert.ToInt32(listBox1.Items[i]) % 2 == 0)
                        listBox1.SelectedIndex = i;
                }
                if (listBox1.SelectedIndex == -1)
                {
                    MessageBox.Show("لابوجد عناصر زوجية");
                }
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                if (Convert.ToInt32(listBox1.Items[i]) % 2 != 0)
                    listBox1.SelectedIndex = i;
            }
            if (listBox1.SelectedIndex == -1)
            {
                MessageBox.Show("لابوجد عناصر فردية");
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            listBox1.SelectedIndex = -1;
            bool p = true;
            if (radioButton3.Checked)
            {
                for (int i = 0; i < listBox1.Items.Count; i++)
                {
                    int n = Convert.ToInt32(listBox1.Items[i]);
                    p = true;
                    for (int j = 2; j < n; j++)
                    {
                        if (n % j == 0)
                        {
                            p = false;
                            break;
                        }
                        if (p == true)
                            listBox1.SelectedIndex = i;
                    }
                    if (listBox1.SelectedIndex == -1)
                        MessageBox.Show("الايوجد عناصر اولية");
                }

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button4.Text == "v")
            {
                Height = button4.Top + button4.Height + this.Height+130;
                button4.Text = "^";
            }
            else
            {
                button4.Text = "v";
                Height = groupBox1.Top + 40;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);

            }


        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            revers(listBox1);
        }
        private void revers(ListBox l)
        {
            for (int i = l.Items.Count - 1; i >= 0; i--)
            {
                l.Items.Add(l.Items[i]);
                l.Items.Remove(l.Items[i]);
            }
        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            revers(listBox2);
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            sortlistbox(listBox2);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            listBox1.SelectedItems.Add(textBox2.Text);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            listBox1.SelectedItems.Remove(textBox3.Text);    }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox6.Text=(listBox1.SelectedItems.Count.ToString());
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox7.Text = (listBox1.Items.Count - listBox1.SelectedItems.Count).ToString();
        }

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {
            int c = listBox1.Items.Count;
            if (listBox1.Items.Count > 0)
            {
                for (int i = 0; i < listBox1.Items.Count; i++)
                {
                    
                    listBox1.SelectedIndex = i; }
            }
            else
                MessageBox.Show("لا يوجد عناصر");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedIndex != -1)
            {
                listBox2.Items.RemoveAt(listBox2.SelectedIndex);

            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            sortlistbox(listBox1);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox5.Text = listBox1.Items.Count.ToString();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            listBox1.SelectedIndex= Convert.ToInt32(textBox4.Text.Trim()) ;
        }

        private void radioButton11_CheckedChanged(object sender, EventArgs e)
        {
            listBox1.SelectedIndex = -1;
        }
    }
}