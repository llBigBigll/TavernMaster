using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TavernMaster
{
    public partial class Creating_tavern_master : Form
    {
        private bool Is_new_game = false;
        private Tavern_master master = new Tavern_master();
        public Creating_tavern_master()
        {
            InitializeComponent();
        }
        public Creating_tavern_master(bool is_new_game)
        {
            Is_new_game = is_new_game;


            #region Первое приветствие
            MessageBox.Show("Приветствую тебя странник","Приветствие",MessageBoxButtons.OK);
            MessageBox.Show("Зло мешает нам найти твою историю....", "Приветствие", MessageBoxButtons.OK);
            MessageBox.Show("Придется все вспоминать заново", "Приветствие", MessageBoxButtons.OK);
            MessageBox.Show("Кажется в прошлый раз как ты к нам заходил ты рассказывал про свою молодость...", "Приветствие", MessageBoxButtons.OK);
            MessageBox.Show("Да-да, что-то припоминаю...", "Приветствие", MessageBoxButtons.OK);
            DialogResult result =  MessageBox.Show("Кажется, ты рассказывал что был великим войном, не так ли?", "Приветствие", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                MessageBox.Show("Ах да! Точно!", "Приветствие", MessageBoxButtons.OK);
                DialogResult result1 =MessageBox.Show("Ты же тот самый лучник! Парень из Темного леса! ", "Приветствие", MessageBoxButtons.YesNo);
                if (result1 == DialogResult.Yes)
                {
                    MessageBox.Show("Не думаю что сейчас в нашем королевстве есть кто-то кто может посоревноватся с тобой в меткости", "Приветствие", MessageBoxButtons.OK);
                    MessageBox.Show("Ха! Я всегда говорил что у меня отличная память!", "Приветствие", MessageBoxButtons.OK);
                    MessageBox.Show("Помню первые годы после войны, про тебя шутили...", "Приветствие", MessageBoxButtons.OK);
                    MessageBox.Show("Мол, ты такой точный что смог выбить глаз скелету с растояния в 2 сотни шагов!", "Приветствие", MessageBoxButtons.OK);
                    MessageBox.Show("Понял, да? ГЛАЗ скелету ВЫБИТЬ!", "Приветствие", MessageBoxButtons.OK);
                    master.Set_craft("Archer");
                }
                else
                {
                    MessageBox.Show("Нет?! Как же так?! ", "Приветствие", MessageBoxButtons.OK);
                    MessageBox.Show("Погоди...", "Приветствие", MessageBoxButtons.OK);
                    MessageBox.Show("Ты же тот самый... Как тебя там...", "Приветствие", MessageBoxButtons.OK);
                    MessageBox.Show("Да чтоб меня! ТОЧНО Тяжелый Молот", "Приветствие", MessageBoxButtons.OK);
                    MessageBox.Show("Помню первые годы после войны, про тебя шутили...", "Приветствие", MessageBoxButtons.OK);
                    MessageBox.Show("Что ты пошел работать к магам из гильдии и делал там КОСТНУЮ МУКУ!", "Приветствие", MessageBoxButtons.OK);
                    master.Set_craft("Warior");


                }
                
            }
            else
            {
                MessageBox.Show("Нет?! Как же так?! ", "Приветствие", MessageBoxButtons.OK);
                MessageBox.Show("Погоди...", "Приветствие", MessageBoxButtons.OK);
                DialogResult result2 = MessageBox.Show("Стой! Не твоей ли работы меч король вручил своему сыну в честь победы над мертвыми?", "Приветствие", MessageBoxButtons.YesNo);
                if (result2 == DialogResult.Yes)
                {
                    MessageBox.Show("Ха! Я всегда говорил что у меня отличная память!", "Приветствие", MessageBoxButtons.OK);
                    MessageBox.Show("Помню раньше люди говорили что твои мечи это просто ОТВАЛ БАШКИ! ", "Приветствие", MessageBoxButtons.OK);
                    MessageBox.Show("Да мне бы меч твоей работы, я бы хоть сейчас пошел на поиски приключений", "Приветствие", MessageBoxButtons.OK);
                    master.Set_craft("Blacksmith");
                }
                else
                {
                    MessageBox.Show("Ужас! Я забываю истории своих клиентов! Я так всь бизнес расстеряю", "Приветствие", MessageBoxButtons.OK);
                    DialogResult result3 = MessageBox.Show("Слуууушай. А часом не ты ли давиче моей жене снадобье дал что молодость возвращает?", "Приветствие", MessageBoxButtons.YesNo);
                    if (result3 == DialogResult.Yes)
                    {
                        MessageBox.Show("Ты ведь понимешь что если эта штука не подействует я заставлю тебя год работать за воду и плесневелый хлеб?!", "Приветствие", MessageBoxButtons.OK);
                        MessageBox.Show("Ладно, ладно. Шучу я. Пусть балуется. Это я к чему у меня на складе завалялись пару отсыревших бочек меда....", "Приветствие", MessageBoxButtons.OK);
                        MessageBox.Show("Может ты бы нашел на них покупателя, а я бы тебе треть прибыли отдал!", "Приветствие", MessageBoxButtons.OK);
                        MessageBox.Show("Жалко что-то мне их просто выбрасывать... А так бы хоть часть денег бы отбил.", "Приветствие", MessageBoxButtons.OK);
                        master.Set_craft("Merchant");
                    }
                    else
                    {
                        MessageBox.Show("Нет? Ну и славно, я бы убил того гада! 3 ЗОЛОТЫХ ЗА 1 БУТЫЛОЧКУ", "Приветствие", MessageBoxButtons.OK);
                        DialogResult result4 = MessageBox.Show("Слушай а раз уж мы про снадобья заговорили, ты как вообще веришь в них?", "Приветствие", MessageBoxButtons.YesNo);
                        if (result4 == DialogResult.Yes)
                        {
                            MessageBox.Show("Слууушай а ты часом не алхимик?", "Приветствие", MessageBoxButtons.OK);
                            MessageBox.Show("По глазам вижу что алхимик! ", "Приветствие", MessageBoxButtons.OK);
                            MessageBox.Show("Как там философский камень поживает?", "Приветствие", MessageBoxButtons.OK);
                            MessageBox.Show("Ой не бери близко к сердцу!Я же не со зла", "Приветствие", MessageBoxButtons.OK);
                            MessageBox.Show("Слушай можешь такое зелье забахать чтобы у меня жена мне не отказывала?!", "Приветствие", MessageBoxButtons.OK);
                            MessageBox.Show("Денег у меня не много. Сам видишь не больше 2ух гостей в зале, и так уже 3 года", "Приветствие", MessageBoxButtons.OK);
                            MessageBox.Show("Но я могу предложить тебе бесплатную выпивку в течении года!", "Приветствие", MessageBoxButtons.OK);
                            master.Set_craft("Alchemy");
                        }
                        else
                        {
                            MessageBox.Show("Да-а-а-а-а-а", "Приветствие", MessageBoxButtons.OK);
                            MessageBox.Show("Ну давай последняя попытка угадать?", "Приветствие", MessageBoxButtons.OK);
                            MessageBox.Show("Ты же фермер из соседней деревушки да?!", "Приветствие", MessageBoxButtons.OK);
                            MessageBox.Show("ХА! Видишь не совсем я еще из ума вижил!", "Приветствие", MessageBoxButtons.OK);
                            MessageBox.Show("Вас фермеров после войны как грязи!", "Приветствие", MessageBoxButtons.OK);
                            MessageBox.Show("Я конечно понимаю что королю нужна была пшеница после того как половина наших земель была вызжена", "Приветствие", MessageBoxButtons.OK);
                            MessageBox.Show("Но мое мнение что вот все вы кто решил заняться этим после войны. Просто лезут в казну свои гразными от навоза руками", "Приветствие", MessageBoxButtons.OK);
                            MessageBox.Show("Хотя везде бывают исключения....", "Приветствие", MessageBoxButtons.OK);
                            master.Set_craft("Farm");
                        }
                    }
                }
            }
            MessageBox.Show("А напомни мне как тебя зовут", "Приветствие", MessageBoxButtons.OK);
            #endregion


            InitializeComponent();
        }

        private void btnCencel_Click(object sender, EventArgs e)//Обработка нажатия на кнопку отмена
        {
            if (Is_new_game)
            {
                Application.Exit();
            }
            else
            {
                this.Close();
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)//Обработка нажатия на кнопку Создать
        {
            
            string name = this.txtName.Text;
            string tavernname = this.txtTavern.Text;
            if (name != "" && name != null)
            {
                master.Set_Name(name);
            }
            else
            {
                MessageBox.Show("Ошибка поля Имя", "Ой",MessageBoxButtons.OK ,MessageBoxIcon.Error);
            }
            if (tavernname != "" && tavernname != null)
            {
                master.Set_TavernName(tavernname);
            }
            else
            {
                MessageBox.Show("Ошибка поля Название", "Ой", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (name != "" && name != null && tavernname != "" && tavernname != null)
            {
                
                Global.Masters.Add(master);
                Global.Appdate_cur_master(master);
                MessageBox.Show("Поздравляю создан новый игровой профиль","Оповещение",MessageBoxButtons.OK,MessageBoxIcon.Information);
                Tuple<Tavern_master, List<Tavern_master>> tuple = new Tuple<Tavern_master, List<Tavern_master>>(master,Global.Masters);
                Program.Write_masters(tuple, Global.file_players_list);
                this.Close();
            }

        }

        private void txtTavern_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnCreate_Click(sender, e);
                e.Handled = true;
            }
        }
    }
}
