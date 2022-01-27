namespace Etikety
{
    partial class NoveWeekForm
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
            System.Windows.Forms.Button nweek2but;
            System.Windows.Forms.Button nweek1but;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NoveWeekForm));
            this.button1 = new System.Windows.Forms.Button();
            nweek2but = new System.Windows.Forms.Button();
            nweek1but = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(341, 511);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 56);
            this.button1.TabIndex = 20;
            this.button1.Text = "Zpět";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // nweek2but
            // 
            nweek2but.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            nweek2but.Location = new System.Drawing.Point(255, 245);
            nweek2but.Name = "nweek2but";
            nweek2but.Size = new System.Drawing.Size(303, 48);
            nweek2but.TabIndex = 19;
            nweek2but.Text = "Týden 2";
            nweek2but.UseVisualStyleBackColor = true;
            nweek2but.Click += new System.EventHandler(this.nweek2but_Click);
            // 
            // nweek1but
            // 
            nweek1but.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            nweek1but.Location = new System.Drawing.Point(255, 145);
            nweek1but.Name = "nweek1but";
            nweek1but.Size = new System.Drawing.Size(303, 48);
            nweek1but.TabIndex = 18;
            nweek1but.Text = "Týden 1";
            nweek1but.UseVisualStyleBackColor = true;
            nweek1but.Click += new System.EventHandler(this.nweek1but_Click);
            // 
            // NoveWeekForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Etikety.Properties.Resources.jFFM_logo_FB_uprava;
            this.ClientSize = new System.Drawing.Size(804, 611);
            this.Controls.Add(this.button1);
            this.Controls.Add(nweek2but);
            this.Controls.Add(nweek1but);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NoveWeekForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NoveWeekForm";
            this.Load += new System.EventHandler(this.NoveWeekForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
    }
}