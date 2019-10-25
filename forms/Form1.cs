using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_KP
{
    public partial class Form1 : Form
    {
        
        Work[] AllWork = new Work[1000];//произведение
        Author[] Authors = new Author[1000];
        Readership[] Readerships = new Readership[1000];
        Publishing_house[] pHouses = new Publishing_house[1000];
        Language[] Languages = new Language[1000];
        Genre[] Genres = new Genre[1000];
        Country[] Countries = new Country[1000];

        int Count;

        static string path = "Books.txt";
        string path2 = "WriteBooks.txt";
        string path3 = "forDelete.txt";

        public Form1()
        {
            InitializeComponent();           
        }
        
        public void Reading(string line, ref string name, ref string author, ref string genre, ref string country, ref string lang, ref string readSh, ref string pubHouse)
        {
            int a = 0, n = 0, y = 0, t = 0, q = 0, z = 0, w = 0, f = 0;

            t = line.IndexOf("  ", 2);
            a = line.IndexOf("  ", t + 2);
            n = line.IndexOf("  ", a + 2);
            y = line.IndexOf("  ", n + 2);
            q = line.IndexOf("  ", y + 2);
            z = line.IndexOf("  ", q + 2);
            w = line.IndexOf("  ", z + 2);
            f = line.IndexOf("  ", w + 2);

            name = Convert.ToString(line.Substring(0, t - 0));
            author = Convert.ToString(line.Substring(t, a - t));
            genre = Convert.ToString(line.Substring(a, n - a));
            country = Convert.ToString(line.Substring(n, y - n));
            lang = Convert.ToString(line.Substring(y, q - y));
            readSh = Convert.ToString(line.Substring(q, z - q));
            pubHouse = Convert.ToString(line.Substring(z, w - z));
            //pubHouse = Convert.ToString(line.Substring(w, f - w));

            name = name.Trim();
            author = author.Trim();
            genre = genre.Trim();
            country = country.Trim();
            lang = lang.Trim();
            readSh = readSh.Trim();
            pubHouse = pubHouse.Trim();            
        }

        public void CreateListOfNames()
        {
            try
            {
                using (StreamReader sr = new StreamReader(path, System.Text.Encoding.Default))
                {

                    string line;
                    string name="", author="", genre="", country="", lang="", readSh="", pubHouse="";

                    while ((line = sr.ReadLine()) != null)
                    {
                        Reading(line, ref name, ref author, ref  genre, ref  country, ref  lang, ref  readSh, ref  pubHouse);

                        comboBox1.Items.Add(name);//LIST OF NAMES
                        comboBox5.Items.Add(author);//LIST OF authors
                        comboBox6.Items.Add(genre);//LIST OF genre
                        comboBox6.Items.Add(country);//LIST OF country
                        comboBox7.Items.Add(lang);//LIST OF lang
                        comboBox8.Items.Add(readSh);//LIST OF readSh
                        comboBox9.Items.Add(pubHouse);//LIST OF pubHouse

                        //запись в класс Book из файла
                        //пишем данные из файла в массив
                        AllWork[Count].Updt(name);
                        Authors[Count].Updt(author);
                        Genres[Count].Updt(genre);
                        Countries[Count].Updt(country);
                        Languages[Count].Updt(lang);                        
                        Readerships[Count].Updt(readSh);
                        pHouses[Count].Updt(pubHouse);

                        Count++;
                    }
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        } //list of works

        public void ReadingLang()
        {
            string pathLang = "ListOfLanguages.txt";
            try
            {
                using (StreamReader sr = new StreamReader(pathLang, System.Text.Encoding.Default))
                {

                    string line, lang;
                    int a = 0, t = 0;

                    while ((line = sr.ReadLine()) != null)
                    {
                        t = line.IndexOf(" ", 1);            

                        lang = Convert.ToString(line.Substring(0, t - 0));

                        lang = lang.Trim();

                        comboBox4.Items.Add(lang);//LIST OF lang                     

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
            string pathCtr = "ListOfCountries.txt";
            try
            {
                using (StreamReader sr = new StreamReader(pathCtr, System.Text.Encoding.Default))
                {

                    string line, cntr;
                    int t = 0;

                    while ((line = sr.ReadLine()) != null)
                    {
                        t = line.IndexOf(" ", 1);

                        cntr = Convert.ToString(line.Substring(0, t - 0));

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

        public void ReadingGenres()
        {
            string pathgen = "ListOfGenres.txt";
            try
            {
                using (StreamReader sr = new StreamReader(pathgen, System.Text.Encoding.Default))
                {

                    string line, gnrs;
                    int t = 0;

                    while ((line = sr.ReadLine()) != null)
                    {
                        t = line.IndexOf(" ", 1);

                        gnrs = Convert.ToString(line.Substring(0, t - 0));

                        gnrs = gnrs.Trim();

                        comboBox2.Items.Add(gnrs);//LIST OF lang                     

                    }
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        } //list of genres

        public void ClearFormsBoxes()
        {
            textBox1.Clear();
            textBox5.Clear();
            groupBox1.Visible = false;
            comboBox1.Text = "";
            comboBox2.Text = "";
            comboBox3.Text = "";
            comboBox4.Text = "";
            textBox2.Clear();
            textBox3.Clear();
        } // очищаем все поля на форме

        public void UpdtForClasses(int parameter)
        {
            AllWork[parameter].Updt(textBox3.Text); // Обновляем текущий по порядку пустой объект
            Authors[parameter].Updt(textBox1.Text);
            Genres[parameter].Updt(comboBox2.Text);
            Countries[parameter].Updt(comboBox3.Text);
            Languages[parameter].Updt(comboBox4.Text);
            Readerships[parameter].Updt(textBox5.Text);
            pHouses[parameter].Updt(textBox2.Text);
        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e) // Обрабатывае нажатие на кнопки
        {
            if (e.KeyChar == (char)Keys.Enter) // Если нажат Enter
            {
                groupBox1.Visible = true;
                textBox3.Text = comboBox1.Text;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            File.Delete(path3);
            Count = 0; // Обнуляем счетчик work при открытии окна

            for (int i = 0; i < 1000; i++)
            {
                AllWork[i] = new Work();
                Authors[i] = new Author();
                Readerships[i] = new Readership();
                pHouses[i] = new Publishing_house();
                Languages[i] = new Language();
                Genres[i] = new Genre();
                Countries[i] = new Country();
            };

            CreateListOfNames();//чтение из файла сведений о книгах | LIST OF NAMES AND THEIR DATA
            ReadingGenres(); //LIST OF GENRES
            ReadingCountries(); //LIST OF COUNTRIES
            ReadingLang(); //LIST OF LANG
        }      
       
        private void button1_Click(object sender, EventArgs e)//DELETE
        {
            Count--;
            for (int i = comboBox1.SelectedIndex; i < Count; i++)
            {
                AllWork[i] = AllWork[i + 1];
            }

            DeleteData(textBox3.Text, textBox1.Text);

            ClearFormsBoxes();

            comboBox1.Items.Clear();
            CreateListName();
        }

        private void button2_Click(object sender, EventArgs e)//SAVE
        {
            WriteData(textBox3.Text,textBox1.Text,comboBox2.Text,comboBox3.Text,comboBox4.Text,textBox5.Text,textBox2.Text);

            ClearFormsBoxes();

            comboBox1.Items.Clear();
            CreateListName();
        }

        void CreateListName()
        { 
            for (int i = 0; i < Count; i++)
            {
                comboBox1.Items.Add(AllWork[i].GetName());
            }
        }

        private void button3_Click(object sender, EventArgs e)//CANCEL
        {
            ClearFormsBoxes();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            textBox3.Text = comboBox1.Text;

            int Index = comboBox1.SelectedIndex; //SelectedIndex, которое содержит номер выбранной строки списка
            textBox1.Text = Authors[Index].GetAuthor();
            textBox5.Text = Readerships[Index].GetCirculation().ToString();
            textBox2.Text = pHouses[Index].GetHouse();
            textBox4.Text = Genres[Index].GetGenre();//GENRES
            comboBox2.Text = textBox4.Text;
            textBox6.Text = Countries[Index].GetCountry();//COUNTRIES
            comboBox3.Text = textBox6.Text;       
            textBox7.Text = Languages[Index].GetLanguage();//LANGUAGE
            comboBox4.Text = textBox7.Text;

        }

        public void WriteData(string NAME, string AUTHOR, string GENRE, string COUNTRY, string LANGUAGE, string READERSHIP,string PUBLISHINGHOUSE)
        {
            bool Flag = false;
            int Cur = -1;

            File.Delete(path2);

            for (int i = 0; i < Count; i++)
            {
                if (AllWork[i].GetName() == textBox3.Text && Authors[i].GetAuthor() == textBox1.Text)
                {
                    Flag = true;
                    Cur = i;
                    break;
                }// Такоe name&&author уже есть
            }

            string forArr = "";           

            if (NAME == ""|| COUNTRY=="" || LANGUAGE=="" || READERSHIP=="" || PUBLISHINGHOUSE=="" || AUTHOR == "" || GENRE == "")
            {
                MessageBox.Show("Заполните все поля данными!", "Предупреждение",MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                /////////here////////
                if (Flag == false) //if there is no author and name combination
                {
                    UpdtForClasses(Count);// Обновляем текущий по порядку пустой объект
                    Count++;
                }
                else
                {
                    UpdtForClasses(Cur);// Обновляем текущий по порядку пустой объект /ubdate current string
                };
                               
                    for (int i = 0; i < Count; i++)
                {
                    forArr = AllWork[i].GetName() + "  " + Authors[i].GetAuthor() + "  " + Genres[i].GetGenre() + "  " + Countries[i].GetCountry() + "  " + Languages[i].GetLanguage() + "  " + Readerships[i].GetCirculation() + "  " + pHouses[i].GetHouse() + "  " + Environment.NewLine;
                    File.AppendAllText(path2, forArr, Encoding.Default);
                };        
                 
                File.Delete(path);// удаляем существующий path2, чтобы скопировать в новый path2 файл Books.txt
                File.Copy(path2, path);
                File.Delete(path2);
            }

        }

        public void DeleteData(string NAME, string AUTHOR)
        {
            for (int i = 0; i < Count; i++)            {

                if (AllWork[i].GetName() == NAME && Authors[i].GetAuthor() == AUTHOR) //если строка содержит nm-значение выбранное пользователем, то продолжаем цикл
                {
                    continue;
                }
                else//если строка не содержит nm-значение выбранное пользователем, то выводим оставшиеся значения из массива
                {
                   string forArr = AllWork[i].GetName() + "  " + Authors[i].GetAuthor() + "  " + Genres[i].GetGenre() + "  " + Countries[i].GetCountry() + "  " + Languages[i].GetLanguage() + "  " + Readerships[i].GetCirculation() + "  " + pHouses[i].GetHouse() + "  " + Environment.NewLine;
                   File.AppendAllText(path3, forArr, Encoding.Default);
                }  
            };

            if (!File.Exists(path3)) File.CreateText(path3);
            if (File.Exists(path3))
            {
                //перезаписываем файл books
                File.Delete(path);
                File.Delete(path2);
                File.Copy(path3, path);
                File.Copy(path3, path2);         
            };

            File.Delete(path3);//удаляем forDelete
        }

        //-------------------------------------------------------------------------//

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)//GENRES
        {
            textBox4.Text = comboBox2.Text;
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)//COUNTRIES
        {
            textBox6.Text = comboBox3.Text;
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)//LANGUAGES
        {
            textBox7.Text = comboBox4.Text;
        }

        private void button4_Click(object sender, EventArgs e)//Exit
        {
            Application.Exit();
        }

        private void label9_Click(object sender, EventArgs e)// GO TO ADMIN PANEL
        {            
            auth s = new auth();
            s.Show();

            this.Hide();
        }
    }
}
