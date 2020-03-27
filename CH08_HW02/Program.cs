/*
 Напишите программу, в которой отображается окно с текстовой меткой и тремя кнопками. В текстовой метке содержится число
 (начальное значение - нулевое). Щелчок по одной из кнопок приводит к увеличению значения на единицу. Щелчок по другой кнопке приводит
 к уменьшению значения на единицу. Щелчок по третьей кнопки приводит к закрытию приложения.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace HW02
{
    class Program
    {
        class MyForm : Form
        {
            int num = 0;
            public MyForm()
            {
                //Настройки основного окна
                this.Text = "Fun with numbers";
                this.Size = new Size(300, 140);
                this.FormBorderStyle = FormBorderStyle.FixedSingle;
                this.MaximizeBox = false;
                //Настройки метки с текстом
                Label lbl = new Label();
                lbl.Text = num.ToString();
                lbl.Location = new Point(10, 10);
                lbl.Width = 265;
                lbl.Height = 40;
                lbl.TextAlign = ContentAlignment.MiddleCenter;
                lbl.BorderStyle = BorderStyle.Fixed3D;
                Font F = new Font("Arial", 15, FontStyle.Italic);
                lbl.Font = F;
                lbl.ForeColor = Color.Blue;
                this.Controls.Add(lbl);
                //Первая кнопка
                Button btn1 = new Button();
                btn1.Location = new Point(10, 55);
                btn1.Height = lbl.Height;
                btn1.Width = lbl.Width / 3;
                btn1.Text = "+";
                btn1.Font = new Font("Arial", 15, FontStyle.Italic);
                btn1.Click += (a, b) =>
                {
                    num++;
                    lbl.Text = num.ToString();
                };
                this.Controls.Add(btn1);
                //Вторая кнопка
                Button btn2 = new Button();
                btn2.Location = new Point(10, 55);
                btn2.Height = lbl.Height;
                btn2.Width = lbl.Width / 3;
                btn2.Left = btn2.Width + 12;
                btn2.Text = "-";
                btn2.Font = new Font("Arial", 15, FontStyle.Italic);
                btn2.Click += (a, b) =>
                {
                    num--;
                    lbl.Text = num.ToString();
                };
                this.Controls.Add(btn2);
                //Третья кнопка
                Button btn3 = new Button();
                btn3.Location = new Point(10, 55);
                btn3.Height = lbl.Height;
                btn3.Width = lbl.Width / 3;
                btn3.Left = btn3.Width * 2 + 14;
                btn3.Text = "Закрыть";
                btn3.Font = new Font("Arial", 10, FontStyle.Bold);
                btn3.Click += (a, b) =>
                {
                    Application.Exit();
                };
                this.Controls.Add(btn3);
            }
        }
        static void Main(string[] args)
        {
            Application.Run(new MyForm());
        }
    }
}