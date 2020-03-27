/*
Напишите программу, в которой отображается окно с закрашенной областью. Для это области есть контекстное меню с названиями цветов
(красный, желтый, зеленый и т.д.). При выборе команды из контекстного меню область закрашивается соответствующим цветом.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace HW08
{
    class MyForm : Form
    {
        private Panel p;
        private ContextMenuStrip cm;
        private string[] clrs = { "Красный", "Зеленый", "Синий", "Черный", "Желтый" };
        private Color[] colors = { Color.Red, Color.Green, Color.Blue, Color.Black, Color.Yellow };
        public MyForm()
        {
            //настройки главного окна
            this.Text = "Контекстное меню";
            this.Size = new Size(255, 155);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            //Настройки панели
            p = new Panel();
            p.SetBounds(10, 10, 200, 80);
            p.BackColor = Color.White;
            this.Controls.Add(p);
            //Настройка контекстного меню
            cm = new ContextMenuStrip();
            for (int i = 0; i < clrs.Length; i++)
            {
                cm.Items.Add(clrs[i]);
            }

            for (int i = 0; i < cm.Items.Count; i++)
            {
                int x = i;
                cm.Items[i].Click += (a, b) =>
                {
                    p.BackColor = colors[x];
                };
            }

            p.ContextMenuStrip = cm;
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