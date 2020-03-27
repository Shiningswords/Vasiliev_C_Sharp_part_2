/*
Напишите программу, в которой отображается окно с изображением и двумя кнопками. Имеется несколько изображений, которые последовательно циклически
отображаются в окне при щелчке по кнопкам. При щелчке по одной кнопке появляется следующее изображение в последовательности, а при щелчке по другой кнопке
отображается предыдущее изображение в последовательности.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace HW06
{
    class MyForm : Form
    {
        private Label pict;
        private Button b1;
        private Button b2;
        private string path = "animals/";
        private string[] files = { "wolf.jpg", "fox.jpg", "bear.jpg", "raccoon.jpg" };
        private int index = 0;
        public MyForm()
        {
            //Настройки главного окна
            this.Text = "В мире животных";
            this.Size = new Size(255, 155);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            //Настройки изображения
            pict = new Label();
            pict.SetBounds(5, 5, 154, 104);
            pict.BorderStyle = BorderStyle.FixedSingle;
            pict.Image = Image.FromFile(path + files[index]);
            this.Controls.Add(pict);
            //Настройки первой кнопки
            b1 = new Button();
            b1.Text = "->";
            b1.Size = new Size(70, 20);
            b1.Left = pict.Right + 5;
            b1.Top = pict.Top;
            b1.Click += (a, b) =>
            {
                if (++index > files.Length - 1)
                {
                    index = 0;
                    pict.Image = Image.FromFile(path + files[index]);
                }
                else pict.Image = Image.FromFile(path + files[index]);
            };
            this.Controls.Add(b1);
            //Настройки второй кнопки
            b2 = new Button();
            b2.Text = "<-";
            b2.Size = new Size(70, 20);
            b2.Left = b1.Left;
            b2.Top = b1.Bottom + 5;
            b2.Click += (a, b) =>
            {
                if (--index < 0)
                {
                    index = files.Length - 1;
                    pict.Image = Image.FromFile(path + files[index]);
                }
                else pict.Image = Image.FromFile(path + files[index]);
            };
            this.Controls.Add(b2);
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