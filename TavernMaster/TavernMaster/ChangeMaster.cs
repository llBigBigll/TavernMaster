using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TavernMaster
{
    public partial class ChangeAcc : Form
    {
        public ChangeAcc()
        {
            InitializeComponent();
            List<string> mastersnames = new List<string>();
            foreach (Tavern_master el in Global.Masters)
            {
                mastersnames.Add(el.Get_Name()+"   Уровень: "+el.GetLvl().ToString()+"  Золото: "+el.Get_Fund().ToString()+"  Таверна: "+
                    "\""+el.Get_TavernName()+ "\"");
            }
            string[] mastersnamearr = mastersnames.ToArray();
            this.listBox.Items.AddRange(mastersnamearr);
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            Creating_tavern_master creating = new Creating_tavern_master();
            creating.Show();
            this.Hide();
            creating.FormClosing += CreatingClosing;
        }

        private void CreatingClosing(object sender, FormClosingEventArgs e)
        {
            this.listBox.Items.Clear();
            List<string> mastersnames = new List<string>();
            foreach (Tavern_master el in Global.Masters)
            {
                mastersnames.Add(el.Get_Name() + "   Уровень: " + el.GetLvl().ToString() + "  Золото: " + el.Get_Fund().ToString() + "  Таверна: " +
                    "\"" + el.Get_TavernName() + "\"");
            }
            string[] mastersnamearr = mastersnames.ToArray();
            this.listBox.Items.AddRange(mastersnamearr);
            this.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Аккаунт" +this.listBox.SelectedItem + " будет удален без возможности востановления", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (Global.Masters[this.listBox.SelectedIndex] != Global.cur_master)
            {
                if (DialogResult.Yes == result)
                {
                    Global.Masters.RemoveAt(this.listBox.SelectedIndex);
                    MessageBox.Show("Аккаунт Удален", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.None);
                    this.listBox.Items.Clear();
                    List<string> mastersnames = new List<string>();
                    foreach (Tavern_master el in Global.Masters)
                    {
                        mastersnames.Add(el.Get_Name() + "   Уровень: " + el.GetLvl().ToString() + "  Золото: " + el.Get_Fund().ToString() + "  Таверна: " +
                            "\"" + el.Get_TavernName() + "\"");
                    }
                    string[] mastersnamearr = mastersnames.ToArray();
                    this.listBox.Items.AddRange(mastersnamearr);
                    Program.Write_masters(new Tuple<Tavern_master, List<Tavern_master>>(Global.cur_master, Global.Masters), Global.file_players_list);
                }
            }
            else {
                MessageBox.Show("Нельзя удалить текущий профиль!!!","Ошибка", MessageBoxButtons.OK,MessageBoxIcon.Stop);
            }
        }

        private void btnChoise_Click(object sender,EventArgs e)
        {
            
            Global.Appdate_cur_master(Global.Masters[this.listBox.SelectedIndex]);
            MessageBox.Show("Профиль изменен на " + Global.cur_player_name, "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
