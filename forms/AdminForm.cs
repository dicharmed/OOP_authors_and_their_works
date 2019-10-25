using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_KP
{
    public partial class AdminForm : Form
    {
        string pathLang = "ListOfLanguages.txt";
        string pathCtr = "ListOfCountries.txt";
        string pathgen = "ListOfGenres.txt";

        string[] GENRES = new string[15];
        string[] LANG = new string[15];
        string[] COUNTRIES = new string[15];

        int c, q, z;

        public AdminForm()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)// EXIT
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e) // to the main form
        {
            this.Close();
            Form1 d = new Form1();
            d.Show();        
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            ReadingGenres();
            ReadingLang();
            ReadingCountries(); 
        }

        public void ReadingGenres()
        {
            try
            {
                using (StreamReader sr = new StreamReader(pathgen, System.Text.Encoding.Default))
                {

                    string line, gnrs;
                    int t = 0;
                    c = 0;
                    while ((line = sr.ReadLine()) != null)
                    {
                        t = line.IndexOf(" ", 1);

                        gnrs = Convert.ToString(line.Substring(0, t - 0));

                        GENRES[c] = gnrs + " "; c++;

                        gnrs = gnrs.Trim();

                        comboBox1.Items.Add(gnrs);//LIST OF lang                     

                    }
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        } //list of genres

        public void ReadingLang()
        {

            try
            {
                using (StreamReader sr = new StreamReader(pathLang, System.Text.Encoding.Default))
                {

                    string line, lang;
                    int t = 0;
                    q = 0;
                    while ((line = sr.ReadLine()) != null)
                    {
                        t = line.IndexOf(" ", 1);

                        lang = Convert.ToString(line.Substring(0, t - 0));

                        LANG[q] = lang + " "; q++;

                        lang = lang.Trim();

                        comboBox2.Items.Add(lang);//LIST OF lang                     

                    }
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        } //list of lang

        public void ReadingCountries()
        {

            try
            {
                using (StreamReader sr = new StreamReader(pathCtr, System.Text.Encoding.Default))
                {

                    string line, cntr;
                    int t = 0;
                    z = 0;
                    while ((line = sr.ReadLine()) != null)
                    {
                        t = line.IndexOf(" ", 1);

                        cntr = Convert.ToString(line.Substring(0, t - 0));

                        COUNTRIES[z] = cntr + " "; z++;

                        cntr = cntr.Trim();

                        comboBox3.Items.Add(cntr);//LIST OF lang                     

                    }
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }// list of countries      
                      
        private void button1_Click(object sender, EventArgs e) //SAVE genres
        {
            if (textBox1.Text != "")
            {
                string genre = textBox1.Text + " " + Environment.NewLine;
            File.AppendAllText(pathgen, genre, Encoding.Default);
            textBox1.Text = "";

            comboBox1.Text = "";
            comboBox1.Items.Clear();           

            ReadingGenres();
            }
            else
                MessageBox.Show("Заполните поле \"Добавить жанр\"!");
        }

        private void button4_Click(object sender, EventArgs e) //DELETE genres
        {
            if (comboBox1.Text != "")
            {
                string[] rez = new string[c - 1];

                for (long y = comboBox1.SelectedIndex; y < c; ++y) //удаление из массива по индексу выбранному пользователем
                {
                    GENRES[y] = GENRES[y + 1];

                }
                --c;

                for (int r = 0; r < c; r++) //удаление из массива по индексу выбранному пользователем
                {
                    rez[r] = GENRES[r];

                }


                File.Delete(pathgen);
                File.WriteAllLines(pathgen, rez, Encoding.Default);

                comboBox1.Items.Clear();
                comboBox1.Text = "";

                ReadingGenres();
            }
            else
                MessageBox.Show("Выберите жанр!");
            
        }

        private void button5_Click(object sender, EventArgs e) //save lang
        {
            if (textBox2.Text != "")
            {
                string lang = textBox2.Text + " " + Environment.NewLine;
            File.AppendAllText(pathLang, lang, Encoding.Default);
            textBox2.Text = "";

            comboBox2.Text = "";
            comboBox2.Items.Clear();

            ReadingLang();
            }
            else
                MessageBox.Show("Заполните поле \"Добавить язык\"!");
        }

        private void button7_Click(object sender, EventArgs e)//delete lang
        {
            if (comboBox2.Text != "")
            {
                string[] rez = new string[q - 1];

            for (long y = comboBox2.SelectedIndex; y < q; ++y) //удаление из массива по индексу выбранному пользователем
            {
                LANG[y] = LANG[y + 1];
            }
            --q;

            for (int r = 0; r < q; r++) //удаление из массива по индексу выбранному пользователем
            {
                rez[r] = LANG[r];

            }

            File.Delete(pathLang);
            File.WriteAllLines(pathLang, rez, Encoding.Default);

            comboBox2.Items.Clear();
            comboBox2.Text = "";

            ReadingLang();
            }
            else
                MessageBox.Show("Выберите язык!");
        }

        private void button6_Click(object sender, EventArgs e)//save country
        {
            if (textBox3.Text != "")
            {
                string ctr = textBox3.Text + " " + Environment.NewLine;
                File.AppendAllText(pathCtr, ctr, Encoding.Default);
                textBox3.Text = "";

                comboBox3.Text = "";
                comboBox3.Items.Clear();

                ReadingCountries();
            }
            else
                MessageBox.Show("Заполните поле \"Добавить страну\"!");

        }

        private void button8_Click(object sender, EventArgs e)//delete country
        {
            if (comboBox3.Text != "")
            {
                string[] rez = new string[z - 1];

            for (long y = comboBox3.SelectedIndex; y < z; ++y) //удаление из массива по индексу выбранному пользователем
            {
                COUNTRIES[y] = COUNTRIES[y + 1];
            }
            --z;

            for (int r = 0; r < z; r++) //удаление из массива по индексу выбранному пользователем
            {
                rez[r] = COUNTRIES[r];

            }

            File.Delete(pathCtr);
            File.WriteAllLines(pathCtr, rez, Encoding.Default);

            comboBox3.Items.Clear();
            comboBox3.Text = "";

            ReadingCountries();
            }
            else
                MessageBox.Show("Выберите страну!");
        }
    }
}
