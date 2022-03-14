using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{


    public partial class Form1 : Form
    {
        private void Sort()
        {
            
        }

        private void Clear()
        {
            this.textBox2.Clear();
            this.textBox1.Clear();
            this.listBox1.Items.Clear();
            this.comboBox1.Items.Clear();
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        

    


        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int c = int.Parse(textBox1.Text);
                string[] sNums = textBox2.Text.Split(',');
                if (c > sNums.Length)
                {
                    MessageBox.Show("Длина массива не соответсвует введенному!");
                    return;
                }

                int[] nums = new int[c];
                for (int i = 0; i < c; i++)
                {
                    nums[i] = int.Parse(sNums[i]);
                    listBox1.Items.Add(nums[i]);
                    if (nums[i] > 5 && nums[i] < 50 )
                    {
                        comboBox1.Items.Add(nums[i]);
                    }
                }

            }

                


            

            
            catch
            {
                MessageBox.Show("Ошибка!");
            }

            

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Clear();
        }
    }
}

        
    

