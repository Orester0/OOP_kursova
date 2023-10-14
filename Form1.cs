using System;
using System.Collections.Generic;
using System.ComponentModel;

using System.Drawing;
using System.IO;

using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace OOP_prog
{

    public partial class Form1 : Form
    {

        List<CCar> CarsList = new List<CCar>();

        public Form1()
        {
            InitializeComponent();


        }


        private void Form1_Load(object sender, EventArgs e)
        {
            tableLayoutPanel1.RowCount = 0;
            System.Windows.Forms.Label Ціна = new Label();
            Ціна.Text = "Ціна"; Ціна.Height = 30; Ціна.AutoEllipsis = true; Ціна.TextAlign = ContentAlignment.MiddleCenter; Ціна.Enabled = true;
            tableLayoutPanel1.Controls.Add(Ціна, 3, tableLayoutPanel1.RowCount);

            System.Windows.Forms.Label Колір = new Label();
            Колір.Text = "Колір"; Колір.Height = 30; Колір.AutoEllipsis = true; Колір.TextAlign = ContentAlignment.MiddleCenter; Колір.Enabled = true;
            tableLayoutPanel1.Controls.Add(Колір, 2, tableLayoutPanel1.RowCount);

            System.Windows.Forms.Label Потужність = new Label();
            Потужність.Text = "Потужність"; Потужність.Height = 30; Потужність.AutoEllipsis = true; Потужність.TextAlign = ContentAlignment.MiddleCenter; Потужність.Enabled = true;
            tableLayoutPanel1.Controls.Add(Потужність, 4, tableLayoutPanel1.RowCount);

            tableLayoutPanel1.Controls.Add(new Label { Text = " ", Height = 30, Width = 20, TextAlign = ContentAlignment.MiddleCenter }, 5, tableLayoutPanel1.RowCount);

            tableLayoutPanel1.Controls.Add(new Label { Text = "#", Height = 30, AutoEllipsis = true, TextAlign = ContentAlignment.MiddleCenter }, 0, tableLayoutPanel1.RowCount);
            tableLayoutPanel1.Controls.Add(new Label { Text = "Марка", Height = 30, AutoEllipsis = true, TextAlign = ContentAlignment.MiddleCenter }, 1, tableLayoutPanel1.RowCount);
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Show();
            label2.Show();
            label3.Show();
            label4.Show();
            textBox1.Show();
            textBox2.Show();
            textBox3.Show();
            textBox4.Show();
            button2.Show();
            button3.Show();
        }

        private void addToListBox(in CCar car)
        {
            Label label = new Label();
            //label.Text += Convert.ToString(listBox1.Items.Count+1) + ". ";
            label.Text += car.ToString();
            CarsList.Add(car);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text) ||
                string.IsNullOrEmpty(textBox3.Text) || string.IsNullOrEmpty(textBox4.Text))
            {
                return;
            }
            uint cost = 0;
            uint capacity = 0;
            if (uint.TryParse(textBox3.Text, out cost) && uint.TryParse(textBox4.Text, out capacity))
            {
                label1.Hide();
                label2.Hide();
                label3.Hide();
                label4.Hide();
                textBox1.Hide();
                textBox2.Hide();
                textBox3.Hide();
                textBox4.Hide();
                button2.Hide();
                button3.Hide();
                CCar car = new CCar(textBox1.Text, textBox2.Text,
                    cost, capacity);
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                addToListBox(car);
                updateList();
            }
            else
            {
                MessageBox.Show("Некоректні дані на ввід", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void відкритиФайлToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stream MyStream;
            OpenFileDialog openFileDialogFileName = new OpenFileDialog
            {
                Filter = "Text Files (*.txt)|*.txt",
                FilterIndex = 2,
                RestoreDirectory = true
            };
            if (openFileDialogFileName.ShowDialog() == DialogResult.OK)
            {
                MyStream = openFileDialogFileName.OpenFile();
                if (MyStream.CanRead)
                {
                    MyStream.Close();

                }
            }
            else return;
            string[] input = File.ReadAllLines(openFileDialogFileName.FileName);
            int j = 0;
            CarsList.Clear();
            updateList();
            foreach (string i in input)
            {
                string[] inputParts = input[j++].Split(',');
                if (inputParts.Length < 4)
                {
                    MessageBox.Show("Некоректні у файлі", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (!string.IsNullOrWhiteSpace(inputParts[0]) && !string.IsNullOrWhiteSpace(inputParts[1])
                    && uint.TryParse(inputParts[2], out uint cost) && uint.TryParse(inputParts[3], out uint capacity))
                {
                    string name = inputParts[0];
                    string color = inputParts[1];
                    CCar car = new CCar(name, color, cost, capacity);
                    addToListBox(car);
                }
                else
                {
                    MessageBox.Show("Некоректні у файлі", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            updateList();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Hide();
            label2.Hide();
            label3.Hide();
            label4.Hide();
            textBox1.Hide();
            textBox2.Hide();
            textBox3.Hide();
            textBox4.Hide();
            button2.Hide();
            button3.Hide();
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            CarsList.Clear();
            updateList();
        }

        private void заЦіноюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CarsList = Sorting.sortCost(CarsList);
            updateList();
        }

        private void updateList()
        {
            tableLayoutPanel1.Visible = false;
            tableLayoutPanel1.Controls.Clear();
            tableLayoutPanel1.RowCount = 0;

            System.Windows.Forms.Label Ціна = new Label();
            Ціна.Click += new EventHandler(заЦіноюToolStripMenuItem_Click);
            Ціна.MouseEnter += new EventHandler(CursorEnter);
            Ціна.MouseLeave += new EventHandler(CursorLeave);
            Ціна.Text = "Ціна"; Ціна.Height = 30; Ціна.AutoEllipsis = true; Ціна.TextAlign = ContentAlignment.MiddleCenter; Ціна.Enabled = true;
            tableLayoutPanel1.Controls.Add(Ціна, 3, tableLayoutPanel1.RowCount);

            System.Windows.Forms.Label Колір = new Label();
            Колір.Click += new EventHandler(заКольоромToolStripMenuItem_Click);
            Колір.MouseEnter += new EventHandler(CursorEnter);
            Колір.MouseLeave += new EventHandler(CursorLeave);
            Колір.Text = "Колір"; Колір.Height = 30; Колір.AutoEllipsis = true; Колір.TextAlign = ContentAlignment.MiddleCenter; Колір.Enabled = true;
            tableLayoutPanel1.Controls.Add(Колір, 2, tableLayoutPanel1.RowCount);

            System.Windows.Forms.Label Потужність = new Label();
            Потужність.Click += new EventHandler(заПотужністюToolStripMenuItem_Click);
            Потужність.MouseEnter += new EventHandler(CursorEnter);
            Потужність.MouseLeave += new EventHandler(CursorLeave);
            Потужність.Text = "Потужність"; Потужність.Height = 30; Потужність.AutoEllipsis = true; Потужність.TextAlign = ContentAlignment.MiddleCenter; Потужність.Enabled = true;
            tableLayoutPanel1.Controls.Add(Потужність, 4, tableLayoutPanel1.RowCount);

            tableLayoutPanel1.Controls.Add(new Label { Text = " ", Height = 30, Width = 20, TextAlign = ContentAlignment.MiddleCenter }, 5, tableLayoutPanel1.RowCount);

            tableLayoutPanel1.Controls.Add(new Label { Text = "#", Height = 30, AutoEllipsis = true, TextAlign = ContentAlignment.MiddleCenter }, 0, tableLayoutPanel1.RowCount);
            tableLayoutPanel1.Controls.Add(new Label { Text = "Марка", Height = 30, AutoEllipsis = true, TextAlign = ContentAlignment.MiddleCenter }, 1, tableLayoutPanel1.RowCount);

            foreach (var car in CarsList)
            {
                tableLayoutPanel1.RowCount++;
                Label lRow = new Label { Text = tableLayoutPanel1.RowCount.ToString(), Height = 25, AutoEllipsis = true, TextAlign = ContentAlignment.MiddleCenter };
                Label lName = new Label { Text = car.getName(), Height = 25, AutoEllipsis = true };
                
                Label lColor = new Label { Text = car.getColor(), Height = 25, AutoEllipsis = true };
                Label lCost = new Label { Text = car.getCost().ToString(), Height = 25, AutoEllipsis = true, TextAlign = ContentAlignment.MiddleCenter };
                Label lCapacity = new Label { Text = car.getCapacity().ToString(), Height = 25, AutoEllipsis = true, TextAlign = ContentAlignment.MiddleCenter };
                Label lDelete = new Label { Text = "X", Height = 25, Width = 25, TextAlign = ContentAlignment.MiddleCenter };
                lDelete.Click += deleteItem;
                lDelete.MouseEnter += labelColorChange;
                lDelete.MouseLeave += labelColorBack;

                tableLayoutPanel1.Controls.Add(lRow, 0, tableLayoutPanel1.RowCount);
                tableLayoutPanel1.Controls.Add(lName, 1, tableLayoutPanel1.RowCount);
                tableLayoutPanel1.Controls.Add(lColor, 2, tableLayoutPanel1.RowCount);
                tableLayoutPanel1.Controls.Add(lCost, 3, tableLayoutPanel1.RowCount);
                tableLayoutPanel1.Controls.Add(lCapacity, 4, tableLayoutPanel1.RowCount);
                tableLayoutPanel1.Controls.Add(lDelete, 5, tableLayoutPanel1.RowCount);
                
            }
            if (CarsList.Count < 9)
            {
                tableLayoutPanel1.Height = 40 + 30 * CarsList.Count;
            }
            else
            {
                tableLayoutPanel1.Height = 250;
            }
            tableLayoutPanel1.Visible = true;
        }

        private void deleteItem(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Справді хочете видалити елемент?", "!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.Cancel)
            {
                return;
            }
            int targetRow = tableLayoutPanel1.GetRow(sender as Control);
            for (int i =0; i < CarsList.Count; i++)
            {
                if(i == targetRow-1)
                {
                    CarsList.RemoveAt(i);
                    updateList();
                    break;
                }
            }
        }

        private void labelColorChange(object sender, EventArgs a)
        {
            Label label = sender as Label;
            label.BackColor = Color.Red;
       
        }

        private void labelColorBack(object sender, EventArgs a)
        {
            Label label = sender as Label;
            label.BackColor = Color.Transparent;
        }

        private void CursorEnter(object sender, EventArgs e)
        {
            Label label = sender as Label;
            if (label != null)
            {
                label.Cursor = Cursors.Hand;
            }
        }

        private void CursorLeave(object sender, EventArgs e)
        {
            Label label = sender as Label;
            if (label != null)
            {
                label.Cursor = Cursors.Default;
            }
        }

        private void заПотужністюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CarsList = Sorting.sortCapacity(CarsList);
            updateList();
        }

        private void заКольоромToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CarsList = Sorting.sortColor(CarsList);
            updateList();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void найдешевшіТаНайToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(CarsList);
            form2.ShowDialog();
        }

        private void однаковаЦінаТаРізніКольориToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3(CarsList);
            form3.ShowDialog();
        }

        private void автоІзЦіноюУВказанихМежахToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4(CarsList);
            form4.ShowDialog();
        }

        private void найпотужнішаЧервоногоТаНайдешевшаЧорногоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5(CarsList);
            form5.ShowDialog();
        }

        private void найдешевшаТаНайдорожчаЗаКольоромToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6(CarsList);
            form6.ShowDialog();
        }
    }

    public class CCar
    {
        private string m_sName = "";
        private string m_sColor = "";
        private uint m_uCost = 0;
        private uint m_uCapacity = 0;
        public CCar()
        {
            m_sName = "Daewoo";
            m_sColor = "Green";
            m_uCost = 1000;
            m_uCapacity = 750;
        }
        public CCar(string name, string color, uint cost, uint capacity)
        {
            m_sName = name;
            m_sColor = color;
            m_uCost = cost;
            m_uCapacity = capacity;
        }

        public string getName()
        {
            return m_sName;
        }
        public string getColor()
        {
            return m_sColor;
        }
        public uint getCost()
        {
            return m_uCost;
        }
        public uint getCapacity()
        {
            return m_uCapacity;
        }

        public void setName(string name)
        {
            m_sName = name;
        }

        public void setColor(string color)
        {
            m_sColor = color;
        }

        public void setCost(uint cost)
        {
            m_uCost = cost;
        }

        public void setCapacity(uint capacity)
        {
            m_uCapacity = capacity;
        }

        public override string ToString()
        {
            return $"{m_sName} {m_sColor} {m_uCost} {m_uCapacity}";
        }

        public static void cheapestAndLeastPowerfulByMark(List<CCar> cars, string name, List<int> cheapestCarsIndices, List<int> leastPowerfulCarsIndices)
        {
            uint minPrice = uint.MaxValue;
            uint minPower = uint.MaxValue;
            int searches = 0;                       // кількість задовільнених пошуків
            for (int i = 0; i < cars.Count; i++)
            {
                if (cars[i].getName() == name)
                {
                    if (cars[i].getCost() < minPrice)
                    {
                        minPrice = cars[i].getCost();
                        cheapestCarsIndices.Clear();
                        cheapestCarsIndices.Add(i);
                    }
                    else if (cars[i].getCost() == minPrice)
                    {
                        cheapestCarsIndices.Add(i);
                    }

                    if (cars[i].getCapacity() < minPower)
                    {
                        minPower = cars[i].getCapacity();
                        leastPowerfulCarsIndices.Clear();
                        leastPowerfulCarsIndices.Add(i);
                    }
                    else if (cars[i].getCapacity() == minPower)
                    {
                        leastPowerfulCarsIndices.Add(i);
                    }
                    searches++;
                }
            }
            if (searches == 0)
            {
                throw new CCarExceptions();         // повертаємо помилку якщо не знайдено нічого
            }
        }
        public static List<CCar> sameCostOtherColors(List<CCar> cars)
        {
            int searches = 0;
            List<CCar> uniqueCarsByColor = new List<CCar> ();
            HashSet<CCar> uniqueCarsByCost = new HashSet<CCar>();
            HashSet<string> uniqueColors = new HashSet<string>();
            for (int i = 0; i < cars.Count; i++)
            {
                for (int j = i + 1; j < cars.Count; j++)
                {
                    if (cars[i].getCost() == cars[j].getCost())
                    {
                        searches++;
                        uniqueCarsByCost.Add(cars[i]);
                        uniqueCarsByCost.Add(cars[j]);
                    }
                }
            }
            if (searches == 0)
            {
                throw new CCarExceptions();
            }
            foreach (var car in uniqueCarsByCost)
            {
                if (uniqueColors.Add(car.getColor()))
                {
                    uniqueCarsByColor.Add(car);

                }
            }
            return uniqueCarsByColor;

        }
        public static List<CCar> carsByCostRange(List<CCar> cars, uint cost1, uint cost2)
        {
            int searches = 0;
            List<CCar> featuredCars = new List<CCar> ();
            foreach (var car in cars)
            {
                if (car.getCost() > cost1 && car.getCost() < cost2)
                {
                    featuredCars.Add(car);
                    searches++;
                }
            }
            if(searches == 0)
            {
                throw new CCarExceptions();
            }
            return featuredCars;
        }

        public static void powerfullRedCheapestBlack(List<CCar> cars, out int blackID, out int redID, string mark)
        {
            blackID = -1; redID = -1;
            for (int i = 0; i < cars.Count; i++)
            {
                if (cars[i].getName() == mark)
                {
                    if (redID == -1)
                    {
                        if (cars[i].getColor() == "Red")
                        {
                            redID = i;
                        }
                    }
                    else if (redID != -1 && cars[i].getColor() == "Red")
                    {
                        if (cars[i].getCapacity() > cars[redID].getCapacity())
                        {
                            redID = i;
                        }
                    }
                    if (blackID == -1)
                    {
                        if (cars[i].getColor() == "Black")
                        {
                            blackID = i;
                        }
                    }
                    else if (blackID != -1 && cars[i].getColor() == "Black")
                    {
                        if (cars[i].getCost() < cars[blackID].getCost())
                        {
                            blackID = i;
                        }
                    }

                }
            }
        }
        public static void minMaxCostByMark(List<CCar> cars, out int minID, out int maxID, string mark)
        {
            maxID = 0; minID = 0; int count = 0;
            for (int i = 0; i < cars.Count; i++)
            {
                if (cars[i].getColor() == mark)
                {
                    if (cars[i].getCost() >= cars[maxID].getCost())
                    {
                        maxID = i;
                    }
                    if (cars[i].getCost() <= cars[minID].getCost())
                    {
                        minID = i;
                    }
                    count++;
                }
            }
            if(count == 0)
            {
                throw new CCarExceptions();
            }
        }
    }
    public class Sorting
    {
        public static List<CCar> sortCost(List<CCar> cars)
        {
            if (cars.Count <= 1) return cars;

            int middle = cars.Count / 2;
            List<CCar> left = cars.GetRange(0, middle);
            List<CCar> right = cars.GetRange(middle, cars.Count - middle);

            left = sortCost(left);
            right = sortCost(right);

            List<CCar> result = new List<CCar>();
            int leftIndex = 0, rightIndex = 0;

            while (leftIndex < left.Count && rightIndex < right.Count)
            {
                if (left[leftIndex].getCost() < right[rightIndex].getCost())
                {
                    result.Add(left[leftIndex]);
                    leftIndex++;
                }
                else
                {
                    result.Add(right[rightIndex]);
                    rightIndex++;
                }
            }

            result.AddRange(left.GetRange(leftIndex, left.Count - leftIndex));
            result.AddRange(right.GetRange(rightIndex, right.Count - rightIndex));

            return result;
        }

        public static List<CCar> sortCapacity(List<CCar> cars)
        {
            if (cars.Count <= 1) return cars;

            int middle = cars.Count / 2;
            List<CCar> left = cars.GetRange(0, middle);
            List<CCar> right = cars.GetRange(middle, cars.Count - middle);

            left = sortCapacity(left);
            right = sortCapacity(right);

            List<CCar> result = new List<CCar>();
            int leftIndex = 0, rightIndex = 0;

            while (leftIndex < left.Count && rightIndex < right.Count)
            {
                if (left[leftIndex].getCapacity() < right[rightIndex].getCapacity())
                {
                    result.Add(left[leftIndex]);
                    leftIndex++;
                }
                else
                {
                    result.Add(right[rightIndex]);
                    rightIndex++;
                }
            }

            result.AddRange(left.GetRange(leftIndex, left.Count - leftIndex));
            result.AddRange(right.GetRange(rightIndex, right.Count - rightIndex));

            return result;
        }
        public static List<CCar> sortColor(List<CCar> cars)
        {
            if (cars.Count <= 1) return cars;

            int middle = cars.Count / 2;
            List<CCar> left = cars.GetRange(0, middle);
            List<CCar> right = cars.GetRange(middle, cars.Count - middle);

            left = sortColor(left);
            right = sortColor(right);

            List<CCar> result = new List<CCar>();
            int leftIndex = 0, rightIndex = 0;

            while (leftIndex < left.Count && rightIndex < right.Count)
            {

                if (string.Compare(left[leftIndex].getColor(), right[rightIndex].getColor()) == -1)
                {
                    result.Add(left[leftIndex]);
                    leftIndex++;
                }
                else
                {
                    result.Add(right[rightIndex]);
                    rightIndex++;
                }
            }

            result.AddRange(left.GetRange(leftIndex, left.Count - leftIndex));
            result.AddRange(right.GetRange(rightIndex, right.Count - rightIndex));

            return result;
        }
    }
    public class CCarExceptions : Exception
    {
        public CCarExceptions() { }
    }
}
