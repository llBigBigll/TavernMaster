using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TavernMaster
{
    [Serializable]
    public class Tavern
    {
        public List<Room> Rooms = new List<Room>();
        public MainHall Mainhall;
        string Name;
        Size TheSize;

        public Tavern(string name)
        {
            this.Name = name;
        }

        public string GetName()
        {
            return this.Name;
        }

        public void  SetName(string name)
        {
            this.Name = name;
        }
        public Tavern()
        {
            for (int i = 0; i < 3; i++)
            {
                Rooms.Add(new Room());
            }
            Name = null;
            TheSize = Size.Small;
            Mainhall = new MainHall(TheSize, 1);
        }
    }
}
