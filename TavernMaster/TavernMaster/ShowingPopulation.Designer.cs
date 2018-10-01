namespace TavernMaster
{
    partial class ShowingPopulation
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
            this.txtBoxPPL = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // txtBoxPPL
            // 
            this.txtBoxPPL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtBoxPPL.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic);
            this.txtBoxPPL.Location = new System.Drawing.Point(12, 12);
            this.txtBoxPPL.Name = "txtBoxPPL";
            this.txtBoxPPL.ReadOnly = true;
            this.txtBoxPPL.Size = new System.Drawing.Size(325, 429);
            this.txtBoxPPL.TabIndex = 0;
            this.txtBoxPPL.Text = "";
            // 
            // ShowingPopulation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TavernMaster.Properties.Resources.imeg;
            this.ClientSize = new System.Drawing.Size(664, 453);
            this.Controls.Add(this.txtBoxPPL);
            this.MaximumSize = new System.Drawing.Size(1020, 609);
            this.MinimumSize = new System.Drawing.Size(680, 492);
            this.Name = "ShowingPopulation";
            this.Text = "Население";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtBoxPPL;
    }
}