using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tutoring4
{
    public partial class Form1 : Form
    {
        Owner owner = new Owner();
        Fish fish = new Fish();
        Electro electro = new Electro();
        Fruit fruit = new Fruit();
        string result;
        int count;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_text_changed(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                count = int.Parse(owner.Purchase(textBoxName.Text, textBoxCount.Text));
                labelPlus.Text += fish.Discount(textBoxName.Text, int.Parse(textBoxCount.Text)) +
                electro.AS(textBoxName.Text, int.Parse(textBoxCount.Text));

                result += textBoxName.Text + " : " + count + " ";
                labelResult.Text = result;
            }
            catch
            {
                MessageBox.Show("정확히 입력해주세요.");
            }
            
        }

        private void checkBoxDelivery_CheckedChanged(object sender, EventArgs e)
        {
            labelPlus.Text += fruit.Fresh(textBoxName.Text);
        }
    }
}
