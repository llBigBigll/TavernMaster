using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public bool Upgrade()
        {
            if (this.Grade < 3)
            {
                
                this.Grade += 1;
                Income = Convert.ToInt32(IsTaken) * Rental - Global.RoomsUpkeep[this.Grade - 1] * Convert.ToInt32(IsActive);
                return true;
            }
            else
            {
                return false;
            }
            
        }
        public string GetGuestName()
        {
            return this.GuestName;
        }
        public int GetIncome()
        {
            return this.Income;
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

        
    }
}
