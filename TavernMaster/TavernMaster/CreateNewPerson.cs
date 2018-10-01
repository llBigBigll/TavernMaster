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

namespace My_first_window_app
{

    public partial class fCreateNewOne : Form
    {


        Random randNum = new Random();

        public fCreateNewOne()
        {
            InitializeComponent();
        }

        private void btnRandomName_Click(object sender, EventArgs e)
        {
            Random randNum = new Random();
            if (this.cmbboxGender.Text == "Мужской")
            {
                this.txtboxName.Text = Human.ListOfMaleNames[randNum.Next(0, Human.ListOfMaleNames.Count)];
            }
            else if (this.cmbboxGender.Text == "Женский")
            {
                this.txtboxName.Text = Human.ListOfFemaleNames[randNum.Next(0, Human.ListOfFemaleNames.Count)];
            }
            else {
                MessageBox.Show("НЕ ВВЕДЕН ПОЛ!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            string name;
            string surname;
            int age;
            int health;
            int charism;
            int intel;
            int att;
            Global.HairColor haircolor;
            Global.Gender gender;

            name = txtboxName.Text;
            surname = txtboxSurname.Text;
            haircolor = Program.Convert_to_haircolor(cmbboxHair.Text);
            gender = Program.Convert_to_gender(cmbboxGender.Text);
            age = Convert.ToInt32(txtboxAge.Text);
            health = Convert.ToInt32(txtboxHealth.Text);
            charism = Convert.ToInt32(txtboxCharism.Text);
            intel = Convert.ToInt32(txtboxInt.Text);
            att = Convert.ToInt32(txtboxAttractivness.Text);

            //txtboxName.Text = att.ToString();
            Global.Population.Add(new Human(name, surname, age, health, gender, haircolor, charism, att, intel));

            //Global.Population.Add(new Human(txtboxName.Text, txtboxSurname.Text, Convert.ToInt32(txtboxAge.Text),
            //    Convert.ToInt32(txtboxHealth.Text), Program.Convert_to_gender(cmbboxGender.SelectedText),
            //    Program.Convert_to_haircolor(cmbboxHair.SelectedText), Convert.ToInt32(txtboxCharism.Text.ToString()),
            //    Convert.ToInt32(txtboxAttractivness.Text.ToString()), Convert.ToInt32(txtboxInt.Text.ToString())));

            MessageBox.Show("Человек Создан", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Tuple<List<string>, List<string>, List<string>> names_tuple = new Tuple<List<string>, List<string>, List<string>>(Human.ListOfMaleNames, Human.ListOfFemaleNames, Human.ListOfSurNames);
            if (Global.Population != null)
            {
                if (Global.Population.Count() != 0)
                {
                    Program.Write_ppl(Global.Population, Global.file_of_population);
                }
            }
            Program.Write_names(names_tuple, Global.file_of_names);
            
            Program.Write_count(Human.counter, Global.file_of_counter);
            this.Close();
        }

        private void EnterToTAB(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void txtboxInt_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }
    }
}
