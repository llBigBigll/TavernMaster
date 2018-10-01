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
            // 
            // numChairs
            // 
            this.numChairs.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic);
            this.numChairs.Location = new System.Drawing.Point(12, 265);
            this.numChairs.Name = "numChairs";
            this.numChairs.Size = new System.Drawing.Size(120, 31);
            this.numChairs.TabIndex = 2;
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
            // MainHallWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TavernMaster.Properties.Resources.imeg;
            this.ClientSize = new System.Drawing.Size(1004, 570);
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
    }
}