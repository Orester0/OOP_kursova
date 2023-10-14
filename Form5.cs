using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_prog
{
    public partial class Form5 : Form
    {
        private List<CCar> cars = new List<CCar>();
        public Form5(List<CCar> temp)
        {
            cars = temp;
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            int redID = -1, blackID = -1; 
            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                CCar.powerfullRedCheapestBlack(cars, out blackID, out redID, textBox1.Text);
            }
            if(redID != -1)
            {
                listBox1.Items.Add(cars[redID]);
            }
            else
            {
                listBox1.Items.Add("No red cars found");
            }
            if(blackID != -1)
            {
                listBox2.Items.Add(cars[blackID]);
            }
            else
            {
                listBox2.Items.Add("No black cars found");
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
