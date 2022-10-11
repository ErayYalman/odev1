using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vizefinalgorsel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {         
                           
                short vize, final;
                float ort, vizey, finaly;
                vize = short.Parse(textBox1.Text);
                final = Convert.ToInt16(textBox4.Text);
                vizey = Convert.ToInt16(textBox3.Text);
                finaly = Convert.ToInt16(textBox2.Text);

                if (vize < 0 || vize > 100)
                {
                    MessageBox.Show("hatalı vize notu lütfen 0-100 arası not giriniz");
                    label5.Visible = false;
                    label6.Visible = false;
                    label7.Visible = false;
                    label8.Visible = false;
                }
                else if (final < 0 || final > 100)
                {
                    MessageBox.Show("hatalı final notu lütfen 0-100 arası not giriniz");
                    label5.Visible = false;
                    label6.Visible = false;
                    label7.Visible = false;
                    label8.Visible = false;
                }
                else
                {
                    if (vizey + finaly != 100 || finaly < vizey || vizey == 0 || finaly == 0)
                    {
                        MessageBox.Show("%'lik dilim(ler) hatalıdır lütfen kontrol ediniz");
                        label5.Visible = false;
                        label6.Visible = false;
                        label7.Visible = false;
                        label8.Visible = false;
                    }
                    else
                    {
                        ort = (vize * vizey / 100) + (final * finaly / 100);
                        if (ort >= 49.5 && final >= 50)
                        {
                            label8.Text = "Geçtiniz :)";
                            label8.ForeColor = Color.Green;
                            label7.Visible = false;
                            label8.Visible = true;
                        }
                        else if (final < 50)
                        {
                            label8.Text = "Kaldınız :(";
                            label8.ForeColor= Color.Red;
                            label7.Text = "(Final Notunuz Yetersiz)";
                            label7.Visible = true;
                            label8.Visible = true;
                        }
                        else
                        {
                            label8.Text = "Kaldınız :(";
                            label8.ForeColor = Color.Red;
                            label7.Visible = false;
                            label8.Visible = true;
                        }
                        label6.Text = ort.ToString();
                        label5.Visible = true;
                        label6.Visible = true;
                        label10.Visible = true;
                        label10.ForeColor = Color.White;
                        if (ort > 90)
                        {
                            label10.Text = "AA";
                        }
                        else if (ort > 85)
                        {
                            label10.Text = "AB";
                        }
                        else if (ort > 80)
                        {
                            label10.Text = "BB";
                        }
                        else if (ort > 75) { label10.Text = "BC"; }
                        else if (ort > 70) { label10.Text = "CC"; }
                        else if (ort > 65) { label10.Text = "CD"; }
                        else if (ort > 60) { label10.Text = "DD"; }
                        else if (ort > 55) { label10.Text = "DE"; }
                        else if (ort >= 50) { label10.Text = "EE";}
                        else { label10.Text = "FF"; label10.ForeColor = Color.Red; }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Dayı hata var, "+ex.Message);
            }
        }
            

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label5.Visible=false;
            label6.Visible=false;
            label7.Visible=false;
            label8.Visible=false;
            label10.Visible=false;
            textBox2.Text = "60";
            textBox3.Text = "40";
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
