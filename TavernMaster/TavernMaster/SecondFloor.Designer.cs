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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.txtIncome = new System.Windows.Forms.Label();
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
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic);
            this.button1.Location = new System.Drawing.Point(12, 321);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 58);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic);
            this.button2.Location = new System.Drawing.Point(281, 321);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(103, 29);
            this.button2.TabIndex = 2;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic);
            this.button3.Location = new System.Drawing.Point(281, 415);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(103, 58);
            this.button3.TabIndex = 3;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic);
            this.button4.Location = new System.Drawing.Point(135, 321);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(103, 58);
            this.button4.TabIndex = 4;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic);
            this.button5.Location = new System.Drawing.Point(281, 356);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(103, 29);
            this.button5.TabIndex = 5;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // txtIncome
            // 
            this.txtIncome.AutoSize = true;
            this.txtIncome.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic);
            this.txtIncome.Location = new System.Drawing.Point(12, 438);
            this.txtIncome.Name = "txtIncome";
            this.txtIncome.Size = new System.Drawing.Size(42, 18);
            this.txtIncome.TabIndex = 6;
            this.txtIncome.Text = "label1";
            // 
            // SecondFloor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TavernMaster.Properties.Resources.imeg;
            this.ClientSize = new System.Drawing.Size(396, 485);
            this.Controls.Add(this.txtIncome);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listOfRenters);
            this.MaximumSize = new System.Drawing.Size(412, 524);
            this.MinimumSize = new System.Drawing.Size(412, 524);
            this.Name = "SecondFloor";
            this.Text = "SecondFloor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listOfRenters;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label txtIncome;
    }
}