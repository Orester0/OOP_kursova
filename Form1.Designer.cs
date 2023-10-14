namespace OOP_prog
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.відкритиФайлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вивантажитиФайлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.функціїToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сортуванняToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.заКольоромToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.заЦіноюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.заПотужністюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.найдешевшіТаНайToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.однаковаЦінаТаРізніКольориToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.автоІзЦіноюУВказанихМежахToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.найпотужнішаЧервоногоТаНайдешевшаЧорногоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.найдешевшаТаНайдорожчаЗаКольоромToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Consolas", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(18, 51);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 37);
            this.button1.TabIndex = 1;
            this.button1.Text = "Додати елемент";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Марка:";
            this.label1.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(124, 108);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(146, 27);
            this.textBox1.TabIndex = 3;
            this.textBox1.Visible = false;
            this.textBox1.WordWrap = false;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(124, 145);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(146, 27);
            this.textBox2.TabIndex = 5;
            this.textBox2.Visible = false;
            this.textBox2.WordWrap = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Колір:";
            this.label2.Visible = false;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(123, 186);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(146, 27);
            this.textBox3.TabIndex = 7;
            this.textBox3.Visible = false;
            this.textBox3.WordWrap = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ціна:";
            this.label3.Visible = false;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(124, 225);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(146, 27);
            this.textBox4.TabIndex = 9;
            this.textBox4.Visible = false;
            this.textBox4.WordWrap = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Потужність:";
            this.label4.Visible = false;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Consolas", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(158, 267);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(99, 37);
            this.button2.TabIndex = 10;
            this.button2.Text = "Зберегти";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.функціїToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(900, 28);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.відкритиФайлToolStripMenuItem,
            this.вивантажитиФайлToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // відкритиФайлToolStripMenuItem
            // 
            this.відкритиФайлToolStripMenuItem.Name = "відкритиФайлToolStripMenuItem";
            this.відкритиФайлToolStripMenuItem.Size = new System.Drawing.Size(223, 26);
            this.відкритиФайлToolStripMenuItem.Text = "Відкрити файл";
            this.відкритиФайлToolStripMenuItem.Click += new System.EventHandler(this.відкритиФайлToolStripMenuItem_Click);
            // 
            // вивантажитиФайлToolStripMenuItem
            // 
            this.вивантажитиФайлToolStripMenuItem.Name = "вивантажитиФайлToolStripMenuItem";
            this.вивантажитиФайлToolStripMenuItem.Size = new System.Drawing.Size(223, 26);
            this.вивантажитиФайлToolStripMenuItem.Text = "Вивантажити файл";
            // 
            // функціїToolStripMenuItem
            // 
            this.функціїToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сортуванняToolStripMenuItem,
            this.найдешевшіТаНайToolStripMenuItem,
            this.однаковаЦінаТаРізніКольориToolStripMenuItem,
            this.автоІзЦіноюУВказанихМежахToolStripMenuItem,
            this.найпотужнішаЧервоногоТаНайдешевшаЧорногоToolStripMenuItem,
            this.найдешевшаТаНайдорожчаЗаКольоромToolStripMenuItem});
            this.функціїToolStripMenuItem.Name = "функціїToolStripMenuItem";
            this.функціїToolStripMenuItem.Size = new System.Drawing.Size(74, 24);
            this.функціїToolStripMenuItem.Text = "Функції";
            // 
            // сортуванняToolStripMenuItem
            // 
            this.сортуванняToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.заКольоромToolStripMenuItem,
            this.заЦіноюToolStripMenuItem,
            this.заПотужністюToolStripMenuItem});
            this.сортуванняToolStripMenuItem.Name = "сортуванняToolStripMenuItem";
            this.сортуванняToolStripMenuItem.Size = new System.Drawing.Size(449, 26);
            this.сортуванняToolStripMenuItem.Text = "Сортування";
            // 
            // заКольоромToolStripMenuItem
            // 
            this.заКольоромToolStripMenuItem.Name = "заКольоромToolStripMenuItem";
            this.заКольоромToolStripMenuItem.Size = new System.Drawing.Size(192, 26);
            this.заКольоромToolStripMenuItem.Text = "За кольором";
            this.заКольоромToolStripMenuItem.Click += new System.EventHandler(this.заКольоромToolStripMenuItem_Click);
            // 
            // заЦіноюToolStripMenuItem
            // 
            this.заЦіноюToolStripMenuItem.Name = "заЦіноюToolStripMenuItem";
            this.заЦіноюToolStripMenuItem.Size = new System.Drawing.Size(192, 26);
            this.заЦіноюToolStripMenuItem.Text = "За ціною";
            this.заЦіноюToolStripMenuItem.Click += new System.EventHandler(this.заЦіноюToolStripMenuItem_Click);
            // 
            // заПотужністюToolStripMenuItem
            // 
            this.заПотужністюToolStripMenuItem.Name = "заПотужністюToolStripMenuItem";
            this.заПотужністюToolStripMenuItem.Size = new System.Drawing.Size(192, 26);
            this.заПотужністюToolStripMenuItem.Text = "За потужністю";
            this.заПотужністюToolStripMenuItem.Click += new System.EventHandler(this.заПотужністюToolStripMenuItem_Click);
            // 
            // найдешевшіТаНайToolStripMenuItem
            // 
            this.найдешевшіТаНайToolStripMenuItem.Name = "найдешевшіТаНайToolStripMenuItem";
            this.найдешевшіТаНайToolStripMenuItem.Size = new System.Drawing.Size(449, 26);
            this.найдешевшіТаНайToolStripMenuItem.Text = "Найдешевша та найменш потужна за маркою";
            this.найдешевшіТаНайToolStripMenuItem.Click += new System.EventHandler(this.найдешевшіТаНайToolStripMenuItem_Click);
            // 
            // однаковаЦінаТаРізніКольориToolStripMenuItem
            // 
            this.однаковаЦінаТаРізніКольориToolStripMenuItem.Name = "однаковаЦінаТаРізніКольориToolStripMenuItem";
            this.однаковаЦінаТаРізніКольориToolStripMenuItem.Size = new System.Drawing.Size(449, 26);
            this.однаковаЦінаТаРізніКольориToolStripMenuItem.Text = "Однакова ціна та різні кольори";
            this.однаковаЦінаТаРізніКольориToolStripMenuItem.Click += new System.EventHandler(this.однаковаЦінаТаРізніКольориToolStripMenuItem_Click);
            // 
            // автоІзЦіноюУВказанихМежахToolStripMenuItem
            // 
            this.автоІзЦіноюУВказанихМежахToolStripMenuItem.Name = "автоІзЦіноюУВказанихМежахToolStripMenuItem";
            this.автоІзЦіноюУВказанихМежахToolStripMenuItem.Size = new System.Drawing.Size(449, 26);
            this.автоІзЦіноюУВказанихМежахToolStripMenuItem.Text = "Авто, із ціною у вказаних межах";
            this.автоІзЦіноюУВказанихМежахToolStripMenuItem.Click += new System.EventHandler(this.автоІзЦіноюУВказанихМежахToolStripMenuItem_Click);
            // 
            // найпотужнішаЧервоногоТаНайдешевшаЧорногоToolStripMenuItem
            // 
            this.найпотужнішаЧервоногоТаНайдешевшаЧорногоToolStripMenuItem.Name = "найпотужнішаЧервоногоТаНайдешевшаЧорногоToolStripMenuItem";
            this.найпотужнішаЧервоногоТаНайдешевшаЧорногоToolStripMenuItem.Size = new System.Drawing.Size(449, 26);
            this.найпотужнішаЧервоногоТаНайдешевшаЧорногоToolStripMenuItem.Text = "Найпотужніша червоного та найдешевша чорного";
            this.найпотужнішаЧервоногоТаНайдешевшаЧорногоToolStripMenuItem.Click += new System.EventHandler(this.найпотужнішаЧервоногоТаНайдешевшаЧорногоToolStripMenuItem_Click);
            // 
            // найдешевшаТаНайдорожчаЗаКольоромToolStripMenuItem
            // 
            this.найдешевшаТаНайдорожчаЗаКольоромToolStripMenuItem.Name = "найдешевшаТаНайдорожчаЗаКольоромToolStripMenuItem";
            this.найдешевшаТаНайдорожчаЗаКольоромToolStripMenuItem.Size = new System.Drawing.Size(449, 26);
            this.найдешевшаТаНайдорожчаЗаКольоромToolStripMenuItem.Text = "Найдешевша та найдорожча за кольором";
            this.найдешевшаТаНайдорожчаЗаКольоромToolStripMenuItem.Click += new System.EventHandler(this.найдешевшаТаНайдорожчаЗаКольоромToolStripMenuItem_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Consolas", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(26, 267);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(99, 37);
            this.button3.TabIndex = 12;
            this.button3.Text = "Скасувати";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Visible = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Consolas", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.Location = new System.Drawing.Point(148, 51);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(125, 37);
            this.button4.TabIndex = 14;
            this.button4.Text = "Очистити список";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoScroll = true;
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Azure;
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetPartial;
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 134F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(392, 31);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(496, 30);
            this.tableLayoutPanel1.TabIndex = 15;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 562);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Курсова";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem відкритиФайлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вивантажитиФайлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem функціїToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сортуванняToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem заКольоромToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem заЦіноюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem заПотужністюToolStripMenuItem;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ToolStripMenuItem найдешевшіТаНайToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem однаковаЦінаТаРізніКольориToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem автоІзЦіноюУВказанихМежахToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem найпотужнішаЧервоногоТаНайдешевшаЧорногоToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem найдешевшаТаНайдорожчаЗаКольоромToolStripMenuItem;
    }
}

