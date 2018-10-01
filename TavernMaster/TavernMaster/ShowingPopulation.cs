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
    public partial class ShowingPopulation : Form
    {

        public void Show_ppl_in_text_box(RichTextBox txtbox, List<Human> population) {
            foreach (Human el in population) {
                txtbox.Text += el.Get_human();
            }
        }
        public List<Human> population = new List<Human>();
        public ShowingPopulation()
        {
            
            InitializeComponent();
            Show_ppl_in_text_box(txtBoxPPL, Global.Population);
        }
    }

}
