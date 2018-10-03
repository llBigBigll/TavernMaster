namespace TavernMaster
{
    partial class MainWindow
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
            this.btnExit = new System.Windows.Forms.Button();
            this.btnCreatePeople = new System.Windows.Forms.Button();
            this.btnShowPop = new System.Windows.Forms.Button();
            this.BtnChangeMaster = new System.Windows.Forms.Button();
            this.btnStartGame = new System.Windows.Forms.Button();
            this.btnRules = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic);
            this.btnExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnExit.Location = new System.Drawing.Point(405, 333);
            this.btnExit.MaximumSize = new System.Drawing.Size(587, 60);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(114, 60);
            this.btnExit.TabIndex = 99;
            this.btnExit.Text = "Выход";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCreatePeople
            // 
            this.btnCreatePeople.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCreatePeople.BackColor = System.Drawing.Color.Transparent;
            this.btnCreatePeople.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreatePeople.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic);
            this.btnCreatePeople.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnCreatePeople.Location = new System.Drawing.Point(12, 333);
            this.btnCreatePeople.MaximumSize = new System.Drawing.Size(587, 60);
            this.btnCreatePeople.Name = "btnCreatePeople";
            this.btnCreatePeople.Size = new System.Drawing.Size(114, 60);
            this.btnCreatePeople.TabIndex = 4;
            this.btnCreatePeople.Text = "Создать человека";
            this.btnCreatePeople.UseVisualStyleBackColor = false;
            this.btnCreatePeople.Click += new System.EventHandler(this.btnCreatePeople_Click);
            // 
            // btnShowPop
            // 
            this.btnShowPop.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnShowPop.BackColor = System.Drawing.Color.Transparent;
            this.btnShowPop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowPop.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic);
            this.btnShowPop.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnShowPop.Location = new System.Drawing.Point(221, 333);
            this.btnShowPop.MaximumSize = new System.Drawing.Size(587, 60);
            this.btnShowPop.Name = "btnShowPop";
            this.btnShowPop.Size = new System.Drawing.Size(114, 60);
            this.btnShowPop.TabIndex = 5;
            this.btnShowPop.Text = "Показать население";
            this.btnShowPop.UseVisualStyleBackColor = false;
            this.btnShowPop.Click += new System.EventHandler(this.btnShowPop_Click);
            // 
            // BtnChangeMaster
            // 
            this.BtnChangeMaster.BackColor = System.Drawing.Color.Transparent;
            this.BtnChangeMaster.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnChangeMaster.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic);
            this.BtnChangeMaster.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BtnChangeMaster.Location = new System.Drawing.Point(221, 244);
            this.BtnChangeMaster.Name = "BtnChangeMaster";
            this.BtnChangeMaster.Size = new System.Drawing.Size(114, 65);
            this.BtnChangeMaster.TabIndex = 1;
            this.BtnChangeMaster.Text = "Выбрать игровой профиль";
            this.BtnChangeMaster.UseVisualStyleBackColor = false;
            this.BtnChangeMaster.Click += new System.EventHandler(this.BtnChangeMaster_Click);
            // 
            // btnStartGame
            // 
            this.btnStartGame.BackColor = System.Drawing.Color.Transparent;
            this.btnStartGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStartGame.Font = new System.Drawing.Font("Monotype Corsiva", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnStartGame.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnStartGame.Location = new System.Drawing.Point(190, 12);
            this.btnStartGame.Name = "btnStartGame";
            this.btnStartGame.Size = new System.Drawing.Size(172, 65);
            this.btnStartGame.TabIndex = 0;
            this.btnStartGame.Text = "Играть";
            this.btnStartGame.UseVisualStyleBackColor = false;
            this.btnStartGame.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnRules
            // 
            this.btnRules.BackColor = System.Drawing.Color.Transparent;
            this.btnRules.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRules.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic);
            this.btnRules.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnRules.Location = new System.Drawing.Point(405, 244);
            this.btnRules.Name = "btnRules";
            this.btnRules.Size = new System.Drawing.Size(114, 65);
            this.btnRules.TabIndex = 2;
            this.btnRules.Text = "Правила";
            this.btnRules.UseVisualStyleBackColor = false;
            this.btnRules.Click += new System.EventHandler(this.button3_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TavernMaster.Properties.Resources.imeg;
            this.ClientSize = new System.Drawing.Size(531, 405);
            this.Controls.Add(this.btnRules);
            this.Controls.Add(this.btnStartGame);
            this.Controls.Add(this.BtnChangeMaster);
            this.Controls.Add(this.btnShowPop);
            this.Controls.Add(this.btnCreatePeople);
            this.Controls.Add(this.btnExit);
            this.MaximumSize = new System.Drawing.Size(1020, 609);
            this.MinimumSize = new System.Drawing.Size(547, 444);
            this.Name = "MainWindow";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Gen_people";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnCreatePeople;
        private System.Windows.Forms.Button btnShowPop;
        private System.Windows.Forms.Button BtnChangeMaster;
        private System.Windows.Forms.Button btnStartGame;
        private System.Windows.Forms.Button btnRules;
    }
}

