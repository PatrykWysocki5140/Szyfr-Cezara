using System;
using System.Windows.Forms;


namespace Szyfr_Cezara
{
    class Obliczenia
    {
        public static char[] alfabet =
           {'A',
            'B',
            'C',
            'D',
            'E',
            'F',
            'G',
            'H',
            'I',
            'J',
            'K',
            'L',
            'M',
            'N',
            'O',
            'P',
            'Q',
            'R',
            'S',
            'T',
            'U',
            'V',
            'W',
            'X',
            'Y',
            'Z', };
        public static char[] alfabet_m =
           {'a',
            'b',
            'c',
            'd',
            'e',
            'f',
            'g',
            'h',
            'i',
            'j',
            'k',
            'l',
            'm',
            'n',
            'o',
            'p',
            'q',
            'r',
            's',
            't',
            'u',
            'v',
            'w',
            'x',
            'y',
            'z', };
        public static char[] alfabet_reverse = new char[26];
        public static char[] alfabet_reverse_m = new char[26];
        public static char[] szyfr = new char[100000000];
        public static char[] deszyfr = new char[100000000];
        // tablice niezbędne do szyfrowania

        public static string[] znaki = new string[((2 * alfabet.Length))]; // tablica wykorzystana przy wizualizacji

        public static void Odwrocenie_tablic()
        {
            for (int i = 0; i < alfabet.Length; i++)
            {
                alfabet_reverse[i] = alfabet[i];
                alfabet_reverse_m[i] = alfabet_m[i];
            }
            Array.Reverse(alfabet_reverse);
            Array.Reverse(alfabet_reverse_m);
            if (alfabet_reverse[0] == 'Z')
                MessageBox.Show("Wczytano dane");
        }
        public static int Alfabet_lenght() // funkcja kontrolna dla długości tablicy alfabetu
        {
            int a = alfabet.Length;
            return a;
        }
        public static void Code(string tekst_wejsciowy, int kod) // szyfrowanie
        {
            Array.Clear(szyfr, 0, szyfr.Length);
            char[] tekst;
            tekst = tekst_wejsciowy.ToCharArray(); // tekst wpisany przez użytkonika 
            int point = 0;

            for (int i = 0; i < tekst.Length; i++) // filtrowanie znaków w tekście użytkownika 
            {
                if (tekst[i] != ' ') // sprawdzanie czy znak z tekstu nie jest spacją 
                {
                    for (int j = 0; j < alfabet.Length; j++) // szukanie w alfabecie znaku pasującego do znaku z tekstu (DUŻE LITERY)
                    {
                        if (tekst[i] == alfabet[j]) // jeśli znak pasuje to trzeba go przesunąć o kod
                        {
                            //     C = (n + k) mod 26,
                            //gdzie k jest kluczem szyfrowania, n jest numerem litery, którą szyfrujemy, a C jest numerem litery po zaszyfrowaniu.
                            szyfr[point] = alfabet[(j + kod) % 26];
                            point++;
                        }
                    }
                    for (int j = 0; j < alfabet_m.Length; j++) // szukanie w alfabecie znaku pasującego do znaku z tekstu (MAŁE LITERY)
                    {
                        if (tekst[i] == alfabet_m[j]) // jeśli znak pasuje to trzeba go przesunąć o kod
                        {
                            //     C = (n + k) mod 26,
                            //gdzie k jest kluczem szyfrowania, n jest numerem litery, którą szyfrujemy, a C jest numerem litery po zaszyfrowaniu.
                            szyfr[point] = alfabet_m[(j + kod) % 26];
                            point++;
                        }
                    }

                }
                else if (tekst[i] == ' ') // jeśli jest jest spacją 
                {
                    szyfr[i] = ' '; // przypisuje spację do ciągu szyfru
                    point++;
                }
                else
                {
                    MessageBox.Show("Nieprawidłowy znak wprowadzony do szyfrowania");
                }
            }

        }
        public static void Decode(string tekst_wejsciowy, int kod) //deszyfracja - zbudowana na identycznym algorytmie, jednak odwróconej tablizy
        {
            Array.Clear(deszyfr, 0, deszyfr.Length);
            char[] tekst;
            tekst = tekst_wejsciowy.ToCharArray(); // tekst wpisany przez użytkonika 
            int point = 0;

            for (int i = 0; i < tekst.Length; i++) // filtrowanie znaków w tekście użytkownika 
            {
                if (tekst[i] != ' ') // sprawdzanie czy znak z tekstu nie jest spacją 
                {
                    for (int j = 0; j < alfabet_reverse.Length; j++) // szukanie w alfabecie znaku pasującego do znaku z tekstu (DUŻE LITERY)
                    {
                        if (tekst[i] == alfabet_reverse[j]) // jeśli znak pasuje to trzeba go przesunąć o kod
                        {
                            deszyfr[point] = alfabet_reverse[(j + kod) % 26];
                            point++;
                        }
                    }
                    for (int j = 0; j < alfabet_reverse_m.Length; j++) // szukanie w alfabecie znaku pasującego do znaku z tekstu (MAŁE LITERY)
                    {
                        if (tekst[i] == alfabet_reverse_m[j]) // jeśli znak pasuje to trzeba go przesunąć o kod
                        {
                            deszyfr[point] = alfabet_reverse_m[(j + kod) % 26];
                            point++;
                        }
                    }

                }
                else if (tekst[i] == ' ') // jeśli jest jest spacją 
                {
                    deszyfr[i] = ' '; // przypisuje spację do ciągu szyfru
                    point++;
                }
                else
                {
                    MessageBox.Show("Nieprawidłowy znak wprowadzony do odszyfrowania");
                }
            }

        }
        public static void Wczytaj_w() // wczytanie danych do tablicy pomocniczej przy wizualizacji
        {
            for (int i = 0; i < alfabet.Length; i++)
            {
                znaki[i] = alfabet[i].ToString();
            }
            int point = 0;
            for (int i = alfabet.Length; i < ((2 * alfabet.Length)); i++)
            {
                znaki[i] = alfabet[point].ToString();
                point++;
            }
            MessageBox.Show("Wczytano dane");
        }

    }
}
