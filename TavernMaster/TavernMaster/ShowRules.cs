using System;
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
    public partial class ShowRules : Form
    {
        public ShowRules()
        {
            InitializeComponent();
            this.textboxRules.Text = Global.Rules;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
