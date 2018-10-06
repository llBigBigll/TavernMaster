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
    public partial class TheGame : Form
    {
        public TheGame()
        {
            
            InitializeComponent();
            this.txtNameOfTavern.Text = Global.cur_master.Get_TavernName();
        }

        private void btnToMainMenu_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnMainHall_Click(object sender, EventArgs e)
        {
            MainHallWindow mainhall= new MainHallWindow();
            mainhall.ShowDialog();
            
        }

        private void UpdateForm(object sender, EventArgs e)
        {
            this.GoldBar.Text = Convert.ToString(Global.cur_master.Get_Fund());
            this.GoldBar.Location = new Point(this.btnProfile.Location.X - 46*(this.GoldBar.Text.Length) ,this.btnProfile.Location.Y);
            this.txtGold.Location = new Point(this.GoldBar.Location.X -155, this.btnProfile.Location.Y);
        }

        private void btnSecondFloor_Click(object sender, EventArgs e)
        {
            SecondFloor secondfloor = new SecondFloor();
            secondfloor.ShowDialog();
            
        }

        private void EndDay_Click(object sender, EventArgs e)
        {

        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            MyProfile profile = new MyProfile();
            profile.ShowDialog();
        }
    }
}
