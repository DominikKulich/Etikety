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
            this.button1 = new System.Windows.Forms.Button();
            SummerBut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SummerBut
            // 
            SummerBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            SummerBut.Location = new System.Drawing.Point(251, 203);
            SummerBut.Name = "SummerBut";
            SummerBut.Size = new System.Drawing.Size(303, 48);
            SummerBut.TabIndex = 0;
            SummerBut.Text = "Letní Cyklus";
            SummerBut.UseVisualStyleBackColor = true;
            // 
            // WinterBut
            // 
            this.WinterBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.WinterBut.Location = new System.Drawing.Point(251, 287);
            this.WinterBut.Name = "WinterBut";
            this.WinterBut.Size = new System.Drawing.Size(303, 48);
            this.WinterBut.TabIndex = 1;
            this.WinterBut.Text = "Zimní Cyklus";
            this.WinterBut.UseVisualStyleBackColor = true;
            this.WinterBut.Click += new System.EventHandler(this.WinterBut_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(321, 368);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(165, 48);
            this.button1.TabIndex = 2;
            this.button1.Text = "Nápověda";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Etikety.Properties.Resources.jFFM_logo_FB_uprava;
            this.ClientSize = new System.Drawing.Size(804, 611);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.WinterBut);
            this.Controls.Add(SummerBut);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Etikety";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button WinterBut;
        private System.Windows.Forms.Button button1;
    }
}

