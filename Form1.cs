using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Цезарь____
{
    public partial class Form1 : Form
    {
        string S = "";
        string alf = "";
        string text = "";
        string key = "";
        
        public Form1()
        {
            InitializeComponent();
        }
        public bool string_in(char a, string s) // функция, которая проверяет наличие того или иного элемента в алфавите 
        {
            for (int i = 0; i < s.Length; i++)
            {
                if (a == s[i])
                    return true;
            }
            return false;
        }
        private void En_CheckedChanged(object sender, EventArgs e)
        {
            alf = "abcdefghijklmnopqrstuvwxyz0123456789";
        }
        private void RU_CheckedChanged(object sender, EventArgs e)
        {
            alf = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя0123456789";
        }    
        private void Encryption(string alf,string key)
        {
            try
            {
                int n = alf.Length; 
                if (alf.Length == 0) throw new Exception("Алфавит не выбран");
                
                //
                text = richTextBox1.Text;
                if (text.Length == 0) throw new Exception("Исходный текст пуст");
                //
                for (int i = 0; i < text.Length; i++)
                    if (!string_in(text[i], alf)) throw new Exception("В тексте присутствует лишние символы ( другой язык, пробелы, знаки препинания, верхний регистр и т.д.)");
                //
                if (key.Length == 0) throw new Exception("Вы не ввели ключ");

                

                // обработка больших чисел
                
                if( !BigInteger.TryParse(key,out BigInteger number_key)) throw new Exception("Некорректный ключ");
                number_key = (number_key % n +n)%n;

                // обработка больших чисел
           

                for (int i = 0, j = 0; i < text.Length; i++) // главный цикл, который проводит шифрование
                    {
                        j = 0;
                        for (; j < alf.Length; j++)
                            if (alf[j] == text[i])
                                break;
                        S += alf[(j + (int)number_key) % n];
                    }
                        
                richTextBox3.Text = S;
                S = "";

            }
            catch (Exception e)
            {
                MessageBox.Show($"Ошибка: {e.Message}");
                
            }
        }
        private void Decryption (string alf, string key)
        {
            try
            {
                int n = alf.Length;
                if (alf.Length == 0) throw new Exception("Алфавит не выбран");


                //
                text = richTextBox3.Text;
                if (text.Length == 0) throw new Exception("Исходный текст пуст");
                //
                for (int i = 0; i < text.Length; i++)
                    if (!string_in(text[i], alf)) throw new Exception("В тексте присутствует лишние символы ( другой язык, пробелы, знаки препинания, верхний регистр и т.д.)");
                //
                if (key.Length == 0) throw new Exception("Вы не ввели ключ");

                // обработка больших чисел
                if (!BigInteger.TryParse(key, out BigInteger number_key)) throw new Exception("Некорректный ключ");
                number_key = (number_key % n + n)%n;
                // обработка больших чисел

                //

                for (int i = 0, j = 0; i < text.Length; i++) // главный цикл, который проводит шифрование
                {
                    j = 0;
                    for (; j < alf.Length; j++)
                        if (alf[j] == text[i])
                            break;
                    S += alf[((j - (int)number_key)+n) % n];
                }

                richTextBox4.Text = S;
                S = "";

            }
            catch (Exception e)
            {
                MessageBox.Show($"Ошибка : {e.Message}");
                
            }
        }
        private void encryption_Click(object sender, EventArgs e)
        {
            key = richTextBox2.Text;
            Encryption(alf,key);
        }
        private void decryption_Click(object sender, EventArgs e)
        {
            key = richTextBox2.Text;
            Decryption(alf, key);
        }
        /// <summary>
        /// //
        /// </summary>
        /// <param name="alf"></param>
        /// <param name="key"></param>
        private void Encryption_V(string alf, string key)
        {
            try
            {
                int n = alf.Length;
                if (alf.Length == 0) throw new Exception("Алфавит не выбран");

                //
                text = richTextBox5.Text;
                if (text.Length == 0) throw new Exception("Исходный текст пуст");
                //
                for (int i = 0; i < text.Length; i++)
                    if (!string_in(text[i], alf)) throw new Exception("В тексте присутствует лишние символы ( другой язык, пробелы, знаки препинания, верхний регистр и т.д.)");
                //
                if (key.Length == 0) throw new Exception("Вы не ввели ключ");
                for (int i = 0; i < key.Length; i++)
                    if (!string_in(key[i], alf)) throw new Exception("В ключе присутствует лишние символы ( другой язык, пробелы, знаки препинания, верхний регистр и т.д.)");

                for (int i = 0 ; i < text.Length; i++) // главный цикл, который проводит шифрование
                {
                    S += alf[(alf.IndexOf(text[i]) + alf.IndexOf(key[i % key.Length]) + n) % n];
                }

                richTextBox6.Text = S;
                S = "";

            }
            catch (Exception e)
            {
                MessageBox.Show($"Ошибка: {e.Message}");

            }
        }
        private void Decryption_V(string alf, string key)
        {
            try
            {
                int n = alf.Length;
                if (alf.Length == 0) throw new Exception("Алфавит не выбран");


                //
                text = richTextBox6.Text;
                if (text.Length == 0) throw new Exception("Исходный текст пуст");
                //
                for (int i = 0; i < text.Length; i++)
                    if (!string_in(text[i], alf)) throw new Exception("В тексте присутствует лишние символы ( другой язык, пробелы, знаки препинания, верхний регистр и т.д.)");
                //
                if (key.Length == 0) throw new Exception("Вы не ввели ключ");
                for (int i = 0; i < key.Length; i++)
                    if (!string_in(key[i], alf)) throw new Exception("В ключе присутствует лишние символы ( другой язык, пробелы, знаки препинания, верхний регистр и т.д.)");


                //

                for (int i = 0; i < text.Length; i++) // главный цикл, который проводит расшифрование
                {
                    S += alf[(alf.IndexOf(text[i]) - alf.IndexOf(key[i%key.Length])  + n) % n];
                }

                richTextBox8.Text = S;
                S = "";

            }
            catch (Exception e)
            {
                MessageBox.Show($"Ошибка : {e.Message}");

            }
        }
        private void vishener_encr_btn_Click(object sender, EventArgs e)
        {
            key = richTextBox7.Text;
            Encryption_V(alf, key);
        }
        private void V_decrypt_btn_Click(object sender, EventArgs e)
        {
            key = richTextBox7.Text;
            Decryption_V(alf, key);
        }
        /// <summary>
        /// /
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Gamn_ecrpyt_btn_Click(object sender, EventArgs e)
        {
           key = richTextBox11.Text;
            encrypt_XOR(alf, key);
        }
        private string string_to_binar(string s)
        {
            string binar = "";
            foreach( char c in s)
            {
                binar += int_to_binar(alf.IndexOf(c));
            }
            return binar;
        }
        private string int_to_binar(int a)
        {
            string binar = "";
            int[] b = new int[6]; // массив с помощью которого двоичное число позже 2^6 = 64 ВПОЛНЕ ДОСТАТОЧНО ТАК КАК В АЛФАВИТЕ В СУММЕ ТОЛЬКО 37 или 43 СИМВОЛОВ
            int n = 0; // n - остаток после % деления из которого формируется число в 
                       //    двоичной системе исчисления
            int i = 0;                //будет выведено с конца для правильного отображения 

            while (a >= 1)
            {
                n = a % 2;
                b[i] = n;
                i++;
                a = a / 2;   
            };
            for (i = (b.Length - 1); i >= 0; i--)
            {
                binar += b[i];
            }
            return binar;
        }
        private int binar_to_int(string s)
        {
            int a = 0;
            for(int i =0;i<s.Length;i++)
            {
                if (s[i]=='1')
                    a +=  (int)Math.Pow(2,s.Length-i-1);
            }
            return a;
        }
        private void encrypt_XOR(string alf, string key)
        {
            try
            {
                
                int n = alf.Length;

                if (n == 0) throw new Exception("Алфавит не выбран");


                //
                text = richTextBox9.Text;
                if (text.Length == 0) throw new Exception("Исходный текст пуст");
                //
                for (int i = 0; i < text.Length; i++)
                    if (!string_in(text[i], alf)) throw new Exception("В тексте присутствует лишние символы ( другой язык, пробелы, знаки препинания, верхний регистр и т.д.)");
                //
                if (key.Length == 0) throw new Exception("Вы не ввели ключ");
                for (int i = 0; i < key.Length; i++)
                    if (!string_in(key[i], alf)) throw new Exception("В ключе присутствует лишние символы ( другой язык, пробелы, знаки препинания, верхний регистр и т.д.)");




                /////
                ///
                string binar_key = "";
                string binar_text = "";
                binar_key += string_to_binar(key);
                binar_text += string_to_binar(text);
                richTextBox10.Text = binar_text;
                richTextBox12.Text = binar_key;

                /////
                ///

                for (int i = 0; i < binar_text.Length; i++) // main for
                {
                    S += ((int)binar_text[i] + (int)binar_key[i % binar_key.Length]) % 2;
                }



                richTextBox13.Text = S;
                S = "";

            }
            catch (Exception e)
            {
                MessageBox.Show($"Ошибка: {e.Message}");

            }
        }
        private void decrypt_XOR(string alf, string key)
        {

            try
            {
               
                

                int n = alf.Length;
                if (alf.Length == 0) throw new Exception("Алфавит не выбран");
                text = 

                //
                text = richTextBox13.Text;
                if (text.Length == 0) throw new Exception("Исходный текст пуст");
                //
                for (int i = 0; i < text.Length; i++)
                    if (!string_in(text[i], alf)) throw new Exception("В тексте присутствует лишние символы ( другой язык, пробелы, знаки препинания, верхний регистр и т.д.)");
                //
                if (key.Length == 0) throw new Exception("Вы не ввели ключ");
                for (int i = 0; i < key.Length; i++)
                    if (!string_in(key[i], alf)) throw new Exception("В ключе присутствует лишние символы ( другой язык, пробелы, знаки препинания, верхний регистр и т.д.)");




                /////
                ///
                string binar_key = "";
                string binar_text = "";
                binar_key += string_to_binar(key);
                binar_text += text;



                /////
                ///

                for (int i = 0; i < binar_text.Length; i++) // main for
                {
                    S += ((int)binar_text[i] + (int)binar_key[i % binar_key.Length]) % 2;
                }
                text = "";

                ////
                ///

                int binar_text_len = S.Length / 6;
                string[] mas = new string[binar_text_len];

                for (int i = 0; i < binar_text_len; i++)
                {
                    for (int j = 0; j < 6; j++)
                    {
                        mas[i] += S[i * 6 + j];
                    }

                }

                for (int i = 0; i < binar_text_len; i++)
                {
                    text += alf[binar_to_int(mas[i])];
                }
                richTextBox14.Text = S;

                richTextBox15.Text = text;
                S = "";

            }
            catch (Exception e)
            {
                MessageBox.Show($"Ошибка: {e.Message}");

            }
        }
        private void Gamn_decrypt_btn_Click(object sender, EventArgs e)
        {
            key = richTextBox11.Text;
            decrypt_XOR(alf, key);
        }
        /// <summary>
        /// //
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_encrypt_AES_Click(object sender, EventArgs e)
        {
            encrypt_AES();
        }
        private void encrypt_AES()
        {
            try
            {
                richTextBox_encrypted_text_AES.Text = "";
                int n = alf.Length;

                if (n == 0) throw new Exception("Алфавит не выбран");


                //
                text = richTextBox_text_AES.Text;
                if (text.Length == 0) throw new Exception("Исходный текст пуст");
                //
                for (int i = 0; i < text.Length; i++)
                    if (!string_in(text[i], alf)) throw new Exception("В тексте присутствует лишние символы ( другой язык, пробелы, знаки препинания, верхний регистр и т.д.)");
                //
                

                string binar_key = get_random_binar_key();
                string binar_text = "";


                //


                if (text.Length % 2 != 0)
                    text += alf[0];
                richTextBox_text_AES.Text = text; 
                binar_text = string_to_binar_text_8bit(text);

                richTextBox_binar_text_AES.Text = binar_text;
                richTextBox_binar_key_AES.Text = binar_key;

                int num_of_blocks = binar_text.Length / 16;

                ///

                string k = "";

                for (int i = 0; i < 16; i++)
                {
                    k += ((int)binar_key[i] + (int)binar_text[i]) % 2;
                }

                //


                S += k;
                //


                for (int i = 1; i < num_of_blocks; i++)
                {
                    string p = "";
                    for (int j = 0; j < 16; j++)
                    {
                        p += ((int)k[j] + (int)binar_text[i * 16 + j]) % 2;
                    }
                    S += p;
                    k = p;
                }
                ///
                richTextBox_encrypted_text_AES.Text = S;
                S = "";
            }
            catch (Exception e)
            {
                MessageBox.Show($"Ошибка: {e.Message}");

            }

        }
        private string string_to_binar_text_8bit(string text)
        {
            string binar = "";
            foreach (char c in text)
            {
                binar += int_to_binar_8bit(alf.IndexOf(c));
            }
            return binar;
        }
        private string int_to_binar_8bit(int a)
        {
            string binar = "";
            int[] b = new int[8]; //           // n - остаток после % деления из которого формируется число в 
            int n = 0;   //    двоичной системе исчисления
            int i = 0;                //будет выведено с конца для правильного отображения 

            while (a >= 1)
            {
                n = a % 2;
                b[i] = n;
                i++;
                a = a / 2;
            };
            for (i = (b.Length - 1); i >= 0; i--)
            {
                binar += b[i];
            }
            return binar;
        }
        private string binar_to_string_8bit(string text)
        {
            string s = "";
            for(int i =0;i<text.Length/8;i++)
            {
                string get_8_bit_to_symbol = "";
                for(int j =0;j<8;j++)
                {
                    get_8_bit_to_symbol+= text[i*8 +j];
                }
                s += alf[binar_to_int(get_8_bit_to_symbol)];
            }
            return s;
        }
        private string get_random_binar_key()
        {
            string binar_key = "";
            string random_counts_for_binar_key = "";
            ///
            while (random_counts_for_binar_key.Length!=8)
            {
                Random rnd= new Random();
                int num = rnd.Next(0,16);
                if(!string_in((char)num,random_counts_for_binar_key))
                    random_counts_for_binar_key += (char)num;
                    
            }
            ///

            for(int i =0;i<16;i++)
            {
                if(string_in((char)i,random_counts_for_binar_key))
                    binar_key += 1;
                else
                    binar_key += 0;
            }
            
            //
            return binar_key;

        }
        private void decrypt_AES()
        {

            try
            {
                richTextBox_decrypted_text_AES.Text = "";
                int n = alf.Length;

                if (n == 0) throw new Exception("Алфавит не выбран");


                //
                text = richTextBox_encrypted_text_AES.Text;
                if (text.Length == 0) throw new Exception("Исходный текст пуст");
                //
                for (int i = 0; i < text.Length; i++)
                    if (!string_in(text[i], alf)) throw new Exception("В тексте присутствует лишние символы ( другой язык, пробелы, знаки препинания, верхний регистр и т.д.)");
                //
                string binar_key = richTextBox_binar_key_AES.Text;
                string binar_text = text;
                //
                int num_of_blocks = binar_text.Length / 16;

                ///


                for (int i = num_of_blocks-1; i >0; i--)
                {
                    string p = "";
                    for (int j = 0; j < 16; j++)
                    {
                        p += ((int)binar_text[i*16+j] + (int)binar_text[(i-1) * 16 + j]) % 2;
                    }
                    S += p;
                    
                }
                for(int i =0;i<16;i++)
                {
                    S += ((int)binar_text[i] + (int)binar_key[i]) % 2;
                }
                

                //
                string k = S;
                

                ////// 2 revers
                S = binar_to_string_8bit(k);
                k = "";
                for(int i= S.Length-1;i>=0;i--)
                {
                    k += S[i];
                }
                S = "";
                for(int i =0;i<k.Length/2;i++)
                {
                    for(int j = 1;j>=0; j--)
                    {
                        S += k[i * 2 + j];
                    }
                }
                ///////
                richTextBox_decrypted_text_AES.Text = S;
                S = "";
            }
            catch (Exception e)
            {
                MessageBox.Show($"Ошибка: {e.Message}");

            }
        }
        private void button_decrypt_AES_Click(object sender, EventArgs e)
        {
            decrypt_AES();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_run_euratocfen_Click(object sender, EventArgs e)
        {
            int n = 10000;// maks number
            int baza = 3;
            List<int> numbers_1 = new List<int> { };
            List<int> numbers_2 = new List<int> { };

            Eratosfen(ref numbers_1,n);
            Theorem_small_Ferma(ref numbers_2,baza ,n);
            Find_and_print_Pseudoprimes(numbers_1,numbers_2);
        }
        private void Eratosfen(ref List<int> numbers_1,int n)
        {
            for (int i =0;i<n;i++)
                numbers_1.Add(i);
            ///
            for (int i = 2; i < numbers_1.Count; i++)
                for (int j = i+1; j > i && j < numbers_1.Count; j++)
                    if (numbers_1[j] % i == 0)
                    { numbers_1.RemoveAt(j); j--; }
                        
            for (int i = 0; i < numbers_1.Count; i++)
                richTextBox1_Sieve_of_Eratosthenes.Text += numbers_1[i] +" ;";
        }
        private void Theorem_small_Ferma(ref List<int> numbers_2,int baza,int n)
        {
            BigInteger a = baza;
            for(int p = 2; p < n; p++)
            {
                if (a % p == 1)
                    numbers_2.Add(p);
                a = a * baza;
            }

            for (int i = 0; i < numbers_2.Count; i++)
                richTextBox_Ferma_theorem.Text += numbers_2[i] + " ;";

        }
        private void Find_and_print_Pseudoprimes(List<int> numbers_1, List<int> numbers_2)
        {
            List<int> Pseudoprimes = new List<int>();
            Pseudoprimes = numbers_2;

            int j = 0;
            for(int i =0; i< numbers_1.Count;i++)
            {
                for(;j<numbers_2.Count;j++)
                {
                    if (numbers_1[i] == numbers_2[j])
                    {
                        Pseudoprimes.Remove(numbers_2[j]);
                        break;
                    }

                    if (numbers_1[i] < numbers_2[j])
                        break;
                }
            }
            for (int i = 0; i < Pseudoprimes.Count; i++)
                richTextBox_Pseudoprimes.Text += Pseudoprimes[i] + " ;";

        }

        //////
        ///


    }
}
