using System;
using System.Linq;
using System.Windows.Forms;

namespace Calculator2024 {

    public partial class frmCalculator : Form {

        double Acc, Num1, Num2 = 0, Type = 0, Back = 0;
        int vComma = 0;
        double vSum = 0, vMinus = 0, vDiv = 0, vTimes = 0, vRoot = 0, vTot = 0;
        bool N1 = true, N2 = false, Count = true, CountEqual = false;

        private void btn0_Click(object sender, EventArgs e) {

            txt1.Text += "0";
            Str();
            Numbers();
            Verify();
            VerifyRoot();
            BackNumber();
            VerifyComma();
            VerifyBack();
            ThereIsPoint();
        }

        private void btn1_Click(object sender, EventArgs e) {

            txt1.Text += "1";
            Str();
            Numbers();
            Verify();
            VerifyRoot();
            BackNumber();
            VerifyComma();
            VerifyBack();
            ThereIsPoint();
        }

        private void btn2_Click(object sender, EventArgs e) {

            txt1.Text += "2";
            Str();
            Numbers();
            Verify();
            VerifyRoot();
            BackNumber();
            VerifyComma();
            VerifyBack();
            ThereIsPoint();
        }

        private void btn3_Click(object sender, EventArgs e) {

            txt1.Text += "3";
            Str();
            Numbers();
            Verify();
            VerifyRoot();
            BackNumber();
            VerifyComma();
            VerifyBack();
            ThereIsPoint();
        }

        private void btn4_Click(object sender, EventArgs e) {

            txt1.Text += "4";
            Str();
            Numbers();
            Verify();
            VerifyRoot();
            BackNumber();
            VerifyComma();
            VerifyBack();
            ThereIsPoint();
        }

        private void btn5_Click(object sender, EventArgs e) {

            txt1.Text += "5";
            Str();
            Numbers();
            Verify();
            VerifyRoot();
            BackNumber();
            VerifyComma();
            VerifyBack();
            ThereIsPoint();
        }

        private void btn6_Click(object sender, EventArgs e) {

            txt1.Text += "6";
            Str();
            Numbers();
            Verify();
            VerifyRoot();
            BackNumber();
            VerifyComma();
            VerifyBack();
            ThereIsPoint();
        }

        private void btn7_Click(object sender, EventArgs e) {

            txt1.Text += "7";
            Str();
            Numbers();
            Verify();
            VerifyRoot();
            BackNumber();
            VerifyComma();
            VerifyBack();
            ThereIsPoint();
        }

        private void btn8_Click(object sender, EventArgs e) {

            txt1.Text += "8";
            Str();
            Numbers();
            Verify();
            VerifyRoot();
            BackNumber();
            VerifyComma();
            VerifyBack();
            ThereIsPoint();
        }

        private void btn9_Click(object sender, EventArgs e) {

            txt1.Text += "9";
            Str();
            Numbers();
            Verify();
            VerifyRoot();
            BackNumber();
            VerifyComma();
            VerifyBack();
            ThereIsPoint();
        }

        private void btnPlus_Click(object sender, EventArgs e) {

            vComma = 0;
            Acc = 0;
            Count = false;
            Type = 1;
            btnP.Enabled = false;
            btnPlus.Enabled = false;
            btnBack.Enabled = false;
            btnMinus.Enabled = false;
            btnTimes.Enabled = false;
            btnRoot.Enabled = false;
            btnDivision.Enabled = false;
            btnEqual.Enabled = false;
            Num1 = double.Parse(txt1.Text);
            textBox1.Text += " + ";
            N1 = false;
            N2 = true;
            txt1.Clear();
            btnMinus.Enabled = false;
            btnTimes.Enabled = false;
            btnDivision.Enabled = false;
            btnRoot.Enabled = false;
            btnPlus.Enabled = false;
        }

