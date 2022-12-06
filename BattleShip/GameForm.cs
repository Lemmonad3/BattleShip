using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BattleShip
{
    public partial class GameForm : Form
    {
        SeaBattle seabattle = new SeaBattle();
        public GameForm()
        {
            InitializeComponent();
        }

        private void user_panel_Paint(object sender, PaintEventArgs e)
        {
            int w = user_panel.Width / seabattle.ReturnMasSize();
            int h = user_panel.Height / seabattle.ReturnMasSize();
            ControlPaint.DrawGrid(e.Graphics, new Rectangle(Point.Empty, user_panel.Size), new Size(w, 1), Color.White);
            ControlPaint.DrawGrid(e.Graphics, new Rectangle(Point.Empty, user_panel.Size), new Size(1, h), Color.White);
            for (int i = 0; i < seabattle.ReturnMasSize(); i++)
                for (int j = 0; j < seabattle.ReturnMasSize(); j++)
                {
                    if (seabattle[i, j] == 0)
                        e.Graphics.FillRectangle(Brushes.White, j * w + 1, i * h + 1, w - 1, h - 1);
                    if (seabattle[i, j] == 1 || seabattle[i, j] == 2)
                        e.Graphics.FillRectangle(Brushes.Red, j * w + 1, i * h + 1, w - 1, h - 1);
                    if (seabattle[i, j] == 3)
                        e.Graphics.FillRectangle(Brushes.Green, j * w + 1, i * h + 1, w - 1, h - 1);
                    if (seabattle[i, j] == 4)
                        e.Graphics.FillRectangle(Brushes.LightCoral, j * w + 1, i * h + 1, w - 1, h - 1);
                }
        }

        private void enemy_panel_Paint(object sender, PaintEventArgs e)
        {
            int w = user_panel.Width / seabattle.ReturnMasSize();
            int h = user_panel.Height / seabattle.ReturnMasSize();
            ControlPaint.DrawGrid(e.Graphics, new Rectangle(Point.Empty, user_panel.Size), new Size(w, 1), Color.White);
            ControlPaint.DrawGrid(e.Graphics, new Rectangle(Point.Empty, user_panel.Size), new Size(1, h), Color.White);
            for (int i = 0; i < seabattle.ReturnMasSize(); i++)
                for (int j = 0; j < seabattle.ReturnMasSize(); j++)
                {
                    if (seabattle.GetEnemyValue(i, j) < 3)
                        e.Graphics.FillRectangle(Brushes.White, j * w + 1, i * h + 1, w - 1, h - 1);
                    if (seabattle.GetEnemyValue(i, j) == 2)
                       e.Graphics.FillRectangle(Brushes.Red, j * w + 1, i * h + 1, w - 1, h - 1);
                    if (seabattle.GetEnemyValue(i, j) == 3)
                        e.Graphics.FillRectangle(Brushes.Green, j * w + 1, i * h + 1, w - 1, h - 1);
                    if (seabattle.GetEnemyValue(i, j) == 4)
                        e.Graphics.FillRectangle(Brushes.LightCoral, j * w + 1, i * h + 1, w - 1, h - 1);
                }
        }

        private void user_panel_MouseMove(object sender, MouseEventArgs e)
        {
            if (!(deck1.Enabled == false && deck2.Enabled == false && deck3.Enabled == false
                && deck4.Enabled == false))
            {
                int w = user_panel.Width / seabattle.ReturnMasSize();
                int h = user_panel.Height / seabattle.ReturnMasSize();
                int x = e.X / w;
                int y = e.Y / h;
                int size;
                if (deck1.Checked) size = 1;
                else if (deck2.Checked) size = 2;
                else if (deck3.Checked) size = 3;
                else size = 4;
                seabattle.WatchShip(y, x, w, h, size, user_panel);
            }

        }

        private void user_panel_MouseLeave(object sender, EventArgs e)
        {
            seabattle.NullMas();
            user_panel.Invalidate();
        }

        private void user_panel_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                seabattle.ChangeVertical();
                seabattle.NullMas();
                user_panel.Invalidate();
            }
            else
            {
                int w = user_panel.Width / seabattle.ReturnMasSize();
                int h = user_panel.Height / seabattle.ReturnMasSize();
                int x = e.X / w;
                int y = e.Y / h;
                int size;
                if (deck1.Checked) size = 1;
                else if (deck2.Checked) size = 2;
                else if (deck3.Checked) size = 3;
                else size = 4;
                seabattle.NullMas();
                if (seabattle.CheckSq(x, y, size - 1, seabattle.GetLink()))
                {
                    seabattle.CreateShip(x, y, 2, size - 1, seabattle.GetLink());
                    if (deck1.Checked) seabattle.Count1X++;
                    else if (deck2.Checked) seabattle.Count2X++;
                    else if (deck3.Checked) seabattle.Count3X++;
                    else seabattle.Count4X++;
                    if (seabattle.Count1X > 3) deck1.Enabled = false;
                    if (seabattle.Count2X > 2) deck2.Enabled = false;
                    if (seabattle.Count3X > 1) deck3.Enabled = false;
                    if (seabattle.Count4X > 0) deck4.Enabled = false;
                    seabattle.FindNextRb(deck1, deck2, deck3, deck4);
                }
                user_panel.Invalidate();
            }
        }

        private void deck1_CheckedChanged(object sender, EventArgs e)
        {
            seabattle.NullMas();
            user_panel.Invalidate();
        }

        private void butt_clearing_the_field_Click(object sender, EventArgs e)
        {
            seabattle.Reset();
            deck1.Enabled = true;
            deck1.Checked = true;
            deck2.Enabled = true;
            deck3.Enabled = true;
            deck4.Enabled = true;
            user_panel.Invalidate();
        }

        private void butt_start_game_Click(object sender, EventArgs e)
        {
            text_label.Text = "Игра Началась";
            text_label.Location = new Point(text_label.Location.X - 75, text_label.Location.Y);
            seabattle.Count1X = 0;
            seabattle.Count2X = 0;
            seabattle.Count3X = 0;
            seabattle.Count4X = 0;
            int y, x, count = 10, size = 3;
            while (count > 0)
            {
                Random r = new Random();
                if (count < 10) size = 2;
                if (count < 8) size = 1;
                if (count < 5) size = 0;
                y = r.Next(0, 10);
                x = r.Next(0, 10);
                if (r.Next(0, 2) == 1) 
                    seabattle.ChangeVertical();
                if (seabattle.CheckSq(x,y,size, seabattle.GetEnemyLink()))
                {
                    seabattle.CreateShip(x, y, 2, size, seabattle.GetEnemyLink());
                    count--;
                }
                
            }
            enemy_panel.Invalidate();
            butt_clearing_the_field.Enabled = false;
            butt_start_game.Enabled = false;
            butt_rand_ship.Enabled = false;
        }

        private void butt_rand_ship_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
                for (int j = 0; j < 10; j++)
                { 
                    seabattle[i, j] = 0; 
                }

            int y, x, count = 0, size = 0;
            while(count < 10){
                Random r = new Random();
                if (count > 3) size = 1;
                if (count > 6) size = 2;
                if (count > 8) size = 3;
                y = r.Next(0, 10);
                x = r.Next(0, 10);
                if (r.Next(0, 2) == 1) 
                    seabattle.ChangeVertical();
                if(seabattle.CheckSq(x,y,size,seabattle.GetLink()))
                {
                    seabattle.CreateShip(x, y, 2, size, seabattle.GetLink());
                    count++;
                }
            }
            deck1.Enabled = false;
            deck2.Enabled = false;
            deck3.Enabled = false;
            deck4.Enabled = false;
            deck1.Checked = false;
            deck2.Checked = false;
            deck3.Checked = false;
            deck4.Checked = false;
            user_panel.Invalidate();
        }

        private void enemy_panel_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && butt_rand_ship.Enabled == false)
            {
                int w = user_panel.Width / seabattle.ReturnMasSize();
                int h = user_panel.Height / seabattle.ReturnMasSize();
                int x = e.X / w;
                int y = e.Y / h;
                if (seabattle.GetEnemyValue(y, x) == 2)
                {
                    seabattle.SetEnemyValue(y, x, 3);
                    seabattle.EnemyShip--;
                    seabattle.Explosion(x, y, seabattle.GetEnemyLink());
                    enemy_panel.Invalidate();
                    if (seabattle.EnemyShip == 0)
                    {
                            DialogResult result = MessageBox.Show(
                                  "Победил Игрок",
                                   "Поздравляем!",
                             MessageBoxButtons.RetryCancel,
                             MessageBoxIcon.Information,
                             MessageBoxDefaultButton.Button1,
                             MessageBoxOptions.DefaultDesktopOnly);

                            if (result == DialogResult.Retry)
                            {
                                GameForm start = new GameForm();
                                Hide();
                                start.Show();

                            }

                            if (result == DialogResult.Cancel)
                            {
                                Application.Exit();
                            }
                            TopMost = true;

                    }
                }
                else if (seabattle.GetEnemyValue(y, x) == 0)
                {
                    EnemyTurn();
                    seabattle.SetEnemyValue(y, x, 4);
                    enemy_panel.Invalidate();
                }
            }
        }

        public void EnemyTurn()
        {
            int x, y;
            Random r = new Random();
            bool flag = true;
            while (flag)
            {
                x = r.Next(0, 10);
                y = r.Next(0, 10);
                if (seabattle[x, y] == 0 || seabattle[x, y] == 2)
                    flag = false;
                if (seabattle[x, y] == 0)
                {
                    seabattle[x, y] = 4;
                    user_panel.Invalidate();
                }
                else
                {
                    seabattle[x, y] = 3;
                    seabattle.MyShip--;
                    seabattle.Explosion(x, y, seabattle.GetLink());
                    if (seabattle.MyShip == 0)
                    {
                        DialogResult result = MessageBox.Show(
                              "Победил противник",
                               "Какая досада!",
                        MessageBoxButtons.RetryCancel,
                        MessageBoxIcon.Information,
                        MessageBoxDefaultButton.Button1,
                        MessageBoxOptions.DefaultDesktopOnly);

                        if (result == DialogResult.Retry)
                        {
                            GameForm game = new GameForm();
                            Hide();
                            game.Show();
                        }
                       
                        if (result == DialogResult.Cancel)
                        {
                            Application.Exit();
                        }
                        TopMost = true;

                        TopMost = true;
                    }
                }
            }
        }
        

        private void GameForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void enemy_panel_Click(object sender, EventArgs e)
        {

        }
    }
}

