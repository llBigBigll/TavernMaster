﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TavernMasterr
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
    }
}
