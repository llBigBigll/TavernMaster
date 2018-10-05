using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TavernMaster
{
    [Serializable]
    public class Room
    {
        //int Name;
        int Grade;//(1-3)
        String GuestName;
        bool IsTaken;
        int Rental;
        int Income;
        int TimeOfRent;
        bool IsActive;
        public Room()
        {
            Grade = 1;
            GuestName = null;
            IsTaken = false;
            IsActive = true;
            Income = Convert.ToInt32(IsTaken) * Rental - Global.RoomsUpkeep[this.Grade - 1] * Convert.ToInt32(IsActive);
        }
        public void PassOneTurn()
        {
            if (this.TimeOfRent >=1)
            {
                this.TimeOfRent -= 1;
                Global.cur_master.Add_Cash(this.Income);
                if (this.TimeOfRent == 0)
                {
                    this.GuestName = null;
                    this.IsTaken = false;
                }
            }
        }
        public Room(int grade)
        {
            Grade = grade;
            GuestName = null;
            IsTaken = false;
            IsActive = true;
            Income = Convert.ToInt32(IsTaken)* Rental - Global.RoomsUpkeep[this.Grade-1]*Convert.ToInt32(IsActive);
        }
        public void Rent(string renter, int rentime)
        {
            
            this.TimeOfRent = rentime;
            this.IsTaken = true;
            this.GuestName = renter;
        }
        public void Upgrade()
        {
            if (this.Grade < 3)
            {
                if (Global.cur_master.WithDrawMoney(Global.RoomsUpgradeCost[this.Grade]))
                {
                    this.Grade += 1;
                    Income = Convert.ToInt32(IsTaken) * Rental - Global.RoomsUpkeep[this.Grade - 1] * Convert.ToInt32(IsActive);
                    
                }
                else
                {
                    MessageBox.Show("Не достаточно средств", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                
            }
            else
            {
                MessageBox.Show("Комната- максимального уровня", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }
        public string GetGuestName()
        {
            return this.GuestName;
        }
        public int GetIncome()
        {
            if (this.IsActive)
            {
                return this.Income;
            }
            else
            {
                return 0;
            }
        }
        public int GetTimeOfRent()
        {
            return this.TimeOfRent;
        }
        public int GetGrade()
        {
            return this.Grade;
        }
        public void SetRental(int rental)
        {
            this.Rental = rental;
        }
        public void ChangeStatus()
        {
            if (this.IsActive)
            {
                
                this.IsActive = false;
            }
            else
            {   
                this.IsActive = true;
            }
        }
        public bool GetStatus()
        {
            return this.IsActive;
        }

        
    }
}
