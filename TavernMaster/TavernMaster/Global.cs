using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TavernMaster
{

    public enum Size {Small, Medium, Large }
    public enum MasterCraft { Blacksmith, Alchemy, Warior, Archer, Farm, Merchant, None }
    public enum Gender { Male, Female }
    public enum HairColor { Brown, Blond, Red, Black, Purple, Green, Pink }
    public static class Global

    {
        public static string Rules = "Правила:\n" +
            "Каждый игрок обязан любить разработчика!\n" +
            "Инцест запрещен\n" +
            "...." +
            "";
        public static int[] RoomsUpgradeCost = {0,20,65 };
        public static int[] RoomsUpkeep = {0,4,8};

        public static int[] ChairBuyPrice = { 1, 2, 5 };
        public static int[] ChairSellPrice = { 0, 1, 2 };
        public static int[] TableBuyPrice = { 5, 11, 20 };
        public static int[] TableSellPrice = { 2, 4, 9 };
        public static int[] MainHallUpgradePrice = { 100, 4000, 20000 };
        public static int[] MainHallSellPrice = { 0, 1000, 11000 };

        public static List<Human> Population = new List<Human>();
        public static List<Tavern_master> Masters = new List<Tavern_master>();
        public static bool is_there_tavern = false;
        public static Tavern_master cur_master;
        public static string cur_player_name = "";
        public static string file_players_list = @"\" + "players.dat";
        public static string file_of_names = @"\" + "names.dat";
        public static string file_of_population = @"\" + cur_player_name + "pulation.dat";
        public static string file_of_counter = @"\" + cur_player_name + "counter.dat";

        public static void ComingSoon()
        {
            MessageBox.Show("Мы уже работаем над этим!!!!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void AddMaster(Tavern_master master)
        {
            
            Masters.Add(master);
        }

        public static void Appdate_data()
        {
            
            cur_player_name = cur_master.Get_Name();
            file_of_population = @"\" + cur_player_name + "pulation.dat";
            file_of_counter = @"\" + cur_player_name + "counter.dat";
        }
        public static void Appdate_cur_master(Tavern_master master)
        {
            cur_master = master;
            cur_player_name = cur_master.Get_Name();
            file_of_population = @"\" + cur_player_name + "pulation.dat";
            file_of_counter = @"\" + cur_player_name + "counter.dat";
        }
        public static void SaveGame()
        {
            Tuple<Tavern_master, List<Tavern_master>> tuple = new Tuple<Tavern_master, List<Tavern_master>>(cur_master,Masters);
            Program.Write_masters(tuple, file_players_list);
        }

    }
}