        private void btnMinus_Click(object sender, EventArgs e) {

            vComma = 0;
            Acc = 1;
            Count = false;
            Type = 1;
            btnP.Enabled = false;
            btnPlus.Enabled = false;
            btnMinus.Enabled = false;
            btnBack.Enabled = false;
            btnTimes.Enabled = false;
            btnRoot.Enabled = false;
            btnDivision.Enabled = false;
            btnEqual.Enabled = false;
            Num1 = double.Parse(txt1.Text);
            textBox1.Text += " - ";
            N1 = false;
            N2 = true;
            txt1.Clear();
            btnMinus.Enabled = false;
            btnTimes.Enabled = false;
            btnDivision.Enabled = false;
            btnRoot.Enabled = false;
            btnPlus.Enabled = false;
        }

        private void btnTimes_Click(object sender, EventArgs e) {

            vComma = 0;
            Acc = 2;
            Count = false;
            Type = 1;
            btnP.Enabled = false;
            btnPlus.Enabled = false;
            btnMinus.Enabled = false;
            btnBack.Enabled = false;
            btnTimes.Enabled = false;
            btnRoot.Enabled = false;
            btnDivision.Enabled = false;
            btnEqual.Enabled = false;
            Num1 = double.Parse(txt1.Text);
            textBox1.Text += " x ";
            N1 = false;
            N2 = true;
            txt1.Clear();
            btnMinus.Enabled = false;
            btnTimes.Enabled = false;
            btnDivision.Enabled = false;
            btnRoot.Enabled = false;
            btnPlus.Enabled = false;
        }

        private void btnDivision_Click(object sender, EventArgs e) {

            vComma = 0;
            Acc = 3;
            Count = false;
            Type = 1;
            btnP.Enabled = false;
            btnPlus.Enabled = false;
            btnBack.Enabled = false;
            btnMinus.Enabled = false;
            btnTimes.Enabled = false;
            btnRoot.Enabled = false;
            btnDivision.Enabled = false;
            btnEqual.Enabled = false;
            Num1 = double.Parse(txt1.Text);
            textBox1.Text += " ÷ ";
            N1 = false;
            N2 = true;
            txt1.Clear();
            btnMinus.Enabled = false;
            btnTimes.Enabled = false;
            btnDivision.Enabled = false;
            btnRoot.Enabled = false;
            btnPlus.Enabled = false;
        }

        private void btnRoot_Click(object sender, EventArgs e) {

            Acc = 4;
            btnRoot.Enabled = false;
            textBox1.Text = "√";
            txt1.Clear();
        }

        private void btnBack_Click(object sender, EventArgs e) {
            
            txt1.Text = txt1.Text.Remove(txt1.Text.Length - 1);
            textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);

            if (txt1.Text.Length == 0) {

                btnBack.Enabled = false;
                btnRoot.Enabled = true;
                btnPlus.Enabled = false;
                btnMinus.Enabled = false;
                btnTimes.Enabled = false;
                btnDivision.Enabled = false;
                btnP.Enabled = false;
            }
            else {

                btnBack.Enabled = true;
            }

            if (Type == 1 && txt1.Text.Length == 0) {

                btnRoot.Enabled = false;
                btnBack.Enabled = false;
                btnEqual.Enabled = false;
            }

            if (Type == 1 && txt1.Text.Length > 0)
                Num2 = double.Parse(txt1.Text);

            if (textBox1.Text.Length > 0) {
                
                btnRoot.Enabled = false;
                btnEqual.Enabled = false;
            }
        }

        public void VerifyBack() {

            if (txt1.Text.Length == 0)
                btnBack.Enabled = false;
            else
                btnBack.Enabled = true;
        }        

        private void btnP_Click(object sender, EventArgs e) {

            vComma++;
            txt1.Text += ".";
            textBox1.Text += ".";
            btnP.Enabled = false;
            btnPlus.Enabled = false;
            btnMinus.Enabled = false;
            btnTimes.Enabled = false;
            btnDivision.Enabled = false;
        }

        public void ThereIsPoint() {
            
            if (Type == 0) {
                
                if (txt1.Text.Length > 0 || textBox1.Text.Length > 0) {
                    
                    if (txt1.Text.Contains(".") || textBox1.Text.Contains("."))                    
                        btnP.Enabled = false;                    
                    else                    
                        btnP.Enabled = true;                    
                }
            }

            if (Type == 1) {
                
                if (txt1.Text.Length > 0) {
                    
                    if (txt1.Text.Contains("."))
                        btnP.Enabled = false;
                    else
                        btnP.Enabled = true;
                }
            }
        }        

