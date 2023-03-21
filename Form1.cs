using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
                    text += "a";
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
                        p += ((int)k[i] + (int)binar_text[i * 16 + j]) % 2;
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

        //////
        ///


    }
}
