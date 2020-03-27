/*
 Напишите программу, в которой открывается окно с раскрывающимся списком. Список содержит названия цветов (красный, желтый, зеленый и т.д.).
 Также окно содержит область, закрашенную тем цветом, который выбран в списке. При выборе в списке в списке нового цвета область закрашивается этим цветом автоматически.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace HW03
{
    class MyForm : Form
    {
        string[] colors = { "Красный", "Зеленый", "Желтый", "Черный" };
        private ComboBox list;
        private Panel panel;

        public MyForm()
        {
            //Натройки главного окна
            this.Text = "Цвета";
            this.Size = new Size(300, 155);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            //Настройки панели с отображаемым цветом
            panel = new Panel();
            panel.SetBounds(5, 5, 154, 104);
            this.Controls.Add(panel);
            //Настройки ComboBox
            list = new ComboBox();
            list.Items.AddRange(colors);
            list.DropDownStyle = ComboBoxStyle.DropDownList;
            list.Left = panel.Right + 5;
            list.Top = panel.Top;
            this.Controls.Add(list);
            list.SelectedIndexChanged += (a, b) =>
            {
                switch (list.SelectedIndex)
                {
                    case 0:
                        panel.BackColor = Color.Red;
                        break;
                    case 1:
                        panel.BackColor = Color.Green;
                        break;
                    case 2:
                        panel.BackColor = Color.Yellow;
                        break;
                    case 3:
                        panel.BackColor = Color.Black;
                        break;
                }
            };
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Application.Run(new MyForm());
        }
    }
}