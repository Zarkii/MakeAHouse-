namespace MakeAHouse_
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.Description = new System.Windows.Forms.TextBox();
            this.GoHere = new System.Windows.Forms.Button();
            this.Exits = new System.Windows.Forms.ComboBox();
            this.GoThroughTheDoor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Description
            // 
            this.Description.Location = new System.Drawing.Point(12, 12);
            this.Description.Multiline = true;
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(349, 259);
            this.Description.TabIndex = 0;
            // 
            // GoHere
            // 
            this.GoHere.Location = new System.Drawing.Point(12, 277);
            this.GoHere.Name = "GoHere";
            this.GoHere.Size = new System.Drawing.Size(75, 23);
            this.GoHere.TabIndex = 1;
            this.GoHere.Text = "Idz tutaj";
            this.GoHere.UseVisualStyleBackColor = true;
            this.GoHere.Click += new System.EventHandler(this.button1_Click);
            // 
            // Exits
            // 
            this.Exits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Exits.FormattingEnabled = true;
            this.Exits.Location = new System.Drawing.Point(94, 277);
            this.Exits.Name = "Exits";
            this.Exits.Size = new System.Drawing.Size(267, 21);
            this.Exits.TabIndex = 2;
            // 
            // GoThroughTheDoor
            // 
            this.GoThroughTheDoor.Location = new System.Drawing.Point(12, 306);
            this.GoThroughTheDoor.Name = "GoThroughTheDoor";
            this.GoThroughTheDoor.Size = new System.Drawing.Size(349, 23);
            this.GoThroughTheDoor.TabIndex = 3;
            this.GoThroughTheDoor.Text = "Idz przez drzwi";
            this.GoThroughTheDoor.UseVisualStyleBackColor = true;
            this.GoThroughTheDoor.Click += new System.EventHandler(this.GoThroughTheDoor_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 341);
            this.Controls.Add(this.GoThroughTheDoor);
            this.Controls.Add(this.Exits);
            this.Controls.Add(this.GoHere);
            this.Controls.Add(this.Description);
            this.Name = "Form1";
            this.Text = "Zbadaj Dom";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Description;
        private System.Windows.Forms.Button GoHere;
        private System.Windows.Forms.ComboBox Exits;
        private System.Windows.Forms.Button GoThroughTheDoor;
    }
}

