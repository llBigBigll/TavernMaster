namespace TavernMaster
{
    partial class fCreateNewOne
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
            this.txtboxName = new System.Windows.Forms.TextBox();
            this.txtboxSurname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbboxGender = new System.Windows.Forms.ComboBox();
            this.cmbboxHair = new System.Windows.Forms.ComboBox();
            this.btnRandomName = new System.Windows.Forms.Button();
            this.btnRandomSurname = new System.Windows.Forms.Button();
            this.btnRandomAge = new System.Windows.Forms.Button();
            this.btnRandomHealth = new System.Windows.Forms.Button();
            this.btnRandomHair = new System.Windows.Forms.Button();
            this.btnRandomCharisma = new System.Windows.Forms.Button();
            this.btnRandomAttract = new System.Windows.Forms.Button();
            this.btnRandomInt = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtboxAge = new System.Windows.Forms.NumericUpDown();
            this.txtboxAttractivness = new System.Windows.Forms.NumericUpDown();
            this.txtboxCharism = new System.Windows.Forms.NumericUpDown();
            this.txtboxHealth = new System.Windows.Forms.NumericUpDown();
            this.txtboxInt = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.txtboxAge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtboxAttractivness)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtboxCharism)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtboxHealth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtboxInt)).BeginInit();
            this.SuspendLayout();
            // 
            // txtboxName
            // 
            this.txtboxName.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtboxName.Location = new System.Drawing.Point(13, 43);
            this.txtboxName.Margin = new System.Windows.Forms.Padding(4);
            this.txtboxName.Name = "txtboxName";
            this.txtboxName.Size = new System.Drawing.Size(133, 25);
            this.txtboxName.TabIndex = 1;
            this.txtboxName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EnterToTAB);
            // 
            // txtboxSurname
            // 
            this.txtboxSurname.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtboxSurname.Location = new System.Drawing.Point(13, 108);
            this.txtboxSurname.Margin = new System.Windows.Forms.Padding(4);
            this.txtboxSurname.Name = "txtboxSurname";
            this.txtboxSurname.Size = new System.Drawing.Size(133, 25);
            this.txtboxSurname.TabIndex = 2;
            this.txtboxSurname.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EnterToTAB);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(10, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 18);
            this.label1.TabIndex = 10;
            this.label1.Text = "Имя";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(12, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 18);
            this.label2.TabIndex = 11;
            this.label2.Text = "Фамилия";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label3.Location = new System.Drawing.Point(12, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 18);
            this.label3.TabIndex = 12;
            this.label3.Text = "Пол";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label4.Location = new System.Drawing.Point(10, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 18);
            this.label4.TabIndex = 13;
            this.label4.Text = "Возраст";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label5.Location = new System.Drawing.Point(12, 284);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 18);
            this.label5.TabIndex = 14;
            this.label5.Text = "Уровень здоровья";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label6.Location = new System.Drawing.Point(362, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 18);
            this.label6.TabIndex = 15;
            this.label6.Text = "Цвет волос";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label7.Location = new System.Drawing.Point(362, 87);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 18);
            this.label7.TabIndex = 16;
            this.label7.Text = "Уровень харизмы";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label8.Location = new System.Drawing.Point(361, 156);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(180, 18);
            this.label8.TabIndex = 17;
            this.label8.Text = "Уровень привлекательности";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label9.Location = new System.Drawing.Point(361, 219);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(135, 18);
            this.label9.TabIndex = 18;
            this.label9.Text = "Уровень интеллекта";
            // 
            // cmbboxGender
            // 
            this.cmbboxGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbboxGender.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmbboxGender.FormattingEnabled = true;
            this.cmbboxGender.Items.AddRange(new object[] {
            "Мужской",
            "Женский"});
            this.cmbboxGender.Location = new System.Drawing.Point(13, 178);
            this.cmbboxGender.Name = "cmbboxGender";
            this.cmbboxGender.Size = new System.Drawing.Size(133, 26);
            this.cmbboxGender.TabIndex = 3;
            this.cmbboxGender.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EnterToTAB);
            // 
            // cmbboxHair
            // 
            this.cmbboxHair.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbboxHair.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmbboxHair.FormattingEnabled = true;
            this.cmbboxHair.Items.AddRange(new object[] {
            "Каштановые",
            "Блондин",
            "Рыжий",
            "Брюнет",
            "Фиолетовый",
            "Зеленый",
            "Розовый"});
            this.cmbboxHair.Location = new System.Drawing.Point(364, 43);
            this.cmbboxHair.Name = "cmbboxHair";
            this.cmbboxHair.Size = new System.Drawing.Size(133, 26);
            this.cmbboxHair.TabIndex = 6;
            this.cmbboxHair.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EnterToTAB);
            // 
            // btnRandomName
            // 
            this.btnRandomName.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnRandomName.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnRandomName.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnRandomName.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnRandomName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRandomName.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic);
            this.btnRandomName.Location = new System.Drawing.Point(151, 43);
            this.btnRandomName.Name = "btnRandomName";
            this.btnRandomName.Size = new System.Drawing.Size(86, 26);
            this.btnRandomName.TabIndex = 21;
            this.btnRandomName.Text = "Случайно";
            this.btnRandomName.UseVisualStyleBackColor = true;
            this.btnRandomName.Click += new System.EventHandler(this.btnRandomName_Click);
            // 
            // btnRandomSurname
            // 
            this.btnRandomSurname.BackColor = System.Drawing.SystemColors.Menu;
            this.btnRandomSurname.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnRandomSurname.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnRandomSurname.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnRandomSurname.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnRandomSurname.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRandomSurname.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic);
            this.btnRandomSurname.Location = new System.Drawing.Point(153, 107);
            this.btnRandomSurname.Name = "btnRandomSurname";
            this.btnRandomSurname.Size = new System.Drawing.Size(86, 26);
            this.btnRandomSurname.TabIndex = 22;
            this.btnRandomSurname.Text = "Случайно";
            this.btnRandomSurname.UseVisualStyleBackColor = false;
            // 
            // btnRandomAge
            // 
            this.btnRandomAge.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnRandomAge.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnRandomAge.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnRandomAge.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnRandomAge.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRandomAge.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic);
            this.btnRandomAge.Location = new System.Drawing.Point(153, 239);
            this.btnRandomAge.Name = "btnRandomAge";
            this.btnRandomAge.Size = new System.Drawing.Size(86, 26);
            this.btnRandomAge.TabIndex = 24;
            this.btnRandomAge.Text = "Случайно";
            this.btnRandomAge.UseVisualStyleBackColor = true;
            // 
            // btnRandomHealth
            // 
            this.btnRandomHealth.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnRandomHealth.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnRandomHealth.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnRandomHealth.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnRandomHealth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRandomHealth.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic);
            this.btnRandomHealth.Location = new System.Drawing.Point(153, 304);
            this.btnRandomHealth.Name = "btnRandomHealth";
            this.btnRandomHealth.Size = new System.Drawing.Size(86, 26);
            this.btnRandomHealth.TabIndex = 25;
            this.btnRandomHealth.Text = "Случайно";
            this.btnRandomHealth.UseVisualStyleBackColor = true;
            // 
            // btnRandomHair
            // 
            this.btnRandomHair.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnRandomHair.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnRandomHair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnRandomHair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnRandomHair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRandomHair.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic);
            this.btnRandomHair.Location = new System.Drawing.Point(504, 43);
            this.btnRandomHair.Name = "btnRandomHair";
            this.btnRandomHair.Size = new System.Drawing.Size(86, 26);
            this.btnRandomHair.TabIndex = 26;
            this.btnRandomHair.Text = "Случайно";
            this.btnRandomHair.UseVisualStyleBackColor = true;
            // 
            // btnRandomCharisma
            // 
            this.btnRandomCharisma.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRandomCharisma.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnRandomCharisma.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnRandomCharisma.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnRandomCharisma.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnRandomCharisma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRandomCharisma.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic);
            this.btnRandomCharisma.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnRandomCharisma.Location = new System.Drawing.Point(504, 107);
            this.btnRandomCharisma.Name = "btnRandomCharisma";
            this.btnRandomCharisma.Size = new System.Drawing.Size(86, 26);
            this.btnRandomCharisma.TabIndex = 27;
            this.btnRandomCharisma.Text = "Случайно";
            this.btnRandomCharisma.UseVisualStyleBackColor = false;
            // 
            // btnRandomAttract
            // 
            this.btnRandomAttract.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnRandomAttract.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnRandomAttract.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnRandomAttract.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnRandomAttract.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRandomAttract.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic);
            this.btnRandomAttract.Location = new System.Drawing.Point(504, 177);
            this.btnRandomAttract.Name = "btnRandomAttract";
            this.btnRandomAttract.Size = new System.Drawing.Size(86, 26);
            this.btnRandomAttract.TabIndex = 28;
            this.btnRandomAttract.Text = "Случайно";
            this.btnRandomAttract.UseVisualStyleBackColor = true;
            // 
            // btnRandomInt
            // 
            this.btnRandomInt.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnRandomInt.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnRandomInt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnRandomInt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnRandomInt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRandomInt.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic);
            this.btnRandomInt.Location = new System.Drawing.Point(504, 237);
            this.btnRandomInt.Name = "btnRandomInt";
            this.btnRandomInt.Size = new System.Drawing.Size(86, 26);
            this.btnRandomInt.TabIndex = 29;
            this.btnRandomInt.Text = "Случайно";
            this.btnRandomInt.UseVisualStyleBackColor = true;
            // 
            // btnCreate
            // 
            this.btnCreate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCreate.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnCreate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnCreate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreate.Location = new System.Drawing.Point(337, 303);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(103, 37);
            this.btnCreate.TabIndex = 30;
            this.btnCreate.Text = "Создать";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Location = new System.Drawing.Point(471, 303);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(111, 36);
            this.btnExit.TabIndex = 31;
            this.btnExit.Text = "Выход";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtboxAge
            // 
            this.txtboxAge.Location = new System.Drawing.Point(13, 241);
            this.txtboxAge.Name = "txtboxAge";
            this.txtboxAge.Size = new System.Drawing.Size(120, 28);
            this.txtboxAge.TabIndex = 4;
            // 
            // txtboxAttractivness
            // 
            this.txtboxAttractivness.Location = new System.Drawing.Point(364, 179);
            this.txtboxAttractivness.Name = "txtboxAttractivness";
            this.txtboxAttractivness.Size = new System.Drawing.Size(120, 28);
            this.txtboxAttractivness.TabIndex = 8;
            // 
            // txtboxCharism
            // 
            this.txtboxCharism.Location = new System.Drawing.Point(364, 109);
            this.txtboxCharism.Name = "txtboxCharism";
            this.txtboxCharism.Size = new System.Drawing.Size(120, 28);
            this.txtboxCharism.TabIndex = 7;
            // 
            // txtboxHealth
            // 
            this.txtboxHealth.Location = new System.Drawing.Point(13, 312);
            this.txtboxHealth.Name = "txtboxHealth";
            this.txtboxHealth.Size = new System.Drawing.Size(120, 28);
            this.txtboxHealth.TabIndex = 5;
            // 
            // txtboxInt
            // 
            this.txtboxInt.Location = new System.Drawing.Point(364, 241);
            this.txtboxInt.Name = "txtboxInt";
            this.txtboxInt.Size = new System.Drawing.Size(120, 28);
            this.txtboxInt.TabIndex = 9;
            // 
            // fCreateNewOne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TavernMaster.Properties.Resources.imeg;
            this.ClientSize = new System.Drawing.Size(606, 351);
            this.Controls.Add(this.txtboxInt);
            this.Controls.Add(this.txtboxHealth);
            this.Controls.Add(this.txtboxCharism);
            this.Controls.Add(this.txtboxAttractivness);
            this.Controls.Add(this.txtboxAge);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.btnRandomInt);
            this.Controls.Add(this.btnRandomAttract);
            this.Controls.Add(this.btnRandomCharisma);
            this.Controls.Add(this.btnRandomHair);
            this.Controls.Add(this.btnRandomHealth);
            this.Controls.Add(this.btnRandomAge);
            this.Controls.Add(this.btnRandomSurname);
            this.Controls.Add(this.btnRandomName);
            this.Controls.Add(this.cmbboxHair);
            this.Controls.Add(this.cmbboxGender);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtboxSurname);
            this.Controls.Add(this.txtboxName);
            this.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1020, 609);
            this.MinimumSize = new System.Drawing.Size(622, 390);
            this.Name = "fCreateNewOne";
            this.Text = "Создание Человека";
            ((System.ComponentModel.ISupportInitialize)(this.txtboxAge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtboxAttractivness)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtboxCharism)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtboxHealth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtboxInt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtboxName;
        private System.Windows.Forms.TextBox txtboxSurname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbboxGender;
        private System.Windows.Forms.ComboBox cmbboxHair;
        private System.Windows.Forms.Button btnRandomName;
        private System.Windows.Forms.Button btnRandomSurname;
        private System.Windows.Forms.Button btnRandomAge;
        private System.Windows.Forms.Button btnRandomHealth;
        private System.Windows.Forms.Button btnRandomHair;
        private System.Windows.Forms.Button btnRandomAttract;
        private System.Windows.Forms.Button btnRandomInt;
        private System.Windows.Forms.Button btnRandomCharisma;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.NumericUpDown txtboxAge;
        private System.Windows.Forms.NumericUpDown txtboxAttractivness;
        private System.Windows.Forms.NumericUpDown txtboxCharism;
        private System.Windows.Forms.NumericUpDown txtboxHealth;
        private System.Windows.Forms.NumericUpDown txtboxInt;
    }
}