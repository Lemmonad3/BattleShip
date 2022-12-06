using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BattleShip
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();

        }

        private void start_game_Click(object sender, EventArgs e)
        {
            GameForm game = new GameForm();
            Hide();
            game.Show();

        }

        private void end_game_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void property_Click(object sender, EventArgs e)
        {
            MessageBox.Show("В данной игре необходимо уничтожить корабли противника раньше чем уничтожат ваши. " +
                "С каждым попадание по кораблю, игрок получает дополнительный выстрел, чтобы добить крейсер. " +
                "При этом если корабль противника окажется уничтожен, огонь продолжается до первого промаха. " +
                "После уничтожения корабля противника, рядом находящиеся ячейки подсвечиваются, показывая что рядом кораблей нет. " +
                "После победы или поражения, можно начать игру снова или выйти");
        }
    }
}
