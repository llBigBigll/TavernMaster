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
    public partial class SecondFloor : Form
    {
        public SecondFloor()
        {
            InitializeComponent();
            foreach (Room room in Global.cur_master.TheTavern.Rooms)
            {
                if (room.GetGuestName() != null)
                {
                    this.listOfRenters.Items.Add("Постоялец: " + room.GetGuestName() + "Уровень: " +
                        room.GetGrade().ToString() + "Доход: " + room.GetIncome().ToString());
                }
                else
                {
                    this.listOfRenters.Items.Add("Постояльца нет " + room.GetGuestName() + "Уровень: " +
                        room.GetGrade().ToString() + "Доход: " + room.GetIncome().ToString());
                }
            }
        }
    }
}
