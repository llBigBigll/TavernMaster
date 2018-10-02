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
            creating.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCreatePeople_Click(object sender, EventArgs e)
        {
            this.Hide();
            fCreateNewOne createppl = new fCreateNewOne();
            createppl.Show();
            createppl.FormClosing += ShowWhenChildClosed;
        }

        private void btnShowPop_Click(object sender, EventArgs e)
        {
            ShowingPopulation showpop = new ShowingPopulation();
            this.Hide();
            showpop.Show();
            showpop.FormClosing += ShowWhenChildClosed;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            TheGame game = new TheGame();
            game.Show();
            this.Hide();
            game.FormClosing += ShowWhenChildClosed;
        }

        private void ShowWhenChildClosed(object sender, FormClosingEventArgs e)
        {
            this.Show();
        }



        private void button3_Click(object sender, EventArgs e)
        {
            ShowRules rules = new ShowRules();
            this.Hide();
            rules.Show();
            rules.FormClosing += ShowWhenChildClosed;
        }

        private void BtnChangeMaster_Click(object sender, EventArgs e)
        {
            this.Hide();
            ChangeAcc acc = new ChangeAcc();
            acc.Show();
            acc.FormClosing += ShowWhenChildClosed;
        }
    }
}
