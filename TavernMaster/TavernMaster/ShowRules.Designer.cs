namespace TavernMaster
{
    partial class ShowRules
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
            this.textboxRules = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic);
            this.btnExit.Location = new System.Drawing.Point(869, 504);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(123, 54);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Выход";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // textboxRules
            // 
            this.textboxRules.BackColor = System.Drawing.Color.PapayaWhip;
            this.textboxRules.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textboxRules.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic);
            this.textboxRules.Location = new System.Drawing.Point(12, 12);
            this.textboxRules.Name = "textboxRules";
            this.textboxRules.ReadOnly = true;
            this.textboxRules.Size = new System.Drawing.Size(545, 546);
            this.textboxRules.TabIndex = 1;
            this.textboxRules.Text = "";
            // 
            // ShowRules
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TavernMaster.Properties.Resources.imeg;
            this.ClientSize = new System.Drawing.Size(1004, 570);
            this.Controls.Add(this.textboxRules);
            this.Controls.Add(this.btnExit);
            this.MaximumSize = new System.Drawing.Size(1020, 609);
            this.MinimumSize = new System.Drawing.Size(1020, 609);
            this.Name = "ShowRules";
            this.Text = "ShowRules";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.RichTextBox textboxRules;
    }
}