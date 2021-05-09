using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tutoring3
{
    
    public partial class Form1 : Form
    {
        string delivery;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonResult_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text == "")
                {
                    textBox1.Text = "0";
                }
                if (textBox2.Text == "")
                {
                    textBox2.Text = "0";
                }
                if (textBox3.Text == "")
                {
                    textBox3.Text = "0";
                }
                if (textBox4.Text == "")
                {
                    textBox4.Text = "0";
                }
                if (checkBoxDelivery.Checked)
                {
                    delivery = "배달 O";
                }
                if (!checkBoxDelivery.Checked)
                {
                    delivery = "배달 X";
                }

                labelResult.Text = "사과 : " + int.Parse(textBox1.Text) + " 배 : " + int.Parse(textBox2.Text) + " 바나나 : " + int.Parse(textBox3.Text) + " 귤 : " + int.Parse(textBox4.Text)+" "+delivery;
            }
            catch
            {
                MessageBox.Show( "숫자로 입력해주세요.");
            }
            
            
        }
    }
}
