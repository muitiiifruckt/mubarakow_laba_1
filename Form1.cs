using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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

        public bool string_in(char a, string s) // функция, которая проверяет наличие того или иного элемента в алфавит 
        {
            for (int i = 0; i < s.Length; i++)
            {
                if (a == s[i])
                    return true;
            }
            return false;
        }

        private void checkBox_ru_CheckedChanged(object sender, EventArgs e)
        {
            
            checkBox_en.CheckState = CheckState.Unchecked;
            alf = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя0123456789";
        }

        private void checkBox_en_CheckedChanged(object sender, EventArgs e)
        {
            checkBox_ru.CheckState = CheckState.Unchecked;
            alf = "abcdefghijklmnopqrstuvwxyz0123456789";
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
                double numberkey = double.Parse(key);
                int number_key = (int)(numberkey % (double)n);
                // обработка больших чисел

                //

                for (int i = 0, j = 0; i < text.Length; i++) // главный цикл, который проводит шифрование
                    {
                        j = 0;
                        for (; j < alf.Length; j++)
                            if (alf[j] == text[i])
                                break;
                        S += alf[(j + number_key) % n];
                    }
                        
                richTextBox3.Text = S;
                S = "";

            }
            catch (Exception e)
            {
                MessageBox.Show($"Ошибка: {e.Message}");
                throw;
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
                double numberkey = double.Parse(key);
                int number_key = (int)(numberkey % (double)n);
                // обработка больших чисел

                //

                for (int i = 0, j = 0; i < text.Length; i++) // главный цикл, который проводит шифрование
                {
                    j = 0;
                    for (; j < alf.Length; j++)
                        if (alf[j] == text[i])
                            break;
                    S += alf[((j - number_key)+n) % n];
                }

                richTextBox4.Text = S;
                S = "";

            }
            catch (Exception e)
            {
                MessageBox.Show($"Ошибка: {e.Message}");
                throw;
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
    }
}
