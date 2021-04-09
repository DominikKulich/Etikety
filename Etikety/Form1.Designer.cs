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
            System.Windows.Forms.Button SummerBut;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.WinterBut = new System.Windows.Forms.Button();
            SummerBut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SummerBut
            // 
            SummerBut.Location = new System.Drawing.Point(251, 203);
            SummerBut.Name = "SummerBut";
            SummerBut.Size = new System.Drawing.Size(303, 48);
            SummerBut.TabIndex = 0;
            SummerBut.Text = "Letní Cyklus";
            SummerBut.UseVisualStyleBackColor = true;
            
            // 
            // WinterBut
            // 
            this.WinterBut.Location = new System.Drawing.Point(251, 310);
            this.WinterBut.Name = "WinterBut";
            this.WinterBut.Size = new System.Drawing.Size(303, 48);
            this.WinterBut.TabIndex = 1;
            this.WinterBut.Text = "Zimní cyklus";
            this.WinterBut.UseVisualStyleBackColor = true;
            this.WinterBut.Click += new System.EventHandler(this.WinterBut_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(804, 611);
            this.Controls.Add(this.WinterBut);
            this.Controls.Add(SummerBut);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Etikety";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button WinterBut;
    }
}

