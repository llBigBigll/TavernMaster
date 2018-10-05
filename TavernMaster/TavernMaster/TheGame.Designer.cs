namespace TavernMaster
{
    partial class TheGame
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
            this.btnMainHall = new System.Windows.Forms.Button();
            this.txtNameOfTavern = new System.Windows.Forms.Label();
            this.btnSecondFloor = new System.Windows.Forms.Button();
            this.btnCourtyard = new System.Windows.Forms.Button();
            this.btnBedroom = new System.Windows.Forms.Button();
            this.btnWorkshop = new System.Windows.Forms.Button();
            this.btnShowcase = new System.Windows.Forms.Button();
            this.btnToMainMenu = new System.Windows.Forms.Button();
            this.listboxMercenaries = new System.Windows.Forms.ListBox();
            this.btnGiveOrder = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnAlchemy = new System.Windows.Forms.Button();
            this.btnProfile = new System.Windows.Forms.Button();
            this.btnBlacksmith = new System.Windows.Forms.Button();
            this.txtGold = new System.Windows.Forms.Label();
            this.GoldBar = new System.Windows.Forms.Label();
            this.EndDay = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMainHall
            // 
            this.btnMainHall.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnMainHall.Location = new System.Drawing.Point(19, 100);
            this.btnMainHall.Margin = new System.Windows.Forms.Padding(10, 20, 10, 20);
            this.btnMainHall.Name = "btnMainHall";
            this.btnMainHall.Size = new System.Drawing.Size(176, 59);
            this.btnMainHall.TabIndex = 0;
            this.btnMainHall.Text = "Главный Зал";
            this.btnMainHall.UseVisualStyleBackColor = true;
            this.btnMainHall.Click += new System.EventHandler(this.btnMainHall_Click);
            // 
            // txtNameOfTavern
            // 
            this.txtNameOfTavern.AutoSize = true;
            this.txtNameOfTavern.BackColor = System.Drawing.Color.Transparent;
            this.txtNameOfTavern.Font = new System.Drawing.Font("Monotype Corsiva", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtNameOfTavern.ForeColor = System.Drawing.Color.LightGreen;
            this.txtNameOfTavern.Location = new System.Drawing.Point(12, 11);
            this.txtNameOfTavern.Name = "txtNameOfTavern";
            this.txtNameOfTavern.Size = new System.Drawing.Size(445, 57);
            this.txtNameOfTavern.TabIndex = 1;
            this.txtNameOfTavern.Text = "00000000000000000001";
            // 
            // btnSecondFloor
            // 
            this.btnSecondFloor.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSecondFloor.Location = new System.Drawing.Point(19, 199);
            this.btnSecondFloor.Margin = new System.Windows.Forms.Padding(10, 20, 10, 20);
            this.btnSecondFloor.Name = "btnSecondFloor";
            this.btnSecondFloor.Size = new System.Drawing.Size(176, 59);
            this.btnSecondFloor.TabIndex = 1;
            this.btnSecondFloor.Text = "Второй Этаж";
            this.btnSecondFloor.UseVisualStyleBackColor = true;
            this.btnSecondFloor.Click += new System.EventHandler(this.btnSecondFloor_Click);
            // 
            // btnCourtyard
            // 
            this.btnCourtyard.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCourtyard.Location = new System.Drawing.Point(215, 199);
            this.btnCourtyard.Margin = new System.Windows.Forms.Padding(10, 20, 10, 20);
            this.btnCourtyard.Name = "btnCourtyard";
            this.btnCourtyard.Size = new System.Drawing.Size(176, 59);
            this.btnCourtyard.TabIndex = 6;
            this.btnCourtyard.Text = "Двор";
            this.btnCourtyard.UseVisualStyleBackColor = true;
            // 
            // btnBedroom
            // 
            this.btnBedroom.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnBedroom.Location = new System.Drawing.Point(19, 298);
            this.btnBedroom.Margin = new System.Windows.Forms.Padding(10, 20, 10, 20);
            this.btnBedroom.Name = "btnBedroom";
            this.btnBedroom.Size = new System.Drawing.Size(176, 59);
            this.btnBedroom.TabIndex = 3;
            this.btnBedroom.Text = "Спальня";
            this.btnBedroom.UseVisualStyleBackColor = true;
            // 
            // btnWorkshop
            // 
            this.btnWorkshop.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnWorkshop.Location = new System.Drawing.Point(215, 100);
            this.btnWorkshop.Margin = new System.Windows.Forms.Padding(10, 20, 10, 20);
            this.btnWorkshop.Name = "btnWorkshop";
            this.btnWorkshop.Size = new System.Drawing.Size(176, 59);
            this.btnWorkshop.TabIndex = 4;
            this.btnWorkshop.Text = "Мастерская";
            this.btnWorkshop.UseVisualStyleBackColor = true;
            // 
            // btnShowcase
            // 
            this.btnShowcase.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnShowcase.Location = new System.Drawing.Point(215, 298);
            this.btnShowcase.Margin = new System.Windows.Forms.Padding(10, 20, 10, 20);
            this.btnShowcase.Name = "btnShowcase";
            this.btnShowcase.Size = new System.Drawing.Size(176, 59);
            this.btnShowcase.TabIndex = 5;
            this.btnShowcase.Text = "Витрина";
            this.btnShowcase.UseVisualStyleBackColor = true;
            // 
            // btnToMainMenu
            // 
            this.btnToMainMenu.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnToMainMenu.Location = new System.Drawing.Point(809, 482);
            this.btnToMainMenu.Margin = new System.Windows.Forms.Padding(10, 20, 10, 20);
            this.btnToMainMenu.Name = "btnToMainMenu";
            this.btnToMainMenu.Size = new System.Drawing.Size(176, 59);
            this.btnToMainMenu.TabIndex = 7;
            this.btnToMainMenu.Text = "В Главное меню";
            this.btnToMainMenu.UseVisualStyleBackColor = true;
            this.btnToMainMenu.Click += new System.EventHandler(this.btnToMainMenu_Click);
            // 
            // listboxMercenaries
            // 
            this.listboxMercenaries.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listboxMercenaries.FormattingEnabled = true;
            this.listboxMercenaries.ItemHeight = 18;
            this.listboxMercenaries.Location = new System.Drawing.Point(698, 100);
            this.listboxMercenaries.Name = "listboxMercenaries";
            this.listboxMercenaries.Size = new System.Drawing.Size(260, 292);
            this.listboxMercenaries.TabIndex = 8;
            // 
            // btnGiveOrder
            // 
            this.btnGiveOrder.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnGiveOrder.Location = new System.Drawing.Point(698, 409);
            this.btnGiveOrder.Name = "btnGiveOrder";
            this.btnGiveOrder.Size = new System.Drawing.Size(134, 31);
            this.btnGiveOrder.TabIndex = 9;
            this.btnGiveOrder.Text = "Дать задание";
            this.btnGiveOrder.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(875, 409);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(83, 31);
            this.button2.TabIndex = 10;
            this.button2.Text = "Инфо...";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnAlchemy
            // 
            this.btnAlchemy.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic);
            this.btnAlchemy.Location = new System.Drawing.Point(509, 199);
            this.btnAlchemy.Margin = new System.Windows.Forms.Padding(10, 20, 10, 20);
            this.btnAlchemy.MaximumSize = new System.Drawing.Size(176, 59);
            this.btnAlchemy.MinimumSize = new System.Drawing.Size(176, 59);
            this.btnAlchemy.Name = "btnAlchemy";
            this.btnAlchemy.Size = new System.Drawing.Size(176, 59);
            this.btnAlchemy.TabIndex = 11;
            this.btnAlchemy.Text = "Алхимия";
            this.btnAlchemy.UseVisualStyleBackColor = true;
            // 
            // btnProfile
            // 
            this.btnProfile.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic);
            this.btnProfile.Location = new System.Drawing.Point(809, 9);
            this.btnProfile.Margin = new System.Windows.Forms.Padding(10, 20, 10, 20);
            this.btnProfile.MaximumSize = new System.Drawing.Size(176, 59);
            this.btnProfile.MinimumSize = new System.Drawing.Size(176, 59);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(176, 59);
            this.btnProfile.TabIndex = 12;
            this.btnProfile.Text = "Мой Профиль";
            this.btnProfile.UseVisualStyleBackColor = true;
            // 
            // btnBlacksmith
            // 
            this.btnBlacksmith.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic);
            this.btnBlacksmith.Location = new System.Drawing.Point(509, 100);
            this.btnBlacksmith.Margin = new System.Windows.Forms.Padding(10, 20, 10, 20);
            this.btnBlacksmith.MaximumSize = new System.Drawing.Size(176, 59);
            this.btnBlacksmith.MinimumSize = new System.Drawing.Size(176, 59);
            this.btnBlacksmith.Name = "btnBlacksmith";
            this.btnBlacksmith.Size = new System.Drawing.Size(176, 59);
            this.btnBlacksmith.TabIndex = 13;
            this.btnBlacksmith.Text = "Кузнечное дело";
            this.btnBlacksmith.UseVisualStyleBackColor = true;
            // 
            // txtGold
            // 
            this.txtGold.AutoSize = true;
            this.txtGold.BackColor = System.Drawing.Color.Transparent;
            this.txtGold.Font = new System.Drawing.Font("Monotype Corsiva", 36F, System.Drawing.FontStyle.Italic);
            this.txtGold.ForeColor = System.Drawing.Color.Yellow;
            this.txtGold.Location = new System.Drawing.Point(445, 11);
            this.txtGold.Name = "txtGold";
            this.txtGold.Size = new System.Drawing.Size(169, 57);
            this.txtGold.TabIndex = 14;
            this.txtGold.Text = "Золото:";
            // 
            // GoldBar
            // 
            this.GoldBar.AutoSize = true;
            this.GoldBar.BackColor = System.Drawing.Color.Transparent;
            this.GoldBar.Font = new System.Drawing.Font("Monotype Corsiva", 36F, System.Drawing.FontStyle.Italic);
            this.GoldBar.ForeColor = System.Drawing.Color.Yellow;
            this.GoldBar.Location = new System.Drawing.Point(600, 9);
            this.GoldBar.Name = "GoldBar";
            this.GoldBar.Size = new System.Drawing.Size(46, 57);
            this.GoldBar.TabIndex = 15;
            this.GoldBar.Text = "0";
            // 
            // EndDay
            // 
            this.EndDay.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic);
            this.EndDay.Location = new System.Drawing.Point(382, 482);
            this.EndDay.Margin = new System.Windows.Forms.Padding(10, 20, 10, 20);
            this.EndDay.Name = "EndDay";
            this.EndDay.Size = new System.Drawing.Size(176, 59);
            this.EndDay.TabIndex = 16;
            this.EndDay.Text = "Закончить День";
            this.EndDay.UseVisualStyleBackColor = true;
            this.EndDay.Click += new System.EventHandler(this.EndDay_Click);
            // 
            // TheGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TavernMaster.Properties.Resources.imeg;
            this.ClientSize = new System.Drawing.Size(1004, 570);
            this.Controls.Add(this.EndDay);
            this.Controls.Add(this.GoldBar);
            this.Controls.Add(this.txtGold);
            this.Controls.Add(this.btnBlacksmith);
            this.Controls.Add(this.btnProfile);
            this.Controls.Add(this.btnAlchemy);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnGiveOrder);
            this.Controls.Add(this.listboxMercenaries);
            this.Controls.Add(this.btnToMainMenu);
            this.Controls.Add(this.btnShowcase);
            this.Controls.Add(this.btnWorkshop);
            this.Controls.Add(this.btnBedroom);
            this.Controls.Add(this.btnCourtyard);
            this.Controls.Add(this.btnSecondFloor);
            this.Controls.Add(this.txtNameOfTavern);
            this.Controls.Add(this.btnMainHall);
            this.MaximumSize = new System.Drawing.Size(1020, 609);
            this.MinimumSize = new System.Drawing.Size(1020, 609);
            this.Name = "TheGame";
            this.Text = "TheGame";
            this.Activated += new System.EventHandler(this.UpdateForm);
            this.Load += new System.EventHandler(this.UpdateForm);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMainHall;
        private System.Windows.Forms.Label txtNameOfTavern;
        private System.Windows.Forms.Button btnSecondFloor;
        private System.Windows.Forms.Button btnCourtyard;
        private System.Windows.Forms.Button btnBedroom;
        private System.Windows.Forms.Button btnWorkshop;
        private System.Windows.Forms.Button btnShowcase;
        private System.Windows.Forms.Button btnToMainMenu;
        private System.Windows.Forms.ListBox listboxMercenaries;
        private System.Windows.Forms.Button btnGiveOrder;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnAlchemy;
        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.Button btnBlacksmith;
        private System.Windows.Forms.Label txtGold;
        private System.Windows.Forms.Label GoldBar;
        private System.Windows.Forms.Button EndDay;
    }
}