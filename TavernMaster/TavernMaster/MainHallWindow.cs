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
            this.txtSumm.Text = ("Стоимость улутшения: " + summ.ToString());
            this.txtSumm.Show();
        }
    }
}
