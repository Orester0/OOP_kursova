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
    public partial class Form6 : Form
    {
        private List<CCar> cars = new List<CCar>();
        public Form6(List<CCar> temp)
        {
            cars = temp;
            InitializeComponent();
        }


        private void Form6_Load(object sender, EventArgs e)
        {
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int minID = 0; int maxID = 0;           
            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                try
                {
                    CCar.minMaxCostByMark(cars, out minID, out maxID, textBox1.Text);
                }
                catch (CCarExceptions)
                {
                    label4.Text = $"No {textBox1.Text} cars found";
                    label5.Text = $"No {textBox1.Text} cars found";
                    return;
                }
            }

            label4.Text = cars[minID].ToString();
            label5.Text = cars[maxID].ToString();
            
        }
    }
}
