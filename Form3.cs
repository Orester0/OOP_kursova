using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace OOP_prog
{
    public partial class Form3 : Form
    {
        private List<CCar> cars = new List<CCar>();
        public Form3(List<CCar> temp)
        {
            cars = temp;
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            List<CCar> uniqueCarsByColor = new List<CCar>();
            try
            {
                uniqueCarsByColor = CCar.sameCostOtherColors(cars);// RETURN FROM METHOD
            }
            catch (CCarExceptions)
            {
                MessageBox.Show("Не знайдено таких машин.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }

            foreach (var car in uniqueCarsByColor)
            {
                listBox1.Items.Add(car);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
