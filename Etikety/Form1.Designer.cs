namespace Etikety
{
    partial class Form1
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Button Tyden1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tyden2 = new System.Windows.Forms.Button();
            this.tyden3 = new System.Windows.Forms.Button();
            this.tyden4 = new System.Windows.Forms.Button();
            this.tyden5 = new System.Windows.Forms.Button();
            Tyden1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Tyden1
            // 
            Tyden1.Location = new System.Drawing.Point(261, 39);
            Tyden1.Name = "Tyden1";
            Tyden1.Size = new System.Drawing.Size(303, 48);
            Tyden1.TabIndex = 0;
            Tyden1.Text = "Týden 1";
            Tyden1.UseVisualStyleBackColor = true;
            Tyden1.Click += new System.EventHandler(this.Tyden1_Click);
            // 
            // tyden2
            // 
            this.tyden2.Location = new System.Drawing.Point(261, 146);
            this.tyden2.Name = "tyden2";
            this.tyden2.Size = new System.Drawing.Size(303, 48);
            this.tyden2.TabIndex = 1;
            this.tyden2.Text = "Týden 2";
            this.tyden2.UseVisualStyleBackColor = true;
            // 
            // tyden3
            // 
            this.tyden3.Location = new System.Drawing.Point(261, 251);
            this.tyden3.Name = "tyden3";
            this.tyden3.Size = new System.Drawing.Size(303, 48);
            this.tyden3.TabIndex = 2;
            this.tyden3.Text = "Týden 3";
            this.tyden3.UseVisualStyleBackColor = true;
            // 
            // tyden4
            // 
            this.tyden4.Location = new System.Drawing.Point(261, 351);
            this.tyden4.Name = "tyden4";
            this.tyden4.Size = new System.Drawing.Size(303, 48);
            this.tyden4.TabIndex = 3;
            this.tyden4.Text = "Týden 4";
            this.tyden4.UseVisualStyleBackColor = true;
            // 
            // tyden5
            // 
            this.tyden5.Location = new System.Drawing.Point(261, 453);
            this.tyden5.Name = "tyden5";
            this.tyden5.Size = new System.Drawing.Size(303, 48);
            this.tyden5.TabIndex = 4;
            this.tyden5.Text = "týden 5";
            this.tyden5.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(804, 611);
            this.Controls.Add(this.tyden5);
            this.Controls.Add(this.tyden4);
            this.Controls.Add(this.tyden3);
            this.Controls.Add(this.tyden2);
            this.Controls.Add(Tyden1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Etikety";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button tyden2;
        private System.Windows.Forms.Button tyden3;
        private System.Windows.Forms.Button tyden4;
        private System.Windows.Forms.Button tyden5;
    }
}

