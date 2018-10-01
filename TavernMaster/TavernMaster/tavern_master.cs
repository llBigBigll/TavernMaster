using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TavernMasterr
{
    public enum MasterCraft {Blacksmith, Alchemy, Warior, Archer,Farm, Merchant, None }

    [Serializable]
    public class Tavern_master
    {

        /*
         *Опыт требуемый для получения уровня
         * 0-0
         * 1-1000
         * 2-1200(2200)
         * 3-(опыт необходимый для уровня 2)*1.2
         * ...
         * ...
         * 10-5160
         * 11-5572((lvl10)*1.08
         * ...
         * ...
         * ...
         */
        int Level;
        string Name;
        string TavernName;
        MasterCraft craft;
        double Cur_exp;

        private void Appdate_lvl()
        {
            double exp_needed = 1000*Math.Pow(1.2,this.Level-1);
            while(this.Cur_exp >= exp_needed)
            {
                this.Level += 1;
                this.Cur_exp -= exp_needed;
                exp_needed = 1000 * Math.Pow(1.2, this.Level - 1);
            }
        }
        public void Set_craft(MasterCraft masterCraft)
        {
            this.craft = masterCraft;
        }
        public void Set_craft(string mastercraft)
        {
            this.craft = MasterCraft.None;
            if (mastercraft == "Blacksmith") { this.craft = MasterCraft.Blacksmith; }
            if (mastercraft == "Alchemy") { this.craft = MasterCraft.Alchemy; }
            if (mastercraft == "Warior") { this.craft = MasterCraft.Warior; }
            if (mastercraft == "Archer") { this.craft = MasterCraft.Archer; }
            if (mastercraft == "Farm") { this.craft = MasterCraft.Farm; }
            if (mastercraft == "Merchant") { this.craft = MasterCraft.Merchant; }
            
        }
        public string Get_TavernName()
        {
            return this.TavernName;
        }
        public string Get_Name()
        {
            return this.Name;
        }
        public void Set_Name(string name)
        {
            this.Name = name;
        }
        public void Set_TavernName(string tavernname)
        {
            this.TavernName = tavernname;
        }
        public void Give_exp(int exp_earned)
        {
            this.Cur_exp += exp_earned;
            Appdate_lvl();
        }
        public Tavern_master()
        {
            this.Level = 0;
            this.Name = null;
            this.TavernName = null;
            this.Cur_exp = 0;
        }

    }
}
