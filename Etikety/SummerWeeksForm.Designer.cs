namespace Etikety
{
    partial class SummerWeeksForm
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
            System.Windows.Forms.Button sweek5but;
            System.Windows.Forms.Button sweek4but;
            System.Windows.Forms.Button sweek3but;
            System.Windows.Forms.Button sweek2but;
            System.Windows.Forms.Button sweek1but;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SummerWeeksForm));
            this.button1 = new System.Windows.Forms.Button();
            sweek5but = new System.Windows.Forms.Button();
            sweek4but = new System.Windows.Forms.Button();
            sweek3but = new System.Windows.Forms.Button();
            sweek2but = new System.Windows.Forms.Button();
            sweek1but = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // sweek5but
            // 
            sweek5but.Enabled = false;
            sweek5but.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            sweek5but.Location = new System.Drawing.Point(261, 476);
            sweek5but.Name = "sweek5but";
            sweek5but.Size = new System.Drawing.Size(303, 48);
            sweek5but.TabIndex = 16;
            sweek5but.Text = "Týden 5";
            sweek5but.UseVisualStyleBackColor = true;
            sweek5but.Click += new System.EventHandler(this.sweek5but_Click);
            // 
            // sweek4but
            // 
            sweek4but.Enabled = false;
            sweek4but.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            sweek4but.Location = new System.Drawing.Point(261, 376);
            sweek4but.Name = "sweek4but";
            sweek4but.Size = new System.Drawing.Size(303, 48);
            sweek4but.TabIndex = 15;
            sweek4but.Text = "Týden 4";
            sweek4but.UseVisualStyleBackColor = true;
            sweek4but.Click += new System.EventHandler(this.sweek4but_Click);
            // 
            // sweek3but
            // 
            sweek3but.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            sweek3but.Location = new System.Drawing.Point(261, 276);
            sweek3but.Name = "sweek3but";
            sweek3but.Size = new System.Drawing.Size(303, 48);
            sweek3but.TabIndex = 14;
            sweek3but.Text = "Týden 3";
            sweek3but.UseVisualStyleBackColor = true;
            sweek3but.Click += new System.EventHandler(this.sweek3but_Click);
            // 
            // sweek2but
            // 
            sweek2but.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            sweek2but.Location = new System.Drawing.Point(261, 176);
            sweek2but.Name = "sweek2but";
            sweek2but.Size = new System.Drawing.Size(303, 48);
            sweek2but.TabIndex = 13;
            sweek2but.Text = "Týden 2";
            sweek2but.UseVisualStyleBackColor = true;
            sweek2but.Click += new System.EventHandler(this.sweek2but_Click);
            // 
            // sweek1but
            // 
            sweek1but.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            sweek1but.Location = new System.Drawing.Point(261, 76);
            sweek1but.Name = "sweek1but";
            sweek1but.Size = new System.Drawing.Size(303, 48);
            sweek1but.TabIndex = 12;
            sweek1but.Text = "Týden 1";
            sweek1but.UseVisualStyleBackColor = true;
            sweek1but.Click += new System.EventHandler(this.sweek1but_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(351, 543);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 56);
            this.button1.TabIndex = 17;
            this.button1.Text = "Zpět";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SummerWeeksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(804, 611);
            this.Controls.Add(this.button1);
            this.Controls.Add(sweek5but);
            this.Controls.Add(sweek4but);
            this.Controls.Add(sweek3but);
            this.Controls.Add(sweek2but);
            this.Controls.Add(sweek1but);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SummerWeeksForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Letní cyklus";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SummerWeeksForm_FormClosing);
            this.Load += new System.EventHandler(this.SummerWeeksForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
    }
}