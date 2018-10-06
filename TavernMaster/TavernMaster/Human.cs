using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TavernMaster
{

  
//enum Attractiveness { Ugly, Almost_Ugly, NotVeryAttractive, Attractive, Alpha }//5 элементов
//enum Intelligence { Retarded, Stupid, NotStupid, MiddleMinded, Smart, Genius }//6 элементов
//enum Charisma { Parubij, PickUpMaster, Mercury, Jesus }//4 элемента

    [Serializable]
    public class Human
    {
        

        public static int counter = 0;//Счетчик людей глобальный
        public static List<string> ListOfMaleNames = new List<string>() { "Иван" };//список мужских Имен для случайного подбора 
        public static List<string> ListOfFemaleNames = new List<string>() { "Мария" };//список женских Имен для случайного подбора 
        public static List<string> ListOfSurNames = new List<string>() { "Петренко" };//список фамилий для случайного подбора

        string Name;//Имя

        string SurName;//фамилия

        int Age;//возраст

        int identification_code;//уникальный код человека

        Gender gender;//пол 
        const int num_of_gender = 2;//количество возможных полов

        HairColor hair_color;//цвет волос
        const int num_of_hairs = 7;// количество возможных цветов волос

        int charisma;//уровень харизмы [0,100]
        //const int num_of_charisma = 4; //количество уровней харизмы

        int attractiveness;//уровень привлекательности [0,100]
        //const int num_of_attractiveness = 5;//количество уровней привлекательности

        int intelligence;//уровень интеллекта [0,100]
                         //const int num_of_intelligence = 6; //количество уровней интеллекта

        int HealthIndex;//уровень здоровья от 0 до 100 где 0- мертв 100- абсолютно здоров



        public Human(int id, int age)//служебный конструктор только с полями возраст и код
        {
            this.Age = age;
            this.identification_code = id;
        }
        public Human(string name, string surname, int age, int Healthindexx, Gender genderr, HairColor hairColor, int charisma,
            int attractivenesss,int intelligencee)//Новый человек с всеми задаными параметрами
        {
            this.Name = name;
            this.SurName = surname;
            this.Age = age;
            this.identification_code = counter;
            this.gender = genderr;
            this.hair_color = hairColor;
            this.charisma = charisma;
            this.attractiveness = attractivenesss;
            this.intelligence = intelligencee;
            this.HealthIndex = Healthindexx;
            if (this.gender == Gender.Male)
            {
                if (!ListOfMaleNames.Contains(name))
                {
                    ListOfMaleNames.Add(name);
                }
                if (!ListOfSurNames.Contains(surname))
                {
                    ListOfSurNames.Add(surname);
                }
            }
            else
            {
                if (!ListOfFemaleNames.Contains(name))
                {
                    ListOfFemaleNames.Add(name);
                }
                if (!ListOfSurNames.Contains(surname))
                {
                    ListOfSurNames.Add(surname);
                }
            }
            counter++;
        }
        public Human(int age)//случайный человек заданого возраста
        {
            Random randomNum = new Random();


            this.SurName = ListOfSurNames[randomNum.Next(0, ListOfSurNames.Count)];
            this.Age = age;
            this.identification_code = counter;
            this.gender = (Gender)randomNum.Next(0, num_of_gender);
            if (this.gender == Gender.Male)
            {
                this.Name = ListOfMaleNames[randomNum.Next(0, ListOfMaleNames.Count)];
            }
            else
            {
                this.Name = ListOfFemaleNames[randomNum.Next(0, ListOfFemaleNames.Count)];
            }
            this.hair_color = (HairColor)randomNum.Next(0, num_of_hairs);
            this.charisma = randomNum.Next(0, 100);
            this.attractiveness = randomNum.Next(0, 100);
            this.intelligence = randomNum.Next(0, 100);
            this.HealthIndex = randomNum.Next(0, 101);

            counter++;
        }
        public Human()//полностью рандомный взрослый человек
        {
            Random randomNum = new Random();//случайный взрослый
            this.SurName = ListOfSurNames[randomNum.Next(0, ListOfSurNames.Count)];
            this.Age = 18 + randomNum.Next(0, 25);
            this.identification_code = counter;
            this.gender = (Gender)randomNum.Next(0, num_of_gender);
            if (this.gender == Gender.Male)
            {
                this.Name = ListOfMaleNames[randomNum.Next(0, ListOfMaleNames.Count)];
            }
            else
            {
                this.Name = ListOfFemaleNames[randomNum.Next(0, ListOfFemaleNames.Count)];
            }
            this.HealthIndex = randomNum.Next(0, 101);
            this.hair_color = (HairColor)randomNum.Next(0, num_of_hairs);
            this.charisma = randomNum.Next(0, 101);
            this.attractiveness = randomNum.Next(0, 101);
            this.intelligence = randomNum.Next(0, 101);

            counter++;
        }

        public string Get_human()//Возвращает данные о человеке в виде строки
        {
            string ansv= "";
            ansv += this.Name + " " + this.SurName + "\n";
            ansv += "ID: " + this.identification_code.ToString()+ "\n";
            ansv += "Пол: " + this.gender.ToString() + "\n";
            ansv += this.Age.ToString() + " лет" + "\n";
            ansv += "Цвет волос :" + this.hair_color.ToString() + "\n";
            ansv += "Уровень здоровья :" + this.HealthIndex.ToString() + "\n";
            ansv += "Харизма: " + this.charisma.ToString() + "\n";
            ansv += "Привлекательность: " + this.attractiveness.ToString() + "\n";
            ansv += "Интеллект: " + this.intelligence.ToString() + "\n";
            return ansv;
        } 
        public int get_health()
        {
            return this.HealthIndex;
        }
        public int get_age()
        {
            return this.Age;
        }
        public int get_id()
        {
            return this.identification_code;
        }
        public void Show_human()//вывод всех людей в консоль
        {
            Console.WriteLine(this.Name + " " + this.SurName);
            Console.WriteLine("ID: " + this.identification_code.ToString());
            Console.WriteLine("Пол: " + this.gender.ToString());
            Console.WriteLine(this.Age.ToString() + " лет");
            Console.WriteLine("Цвет волос :" + this.hair_color.ToString());
            Console.WriteLine("Уровень здоровья :" + this.HealthIndex.ToString());
            Console.WriteLine("Харизма: " + this.charisma.ToString());
            Console.WriteLine("Привлекательность: " + this.attractiveness.ToString());
            Console.WriteLine("Интеллект: " + this.intelligence.ToString());
        }
        public void Spend_years(int years)//обновляет значение возраста и здоровья в зависимости от пройденных лет
        {
            this.HealthIndex -= years;
            this.Age += years;

        }

        bool IsEqual(Human human) { return Int32.Equals(identification_code, human.identification_code); }
        public override bool Equals(object obj)
        {
            if (Object.ReferenceEquals(null, obj)) { return false; }
            if (Object.ReferenceEquals(this, obj)) { return true; }
            if (obj.GetType() != this.GetType()) { return false; }
            return IsEqual((Human)obj);
        }
        public bool Equals(Human human)
        {
            if (Object.ReferenceEquals(null, human)) { return false; }
            if (Object.ReferenceEquals(this, human)) { return true; }

            return IsEqual(human);
        }
        public static bool operator !=(Human a, Human b)
        {
            return a.identification_code != b.identification_code;
        }
        public static bool operator ==(Human a, Human b)
        {
            return a.identification_code == b.identification_code;
        }
    }
}
