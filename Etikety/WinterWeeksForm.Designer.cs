namespace Etikety
{
    partial class WinterWeeksForm
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
            System.Windows.Forms.Button wweek5but;
            System.Windows.Forms.Button wweek4but;
            System.Windows.Forms.Button wweek3but;
            System.Windows.Forms.Button wweek2but;
            System.Windows.Forms.Button wweek1but;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WinterWeeksForm));
            this.button1 = new System.Windows.Forms.Button();
            wweek5but = new System.Windows.Forms.Button();
            wweek4but = new System.Windows.Forms.Button();
            wweek3but = new System.Windows.Forms.Button();
            wweek2but = new System.Windows.Forms.Button();
            wweek1but = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // wweek5but
            // 
            wweek5but.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            wweek5but.Location = new System.Drawing.Point(261, 476);
            wweek5but.Name = "wweek5but";
            wweek5but.Size = new System.Drawing.Size(303, 48);
            wweek5but.TabIndex = 10;
            wweek5but.Text = "Týden 5";
            wweek5but.UseVisualStyleBackColor = true;
            wweek5but.Click += new System.EventHandler(this.wweek5but_Click);
            // 
            // wweek4but
            // 
            wweek4but.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            wweek4but.Location = new System.Drawing.Point(261, 376);
            wweek4but.Name = "wweek4but";
            wweek4but.Size = new System.Drawing.Size(303, 48);
            wweek4but.TabIndex = 9;
            wweek4but.Text = "Týden 4";
            wweek4but.UseVisualStyleBackColor = true;
            wweek4but.Click += new System.EventHandler(this.wweek4but_Click);
            // 
            // wweek3but
            // 
            wweek3but.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            wweek3but.Location = new System.Drawing.Point(261, 276);
            wweek3but.Name = "wweek3but";
            wweek3but.Size = new System.Drawing.Size(303, 48);
            wweek3but.TabIndex = 8;
            wweek3but.Text = "Týden 3";
            wweek3but.UseVisualStyleBackColor = true;
            wweek3but.Click += new System.EventHandler(this.wweek3but_Click);
            // 
            // wweek2but
            // 
            wweek2but.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            wweek2but.Location = new System.Drawing.Point(261, 176);
            wweek2but.Name = "wweek2but";
            wweek2but.Size = new System.Drawing.Size(303, 48);
            wweek2but.TabIndex = 7;
            wweek2but.Text = "Týden 2";
            wweek2but.UseVisualStyleBackColor = true;
            wweek2but.Click += new System.EventHandler(this.wweek2but_Click);
            // 
            // wweek1but
            // 
            wweek1but.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            wweek1but.Location = new System.Drawing.Point(261, 76);
            wweek1but.Name = "wweek1but";
            wweek1but.Size = new System.Drawing.Size(303, 48);
            wweek1but.TabIndex = 6;
            wweek1but.Text = "Týden 1";
            wweek1but.UseVisualStyleBackColor = true;
            wweek1but.Click += new System.EventHandler(this.wweek1but_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(351, 543);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 56);
            this.button1.TabIndex = 11;
            this.button1.Text = "Zpět";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // WinterWeeksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(804, 611);
            this.Controls.Add(this.button1);
            this.Controls.Add(wweek5but);
            this.Controls.Add(wweek4but);
            this.Controls.Add(wweek3but);
            this.Controls.Add(wweek2but);
            this.Controls.Add(wweek1but);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "WinterWeeksForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Zimní cyklus";
            this.Load += new System.EventHandler(this.WinterWeeksForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
    }
}