/*
 Напишите программу, отображающую окно, в котором внутренняя часть закрашена желтым цветом.
 При наведении курсора на область окна цвет фона меняется на зеленый. При щелчке мышью
 размер окна должен увеличиваться на 10%.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace HW01
{
    class MyForm : Form
    {
        private Color baseColor;
        public MyForm()
        {
            this.Text = "Yo!";
            this.Width = 200;
            this.Height = 100;

            FormBorderStyle = FormBorderStyle.Fixed3D;

            baseColor = BackColor;
            MouseEnter += (a, b) => {
                BackColor = Color.Green;
            };
            MouseLeave += (a, b) =>
            {
                BackColor = baseColor;
            };
            Click += (a, b) =>
            {
                this.Width = (int)(this.Width * 1.1);
                this.Height = (int)(this.Height * 1.1);
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
