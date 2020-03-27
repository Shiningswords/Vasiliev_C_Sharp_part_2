/*
Напишите программу, в которой отображается окно с двуя текстовыми полями. Предполагается, что в эти текстовые поля вводятся целочисленные значения.
Кроме полей, в окне размещена метка, в которой содержится информация о том, какое из двух чисел больше/меньше или что числа равны друг другу.
Информация в метке обновляется автоматически при изменении содержимого полей. Если хотя бы в одном из полей указано не число, метка должна содержать информацию об этом.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace HW05
{
    class MyForm : Form
    {
        private TextBox tb1;
        private TextBox tb2;
        private Label lbl;
        public MyForm()
        {
            //Настройки главного окна
            this.Text = ">=<";
            this.Size = new Size(300, 155);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            //Настройки метки
            lbl = new Label();
            Font basefont = new Font(lbl.Font, lbl.Font.Style);
            lbl.SetBounds(5, 5, 200, 20);
            lbl.Text = "";
            this.Controls.Add(lbl);
            //настройки первого текстбокса
            tb1 = new TextBox();
            tb1.Left = lbl.Left;
            tb1.Top = lbl.Bottom + 5;
            tb1.Height = lbl.Height;
            tb1.Width = lbl.Width;
            tb1.MaxLength = 8;
            tb1.KeyUp += CheckedTextBoxes;
            this.Controls.Add(tb1);
            //настройки второго текстбокса
            tb2 = new TextBox();
            tb2.Left = tb1.Left;
            tb2.Top = tb1.Bottom + 5;
            tb2.Height = lbl.Height;
            tb2.Width = lbl.Width;
            tb2.MaxLength = 8;
            tb2.KeyUp += CheckedTextBoxes;
            this.Controls.Add(tb2);
        }
        private void CheckedTextBoxes(object obj, EventArgs ea)
        {
            try
            {
                if (Int32.Parse(tb1.Text) > Int32.Parse(tb2.Text)) lbl.Text = $"{tb1.Text} > {tb2.Text}";
                else if (Int32.Parse(tb1.Text) < Int32.Parse(tb2.Text)) lbl.Text = $"{tb1.Text} < {tb2.Text}";
                else lbl.Text = $"{tb1.Text} = {tb2.Text}";
            }
            catch (Exception)
            {
                lbl.Text = $"В одном из полей введено не число";
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