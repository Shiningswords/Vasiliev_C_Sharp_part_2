/*
Напишите программу, в которой отображается окно со списком выбора. В списке выбора представлены названия шрифтов. Также окно содержит
раскрывающийся список с названиями цветов (красный, зеленый, синий и т.д.). Окно содержит область с текстом. При выборе цвета или
названия шрифта этот цвет или шрифт применяются для отображения текста.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace HW07
{
    class MyForm : Form
    {
        private Color[] clrs = { Color.Red, Color.Yellow, Color.Blue, Color.Black };
        private Label lbl;
        private ListBox lb;
        private ComboBox cb;
        public MyForm()
        {
            //Настройки главного окна
            this.Text = "Шрифт и цвет";
            this.Size = new Size(255, 155);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            //Настройки текста
            lbl = new Label();
            lbl.SetBounds(5, 5, 200, 20);
            lbl.Text = "Шрифт и цвет!!!";
            this.Controls.Add(lbl);
            //Настройка листбокса
            lb = new ListBox();
            lb.SetBounds(5, 30, 100, 60);
            lb.Items.AddRange(new string[] { "Times New Roman", "Arial", "Comic Sans MS", "Georgia" });
            lb.SelectedIndexChanged += (a, b) =>
            {
                lbl.Font = new Font(lb.Text, lbl.Font.Size, lbl.Font.Style);
            };
            this.Controls.Add(lb);
            //Настройка комбобокса
            cb = new ComboBox();
            cb.SetBounds(110, 30, 100, 50);
            cb.Items.AddRange(new string[] { "Красный", "Желтый", "Синий", "Черный" });
            cb.SelectedIndexChanged += (a, b) =>
            {
                lbl.ForeColor = clrs[cb.SelectedIndex];
            };
            this.Controls.Add(cb);
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
