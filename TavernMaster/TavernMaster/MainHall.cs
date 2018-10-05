using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TavernMaster
{
    [Serializable]
    public class MainHall
    {
        /*Вместимость :
         * ур1 - 5 стол 20 стул
         * ур2 - 15 стол 30 стул
         * ур3 - 40  стол 160 стул
         * Стоимость стула покупа/прожа:
         *ур1 -1/0
         *ур2 - 2/1 
         *ур3 - 5/2
         *Стоимость стола покупа/прожа:
         *ур1 - 5/2
         *ур2 - 11/4 
         *ур3 - 20/9
         *Стоимость чучела покупа/прожа(целое)/продажа(битое):
         *ур1 - 10/4/0 (соломяное)
         *ур2 - 25/10/5 (деревянное)
         *ур3 - 65/25/10 (в доспехах)
         * 
         */

        int CapacityTable;
        int CapasityChair;
        Size TheSize;
        int NumTable;
        int NumChair;
        
        int Grade;//(1-3)
        
        public MainHall( Size sz, int grade )
        {
            if (sz == Size.Small)
            {
                this.TheSize = sz;
                this.CapacityTable = 5;
                this.CapasityChair = 20;
                //this.Cost = 0;

            }else if (sz == Size.Medium)
            {
                this.TheSize = sz;
                this.CapacityTable = 15;
                this.CapasityChair = 60;
                //this.Cost = 1000;

            }else if (sz == Size.Large)
            {
                this.TheSize = sz;
                this.CapacityTable = 40;
                this.CapasityChair = 160;
                //this.Cost = 11000;
            }
            this.Grade = grade;
            NumChair = 0;
            NumTable = 0;
        }

        public int GetGrade()

        {
            return this.Grade;

        }

        public int GetChairsCapacity()
        {
            return this.CapasityChair;
        }

        public int GetTableCapacity()
        {
            return this.CapacityTable;
        }

        public int CountChairs()
        {
            return this.NumChair;
        }

        public int CountTables()
        {
            return this.NumTable;
        }

        public int GetUpdateCost()
        {
            return this.NumChair * (Global.ChairBuyPrice[Grade - 1] - Global.ChairSellPrice[Grade - 1]) +
                this.NumTable * (Global.TableBuyPrice[Grade - 1] - Global.TableSellPrice[Grade - 1])+ Global.MainHallUpgradePrice[(int)TheSize];
        }

        public int GetCost()
        {
          
            return this.NumTable*Global.TableSellPrice[Grade-1]+this.NumChair*Global.ChairSellPrice[Grade-1]+
                Global.MainHallSellPrice[(int)TheSize] ;

        }

        public void Upgrade()
        {
            if (this.Grade < 3)
            {
                this.Grade += 1;
                this.NumChair = 0;
                this.NumTable = 0;
            }
            else
            {
                MessageBox.Show("Главный зал уже максимального уровня!","Ошибка",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        public void SetTables(int num)
        {   
            this.NumTable = num;
        }

        public void SetChairs(int num)
        {
            this.NumChair = num;
        }

        public int FreeChairsCount()
        {
            return this.NumChair - (this.NumTable * 4);
        }


    }
}
