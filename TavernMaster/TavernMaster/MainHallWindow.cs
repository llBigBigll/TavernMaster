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
    [Serializable]
    public partial class MainHallWindow : Form
    {
        static int UpgradeCost = 0;
        static int updateCost;
        public MainHallWindow()
        {
            InitializeComponent();
            UpdateWindow();
            this.txtSumm.Hide();

        }
        private void UpdateWindow()
        {
            this.txtInvo.Text = "Стоимость улутшения до уровня 2- " + Global.MainHallUpgradePrice[1] + ". Для уровня 3 соответственно- " +
    Global.MainHallUpgradePrice[2] + " \nПри улутшении происходит автоматическа продажа столов и стульев";
            this.numTables.Value = Global.cur_master.TheTavern.Mainhall.CountTables();
            this.numChairs.Value = Global.cur_master.TheTavern.Mainhall.CountChairs();
            this.MaxChairs.Text = Global.cur_master.TheTavern.Mainhall.GetChairsCapacity().ToString();
            this.MaxTable.Text = Global.cur_master.TheTavern.Mainhall.GetTableCapacity().ToString();
            this.numTables.Maximum = Global.cur_master.TheTavern.Mainhall.GetTableCapacity();
            this.numChairs.Maximum = Global.cur_master.TheTavern.Mainhall.GetChairsCapacity();
            
            if (Global.cur_master.TheTavern.Mainhall.GetGrade() < 3)
            {
                this.UpgraddeSummBar.Text = "Стоимость улутшения:" +
                    (Global.MainHallUpgradePrice[Global.cur_master.TheTavern.Mainhall.GetGrade()] -
                    Global.cur_master.TheTavern.Mainhall.CountTables() * Global.TableSellPrice[Global.cur_master.TheTavern.Mainhall.GetGrade() - 1] -
                    Global.cur_master.TheTavern.Mainhall.CountChairs() * Global.ChairSellPrice[Global.cur_master.TheTavern.Mainhall.GetGrade() - 1]).ToString();
            }
            else
            {
                this.UpgraddeSummBar.Text = "Максимальный уровень!";

            }
            this.GradeBar.Text = "Уровень главного зала: " + Global.cur_master.TheTavern.Mainhall.GetGrade().ToString();

        }

        private void ValueChanged(object sender, EventArgs e)
        {
            int summ=0;
            if ((Convert.ToInt32(this.numTables.Value) - Global.cur_master.TheTavern.Mainhall.CountTables()) >= 0 &&
                (Convert.ToInt32(this.numChairs.Value) - Global.cur_master.TheTavern.Mainhall.CountChairs()) >=0)
            {
                summ = (Convert.ToInt32(this.numTables.Value) - Global.cur_master.TheTavern.Mainhall.CountTables()) *
                    Global.TableBuyPrice[Global.cur_master.TheTavern.Mainhall.GetGrade() - 1] +
                    (Convert.ToInt32(this.numChairs.Value) - Global.cur_master.TheTavern.Mainhall.CountChairs()) *
                    Global.ChairBuyPrice[Global.cur_master.TheTavern.Mainhall.GetGrade() - 1];
            }
            else if (Convert.ToInt32(this.numTables.Value) - Global.cur_master.TheTavern.Mainhall.CountTables() <= 0 &&
                Convert.ToInt32(this.numChairs.Value) - Global.cur_master.TheTavern.Mainhall.CountChairs() <= 0)
            {
                summ = (Convert.ToInt32(this.numTables.Value) - Global.cur_master.TheTavern.Mainhall.CountTables()) *
                Global.TableSellPrice[Global.cur_master.TheTavern.Mainhall.GetGrade() - 1] +
                (Convert.ToInt32(this.numChairs.Value) - Global.cur_master.TheTavern.Mainhall.CountChairs()) *
                Global.ChairSellPrice[Global.cur_master.TheTavern.Mainhall.GetGrade() - 1];
            } else if (Convert.ToInt32(this.numTables.Value) - Global.cur_master.TheTavern.Mainhall.CountTables() >= 0 &&
                Convert.ToInt32(this.numChairs.Value) - Global.cur_master.TheTavern.Mainhall.CountChairs() <= 0)
            {
                summ = (Convert.ToInt32(this.numTables.Value) - Global.cur_master.TheTavern.Mainhall.CountTables()) *
                Global.TableBuyPrice[Global.cur_master.TheTavern.Mainhall.GetGrade() - 1] +
                (Convert.ToInt32(this.numChairs.Value) - Global.cur_master.TheTavern.Mainhall.CountChairs()) *
                Global.ChairSellPrice[Global.cur_master.TheTavern.Mainhall.GetGrade() - 1];

            } else if (Convert.ToInt32(this.numTables.Value) - Global.cur_master.TheTavern.Mainhall.CountTables() <= 0 &&
                Convert.ToInt32(this.numChairs.Value) - Global.cur_master.TheTavern.Mainhall.CountChairs() >= 0)
            {
                summ = (Convert.ToInt32(this.numTables.Value) - Global.cur_master.TheTavern.Mainhall.CountTables()) *
                Global.TableSellPrice[Global.cur_master.TheTavern.Mainhall.GetGrade() - 1] +
                (Convert.ToInt32(this.numChairs.Value) - Global.cur_master.TheTavern.Mainhall.CountChairs()) *
                Global.ChairBuyPrice[Global.cur_master.TheTavern.Mainhall.GetGrade() - 1];
            }
            updateCost = summ;
            this.txtSumm.Text = ("Стоимость улутшения: " + summ.ToString());
            this.txtSumm.Show();
            
        }

        private void UpdateGoldBar(object sender, EventArgs e)
        {
            this.GoldBar.Text = Convert.ToString(Global.cur_master.Get_Fund());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!(Global.cur_master.TheTavern.Mainhall.CountChairs() == Convert.ToInt32(this.numChairs.Value) &&
                Global.cur_master.TheTavern.Mainhall.CountTables() == Convert.ToInt32(this.numTables.Value)))
            {
                if (Global.cur_master.WithDrawMoney(updateCost))
                {
                    Global.cur_master.TheTavern.Mainhall.SetChairs(Convert.ToInt32(this.numChairs.Value));
                    Global.cur_master.TheTavern.Mainhall.SetTables(Convert.ToInt32(this.numTables.Value));
                    MessageBox.Show("Закупка произведена!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.txtSumm.Hide();
                    UpdateWindow();
                }
                else
                {
                    MessageBox.Show("Не хватает средств!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnUpgrade_Click(object sender, EventArgs e)
        {
            
            if (Global.cur_master.TheTavern.Mainhall.GetGrade() < 3)
            {
                UpgradeCost = Global.MainHallUpgradePrice[Global.cur_master.TheTavern.Mainhall.GetGrade()] -
                Global.cur_master.TheTavern.Mainhall.CountChairs() * Global.ChairSellPrice[Global.cur_master.TheTavern.Mainhall.GetGrade() - 1] -
                Global.cur_master.TheTavern.Mainhall.CountTables() * Global.TableSellPrice[Global.cur_master.TheTavern.Mainhall.GetGrade() - 1];
                if (Global.cur_master.WithDrawMoney(UpgradeCost))
                {
                    Global.cur_master.TheTavern.Mainhall.Upgrade();
                    this.UpdateWindow();
                }
                else
                {
                    MessageBox.Show("Не хавтает золота!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
            else
            {
                MessageBox.Show("Максимальный уровень!!!","Ошибка",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void MainHallWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            Global.SaveGame();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
