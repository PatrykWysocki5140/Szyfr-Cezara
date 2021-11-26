using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Szyfr_Cezara
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label8.Text = Obliczenia.Alfabet_lenght().ToString();
            Obliczenia.Odwrocenie_tablic();
        }
        private void do_code_Click(object sender, EventArgs e)
        {
            try
            {
                int numVal = Int32.Parse(code.Text);
                if (trackBar.Value == numVal)
                {
                    Obliczenia.Code(text_to_code.Text, trackBar.Value);
                    text_code.Text = new string(Obliczenia.szyfr);
                }
                else
                {
                    Obliczenia.Code(text_to_code.Text, numVal);
                    text_code.Text = new string(Obliczenia.szyfr);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Błędny kod");
            }
        }
        private void do_decode_Click(object sender, EventArgs e)
        {
            try
            {
                int numVal = Int32.Parse(decode.Text);
                if (trackBar1.Value == numVal)
                {
                    Obliczenia.Decode(text_to_decode.Text, trackBar1.Value);
                    text_decode.Text = new string(Obliczenia.deszyfr);
                }
                else
                {
                    Obliczenia.Decode(text_to_decode.Text, numVal);
                    text_decode.Text = new string(Obliczenia.deszyfr);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Błędny kod");
            } 
        }

        private void show_move_CheckedChanged(object sender, EventArgs e)
        {
            if (show_move.Checked)
            {
                Reset.Visible = true;
                time.Visible = true;
                wizualizacja_run.Visible = true;
                p1.Visible = true;
                p2.Visible = true;
                p3.Visible = true;
                p4.Visible = true;
                p5.Visible = true;
                p6.Visible = true;
                p7.Visible = true;
                p8.Visible = true;
                p9.Visible = true;
                p10.Visible = true;
                p11.Visible = true;
                p12.Visible = true;
                p13.Visible = true;
                p14.Visible = true;
                p15.Visible = true;
                p16.Visible = true;
                p17.Visible = true;
                p18.Visible = true;
                p19.Visible = true;
                p20.Visible = true;
                p21.Visible = true;
                p22.Visible = true;
                p23.Visible = true;
                p24.Visible = true;
                p25.Visible = true;
                p26.Visible = true;
                m1.Visible = true;
                m2.Visible = true;
                m3.Visible = true;
                m4.Visible = true;
                m5.Visible = true;
                m6.Visible = true;
                m7.Visible = true;
                m8.Visible = true;
                m9.Visible = true;
                m10.Visible = true;
                m11.Visible = true;
                m12.Visible = true;
                m13.Visible = true;
                m14.Visible = true;
                m15.Visible = true;
                m16.Visible = true;
                m17.Visible = true;
                m18.Visible = true;
                m19.Visible = true;
                m20.Visible = true;
                m21.Visible = true;
                m22.Visible = true;
                m23.Visible = true;
                m24.Visible = true;
                m25.Visible = true;
                m26.Visible = true;
                Obliczenia.Wczytaj_w();
                Reset_color();
            }
            else
            {
                Reset.Visible = false;
                time.Visible = false;
                wizualizacja_run.Visible = false;
                p1.Visible = false;
                p2.Visible = false;
                p3.Visible = false;
                p4.Visible = false;
                p5.Visible = false;
                p6.Visible = false;
                p7.Visible = false;
                p8.Visible = false;
                p9.Visible = false;
                p10.Visible = false;
                p11.Visible = false;
                p12.Visible = false;
                p13.Visible = false;
                p14.Visible = false;
                p15.Visible = false;
                p16.Visible = false;
                p17.Visible = false;
                p18.Visible = false;
                p19.Visible = false;
                p20.Visible = false;
                p21.Visible = false;
                p22.Visible = false;
                p23.Visible = false;
                p24.Visible = false;
                p25.Visible = false;
                p26.Visible = false;
                m1.Visible = false;
                m2.Visible = false;
                m3.Visible = false;
                m4.Visible = false;
                m5.Visible = false;
                m6.Visible = false;
                m7.Visible = false;
                m8.Visible = false;
                m9.Visible = false;
                m10.Visible = false;
                m11.Visible = false;
                m12.Visible = false;
                m13.Visible = false;
                m14.Visible = false;
                m15.Visible = false;
                m16.Visible = false;
                m17.Visible = false;
                m18.Visible = false;
                m19.Visible = false;
                m20.Visible = false;
                m21.Visible = false;
                m22.Visible = false;
                m23.Visible = false;
                m24.Visible = false;
                m25.Visible = false;
                m26.Visible = false;
            }
        }

        private void trackBar_Scroll(object sender, EventArgs e)
        {
            code.Text = trackBar.Value.ToString();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            decode.Text = trackBar1.Value.ToString();
        }
        private void time_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void wizualizacja_run_Click(object sender, EventArgs e)
        {
            if (time.Checked == true)
            {
                Wizualizacja();
            }
            else
            {
                Wizualizacja_zwykla();
            }
        }

        public void Wizualizacja()
        {
            char[] tekst;
            char[] szyfr;
            tekst = text_to_code.Text.ToCharArray();
            szyfr = text_code.Text.ToCharArray();
            for (int i = 0; i < tekst.Length; i++)
            {
                if ((tekst[i] != ' ') && (szyfr[i] != ' '))
                {
                    Przesun(tekst[i].ToString(), szyfr[i].ToString());
                    MessageBox.Show("Znak  " + tekst[i].ToString() + "  został zaszyfrowany jako:  " + szyfr[i].ToString());
                    Reset_color();
                }
            }
        }
        public void Wizualizacja_zwykla()
        {
            char[] tekst;
            char[] szyfr;
            tekst = text_to_code.Text.ToCharArray();
            szyfr = text_code.Text.ToCharArray();
            for (int i = 0; i < tekst.Length; i++)
            {
                if ((tekst[i] != ' ') && (szyfr[i] != ' '))
                {
                    Przesun_zwykly(tekst[i].ToString(), szyfr[i].ToString());
                    MessageBox.Show("Znak  " + tekst[i].ToString() + "  został zaszyfrowany jako:  " + szyfr[i].ToString());
                    Reset_color();
                }
            }
        }
        public void Pokaz(string znak, int i)
        {
            znak = znak.ToUpper();
            switch (znak)
            {
                case "A":
                    {
                        if (i == 0)
                        {
                            p1.BackColor = System.Drawing.Color.Red;
                        }
                        else
                        {
                            p1.BackColor = System.Drawing.Color.Green;
                        }
                        break;
                    }
                case "B":
                    {
                        if (i == 0)
                        {
                            p2.BackColor = System.Drawing.Color.Red;
                        }
                        else
                        {
                            p2.BackColor = System.Drawing.Color.Green;
                        }
                        break;
                    }
                case "C":
                    {
                        if (i == 0)
                        {
                            p3.BackColor = System.Drawing.Color.Red;
                        }
                        else
                        {
                            p3.BackColor = System.Drawing.Color.Green;
                        }
                        break;
                    }
                case "D":
                    {
                        if (i == 0)
                        {
                            p4.BackColor = System.Drawing.Color.Red;
                        }
                        else
                        {
                            p4.BackColor = System.Drawing.Color.Green;
                        }
                        break;
                    }
                case "E":
                    {
                        if (i == 0)
                        {
                            p5.BackColor = System.Drawing.Color.Red;
                        }
                        else
                        {
                            p5.BackColor = System.Drawing.Color.Green;
                        }
                        break;
                    }
                case "F":
                    {
                        if (i == 0)
                        {
                            p6.BackColor = System.Drawing.Color.Red;
                        }
                        else
                        {
                            p6.BackColor = System.Drawing.Color.Green;
                        }
                        break;
                    }
                case "G":
                    {
                        if (i == 0)
                        {
                            p7.BackColor = System.Drawing.Color.Red;
                        }
                        else
                        {
                            p7.BackColor = System.Drawing.Color.Green;
                        }
                        break;
                    }
                case "H":
                    {
                        if (i == 0)
                        {
                            p8.BackColor = System.Drawing.Color.Red;
                        }
                        else
                        {
                            p8.BackColor = System.Drawing.Color.Green;
                        }
                        break;
                    }
                case "I":
                    {
                        if (i == 0)
                        {
                            p9.BackColor = System.Drawing.Color.Red;
                        }
                        else
                        {
                            p9.BackColor = System.Drawing.Color.Green;
                        }
                        break;
                    }
                case "J":
                    {
                        if (i == 0)
                        {
                            p10.BackColor = System.Drawing.Color.Red;
                        }
                        else
                        {
                            p10.BackColor = System.Drawing.Color.Green;
                        }
                        break;
                    }
                case "K":
                    {
                        if (i == 0)
                        {
                            p11.BackColor = System.Drawing.Color.Red;
                        }
                        else
                        {
                            p11.BackColor = System.Drawing.Color.Green;
                        }
                        break;
                    }
                case "L":
                    {
                        if (i == 0)
                        {
                            p12.BackColor = System.Drawing.Color.Red;
                        }
                        else
                        {
                            p12.BackColor = System.Drawing.Color.Green;
                        }
                        break;
                    }
                case "M":
                    {
                        if (i == 0)
                        {
                            p13.BackColor = System.Drawing.Color.Red;
                        }
                        else
                        {
                            p13.BackColor = System.Drawing.Color.Green;
                        }
                        break;
                    }
                case "N":
                    {
                        if (i == 0)
                        {
                            p14.BackColor = System.Drawing.Color.Red;
                        }
                        else
                        {
                            p14.BackColor = System.Drawing.Color.Green;
                        }
                        break;
                    }
                case "O":
                    {
                        if (i == 0)
                        {
                            p15.BackColor = System.Drawing.Color.Red;
                        }
                        else
                        {
                            p15.BackColor = System.Drawing.Color.Green;
                        }
                        break;
                    }
                case "P":                    
                    {
                        if (i == 0)
                        {
                            p16.BackColor = System.Drawing.Color.Red;
                        }
                        else
                        {
                            p16.BackColor = System.Drawing.Color.Green;
                        }
                        break;
                    }
                case "Q":
                    {
                        if (i == 0)
                        {
                            p26.BackColor = System.Drawing.Color.Red;
                        }
                        else
                        {
                            p26.BackColor = System.Drawing.Color.Green;
                        }
                        break;
                    }
                case "R":
                    {
                        if (i == 0)
                        {
                            p17.BackColor = System.Drawing.Color.Red;
                        }
                        else
                        {
                            p17.BackColor = System.Drawing.Color.Green;
                        }
                        break;
                    }
                case "S":
                    {
                        if (i == 0)
                        {
                            p18.BackColor = System.Drawing.Color.Red;
                        }
                        else
                        {
                            p18.BackColor = System.Drawing.Color.Green;
                        }
                        break;
                    }
                case "T":
                    {
                        if (i == 0)
                        {
                            p19.BackColor = System.Drawing.Color.Red;
                        }
                        else
                        {
                            p19.BackColor = System.Drawing.Color.Green;
                        }
                        break;
                    }
                case "U":
                    {
                        if (i == 0)
                        {
                            p20.BackColor = System.Drawing.Color.Red;
                        }
                        else
                        {
                            p20.BackColor = System.Drawing.Color.Green;
                        }
                        break;
                    }
                case "V":
                    {
                        if (i == 0)
                        {
                            p21.BackColor = System.Drawing.Color.Red;
                        }
                        else
                        {
                            p21.BackColor = System.Drawing.Color.Green;
                        }
                        break;
                    }
                case "W":
                    {
                        if (i == 0)
                        {
                            p22.BackColor = System.Drawing.Color.Red;
                        }
                        else
                        {
                            p22.BackColor = System.Drawing.Color.Green;
                        }
                        break;
                    }
                case "X":
                    {
                        if (i == 0)
                        {
                            p23.BackColor = System.Drawing.Color.Red;
                        }
                        else
                        {
                            p23.BackColor = System.Drawing.Color.Green;
                        }
                        break;
                    }
                case "Y":
                    {
                        if (i == 0)
                        {
                            p24.BackColor = System.Drawing.Color.Red;
                        }
                        else
                        {
                            p24.BackColor = System.Drawing.Color.Green;
                        }
                        break;
                    }
                case "Z":
                    {
                        if (i == 0)
                        {
                            p25.BackColor = System.Drawing.Color.Red;
                        }
                        else
                        {
                            p25.BackColor = System.Drawing.Color.Green;
                        }
                        break;
                    }
            }
        }
        public void Reset_color()
        {
            p1.BackColor = System.Drawing.SystemColors.Info;
            p2.BackColor = System.Drawing.SystemColors.Info;
            p3.BackColor = System.Drawing.SystemColors.Info;
            p4.BackColor = System.Drawing.SystemColors.Info;
            p5.BackColor = System.Drawing.SystemColors.Info;
            p6.BackColor = System.Drawing.SystemColors.Info;
            p7.BackColor = System.Drawing.SystemColors.Info;
            p8.BackColor = System.Drawing.SystemColors.Info;
            p9.BackColor = System.Drawing.SystemColors.Info;
            p10.BackColor = System.Drawing.SystemColors.Info;
            p11.BackColor = System.Drawing.SystemColors.Info;
            p12.BackColor = System.Drawing.SystemColors.Info;
            p13.BackColor = System.Drawing.SystemColors.Info;
            p14.BackColor = System.Drawing.SystemColors.Info;
            p15.BackColor = System.Drawing.SystemColors.Info;
            p16.BackColor = System.Drawing.SystemColors.Info;
            p17.BackColor = System.Drawing.SystemColors.Info;
            p18.BackColor = System.Drawing.SystemColors.Info;
            p19.BackColor = System.Drawing.SystemColors.Info;
            p20.BackColor = System.Drawing.SystemColors.Info;
            p21.BackColor = System.Drawing.SystemColors.Info;
            p22.BackColor = System.Drawing.SystemColors.Info;
            p23.BackColor = System.Drawing.SystemColors.Info;
            p24.BackColor = System.Drawing.SystemColors.Info;
            p25.BackColor = System.Drawing.SystemColors.Info;
            p26.BackColor = System.Drawing.SystemColors.Info;
        }
        public async void Przesun(string a, string b)
        {
            a = a.ToUpper();
            b = b.ToUpper();
            try
            {
                if (a == b)
                {
                    Pokaz(a, 0);
                }
                else
                {
                    for (int i = 0; i < Obliczenia.znaki.Length; i++)
                    {
                        if (Obliczenia.znaki[i] == a)
                        {
                            Pokaz(Obliczenia.znaki[i], 0);
                            while (true)
                            {
                                Pokaz(Obliczenia.znaki[i++], 0);
                                await Task.Delay(200);
                                if (Obliczenia.znaki[i] == b)
                                {
                                    Pokaz(Obliczenia.znaki[i], 1);
                                    break;
                                }
                            }
                        }
                    }
                }
            }
            catch (IndexOutOfRangeException)
            {
            }

        }
        public void Przesun_zwykly(string a, string b)
        {
            a = a.ToUpper();
            b = b.ToUpper();
            try
            {
                if (a == b)
                {
                    Pokaz(a, 0);
                }
                else
                {
                    for (int i = 0; i < Obliczenia.znaki.Length; i++)
                    {
                        if (Obliczenia.znaki[i] == a)
                        {
                            Pokaz(Obliczenia.znaki[i], 0);
                            while (true)
                            {
                                Pokaz(Obliczenia.znaki[i++], 0);
                                if (Obliczenia.znaki[i] == b)
                                {
                                    Pokaz(Obliczenia.znaki[i], 1);
                                    break;
                                }
                            }
                        }
                    }
                }
            }
            catch (IndexOutOfRangeException)
            {
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void text_to_code_TextChanged(object sender, EventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(text_to_code.Text, "^[a-zA-Z ]"))
            {
                if (text_to_code.Text != "")
                {
                    MessageBox.Show("Użyj tylko liter");
                    text_to_code.Text = text_to_code.Text.Remove(text_to_code.Text.Length - 1);
                }
            }
        }
        private void code_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(code.Text, "[^0-9]"))
            {
                if (code.Text != "")
                {
                    MessageBox.Show("Użyj tylko cyfr");
                    code.Text = code.Text.Remove(code.Text.Length - 1);
                }
            }
        }
        private void text_code_TextChanged(object sender, EventArgs e)
        {
        }
        private void text_to_decode_TextChanged(object sender, EventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(text_to_decode.Text, "^[a-zA-Z ]"))
            {
                if (text_to_decode.Text != "")
                {
                    MessageBox.Show("Użyj tylko liter");
                    text_to_decode.Text = text_to_decode.Text.Remove(text_to_decode.Text.Length - 1);
                }
            }
        }
        private void decode_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(decode.Text, "[^0-9]"))
            {
                if (decode.Text != "")
                {
                    MessageBox.Show("Użyj tylko cyfr");
                    decode.Text = decode.Text.Remove(decode.Text.Length - 1);
                }
            }
        }
        private void text_decode_TextChanged(object sender, EventArgs e)
        {

        }
        private void save_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void label8_Click(object sender, EventArgs e)
        {

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Szyfr Cezara";

        }
        public void p1_TextChanged(object sender, EventArgs e)
        {

        }
        private void p2_TextChanged(object sender, EventArgs e)
        {

        }
        private void p3_TextChanged(object sender, EventArgs e)
        {

        }
        private void p4_TextChanged(object sender, EventArgs e)
        {

        }
        private void p5_TextChanged(object sender, EventArgs e)
        {

        }
        private void p6_TextChanged(object sender, EventArgs e)
        {

        }
        private void p7_TextChanged(object sender, EventArgs e)
        {

        }
        private void p8_TextChanged(object sender, EventArgs e)
        {

        }
        private void p9_TextChanged(object sender, EventArgs e)
        {

        }
        private void p10_TextChanged(object sender, EventArgs e)
        {

        }
        private void p11_TextChanged(object sender, EventArgs e)
        {

        }
        private void p12_TextChanged(object sender, EventArgs e)
        {

        }
        private void p13_TextChanged(object sender, EventArgs e)
        {

        }
        private void p14_TextChanged(object sender, EventArgs e)
        {

        }
        private void p15_TextChanged(object sender, EventArgs e)
        {

        }
        private void p16_TextChanged(object sender, EventArgs e)
        {

        }
        private void p17_TextChanged(object sender, EventArgs e)
        {

        }
        private void p18_TextChanged(object sender, EventArgs e)
        {

        }
        private void p19_TextChanged(object sender, EventArgs e)
        {

        }
        private void p20_TextChanged(object sender, EventArgs e)
        {

        }
        private void p21_TextChanged(object sender, EventArgs e)
        {

        }
        private void p22_TextChanged(object sender, EventArgs e)
        {

        }
        private void p23_TextChanged(object sender, EventArgs e)
        {

        }
        private void p24_TextChanged(object sender, EventArgs e)
        {

        }
        private void p25_TextChanged(object sender, EventArgs e)
        {

        }
        private void m1_TextChanged(object sender, EventArgs e)
        {

        }
        private void m2_TextChanged(object sender, EventArgs e)
        {

        }
        private void m3_TextChanged(object sender, EventArgs e)
        {

        }
        private void m4_TextChanged(object sender, EventArgs e)
        {

        }
        private void m5_TextChanged(object sender, EventArgs e)
        {

        }
        private void m6_TextChanged(object sender, EventArgs e)
        {

        }
        private void m7_TextChanged(object sender, EventArgs e)
        {

        }
        private void m8_TextChanged(object sender, EventArgs e)
        {

        }
        private void m9_TextChanged(object sender, EventArgs e)
        {

        }
        private void m10_TextChanged(object sender, EventArgs e)
        {

        }
        private void m11_TextChanged(object sender, EventArgs e)
        {

        }
        private void m12_TextChanged(object sender, EventArgs e)
        {

        }
        private void m13_TextChanged(object sender, EventArgs e)
        {

        }
        private void m14_TextChanged(object sender, EventArgs e)
        {

        }
        private void m15_TextChanged(object sender, EventArgs e)
        {

        }
        private void m16_TextChanged(object sender, EventArgs e)
        {

        }
        private void m17_TextChanged(object sender, EventArgs e)
        {

        }
        private void m18_TextChanged(object sender, EventArgs e)
        {

        }
        private void m19_TextChanged(object sender, EventArgs e)
        {

        }
        private void m20_TextChanged(object sender, EventArgs e)
        {

        }
        private void m21_TextChanged(object sender, EventArgs e)
        {

        }
        private void m22_TextChanged(object sender, EventArgs e)
        {

        }
        private void m23_TextChanged(object sender, EventArgs e)
        {

        }
        private void m24_TextChanged(object sender, EventArgs e)
        {

        }
        private void m25_TextChanged(object sender, EventArgs e)
        {

        }

        private void Reset_Click(object sender, EventArgs e)
        {
            Reset_color();
        }

        private void p26_TextChanged(object sender, EventArgs e)
        {

        }

        private void m26_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
