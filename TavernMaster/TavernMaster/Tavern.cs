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
            Name = null;
            TheSize = Size.Small;
            Mainhall = new MainHall(TheSize, 1);
        }
    }
}
