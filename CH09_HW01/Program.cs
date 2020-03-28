/*
 Напишите программу, в которой генерируется случайное целое число (например, в диапазоне от 1 до 10), а пользователю необходимо его угадать.
 Если пользователь не угадал число, программа выдает запрос о том, хочет ли он попробовать ещё раз. Процесс заканчивается, если пользователь
 угадывает число или отказывается угадывать снова. Для ввода чисел использовать окно с полем ввода, а для запроса о желании продолжить
 угадывание использовать окно с кнопками Да/нет.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace HW01
{
    class MyForm : Form
    {
        Label lbl;
        TextBox tb;
        Button btn;
        DialogResult res;
        Random rnd = new Random();
        int num;
        public MyForm()
        {
            num = rnd.Next(1, 11);

            this.Text = "Угадай число";
            this.Size = new Size(260, 130);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            lbl = new Label();
            lbl.SetBounds(5, 5, 185, 20);
            lbl.Text = "Угадайте число от 1 до 10";
            this.Controls.Add(lbl);

            tb = new TextBox();
            tb.SetBounds(5, 30, 185, 20);
            this.Controls.Add(tb);

            btn = new Button();
            btn.Top = tb.Bottom + 5;
            btn.Left = tb.Left;
            btn.Size = new Size(50, 20);
            btn.Text = "Try!";
            btn.Click += OnClickTry;
            this.Controls.Add(btn);
        }
        private void OnClickTry(object obj, EventArgs ae)
        {
            try
            {
                if (int.Parse(tb.Text) == num)
                {
                    MessageBox.Show("Вы угадали!", "Ура!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Application.Exit();
                }
                else
                {
                    res = MessageBox.Show("Неудача, попробовать ещё раз?", "Не получилось...", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                    if (res == DialogResult.No) Application.Exit();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Вы ввели не число, попробуйте ещё раз", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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