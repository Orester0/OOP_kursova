using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_prog
{
    public partial class Form2 : Form
    {
        private List<CCar> cars = new List<CCar>();
        public Form2(List<CCar> temp)
        {
            cars = temp;
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string name = "";
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                return;
            }

            listBox1.Items.Clear();
            listBox2.Items.Clear();

            name = textBox1.Text;
            List<int> cheapestCarsIndices = new List<int>();
            List<int> leastPowerfulCarsIndices = new List<int>();
            try
            {
                CCar.cheapestAndLeastPowerfulByMark(cars, name, cheapestCarsIndices, leastPowerfulCarsIndices);
            }
            catch(CCarExceptions){
                MessageBox.Show("Не знайдено таких машин.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            foreach (var a in cheapestCarsIndices)
            {
                listBox1.Items.Add(cars[a]);
            }
            foreach (var b in leastPowerfulCarsIndices)
            {
                listBox2.Items.Add(cars[b]);
            }
            textBox1.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Hide();
            textBox1.Hide();
            button2.Hide();
            button3.Hide();
            textBox1.Clear();
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
