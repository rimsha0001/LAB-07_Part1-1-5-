using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _213043_Qno3_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public int mul(int m)
        {
            return m * m;
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(label2.Text);
            
            label13.Text = mul(n).ToString();
            int n1 = Convert.ToInt32(label3.Text);
            label14.Text = mul(n1).ToString();
            int n2 = Convert.ToInt32(label4.Text);
            label15.Text = mul(n2).ToString();
            int n3 = Convert.ToInt32(label5.Text);
            label16.Text = mul(n3).ToString();
            int n4 = Convert.ToInt32(label6.Text);
            label17.Text = mul(n4).ToString();
            int n5 = Convert.ToInt32(label7.Text);
            label18.Text = mul(n5).ToString();
            int n6 = Convert.ToInt32(label8.Text);
            label19.Text =mul(n6).ToString();
            int n7 = Convert.ToInt32(label9.Text);
            label20.Text = mul(n7).ToString();
            int n8 = Convert.ToInt32(label10.Text);
            
            label21.Text =mul(n8).ToString();
            int n9 = Convert.ToInt32(label11.Text);
     
            label22.Text = mul(n9).ToString();

        }
        
        private void label13_Click(object sender, EventArgs e)
        {
            
        }
    }
}
