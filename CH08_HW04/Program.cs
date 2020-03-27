/*
 Напишите программу, в которой открывается окно с полем ввода. При вводе текста в окно этот текст автоматически дублируется в текстовой метке.
 В окне должны быть две опции, которые позволяют применять к тексту в метке жирный и курсивный стили.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace HW04
{
    class MyForm : Form
    {
        private Label lbl;
        private TextBox txtbox;
        private CheckBox italic;
        private CheckBox bold;
        public MyForm()
        {
            //Настройки главного окна
            this.Text = "Текст";
            this.Size = new Size(300, 155);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            //Настройки метки
            lbl = new Label();
            Font basefont = new Font(lbl.Font, lbl.Font.Style);
            lbl.SetBounds(5, 5, 200, 20);
            lbl.Text = "";
            this.Controls.Add(lbl);
            //Настройки текстбокса
            txtbox = new TextBox();
            txtbox.SetBounds(5, 25, 200, 10);
            txtbox.MaxLength = 25;
            txtbox.KeyUp += (a, b) =>
            {
                lbl.Text = txtbox.Text;
            };
            this.Controls.Add(txtbox);
            //Настройки 1 чекбокса
            italic = new CheckBox();
            italic.SetBounds(5, 50, 200, 20);
            italic.Text = "Курсив";
            italic.CheckedChanged += CheckedChanged;
            this.Controls.Add(italic);
            //Настройки 2 чекбокса
            bold = new CheckBox();
            bold.Text = "Жирный";
            bold.SetBounds(5, 70, 200, 20);
            bold.CheckedChanged += CheckedChanged;
            this.Controls.Add(bold);
        }
        private void CheckedChanged(object a, EventArgs b)
        {
            if (italic.Checked == true & bold.Checked == true) lbl.Font = new Font(lbl.Font, FontStyle.Bold | FontStyle.Italic);
            else if (italic.Checked == true & bold.Checked == false) lbl.Font = new Font(lbl.Font, FontStyle.Italic);
            else if (italic.Checked == false & bold.Checked == true) lbl.Font = new Font(lbl.Font, FontStyle.Bold);
            else lbl.Font = new Font(lbl.Font, FontStyle.Regular);
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
