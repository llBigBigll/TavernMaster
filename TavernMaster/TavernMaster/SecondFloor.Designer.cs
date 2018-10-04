namespace TavernMaster
{
    partial class SecondFloor
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
            this.listOfRenters = new System.Windows.Forms.ListBox();
            this.btnUpgradeAll = new System.Windows.Forms.Button();
            this.btnChangeStatus = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnUpgrade = new System.Windows.Forms.Button();
            this.incomeBar = new System.Windows.Forms.Label();
            this.txtInfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listOfRenters
            // 
            this.listOfRenters.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic);
            this.listOfRenters.FormattingEnabled = true;
            this.listOfRenters.ItemHeight = 18;
            this.listOfRenters.Location = new System.Drawing.Point(12, 12);
            this.listOfRenters.MaximumSize = new System.Drawing.Size(371, 310);
            this.listOfRenters.MinimumSize = new System.Drawing.Size(371, 310);
            this.listOfRenters.Name = "listOfRenters";
            this.listOfRenters.Size = new System.Drawing.Size(371, 310);
            this.listOfRenters.TabIndex = 0;
            // 
            // btnUpgradeAll
            // 
            this.btnUpgradeAll.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic);
            this.btnUpgradeAll.Location = new System.Drawing.Point(12, 321);
            this.btnUpgradeAll.Name = "btnUpgradeAll";
            this.btnUpgradeAll.Size = new System.Drawing.Size(103, 58);
            this.btnUpgradeAll.TabIndex = 1;
            this.btnUpgradeAll.Text = "Улутшить Все";
            this.btnUpgradeAll.UseVisualStyleBackColor = true;
            this.btnUpgradeAll.Click += new System.EventHandler(this.btnUpgradeAll_Click);
            // 
            // btnChangeStatus
            // 
            this.btnChangeStatus.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic);
            this.btnChangeStatus.Location = new System.Drawing.Point(281, 321);
            this.btnChangeStatus.Name = "btnChangeStatus";
            this.btnChangeStatus.Size = new System.Drawing.Size(102, 58);
            this.btnChangeStatus.TabIndex = 2;
            this.btnChangeStatus.Text = "Вкл/Выкл";
            this.btnChangeStatus.UseVisualStyleBackColor = true;
            this.btnChangeStatus.Click += new System.EventHandler(this.btnChangeStatus_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic);
            this.btnClose.Location = new System.Drawing.Point(281, 415);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(103, 58);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Выход";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnUpgrade
            // 
            this.btnUpgrade.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic);
            this.btnUpgrade.Location = new System.Drawing.Point(151, 321);
            this.btnUpgrade.Name = "btnUpgrade";
            this.btnUpgrade.Size = new System.Drawing.Size(103, 58);
            this.btnUpgrade.TabIndex = 4;
            this.btnUpgrade.Text = "Улутшить ";
            this.btnUpgrade.UseVisualStyleBackColor = true;
            this.btnUpgrade.Click += new System.EventHandler(this.btnUpgrade_Click);
            // 
            // incomeBar
            // 
            this.incomeBar.AutoSize = true;
            this.incomeBar.BackColor = System.Drawing.Color.Transparent;
            this.incomeBar.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.incomeBar.ForeColor = System.Drawing.Color.Yellow;
            this.incomeBar.Location = new System.Drawing.Point(12, 435);
            this.incomeBar.Name = "incomeBar";
            this.incomeBar.Size = new System.Drawing.Size(70, 33);
            this.incomeBar.TabIndex = 6;
            this.incomeBar.Text = "label1";
            // 
            // txtInfo
            // 
            this.txtInfo.AutoSize = true;
            this.txtInfo.BackColor = System.Drawing.Color.Transparent;
            this.txtInfo.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtInfo.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.txtInfo.Location = new System.Drawing.Point(12, 385);
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.Size = new System.Drawing.Size(51, 22);
            this.txtInfo.TabIndex = 7;
            this.txtInfo.Text = "label1";
            // 
            // SecondFloor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TavernMaster.Properties.Resources.imeg;
            this.ClientSize = new System.Drawing.Size(396, 485);
            this.Controls.Add(this.txtInfo);
            this.Controls.Add(this.incomeBar);
            this.Controls.Add(this.btnUpgrade);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnChangeStatus);
            this.Controls.Add(this.btnUpgradeAll);
            this.Controls.Add(this.listOfRenters);
            this.MaximumSize = new System.Drawing.Size(412, 524);
            this.MinimumSize = new System.Drawing.Size(412, 524);
            this.Name = "SecondFloor";
            this.Text = "SecondFloor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SecondFloor_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listOfRenters;
        private System.Windows.Forms.Button btnUpgradeAll;
        private System.Windows.Forms.Button btnChangeStatus;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnUpgrade;
        private System.Windows.Forms.Label incomeBar;
        private System.Windows.Forms.Label txtInfo;
    }
}