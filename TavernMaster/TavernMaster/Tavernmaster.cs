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
        MasterCraft Craft;
        int Cur_exp;
        int SkillPts;

        int Trade;//(0-10)
        int Farm;//(0-10)
        int Alchemy;//(0-10)
        int Blacksmith;//(0-10)
        int Archery;//(0-10)
        int SwordMastery;//(0-10)


        public Tavern_master()
        {
            this.Fund = 56;
            this.Level = 0;
            this.Name = null;
            this.TheTavern = new Tavern();
            this.Cur_exp = 0;
            this.Trade = 0;
            this.Farm = 0;
            this.Alchemy = 0;
            this.Blacksmith = 0;
            this.Archery = 0;
            this.SwordMastery = 0;
            this.SkillPts = 0;
        }

        public Tavern_master(string name)
        {
            this.Name = name;
        }
        
        private void Appdate_lvl()
        {
            int exp_needed = Convert.ToInt32(1000*Math.Pow(1.2,this.Level));
            while(this.Cur_exp >= exp_needed)
            {
                this.Level += 1;
                this.Cur_exp -= exp_needed;
                exp_needed = Convert.ToInt32(1000 * Math.Pow(1.2, this.Level));
            }
        }

        public int GetExpForUp()
        {
            return Convert.ToInt32(1000 * Math.Pow(1.2, this.Level));
        }

        public int GetTradeLvl()
        {
            return this.Trade;
        }
        public int GetFarmLvl()
        {
            return this.Farm;
        }
        public int GetAlchemyLvl()
        {
            return this.Alchemy;
        }
        public int GetBlacksmithLvl()
        {
            return this.Blacksmith;
        }
        public int GetArcheryLvl()
        {
            return this.Archery;
        }
        public int GetSwordMasteryLvl()
        {
            return this.SwordMastery;
        }

        public void SetTradeLvl(int a)
        {
            this.Trade = a;
        }
        public void SetFarmLvl(int a)
        {
            this.Farm = a;
        }
        public void SetAlchemyLvl(int a)
        {
            this.Alchemy = a;
        }
        public void SetBlacksmithLvl(int a)
        {
            this.Blacksmith = a;
        }
        public void SetArcheryLvl(int a)
        {
            this.Archery = a;
        }
        public void SetSwordMasteryLvl(int a)
        {
            this.Trade = a;
        }

        public int GetExp()
        {
            return this.Cur_exp;
        }

        public void Set_craft(MasterCraft masterCraft)
        {
            if (masterCraft == MasterCraft.Blacksmith)
            {
                this.Blacksmith = 2;
                this.SwordMastery = 1;
                this.Archery = 1;
                
            }
            else if (masterCraft == MasterCraft.Alchemy)
            {
                this.Alchemy = 3;
                this.Farm = 1;
            }
            else if (masterCraft == MasterCraft.Warior)
            {
                this.SwordMastery = 2;
                this.Archery = 1;
                this.Blacksmith = 1;
            }
            else if (masterCraft == MasterCraft.Archer)
            {
                this.Archery = 2;
                this.Alchemy = 1;
                this.Blacksmith = 1;
            }
            else if (masterCraft == MasterCraft.Farm)
            {
                this.Farm = 4;
            }
            else if (masterCraft == MasterCraft.Merchant)
            {
                this.Trade = 2;
                this.Farm = 2;
            }
            this.Craft = masterCraft;

        }

        public void Set_craft(string mastercraft)
        {
            this.Craft = MasterCraft.None;
            if (mastercraft == "Blacksmith")
            {
                this.Blacksmith = 2;
                this.SwordMastery = 1;
                this.Archery = 1;
                this.Craft = MasterCraft.Blacksmith;
            }
            else if (mastercraft == "Alchemy")
            {
                this.Alchemy = 3;
                this.Farm = 1;
                this.Craft = MasterCraft.Alchemy;
            }
            else if (mastercraft == "Warior")
            {
                this.SwordMastery = 2;
                this.Archery = 1;
                this.Blacksmith = 1;
                this.Craft = MasterCraft.Warior;
            }
            else if (mastercraft == "Archer")
            {
                this.Archery = 2;
                this.Alchemy = 1;
                this.Blacksmith = 1;
                this.Craft = MasterCraft.Archer;
            }
            else if (mastercraft == "Farm")
            {
                this.Farm = 4;
                this.Craft = MasterCraft.Farm;
            }
            else if (mastercraft == "Merchant")
            {
                this.Trade = 2;
                this.Farm = 2;
                this.Craft = MasterCraft.Merchant;
            }
            
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

        public int GetSkillsPts()
        {
            return this.SkillPts;
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

        public void SpendSkillPts(Skills skill, int count)
        {
            if (skill == Skills.Archery)
            {
                this.Archery += count;
            }
            if (skill == Skills.Blacksmith)
            {
                this.Blacksmith += count;
            }
            if (skill == Skills.Alchemy)
            {
                this.Alchemy += count;
            }
            if (skill == Skills.Farm)
            {
                this.Farm += count;
            }
            if (skill == Skills.SwordMastery)
            {
                this.SwordMastery += count;
            }
            if (skill == Skills.Trade)
            {
                this.Trade += count;
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
