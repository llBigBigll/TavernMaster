using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.RegularExpressions;
using System.Windows.Forms;
/* 
 * TODO:
 * set all buttons back color transparent
 * set all butons flat
 * 
 */



     

namespace TavernMasterr
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 
        [STAThread]

        static public void Write_names(Tuple<List<string>, List<string>, List<string>> names, string filename)//запись доступных имен/фамилий в файл
        {
            BinaryFormatter formatter = new BinaryFormatter();

            using (FileStream filestream = new FileStream(System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)+
                @"\Tavern_master" + filename, FileMode.Create))
            {
                formatter.Serialize(filestream, names);
            }

        }
        static public Tuple<List<string>, List<string>, List<string>> Getnames(string filename)//достает список имен из файла
        {
            BinaryFormatter formatter = new BinaryFormatter();
            List<string> aa = new List<string>() { "" };
            List<string> bb = new List<string>() { "" };
            List<string> cc = new List<string>() { "" };
            Tuple<List<string>, List<string>, List<string>> a = new Tuple<List<string>, List<string>, List<string>>(aa, bb, cc);

            using (FileStream filestream = new FileStream(System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
                + @"\Tavern_master" + filename, FileMode.OpenOrCreate))
            {
                Tuple<List<string>, List<string>, List<string>> b = (Tuple<List<string>, List<string>, List<string>>)formatter.Deserialize(filestream);
                a = b;
            }

            return a;
        }

        static public void Write_ppl(List<Human> humans, string filename)//запись популяции в файл на вход список всех людей
        {
            BinaryFormatter formatter = new BinaryFormatter();

            using (FileStream filestream = new FileStream(System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) +
                @"\Tavern_master" + filename, FileMode.Create))
            {
                formatter.Serialize(filestream, humans);
            }

        }
        static public List<Human> Get_human_list(string filename)//достает популяцию из файла
        {
            BinaryFormatter formatter = new BinaryFormatter();
            List<Human> a = new List<Human>();

            using (FileStream filestream = new FileStream(System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) +
                @"\Tavern_master" + filename, FileMode.OpenOrCreate))
            {
                List<Human> b = (List<Human>)formatter.Deserialize(filestream);
                a = b;
            }

            return a;
        }

        static public void Write_count(int a, string filename)//записывает в файл счетчик 
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream filestream = new FileStream(System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + 
                @"\Tavern_master" + filename, FileMode.Create))
            {
                formatter.Serialize(filestream, a);
            }
        }
        static public int Get_counter(string filename)//чтение из файла
        {
            int a;
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream filestream = new FileStream(System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) +
                @"\Tavern_master" + filename, FileMode.OpenOrCreate))
            {
                int b = (int)formatter.Deserialize(filestream);
                a = b;
            }
            return a;
        }

        static public void Write_masters(Tuple<Tavern_master, List<Tavern_master>> masters, string filename)//Запись игроков в файл
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream filestream = new FileStream(System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) +
                @"\Tavern_master" + filename, FileMode.Create))
            {
                formatter.Serialize(filestream, masters);
            }

        }
        static public Tuple<Tavern_master, List<Tavern_master>> Get_masters(string filename)//Чтение игроков из файла
        {
            BinaryFormatter formatter = new BinaryFormatter();
            Tavern_master cur_master=new Tavern_master();
            List<Tavern_master> all_masters = new List<Tavern_master>();
            Tuple<Tavern_master, List<Tavern_master>> masters = new Tuple<Tavern_master, List<Tavern_master>>(cur_master, all_masters);
            using (FileStream filestream = new FileStream(System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
                + @"\Tavern_master" + filename, FileMode.OpenOrCreate))
            {
                Tuple<Tavern_master, List<Tavern_master>> masterr = (Tuple<Tavern_master, List<Tavern_master>>)formatter.Deserialize(filestream);
                masters = masterr;
            }
                return masters;
        }

        static public void Show_population(List<Human> pop)//выводит на экран всю популяцию
        {
            foreach (Human human in pop)
            {
                human.Show_human();
                Console.WriteLine("##############################");
            }
        }

        static public void Spend_some_years(List<Human> humen, int a)//прожить n лет
        {
            foreach (Human human in humen)
            {
                human.Spend_years(a);
            }
        }
        static public void Appdate_pop(List<Human> humen)//обновить список людей
        {
            List<Human> aa = new List<Human>();
            foreach (Human human in humen)
            {
                int a = 0;
                int b = 0;
                a = human.get_health();
                if (a <= 0)
                {
                    b = human.get_id();
                    aa.Add(new Human(b, 100));
                }
            }

            foreach (Human el in aa)
            {
                humen.Remove(el);
            }

        }

        static public Global.Gender Convert_to_gender(string a)
        {
            Global.Gender gender = Global.Gender.Male;
            if (a == "Мужской") { gender = Global.Gender.Male; }
            if (a == "Женский") { gender = Global.Gender.Female; }

            return gender;
        }
        static public Global.HairColor Convert_to_haircolor(string a)
        {

            Global.HairColor haircolor = Global.HairColor.Black;
           
            if (a == "Каштановые")
            {
                haircolor = Global.HairColor.Brown;
            }
            if (a == "Блондин")
            {
                haircolor = Global.HairColor.Blond;
            }
            if (a == "Рыжий")
            {
                haircolor = Global.HairColor.Red;
            }
            if (a == "Брюнет")
            {
                haircolor = Global.HairColor.Black;
            }
            if (a == "Фиолетовый")
            {
                haircolor = Global.HairColor.Purple;
            }
            if (a == "Зеленый")
            {
                haircolor = Global.HairColor.Green;
            }
            if (a == "Розовый")
            {
                haircolor = Global.HairColor.Pink;
            }

            return haircolor;
        }
        

        static void Main()
        {
            //string cur_player_name = "";
            //string file_players_list = @"\" + "players";
            //string file_of_names = @"\" + "names.dat";
            //string file_of_population = @"\" + cur_player_name + "pulation.dat";
            //string file_of_counter = @"\" + cur_player_name + "counter.dat";

            //Проверка сощевствования папки с игрой
            if (Directory.Exists(System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) +
                @"\Tavern_master") == false)
            {
                Directory.CreateDirectory(System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) +
                    @"\Tavern_master");
            }
            if (new FileInfo(System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) +
                @"\Tavern_master" + Global.file_players_list).Exists)
            {
                if (new FileInfo(System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + 
                    @"\Tavern_master" + Global.file_players_list).Length != 0)
                {
                    Global.Appdate_cur_master( Get_masters(Global.file_players_list).Item1);
                    Global.Masters = Get_masters(Global.file_players_list).Item2;
                    Global.is_there_tavern = true;
                }
            }
            if (Global.is_there_tavern)
            {



                //Загрузка сохраненных данных
                if (new FileInfo(System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) +
                    @"\Tavern_master" + Global.file_of_names).Exists)
                {
                    if (new FileInfo(System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) +
                        @"\Tavern_master" + Global.file_of_names).Length != 0)
                    {
                        Human.ListOfMaleNames = Getnames(Global.file_of_names).Item1;
                        Human.ListOfFemaleNames = Getnames(Global.file_of_names).Item2;
                        Human.ListOfSurNames = Getnames(Global.file_of_names).Item3;
                    }
                }

                //Загрузка сохраненных данных
                if (new FileInfo(System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + 
                    @"\Tavern_master" + Global.file_of_population).Exists)
                {
                    if (new FileInfo(System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) +
                        @"\Tavern_master" + Global.file_of_population).Length != 0)
                    {
                        Global.Population = Get_human_list(Global.file_of_population);
                    }
                }

                //Загрузка сохраненных данных
                if (new FileInfo(System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + 
                    @"\Tavern_master" + Global.file_of_counter).Exists)
                {
                    if (new FileInfo(System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) +
                        @"\Tavern_master" + Global.file_of_counter).Length != 0)
                    {
                        Human.counter = Get_counter(Global.file_of_counter);
                    }
                }


                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new MainWindow());
            }
            else
            {
                bool is_new_game = !Global.is_there_tavern;
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new MainWindow(is_new_game ));

            }
        }
    }
}