        private void btnEqual_Click(object sender, EventArgs e) {

            if (Acc == 0) {

                txt1.Text = Convert.ToString(Num1 + Num2);
                textBox1.Text += " = " + Convert.ToString(Num1 + Num2);
                vSum++;
                lblSum.Text = vSum.ToString();
                vTot++;
                lblTotal.Text = vTot.ToString();                
            }
            else if (Acc == 1) {

                txt1.Text = Convert.ToString(Num1 - Num2);
                textBox1.Text += " = " + Convert.ToString(Num1 - Num2);
                vMinus++;
                lblMinus.Text = vMinus.ToString();
                vTot++;
                lblTotal.Text = vTot.ToString();                
            }
            else if (Acc == 2) {

                txt1.Text = Convert.ToString(Num1 * Num2);
                textBox1.Text += " = " + Convert.ToString(Num1 * Num2);
                vTimes++;
                lblTimes.Text = vTimes.ToString();
                vTot++;
                lblTotal.Text = vTot.ToString();                
            }
            else if (Acc == 3) {

                if (double.IsNaN(Num1 / Num2)) {

                    textBox1.Text = $"{Num1} ÷ {Num2} = Indeterminacy...";
                    txt1.Text = "Indeterminacy...";
                    vDiv++;
                    lblDiv.Text = vDiv.ToString();
                    vTot++;
                    lblTotal.Text = vTot.ToString();
                }
                else {

                    txt1.Text = Convert.ToString(Num1 / Num2);
                    textBox1.Text += " = " + Convert.ToString(Num1 / Num2);
                    vDiv++;
                    lblDiv.Text = vDiv.ToString();
                    vTot++;
                    lblTotal.Text = vTot.ToString();
                }
            }
            else if (Acc == 4) {

                Num1 = double.Parse(txt1.Text);
                textBox1.Text += " = " + Math.Sqrt((double)Num1);
                txt1.Text = Math.Sqrt((double)Num1).ToString();
                vRoot++;
                lblRoot.Text = vRoot.ToString();
                vTot++;
                lblTotal.Text = vTot.ToString();              
            }

            /* Int Truncate */
            lblTotSum.Text = Math.Round(vSum / vTot * 100, 2).ToString();
            lblTotMinus.Text = Math.Round(vMinus / vTot * 100, 2).ToString();
            lblTotTimes.Text = Math.Round(vTimes / vTot * 100, 2).ToString();
            lblTotDiv.Text = Math.Round(vDiv / vTot * 100, 2).ToString();
            lblTotRoot.Text = Math.Round(vRoot / vTot * 100, 2).ToString();        
            
            btnEqual.Enabled = false;
            btn0.Enabled = false;
            btn1.Enabled = false;
            btn2.Enabled = false;
            btn3.Enabled = false;
            btn4.Enabled = false;
            btn5.Enabled = false;
            btn6.Enabled = false;
            btn7.Enabled = false;
            btn8.Enabled = false;
            btn9.Enabled = false;
            btnMinus.Enabled = false;
            btnBack.Enabled = false;
            btnPlus.Enabled = false;
            btnDivision.Enabled = false;
            btnRoot.Enabled = false;
            btnTimes.Enabled = false;
            btnP.Enabled = false;
            btnC.Focus();
        }

        public void Str() {

            if (Type == 0) {

                textBox1.Text = txt1.Text;
                CountEqual = false;
            }
            if (Type == 0 && Acc == 4)
                textBox1.Text = decimal.Parse(txt1.Text).ToString();

            /* Logic used for the second number, where "txt1.Text" is already empty! */
            if (Type == 1 && Acc == 0) {

                CountEqual = true;
                Num2 = double.Parse(txt1.Text);
                textBox1.Text = Num1 + " + " + Num2.ToString();
            }
            if (Type == 1 && Acc == 1) {

                CountEqual = true;
                Num2 = double.Parse(txt1.Text);
                textBox1.Text = Num1 + " - " + Num2.ToString();
            }
            if (Type == 1 && Acc == 2) {

                CountEqual = true;
                Num2 = double.Parse(txt1.Text);
                textBox1.Text = Num1 + " x " + Num2.ToString();
            }
            if (Type == 1 && Acc == 3) {

                CountEqual = true;
                Num2 = double.Parse(txt1.Text);
                textBox1.Text = Num1 + " ÷ " + Num2.ToString();
            }
        }

