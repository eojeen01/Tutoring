using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tutoring2
{
    public partial class Form1 : Form
    {
        int a = 0;
        string[] array = new string[] {"0번째","1번째","2번째","3번째","4번째","5번째","6번째","7번째","8번째","9번째", "10번째"};

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            labelCount.Text = array[a];
            if (a >= 10)
            {
                a = 0;
            }
            else
            {
                a++;
            }
            
        }
    }
}
