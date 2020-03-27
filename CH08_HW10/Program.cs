/*
 Напишите программу, в которой отображается окно, представляющее собой арифметический калькулятор.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace HW10
{
    class MyForm : Form
    {
        private bool flag = true;
        private int num1 = 0;
        private int num2 = 0;
        private int res;
        private int move;
        private Label lbl;

        private Button bzero;
        private Button bone;
        private Button btwo;
        private Button bthree;
        private Button bfour;
        private Button bfive;
        private Button bsix;
        private Button bseven;
        private Button beight;
        private Button bnine;

        private Button plus;
        private Button sub;
        private Button multi;
        private Button equal;
        private Button restart;
        private Button back;

        public MyForm()
        {
            //Настройки главного окна
            this.Text = "Калькулятор";
            this.Size = new Size(350, 150);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            //Настройка текстбокса
            lbl = new Label();
            lbl.SetBounds(5, 5, 295, 20);
            lbl.BackColor = Color.White;
            lbl.Font = new Font(lbl.Font.FontFamily, 14, FontStyle.Regular);
            lbl.Text = "";
            lbl.TextAlign = ContentAlignment.MiddleRight;
            this.Controls.Add(lbl);
            //кнопки
            #region button digits
            bzero = new Button();
            bzero.SetBounds(5, 30, 30, 30);
            bzero.Text = "0";
            bzero.Click += (a, b) =>
            {
                flag = true;
                if (lbl.Text != "0" && lbl.Text != "" && lbl.Text.Length < 8) lbl.Text += 0;
                else if(lbl.Text == "") lbl.Text += 0;
            };
            this.Controls.Add(bzero);

            bone = new Button();
            bone.Size = bzero.Size;
            bone.Top = bzero.Top;
            bone.Left = bzero.Right + 5;
            bone.Text = "1";
            bone.Click += (a, b) =>
            {
                flag = true;
                if (lbl.Text != "0" && lbl.Text.Length < 8) lbl.Text += 1;
                else if (lbl.Text == "0")
                {
                    lbl.Text = "";
                    lbl.Text += 1;
                }
            };
            this.Controls.Add(bone);

            btwo = new Button();
            btwo.Size = bzero.Size;
            btwo.Top = bzero.Top;
            btwo.Left = bone.Right + 5;
            btwo.Text = "2";
            btwo.Click += (a, b) =>
            {
                flag = true;
                if (lbl.Text != "0" && lbl.Text.Length < 8) lbl.Text += 2;
                else if (lbl.Text == "0")
                {
                    lbl.Text = "";
                    lbl.Text += 2;
                }
            };
            this.Controls.Add(btwo);

            bthree = new Button();
            bthree.Size = bzero.Size;
            bthree.Top = btwo.Top;
            bthree.Left = btwo.Right + 5;
            bthree.Text = "3";
            bthree.Click += (a, b) =>
            {
                flag = true;
                if (lbl.Text != "0" && lbl.Text.Length < 8) lbl.Text += 3;
                else if (lbl.Text == "0")
                {
                    lbl.Text = "";
                    lbl.Text += 3;
                }
            };
            this.Controls.Add(bthree);

            bfour = new Button();
            bfour.Size = bzero.Size;
            bfour.Top = btwo.Top;
            bfour.Left = bthree.Right + 5;
            bfour.Text = "4";
            bfour.Click += (a, b) =>
            {
                flag = true;
                if (lbl.Text != "0" && lbl.Text.Length < 8) lbl.Text += 4;
                else if (lbl.Text == "0")
                {
                    lbl.Text = "";
                    lbl.Text += 4;
                }
            };
            this.Controls.Add(bfour);

            bfive = new Button();
            bfive.Size = bzero.Size;
            bfive.Top = btwo.Bottom + 5; ;
            bfive.Left = 5;
            bfive.Text = "5";
            bfive.Click += (a, b) =>
            {
                flag = true;
                if (lbl.Text != "0" && lbl.Text.Length < 8) lbl.Text += 5;
                else if (lbl.Text == "0")
                {
                    lbl.Text = "";
                    lbl.Text += 5;
                }
            };
            this.Controls.Add(bfive);

            bsix = new Button();
            bsix.Size = bzero.Size;
            bsix.Top = bfive.Top; ;
            bsix.Left = bfive.Right + 5;
            bsix.Text = "6";
            bsix.Click += (a, b) =>
            {
                flag = true;
                if (lbl.Text != "0" && lbl.Text.Length < 8) lbl.Text += 6;
                else if (lbl.Text == "0")
                {
                    lbl.Text = "";
                    lbl.Text += 6;
                }
            };
            this.Controls.Add(bsix);

            bseven = new Button();
            bseven.Size = bzero.Size;
            bseven.Top = bfive.Top; ;
            bseven.Left = bsix.Right + 5;
            bseven.Text = "7";
            bseven.Click += (a, b) =>
            {
                flag = true;
                if (lbl.Text != "0" && lbl.Text.Length < 8) lbl.Text += 7;
                else if (lbl.Text == "0")
                {
                    lbl.Text = "";
                    lbl.Text += 7;
                }
            };
            this.Controls.Add(bseven);

            beight = new Button();
            beight.Size = bzero.Size;
            beight.Top = bfive.Top; ;
            beight.Left = bseven.Right + 5;
            beight.Text = "8";
            beight.Click += (a, b) =>
            {
                flag = true;
                if (lbl.Text != "0" && lbl.Text.Length < 8) lbl.Text += 8;
                else if (lbl.Text == "0")
                {
                    lbl.Text = "";
                    lbl.Text += 8;
                }
            };
            this.Controls.Add(beight);

            bnine = new Button();
            bnine.Size = bzero.Size;
            bnine.Top = bfive.Top; ;
            bnine.Left = beight.Right + 5;
            bnine.Text = "9";
            bnine.Click += (a, b) =>
            {
                flag = true;
                if (lbl.Text != "0" && lbl.Text.Length < 8) lbl.Text += 9;
                else if (lbl.Text == "0")
                {
                    lbl.Text = "";
                    lbl.Text += 9;
                }
            };
            this.Controls.Add(bnine);
            #endregion button digits

            plus = new Button();
            plus.Size = bzero.Size;
            plus.Top = bzero.Top; ;
            plus.Left = bfour.Right + 15;
            plus.Text = "+";
            plus.Click += (a, b) =>
            {
                if (num1 == 0 && lbl.Text != "")
                {
                    num1 = Int32.Parse(lbl.Text);
                    lbl.Text = "";
                    move = 0;
                }
                else if (num1 != 0 && lbl.Text == "")
                {
                    move = 0;
                }
                else
                {
                    if (lbl.Text != "")
                    {
                        num2 = Int32.Parse(lbl.Text);
                        lbl.Text = "";
                        move = 0;
                        res = num1 + num2;
                        num1 = num2;
                        num2 = res;
                    }
                }


            };
            this.Controls.Add(plus);

            sub = new Button();
            sub.Size = bzero.Size;
            sub.Top = plus.Top; ;
            sub.Left = plus.Right + 5;
            sub.Text = "-";
            sub.Click += (a, b) =>
            {
                if (num1 == 0 && lbl.Text != "")
                {
                    num1 = Int32.Parse(lbl.Text);
                    lbl.Text = "";
                    move = 1;
                }
                else if (num1 != 0 && lbl.Text == "")
                {
                    move = 1;
                }
                else
                {
                    if (lbl.Text != "")
                    {
                        num2 = Int32.Parse(lbl.Text);
                        lbl.Text = "";
                        move = 1;
                        res = num1 - num2;
                        num1 = res;
                        num2 = num1;
                    }
                }


            };
            this.Controls.Add(sub);

            multi = new Button();
            multi.Size = bzero.Size;
            multi.Top = sub.Top; ;
            multi.Left = sub.Right + 5;
            multi.Text = "*";
            multi.Click += (a, b) =>
            {
                if (num1 == 0 && lbl.Text != "")
                {
                    num1 = Int32.Parse(lbl.Text);
                    lbl.Text = "";
                    move = 2;
                }
                else if(num1 != 0 && lbl.Text == "")
                {
                    move = 2;
                }
                else
                {
                    if (lbl.Text != "")
                    {
                        num2 = Int32.Parse(lbl.Text);
                        lbl.Text = "";
                        move = 2;
                        res = num1 * num2;
                        num1 = res;
                        num2 = num1;
                    }
                }


            };
            this.Controls.Add(multi);

            equal = new Button();
            equal.Size = bzero.Size;
            equal.Top = plus.Bottom + 5; ;
            equal.Left = plus.Left;
            equal.Text = "=";
            equal.Click += (a, b) =>
            {
                if (lbl.Text != "" && num1!=0)
                {
                    switch (move)
                    {
                        case 0:
                            if (num2 == 0) num2 = Int32.Parse(lbl.Text);
                            res = num1 + num2;
                            lbl.Text = res.ToString();
                            num1 = 0;
                            num2 = 0;
                            res = 0;
                            flag = false;
                            break;
                        case 1:
                            if (num2 == 0) num2 = Int32.Parse(lbl.Text);
                            res = num1 - num2;
                            lbl.Text = res.ToString();
                            num1 = 0;
                            num2 = 0;
                            res = 0;
                            flag = false;
                            break;
                        case 2:
                            if (num2 == 0) num2 = Int32.Parse(lbl.Text);
                            res = num1 * num2;
                            lbl.Text = res.ToString();
                            num1 = 0;
                            num2 = 0;
                            res = 0;
                            flag = false;
                            break;
                    };
                }
                else 
                {
                    if (flag)
                    {
                        switch (move)
                        {
                            case 0:
                                if (lbl.Text != "") num2 = Int32.Parse(lbl.Text);
                                lbl.Text = (num2 + num1).ToString();
                                num1 = 0;
                                num2 = 0;
                                res = 0;
                                flag = false;
                                break;
                            case 1:
                                if (lbl.Text != "") num2 = Int32.Parse(lbl.Text);
                                lbl.Text = (num1 - num2).ToString();
                                num1 = 0;
                                num2 = 0;
                                res = 0;
                                flag = false;
                                break;
                            case 2:
                                if (lbl.Text != "") num2 = Int32.Parse(lbl.Text);
                                lbl.Text = (num2 * num1).ToString();
                                num1 = 0;
                                num2 = 0;
                                res = 0;
                                flag = false;
                                break;
                        };
                    }
                }
            };
            this.Controls.Add(equal);

            restart = new Button();
            restart.Size = bzero.Size;
            restart.Top = plus.Bottom + 5; ;
            restart.Left = equal.Right + 5;
            restart.Text = "CE";
            restart.Click += (a, b) =>
            {
                lbl.Text = "";
                num1 = 0;
                num2 = 0;
                res = 0;

            };
            this.Controls.Add(restart);

            back = new Button();
            back.Size = bzero.Size;
            back.Top = plus.Bottom + 5; ;
            back.Left = restart.Right + 5;
            back.Text = "<-";
            back.Click += (a, b) =>
            {
                if (lbl.Text != "")
                {
                    string tmp = lbl.Text;
                    tmp = tmp.Remove(tmp.Length - 1, 1);
                    lbl.Text = tmp;
                }
            };
            this.Controls.Add(back);
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