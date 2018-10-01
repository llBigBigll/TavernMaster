using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TavernMasterr
{
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

        
        public static List<Human> Population = new List<Human>();
        public static List<Tavern_master> Masters= new List<Tavern_master>();
        public static bool is_there_tavern = false;
        public static Tavern_master cur_master = new Tavern_master();
        public static string cur_player_name = "";
        public static string file_players_list = @"\" + "players.dat";
        public static string file_of_names = @"\" + "names.dat";
        public static string file_of_population = @"\" + cur_player_name + "pulation.dat";
        public static string file_of_counter = @"\" + cur_player_name + "counter.dat";

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


    }
}
