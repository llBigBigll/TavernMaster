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
    public partial class SecondFloor : Form
    {
        int AllIncome;
        public SecondFloor()
        {
            InitializeComponent();
            this.txtInfo.Text = "Стоимость улутшения до ур2- "+Global.RoomsUpgradeCost[1].ToString()
                +", до ур3-"+Global.RoomsUpgradeCost[2].ToString();
            UpdateForm();
        }
        private void UpdateForm(object sender, EventArgs e)
        {
            string Status;
            AllIncome = 0;
            this.listOfRenters.Items.Clear();
            foreach (Room room in Global.cur_master.TheTavern.Rooms)
            {
                if (room.GetStatus())
                {
                    Status = " Статус: Вкл";
                }
                else
                {
                    Status = " Статус:Выкл";
                }
                if (room.GetGuestName() != null)
                {
                    this.listOfRenters.Items.Add("Постоялец: " + room.GetGuestName() + " Уровень: " +
                        room.GetGrade().ToString() + "Доход: " + room.GetIncome().ToString() + Status);
                    this.AllIncome += room.GetIncome();
                }
                else
                {
                    this.listOfRenters.Items.Add("Постояльца нет" + room.GetGuestName() + " Уровень: " +
                        room.GetGrade().ToString() + " Доход: " + room.GetIncome().ToString() + Status);
                    this.AllIncome += room.GetIncome();
                }
            }

            this.incomeBar.Text = "Общий доход: "+ Convert.ToString(AllIncome);

            
        }
        private void UpdateForm()
        {
            this.listOfRenters.Items.Clear();
            AllIncome = 0;
            string Status;
            foreach (Room room in Global.cur_master.TheTavern.Rooms)
            {
                if (room.GetStatus())
                {
                    Status = " Статус: Вкл";
                }
                else
                {
                    Status = " Статус:Выкл";
                }
                if (room.GetGuestName() != null)
                {
                    this.listOfRenters.Items.Add("Постоялец: " + room.GetGuestName() + " Уровень: " +
                        room.GetGrade().ToString() + "Доход: " + room.GetIncome().ToString()+Status);
                    this.AllIncome += room.GetIncome();
                }
                else
                {
                    this.listOfRenters.Items.Add("Постояльца нет" + room.GetGuestName() + " Уровень: " +
                        room.GetGrade().ToString() + " Доход: " + room.GetIncome().ToString() + Status );
                    this.AllIncome += room.GetIncome();
                }
            }
            this.incomeBar.Text = "Общий доход: " + Convert.ToString(AllIncome);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnChangeStatus_Click(object sender, EventArgs e)
        {
            int RoomNum;
            RoomNum = this.listOfRenters.SelectedIndex;
            if (RoomNum != -1)
            {
                Global.cur_master.TheTavern.Rooms[RoomNum].ChangeStatus();
                UpdateForm();
            }
        }

        private void SecondFloor_FormClosing(object sender, FormClosingEventArgs e)
        {
            Global.SaveGame();
        }

        private void btnUpgrade_Click(object sender, EventArgs e)
        {
            int RoomNum;
            RoomNum = this.listOfRenters.SelectedIndex;
            Global.cur_master.TheTavern.Rooms[RoomNum].Upgrade();
            UpdateForm();

        }

        private void btnUpgradeAll_Click(object sender, EventArgs e)
        {
            int summ = 0;
            foreach (Room el in Global.cur_master.TheTavern.Rooms)
            {
                if (el.GetGrade() < 3)
                {
                    summ += Global.RoomsUpgradeCost[el.GetGrade()];
                }
            }
            if (summ<= Global.cur_master.Get_Fund())
            {
                foreach (Room el in Global.cur_master.TheTavern.Rooms)
                {
                    if (el.GetGrade() < 3)
                    {
                        el.Upgrade();
                    }
                }
            }
            else
            {
                MessageBox.Show("Не достаточно золота!","Ошибка",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }
    }
}
