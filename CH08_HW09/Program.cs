/*
Напишите программу, в которой отображается окно с главным меню и областью с текстом. Текст содержит информацию о названии, стиле и размере шрифта,
которым отображается текст. В меню есть пункты для выбора названия шрифта, стиля шрифта и размера шрифта. При выборе команды из меню соответствующая характеристика
применяется для отображения текста, а также с учетом новых параметров шрифта меняется сам текст.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace HW09
{
    class MyForm : Form
    {
        private MainMenu mm;
        private Label lbl;
        private string[] fonts = { "Times New Roman", "Arial", "Comic Sans MS", "Georgia" };
        FontStyle[] fs = { FontStyle.Bold, FontStyle.Italic, FontStyle.Regular };
        Color[] clrs = { Color.Red, Color.Green, Color.Blue, Color.Black };

        public MyForm()
        {
            //настройки главного окна
            this.Text = "Main Menu";
            this.Size = new Size(400, 200);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            //настройка текста
            lbl = new Label();
            lbl.Text = $"Шрифт: {lbl.Font.Name} Размер: {lbl.Font.Size} Стиль: {lbl.Font.Style}";
            lbl.SetBounds(5, 50, 350, 100);
            this.Controls.Add(lbl);
            //настройки главного меню
            mm = new MainMenu();
            MenuItem[] main = { new MenuItem("Шрифт"), new MenuItem("Стиль"), new MenuItem("Цвет") };
            //настройка подменю "ШРИФТ"
            for (int i = 0; i < fonts.Length; i++)
            {
                int x = i;
                MenuItem tmp = new MenuItem(fonts[x]);
                tmp.Click += (a, b) =>
                {
                    lbl.Font = new Font(fonts[x], lbl.Font.Size, lbl.Font.Style);
                    lbl.Text = $"Шрифт: {lbl.Font.Name} Размер: {lbl.Font.Size} Стиль: {lbl.Font.Style}";
                };
                main[0].MenuItems.Add(tmp);
            }
            //настройка подменю "СТИЛЬ"
            MenuItem[] style = { new MenuItem("Жирный"), new MenuItem("Курсив"), new MenuItem("Обычный") };
            for (int i = 0; i < fs.Length; i++)
            {
                int x = i;
                MenuItem tmp = new MenuItem(style[x].Text);
                tmp.Click += (a, b) =>
                {
                    lbl.Font = new Font(lbl.Font.FontFamily, lbl.Font.Size, fs[x]);
                    lbl.Text = $"Шрифт: {lbl.Font.Name} Размер: {lbl.Font.Size} Стиль: {lbl.Font.Style}";
                };
                main[1].MenuItems.Add(tmp);
            }
            //настройка подменю "ЦВЕТ"
            MenuItem[] colors = { new MenuItem("Красный"), new MenuItem("Зеленый"), new MenuItem("Синий"), new MenuItem("Черный") };
            for (int i = 0; i < clrs.Length; i++)
            {
                int x = i;
                MenuItem tmp = new MenuItem(colors[x].Text);
                tmp.Click += (a, b) =>
                {
                    lbl.ForeColor = clrs[x];
                    lbl.Text = $"Шрифт: {lbl.Font.Name} Размер: {lbl.Font.Size} Стиль: {lbl.Font.Style}";
                };
                main[2].MenuItems.Add(tmp);
            }

            mm.MenuItems.AddRange(main);
            this.Menu = mm;
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