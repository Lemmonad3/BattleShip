
namespace BattleShip
{
    partial class GameForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameForm));
            this.user_panel = new System.Windows.Forms.Panel();
            this.enemy_panel = new System.Windows.Forms.Panel();
            this.text_label = new System.Windows.Forms.Label();
            this.butt_start_game = new System.Windows.Forms.Button();
            this.butt_clearing_the_field = new System.Windows.Forms.Button();
            this.butt_rand_ship = new System.Windows.Forms.Button();
            this.deck1 = new System.Windows.Forms.RadioButton();
            this.deck2 = new System.Windows.Forms.RadioButton();
            this.deck3 = new System.Windows.Forms.RadioButton();
            this.deck4 = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // user_panel
            // 
            this.user_panel.Location = new System.Drawing.Point(12, 68);
            this.user_panel.Name = "user_panel";
            this.user_panel.Size = new System.Drawing.Size(160, 160);
            this.user_panel.TabIndex = 0;
            this.user_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.user_panel_Paint);
            this.user_panel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.user_panel_MouseClick);
            this.user_panel.MouseLeave += new System.EventHandler(this.user_panel_MouseLeave);
            this.user_panel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.user_panel_MouseMove);
            // 
            // enemy_panel
            // 
            this.enemy_panel.Location = new System.Drawing.Point(280, 68);
            this.enemy_panel.Name = "enemy_panel";
            this.enemy_panel.Size = new System.Drawing.Size(160, 160);
            this.enemy_panel.TabIndex = 1;
            this.enemy_panel.Click += new System.EventHandler(this.enemy_panel_Click);
            this.enemy_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.enemy_panel_Paint);
            this.enemy_panel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.enemy_panel_MouseClick);
            // 
            // text_label
            // 
            this.text_label.AutoSize = true;
            this.text_label.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.text_label.ForeColor = System.Drawing.Color.Gold;
            this.text_label.Image = ((System.Drawing.Image)(resources.GetObject("text_label.Image")));
            this.text_label.Location = new System.Drawing.Point(98, 21);
            this.text_label.Name = "text_label";
            this.text_label.Size = new System.Drawing.Size(248, 24);
            this.text_label.TabIndex = 2;
            this.text_label.Text = "Расставьте корабли по полю";
            // 
            // butt_start_game
            // 
            this.butt_start_game.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.butt_start_game.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.butt_start_game.ForeColor = System.Drawing.Color.Gold;
            this.butt_start_game.Image = ((System.Drawing.Image)(resources.GetObject("butt_start_game.Image")));
            this.butt_start_game.Location = new System.Drawing.Point(365, 257);
            this.butt_start_game.Name = "butt_start_game";
            this.butt_start_game.Size = new System.Drawing.Size(104, 23);
            this.butt_start_game.TabIndex = 3;
            this.butt_start_game.Text = "Начать игру";
            this.butt_start_game.UseVisualStyleBackColor = true;
            this.butt_start_game.Click += new System.EventHandler(this.butt_start_game_Click);
            // 
            // butt_clearing_the_field
            // 
            this.butt_clearing_the_field.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.butt_clearing_the_field.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.butt_clearing_the_field.ForeColor = System.Drawing.Color.Gold;
            this.butt_clearing_the_field.Image = ((System.Drawing.Image)(resources.GetObject("butt_clearing_the_field.Image")));
            this.butt_clearing_the_field.Location = new System.Drawing.Point(12, 257);
            this.butt_clearing_the_field.Name = "butt_clearing_the_field";
            this.butt_clearing_the_field.Size = new System.Drawing.Size(112, 23);
            this.butt_clearing_the_field.TabIndex = 4;
            this.butt_clearing_the_field.Text = "Очистить поле";
            this.butt_clearing_the_field.UseVisualStyleBackColor = true;
            this.butt_clearing_the_field.Click += new System.EventHandler(this.butt_clearing_the_field_Click);
            // 
            // butt_rand_ship
            // 
            this.butt_rand_ship.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.butt_rand_ship.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.butt_rand_ship.ForeColor = System.Drawing.Color.Gold;
            this.butt_rand_ship.Image = ((System.Drawing.Image)(resources.GetObject("butt_rand_ship.Image")));
            this.butt_rand_ship.Location = new System.Drawing.Point(140, 257);
            this.butt_rand_ship.Name = "butt_rand_ship";
            this.butt_rand_ship.Size = new System.Drawing.Size(197, 23);
            this.butt_rand_ship.TabIndex = 5;
            this.butt_rand_ship.Text = "Расставить корабли случайно";
            this.butt_rand_ship.UseVisualStyleBackColor = true;
            this.butt_rand_ship.Click += new System.EventHandler(this.butt_rand_ship_Click);
            // 
            // deck1
            // 
            this.deck1.AutoSize = true;
            this.deck1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.deck1.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.deck1.ForeColor = System.Drawing.Color.Gold;
            this.deck1.Location = new System.Drawing.Point(178, 85);
            this.deck1.Name = "deck1";
            this.deck1.Size = new System.Drawing.Size(39, 20);
            this.deck1.TabIndex = 6;
            this.deck1.TabStop = true;
            this.deck1.Text = "1X";
            this.deck1.UseVisualStyleBackColor = false;
            this.deck1.CheckedChanged += new System.EventHandler(this.deck1_CheckedChanged);
            // 
            // deck2
            // 
            this.deck2.AutoSize = true;
            this.deck2.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.deck2.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.deck2.ForeColor = System.Drawing.Color.Gold;
            this.deck2.Location = new System.Drawing.Point(221, 85);
            this.deck2.Name = "deck2";
            this.deck2.Size = new System.Drawing.Size(39, 20);
            this.deck2.TabIndex = 7;
            this.deck2.TabStop = true;
            this.deck2.Text = "2X";
            this.deck2.UseVisualStyleBackColor = false;
            this.deck2.CheckedChanged += new System.EventHandler(this.deck1_CheckedChanged);
            // 
            // deck3
            // 
            this.deck3.AutoSize = true;
            this.deck3.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.deck3.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.deck3.ForeColor = System.Drawing.Color.Gold;
            this.deck3.Location = new System.Drawing.Point(178, 135);
            this.deck3.Name = "deck3";
            this.deck3.Size = new System.Drawing.Size(39, 20);
            this.deck3.TabIndex = 8;
            this.deck3.TabStop = true;
            this.deck3.Text = "3X";
            this.deck3.UseVisualStyleBackColor = false;
            this.deck3.CheckedChanged += new System.EventHandler(this.deck1_CheckedChanged);
            // 
            // deck4
            // 
            this.deck4.AutoSize = true;
            this.deck4.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.deck4.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.deck4.ForeColor = System.Drawing.Color.Gold;
            this.deck4.Location = new System.Drawing.Point(221, 135);
            this.deck4.Name = "deck4";
            this.deck4.Size = new System.Drawing.Size(39, 20);
            this.deck4.TabIndex = 9;
            this.deck4.TabStop = true;
            this.deck4.Text = "4X";
            this.deck4.UseVisualStyleBackColor = false;
            this.deck4.CheckedChanged += new System.EventHandler(this.deck1_CheckedChanged);
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(481, 308);
            this.Controls.Add(this.deck4);
            this.Controls.Add(this.deck3);
            this.Controls.Add(this.deck2);
            this.Controls.Add(this.deck1);
            this.Controls.Add(this.butt_rand_ship);
            this.Controls.Add(this.butt_clearing_the_field);
            this.Controls.Add(this.butt_start_game);
            this.Controls.Add(this.text_label);
            this.Controls.Add(this.enemy_panel);
            this.Controls.Add(this.user_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GameForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Морской Бой";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.GameForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel user_panel;
        private System.Windows.Forms.Panel enemy_panel;
        private System.Windows.Forms.Label text_label;
        private System.Windows.Forms.Button butt_start_game;
        private System.Windows.Forms.Button butt_clearing_the_field;
        private System.Windows.Forms.Button butt_rand_ship;
        private System.Windows.Forms.RadioButton deck1;
        private System.Windows.Forms.RadioButton deck2;
        private System.Windows.Forms.RadioButton deck3;
        private System.Windows.Forms.RadioButton deck4;
    }
}