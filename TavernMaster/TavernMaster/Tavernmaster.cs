using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TavernMaster
{
    

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

        int Fund;
        int Level;
        string Name;
        public Tavern TheTavern;
        MasterCraft craft;
        double Cur_exp;

        public Tavern_master()
        {
            this.Fund = 56;
            this.Level = 0;
            this.Name = null;
            this.TheTavern = new Tavern();
            this.Cur_exp = 0;
        }
        public Tavern_master(string name)
        {
            this.Name = name;
        }
        

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

        public int GetLvl()
        {
            return this.Level;
        }

        public string Get_TavernName()
        {
            return this.TheTavern.GetName();
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
            this.TheTavern.SetName(tavernname);
        }

        public void Give_exp(int exp_earned)
        {
            this.Cur_exp += exp_earned;
            Appdate_lvl();
        }
        


        public int Get_Fund()
        {
            return this.Fund;
        }
        public void Add_Cash( int summ)
        {
            this.Fund += summ;
        }

        /// <summary>
        /// Get money from Fund 
        /// </summary>
        /// <param summofmoney="summ"></param>
        /// <returns>
        /// alter money if there are such summ and return true 
        /// or return false
        /// </returns>
        public bool WithDrawMoney(int summ)
        {
            if (this.Fund >= summ)
            {
                this.Fund -= summ;
                return true;
            }
            else
            {
                return false;
            }
        }

        bool IsEqual(Tavern_master human) { return String.Equals(Name, human.Name); }
        public override bool Equals(object obj)
        {
            if (Object.ReferenceEquals(null, obj)) { return false; }
            if (Object.ReferenceEquals(this, obj)) { return true; }
            if (obj.GetType() != this.GetType()) { return false; }
            return IsEqual((Tavern_master)obj);
        }
        public bool Equals(Tavern_master human)
        {
            if (Object.ReferenceEquals(null, human)) { return false; }
            if (Object.ReferenceEquals(this, human)) { return true; }

            return IsEqual(human);
        }
        public static bool operator !=(Tavern_master a, Tavern_master b)
        {
            return a.Name != b.Name;
        }
        public static bool operator ==(Tavern_master a, Tavern_master b)
        {
            return a.Name == b.Name;
        }
    }
}