        public void Numbers() {

            btnPlus.Enabled = true;
            btnTimes.Enabled = true;
            btnDivision.Enabled = true;
            btnRoot.Enabled = false;
            btnEqual.Enabled = false;
            btnP.Enabled = true;
            btnMinus.Enabled = true;

            if (CountEqual == false)
                btnEqual.Enabled = false;
            else
                btnEqual.Enabled = true;
        }

        public void Verify() {

            if (Count == false) {

                btnPlus.Enabled = false;
                btnTimes.Enabled = false;
                btnRoot.Enabled = false;
                btnDivision.Enabled = false;
                btnMinus.Enabled = false;
            }
        }

        private void btnC_Click(object sender, EventArgs e) {

            vComma = 0;
            Back++;
            txt1.Text = "";
            textBox1.Text = "";
            Acc = 5;
            Num1 = 0;
            Num2 = 0;
            btnEqual.Enabled = false;
            btn0.Enabled = true;
            btn1.Enabled = true;
            btn2.Enabled = true;
            btn3.Enabled = true;
            btn4.Enabled = true;
            btn5.Enabled = true;
            btn6.Enabled = true;
            btn7.Enabled = true;
            btn8.Enabled = true;
            btn9.Enabled = true;
            btnMinus.Enabled = false;
            btnBack.Enabled = false;
            btnDivision.Enabled = false;
            btnRoot.Enabled = true;
            btnTimes.Enabled = false;
            btnP.Enabled = false;
            btnPlus.Enabled = false;
            Count = true;
        }

        public void BackNumber() {

            if (Back >= 1) {

                btnEqual.Enabled = false;
                textBox1.Text = txt1.Text;

                if (Acc < 5) {

                    btnEqual.Enabled = true;

                    /* SHOWING ON TEXT STARTS HERE... */
                    if (Acc == 4) {

                        Num1 = double.Parse(txt1.Text);
                        textBox1.Text = "√" + Num1.ToString();
                    }
                    if (Type == 1 && Acc == 0) {

                        Num2 = double.Parse(txt1.Text);
                        textBox1.Text = Num1 + " + " + Num2.ToString();
                    }
                    if (Type == 1 && Acc == 1) {

                        Num2 = double.Parse(txt1.Text);
                        textBox1.Text = Num1 + " - " + Num2.ToString();
                    }
                    if (Type == 1 && Acc == 2) {

                        Num2 = double.Parse(txt1.Text);
                        textBox1.Text = Num1 + " x " + Num2.ToString();
                    }
                    if (Type == 1 && Acc == 3) {

                        Num2 = double.Parse(txt1.Text);
                        textBox1.Text = Num1 + " ÷ " + Num2.ToString();
                    }
                }
            }
        }

        public void VerifyRoot() {

            if (Acc == 4) {

                textBox1.Text = "√" + decimal.Parse(txt1.Text);
                btnPlus.Enabled = false;
                btnMinus.Enabled = false;
                btnDivision.Enabled = false;
                btnRoot.Enabled = false;
                btnTimes.Enabled = false;
                btnEqual.Enabled = true;
            }
        }

        public void VerifyComma() {

            if (vComma == 1)
                btnP.Enabled = false;
            else
                btnP.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e) {

            this.IsMdiContainer = false;
            this.Hide();
            frmRate frm = new frmRate();
            frm.MdiParent = frmCalculator.ActiveForm;
            frm.Show();
        }

        public frmCalculator() => InitializeComponent();
        private void txt1_TextChanged(object sender, EventArgs e) => ThereIsPoint();
        private void textBox1_TextChanged(object sender, EventArgs e) => ThereIsPoint();
        private void Form1_Load(object sender, EventArgs e) => this.Enabled = true;
        private void btnExit_Click(object sender, EventArgs e) => Application.Exit();
    }
}
