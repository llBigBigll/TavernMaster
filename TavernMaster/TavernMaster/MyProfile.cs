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
    public partial class MyProfile : Form
    {
        private int freepts = 0;
        private int addedAlchemy = 0;
        private int addedBlacksmith = 0;
        private int addedArchery = 0;
        private int addedFarm = 0;
        private int addedTrade = 0;
        private int addedSwordMastery = 0;

        public MyProfile()
        {   
            InitializeComponent();
            this.lvlBar.Text = "Уровень: " + Global.cur_master.GetLvl().ToString();
            this.skillPts.Text = "Не распределенные очки умения: " + Global.cur_master.GetSkillsPts().ToString();
            freepts = Global.cur_master.GetSkillsPts();
            this.goldBar.Text = "Золото: " + Global.cur_master.Get_Fund().ToString();
            this.expBar.Text = "Опыт: " + Global.cur_master.GetExp().ToString() + @"\" + Global.cur_master.GetExpForUp().ToString();
            this.lblAlchemy.Text = Global.cur_master.GetAlchemyLvl().ToString();
            this.lblBlacksmith.Text = Global.cur_master.GetBlacksmithLvl().ToString();
            this.lblArchery.Text = Global.cur_master.GetArcheryLvl().ToString();
            this.lblFarm.Text = Global.cur_master.GetFarmLvl().ToString();
            this.lblTrade.Text = Global.cur_master.GetTradeLvl().ToString();
            this.lblSwordMastery.Text = Global.cur_master.GetSwordMasteryLvl().ToString();
        }
        private void UpdateForm()
        {
            this.lvlBar.Text = "Уровень: " + Global.cur_master.GetLvl().ToString();
            this.skillPts.Text = "Не распределенные очки умения: " + Global.cur_master.GetSkillsPts().ToString();
            this.goldBar.Text = "Золото: " + Global.cur_master.Get_Fund().ToString();
            this.expBar.Text = "Опыт: " + Global.cur_master.GetExp().ToString() + @"\" + Global.cur_master.GetExpForUp().ToString();
            freepts = Global.cur_master.GetSkillsPts();
            this.lblAlchemy.Text = Global.cur_master.GetAlchemyLvl().ToString();
            this.lblBlacksmith.Text = Global.cur_master.GetBlacksmithLvl().ToString();
            this.lblArchery.Text = Global.cur_master.GetArcheryLvl().ToString();
            this.lblFarm.Text = Global.cur_master.GetFarmLvl().ToString();
            this.lblTrade.Text = Global.cur_master.GetTradeLvl().ToString();
            this.lblSwordMastery.Text = Global.cur_master.GetSwordMasteryLvl().ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MyProfile_FormClosing(object sender, FormClosingEventArgs e)
        {
            Global.SaveGame();
        }

        private void lblPlussBlacksmith_Click(object sender, EventArgs e)
        {
            if (freepts > 0) {
                int curlvl = Convert.ToInt32(this.lblBlacksmith.Text);
                this.lblBlacksmith.Text = (curlvl + 1).ToString();
                freepts -= 1;
                this.skillPts.Text = "Не распределенные очки умения: " + freepts.ToString();
            }
        }

        private void lblPlussAlchemy_Click(object sender, EventArgs e)
        {
            if (freepts > 0)
            {
                int curlvl = Convert.ToInt32(this.lblAlchemy.Text);
                this.lblAlchemy.Text = (curlvl + 1).ToString();
                freepts -= 1;
                this.skillPts.Text = "Не распределенные очки умения: " + freepts.ToString();
            }
        }

        private void lblPlussSwordMastery_Click(object sender, EventArgs e)
        {
            if (freepts > 0)
            {
                int curlvl = Convert.ToInt32(this.lblSwordMastery.Text);
                this.lblSwordMastery.Text = (curlvl + 1).ToString();
                freepts -= 1;
                this.skillPts.Text = "Не распределенные очки умения: " + freepts.ToString();
            }
        }

        private void lblPlussArchery_Click(object sender, EventArgs e)
        {
            if (freepts > 0)
            {
                int curlvl = Convert.ToInt32(this.lblArchery.Text);
                this.lblArchery.Text = (curlvl + 1).ToString();
                freepts -= 1;
                this.skillPts.Text = "Не распределенные очки умения: " + freepts.ToString();
            }
        }

        private void lblPlussFarm_Click(object sender, EventArgs e)
        {
            if (freepts > 0)
            {
                int curlvl = Convert.ToInt32(this.lblFarm.Text);
                this.lblFarm.Text = (curlvl + 1).ToString();
                freepts -= 1;
                this.skillPts.Text = "Не распределенные очки умения: " + freepts.ToString();
            }
        }

        private void lblPlussTrade_Click(object sender, EventArgs e)
        {
            if (freepts > 0)
            {
                int curlvl = Convert.ToInt32(this.lblTrade.Text);
                this.lblTrade.Text = (curlvl + 1).ToString();
                freepts -= 1;
                this.skillPts.Text = "Не распределенные очки умения: " + freepts.ToString();
            }
        }

        private void btnExept_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(this.lblAlchemy.Text) != Global.cur_master.GetAlchemyLvl())
            {
                Global.cur_master.SpendSkillPts(Skills.Alchemy, Convert.ToInt32(this.lblAlchemy.Text) - Global.cur_master.GetAlchemyLvl());
            }
            if (Convert.ToInt32(this.lblBlacksmith.Text) != Global.cur_master.GetBlacksmithLvl())
            {
                Global.cur_master.SpendSkillPts(Skills.Blacksmith, Convert.ToInt32(this.lblBlacksmith.Text) - Global.cur_master.GetBlacksmithLvl());
            }
            if (Convert.ToInt32(this.lblArchery.Text) != Global.cur_master.GetArcheryLvl())
            {
                Global.cur_master.SpendSkillPts(Skills.Archery, Convert.ToInt32(this.lblArchery.Text) - Global.cur_master.GetArcheryLvl());
            }
            if (Convert.ToInt32(this.lblTrade.Text) != Global.cur_master.GetTradeLvl())
            {
                Global.cur_master.SpendSkillPts(Skills.Trade, Convert.ToInt32(this.lblTrade.Text) - Global.cur_master.GetTradeLvl());
            }
            if (Convert.ToInt32(this.lblFarm.Text) != Global.cur_master.GetFarmLvl())
            {
                Global.cur_master.SpendSkillPts(Skills.Farm, Convert.ToInt32(this.lblFarm.Text) - Global.cur_master.GetFarmLvl());
            }
            if (Convert.ToInt32(this.lblSwordMastery.Text) != Global.cur_master.GetSwordMasteryLvl())
            {
                Global.cur_master.SpendSkillPts(Skills.SwordMastery, Convert.ToInt32(this.lblSwordMastery.Text) - Global.cur_master.GetSwordMasteryLvl());
            }

        }

        private void btnCencel_Click(object sender, EventArgs e)
        {
            this.lblAlchemy.Text = Global.cur_master.GetAlchemyLvl().ToString();
            this.lblBlacksmith.Text = Global.cur_master.GetBlacksmithLvl().ToString();
            this.lblArchery.Text = Global.cur_master.GetArcheryLvl().ToString();
            this.lblFarm.Text = Global.cur_master.GetFarmLvl().ToString();
            this.lblTrade.Text = Global.cur_master.GetTradeLvl().ToString();
            this.lblSwordMastery.Text = Global.cur_master.GetSwordMasteryLvl().ToString();
        }
    }
}
