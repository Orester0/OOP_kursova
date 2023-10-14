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
    public partial class Form4 : Form
    {
        private List<CCar> cars = new List<CCar>();
        public Form4(List<CCar> temp)
        {
            cars = temp;
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            uint cost1 = Convert.ToUInt32(textBox1.Text);
            uint cost2 = Convert.ToUInt32(textBox2.Text);
            List<CCar> featuredCars = new List<CCar>();

            try
            {
                featuredCars = CCar.carsByCostRange(cars, cost1, cost2);
                featuredCars.Sort((x, y) => x.getCost().CompareTo(y.getCost()));
            }
            catch (CCarExceptions)
            {
                MessageBox.Show("Не знайдено таких машин.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            foreach(var item in featuredCars)
            {
                listBox1.Items.Add(item);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
