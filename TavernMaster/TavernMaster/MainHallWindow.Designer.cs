namespace TavernMaster
{
    partial class MainHallWindow
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
            this.label1 = new System.Windows.Forms.Label();
            this.numTables = new System.Windows.Forms.NumericUpDown();
            this.numChairs = new System.Windows.Forms.NumericUpDown();
            this.labelTablesNum = new System.Windows.Forms.Label();
            this.labelChairsNum = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtSumm = new System.Windows.Forms.Label();
            this.labelMaxTable = new System.Windows.Forms.Label();
            this.labelMaxChairs = new System.Windows.Forms.Label();
            this.MaxTable = new System.Windows.Forms.Label();
            this.MaxChairs = new System.Windows.Forms.Label();
            this.labelGold = new System.Windows.Forms.Label();
            this.GoldBar = new System.Windows.Forms.Label();
            this.txtInvo = new System.Windows.Forms.Label();
            this.btnUpgrade = new System.Windows.Forms.Button();
            this.UpgraddeSummBar = new System.Windows.Forms.Label();
            this.GradeBar = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numTables)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numChairs)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 32.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(386, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 52);
            this.label1.TabIndex = 0;
            this.label1.Text = "Главный Зал";
            // 
            // numTables
            // 
            this.numTables.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numTables.Location = new System.Drawing.Point(12, 180);
            this.numTables.Name = "numTables";
            this.numTables.Size = new System.Drawing.Size(120, 31);
            this.numTables.TabIndex = 1;
            this.numTables.ValueChanged += new System.EventHandler(this.ValueChanged);
            // 
            // numChairs
            // 
            this.numChairs.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic);
            this.numChairs.Location = new System.Drawing.Point(12, 265);
            this.numChairs.Name = "numChairs";
            this.numChairs.Size = new System.Drawing.Size(120, 31);
            this.numChairs.TabIndex = 2;
            this.numChairs.ValueChanged += new System.EventHandler(this.ValueChanged);
            // 
            // labelTablesNum
            // 
            this.labelTablesNum.AutoSize = true;
            this.labelTablesNum.BackColor = System.Drawing.Color.Transparent;
            this.labelTablesNum.Font = new System.Drawing.Font("Monotype Corsiva", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTablesNum.ForeColor = System.Drawing.Color.Goldenrod;
            this.labelTablesNum.Location = new System.Drawing.Point(12, 149);
            this.labelTablesNum.Name = "labelTablesNum";
            this.labelTablesNum.Size = new System.Drawing.Size(74, 28);
            this.labelTablesNum.TabIndex = 3;
            this.labelTablesNum.Text = "Столы";
            // 
            // labelChairsNum
            // 
            this.labelChairsNum.AutoSize = true;
            this.labelChairsNum.BackColor = System.Drawing.Color.Transparent;
            this.labelChairsNum.Font = new System.Drawing.Font("Monotype Corsiva", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelChairsNum.ForeColor = System.Drawing.Color.Goldenrod;
            this.labelChairsNum.Location = new System.Drawing.Point(12, 236);
            this.labelChairsNum.Name = "labelChairsNum";
            this.labelChairsNum.Size = new System.Drawing.Size(80, 28);
            this.labelChairsNum.TabIndex = 4;
            this.labelChairsNum.Text = "Стулья";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic);
            this.button1.ForeColor = System.Drawing.Color.Yellow;
            this.button1.Location = new System.Drawing.Point(17, 378);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 69);
            this.button1.TabIndex = 5;
            this.button1.Text = "Купить/Продать";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtSumm
            // 
            this.txtSumm.AutoSize = true;
            this.txtSumm.BackColor = System.Drawing.Color.Transparent;
            this.txtSumm.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic);
            this.txtSumm.ForeColor = System.Drawing.Color.Goldenrod;
            this.txtSumm.Location = new System.Drawing.Point(12, 320);
            this.txtSumm.Name = "txtSumm";
            this.txtSumm.Size = new System.Drawing.Size(56, 25);
            this.txtSumm.TabIndex = 6;
            this.txtSumm.Text = "label2";
            // 
            // labelMaxTable
            // 
            this.labelMaxTable.AutoSize = true;
            this.labelMaxTable.BackColor = System.Drawing.Color.Transparent;
            this.labelMaxTable.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic);
            this.labelMaxTable.ForeColor = System.Drawing.Color.Red;
            this.labelMaxTable.Location = new System.Drawing.Point(138, 182);
            this.labelMaxTable.Name = "labelMaxTable";
            this.labelMaxTable.Size = new System.Drawing.Size(109, 25);
            this.labelMaxTable.TabIndex = 7;
            this.labelMaxTable.Text = "Максимум :";
            // 
            // labelMaxChairs
            // 
            this.labelMaxChairs.AutoSize = true;
            this.labelMaxChairs.BackColor = System.Drawing.Color.Transparent;
            this.labelMaxChairs.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic);
            this.labelMaxChairs.ForeColor = System.Drawing.Color.Red;
            this.labelMaxChairs.Location = new System.Drawing.Point(138, 267);
            this.labelMaxChairs.Name = "labelMaxChairs";
            this.labelMaxChairs.Size = new System.Drawing.Size(104, 25);
            this.labelMaxChairs.TabIndex = 8;
            this.labelMaxChairs.Text = "Максимум:";
            // 
            // MaxTable
            // 
            this.MaxTable.AutoSize = true;
            this.MaxTable.BackColor = System.Drawing.Color.Transparent;
            this.MaxTable.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic);
            this.MaxTable.ForeColor = System.Drawing.Color.Red;
            this.MaxTable.Location = new System.Drawing.Point(241, 182);
            this.MaxTable.Name = "MaxTable";
            this.MaxTable.Size = new System.Drawing.Size(56, 25);
            this.MaxTable.TabIndex = 9;
            this.MaxTable.Text = "label3";
            // 
            // MaxChairs
            // 
            this.MaxChairs.AutoSize = true;
            this.MaxChairs.BackColor = System.Drawing.Color.Transparent;
            this.MaxChairs.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic);
            this.MaxChairs.ForeColor = System.Drawing.Color.Red;
            this.MaxChairs.Location = new System.Drawing.Point(241, 267);
            this.MaxChairs.Name = "MaxChairs";
            this.MaxChairs.Size = new System.Drawing.Size(56, 25);
            this.MaxChairs.TabIndex = 10;
            this.MaxChairs.Text = "label4";
            // 
            // labelGold
            // 
            this.labelGold.AutoSize = true;
            this.labelGold.BackColor = System.Drawing.Color.Transparent;
            this.labelGold.Font = new System.Drawing.Font("Monotype Corsiva", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelGold.ForeColor = System.Drawing.Color.Yellow;
            this.labelGold.Location = new System.Drawing.Point(390, 72);
            this.labelGold.Name = "labelGold";
            this.labelGold.Size = new System.Drawing.Size(115, 39);
            this.labelGold.TabIndex = 11;
            this.labelGold.Text = "Золото:";
            // 
            // GoldBar
            // 
            this.GoldBar.AutoSize = true;
            this.GoldBar.BackColor = System.Drawing.Color.Transparent;
            this.GoldBar.Font = new System.Drawing.Font("Monotype Corsiva", 24F, System.Drawing.FontStyle.Italic);
            this.GoldBar.ForeColor = System.Drawing.Color.Yellow;
            this.GoldBar.Location = new System.Drawing.Point(499, 72);
            this.GoldBar.Name = "GoldBar";
            this.GoldBar.Size = new System.Drawing.Size(78, 39);
            this.GoldBar.TabIndex = 12;
            this.GoldBar.Text = "None";
            // 
            // txtInvo
            // 
            this.txtInvo.AutoSize = true;
            this.txtInvo.BackColor = System.Drawing.Color.Transparent;
            this.txtInvo.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic);
            this.txtInvo.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.txtInvo.Location = new System.Drawing.Point(12, 483);
            this.txtInvo.Name = "txtInvo";
            this.txtInvo.Size = new System.Drawing.Size(56, 25);
            this.txtInvo.TabIndex = 13;
            this.txtInvo.Text = "label2";
            // 
            // btnUpgrade
            // 
            this.btnUpgrade.BackColor = System.Drawing.Color.Transparent;
            this.btnUpgrade.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpgrade.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic);
            this.btnUpgrade.ForeColor = System.Drawing.Color.Yellow;
            this.btnUpgrade.Location = new System.Drawing.Point(199, 378);
            this.btnUpgrade.Name = "btnUpgrade";
            this.btnUpgrade.Size = new System.Drawing.Size(150, 69);
            this.btnUpgrade.TabIndex = 14;
            this.btnUpgrade.Text = "Улутшить";
            this.btnUpgrade.UseVisualStyleBackColor = false;
            this.btnUpgrade.Click += new System.EventHandler(this.btnUpgrade_Click);
            // 
            // UpgraddeSummBar
            // 
            this.UpgraddeSummBar.AutoSize = true;
            this.UpgraddeSummBar.BackColor = System.Drawing.Color.Transparent;
            this.UpgraddeSummBar.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic);
            this.UpgraddeSummBar.ForeColor = System.Drawing.Color.Goldenrod;
            this.UpgraddeSummBar.Location = new System.Drawing.Point(194, 350);
            this.UpgraddeSummBar.Name = "UpgraddeSummBar";
            this.UpgraddeSummBar.Size = new System.Drawing.Size(56, 25);
            this.UpgraddeSummBar.TabIndex = 15;
            this.UpgraddeSummBar.Text = "label2";
            // 
            // GradeBar
            // 
            this.GradeBar.AutoSize = true;
            this.GradeBar.BackColor = System.Drawing.Color.Transparent;
            this.GradeBar.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GradeBar.ForeColor = System.Drawing.Color.Purple;
            this.GradeBar.Location = new System.Drawing.Point(368, 394);
            this.GradeBar.Name = "GradeBar";
            this.GradeBar.Size = new System.Drawing.Size(70, 33);
            this.GradeBar.TabIndex = 16;
            this.GradeBar.Text = "label2";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic);
            this.button2.ForeColor = System.Drawing.Color.Yellow;
            this.button2.Location = new System.Drawing.Point(842, 489);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 69);
            this.button2.TabIndex = 17;
            this.button2.Text = "Назад";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // MainHallWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TavernMaster.Properties.Resources.imeg;
            this.ClientSize = new System.Drawing.Size(1004, 570);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.GradeBar);
            this.Controls.Add(this.UpgraddeSummBar);
            this.Controls.Add(this.btnUpgrade);
            this.Controls.Add(this.txtInvo);
            this.Controls.Add(this.GoldBar);
            this.Controls.Add(this.labelGold);
            this.Controls.Add(this.MaxChairs);
            this.Controls.Add(this.MaxTable);
            this.Controls.Add(this.labelMaxChairs);
            this.Controls.Add(this.labelMaxTable);
            this.Controls.Add(this.txtSumm);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelChairsNum);
            this.Controls.Add(this.labelTablesNum);
            this.Controls.Add(this.numChairs);
            this.Controls.Add(this.numTables);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(1020, 609);
            this.MinimumSize = new System.Drawing.Size(1020, 609);
            this.Name = "MainHallWindow";
            this.Text = "Главный зал";
            this.Activated += new System.EventHandler(this.UpdateGoldBar);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainHallWindow_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.numTables)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numChairs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numTables;
        private System.Windows.Forms.NumericUpDown numChairs;
        private System.Windows.Forms.Label labelTablesNum;
        private System.Windows.Forms.Label labelChairsNum;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label txtSumm;
        private System.Windows.Forms.Label labelMaxTable;
        private System.Windows.Forms.Label labelMaxChairs;
        private System.Windows.Forms.Label MaxTable;
        private System.Windows.Forms.Label MaxChairs;
        private System.Windows.Forms.Label labelGold;
        private System.Windows.Forms.Label GoldBar;
        private System.Windows.Forms.Label txtInvo;
        private System.Windows.Forms.Button btnUpgrade;
        private System.Windows.Forms.Label UpgraddeSummBar;
        private System.Windows.Forms.Label GradeBar;
        private System.Windows.Forms.Button button2;
    }
}