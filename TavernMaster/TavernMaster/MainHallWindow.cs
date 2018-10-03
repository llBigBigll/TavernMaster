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
        static int updateCost;
        public MainHallWindow()
        {
            InitializeComponent();
            this.numTables.Value = Global.cur_master.TheTavern.Mainhall.CountTables();
            this.numChairs.Value = Global.cur_master.TheTavern.Mainhall.CountChairs();
            this.MaxChairs.Text = Global.cur_master.TheTavern.Mainhall.GetChairsCapacity().ToString();
            this.MaxTable.Text = Global.cur_master.TheTavern.Mainhall.GetTableCapacity().ToString();
            this.numTables.Maximum = Global.cur_master.TheTavern.Mainhall.GetTableCapacity();
            this.numChairs.Maximum = Global.cur_master.TheTavern.Mainhall.GetChairsCapacity();
            this.txtSumm.Hide();
            
        }

        private void ValueChanged(object sender, EventArgs e)
        {
            int summ = (Convert.ToInt32(this.numTables.Value) - Global.cur_master.TheTavern.Mainhall.CountTables()) * 
                Global.TableBuyPrice[Global.cur_master.TheTavern.Mainhall.GetGrade()-1] +
                (Convert.ToInt32(this.numChairs.Value) - Global.cur_master.TheTavern.Mainhall.CountChairs()) *
                Global.ChairBuyPrice[Global.cur_master.TheTavern.Mainhall.GetGrade() - 1];
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
            if (Global.cur_master.WithDrawMoney(updateCost))
            {
                Global.cur_master.TheTavern.Mainhall.AddChairs(Convert.ToInt32(this.numChairs.Value));
                Global.cur_master.TheTavern.Mainhall.AddTables(Convert.ToInt32(this.numTables.Value));
                MessageBox.Show("Закупка произведена!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Не хватает средств!","Сообщение",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void MainHallWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            Global.SaveGame();

        }
    }
}
