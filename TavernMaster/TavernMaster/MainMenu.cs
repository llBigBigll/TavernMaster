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
    public partial class MainWindow : Form
    {   
        public List<Human> population;
        

        public MainWindow()
        {
            
            InitializeComponent();

        }
        public MainWindow(bool is_new_game)
        {
            InitializeComponent();
            Creating_tavern_master creating = new Creating_tavern_master(is_new_game);
            creating.ShowDialog();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCreatePeople_Click(object sender, EventArgs e)
        {
            fCreateNewOne createWindow = new fCreateNewOne();
            createWindow.ShowDialog();
        }

        private void btnShowPop_Click(object sender, EventArgs e)
        {
            ShowingPopulation createWindow = new ShowingPopulation();
            createWindow.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TheGame game = new TheGame();
            game.ShowDialog();
            

        }

        private void button3_Click(object sender, EventArgs e)
        {
            ShowRules rules = new ShowRules();
            
            rules.ShowDialog();
        }

        private void BtnChangeMaster_Click(object sender, EventArgs e)
        {
            ChangeAcc acc = new ChangeAcc();
            acc.Show();
        }
    }
}
