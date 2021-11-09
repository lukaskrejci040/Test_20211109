namespace Test_20211109
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.vkladB = new System.Windows.Forms.Button();
            this.vkladN = new System.Windows.Forms.NumericUpDown();
            this.vypisJmeno = new System.Windows.Forms.Label();
            this.vypisZustatek = new System.Windows.Forms.Label();
            this.vybratB = new System.Windows.Forms.Button();
            this.vyberN = new System.Windows.Forms.NumericUpDown();
            this.platbaN = new System.Windows.Forms.NumericUpDown();
            this.platbaB = new System.Windows.Forms.Button();
            this.limitPlatbyB = new System.Windows.Forms.Button();
            this.limitPlatbyN = new System.Windows.Forms.NumericUpDown();
            this.nefunguje = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.vkladN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vyberN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.platbaN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.limitPlatbyN)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(365, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Osobní účet";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Jméno";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Zůstatek";
            // 
            // vkladB
            // 
            this.vkladB.AutoSize = true;
            this.vkladB.Location = new System.Drawing.Point(53, 129);
            this.vkladB.Name = "vkladB";
            this.vkladB.Size = new System.Drawing.Size(86, 23);
            this.vkladB.TabIndex = 3;
            this.vkladB.Text = "Vložit hotovost";
            this.vkladB.UseVisualStyleBackColor = true;
            this.vkladB.Click += new System.EventHandler(this.vkladB_Click);
            // 
            // vkladN
            // 
            this.vkladN.Location = new System.Drawing.Point(145, 132);
            this.vkladN.Name = "vkladN";
            this.vkladN.Size = new System.Drawing.Size(120, 20);
            this.vkladN.TabIndex = 4;
            // 
            // vypisJmeno
            // 
            this.vypisJmeno.AutoSize = true;
            this.vypisJmeno.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.vypisJmeno.Location = new System.Drawing.Point(125, 32);
            this.vypisJmeno.Name = "vypisJmeno";
            this.vypisJmeno.Size = new System.Drawing.Size(10, 13);
            this.vypisJmeno.TabIndex = 6;
            this.vypisJmeno.Text = "-";
            // 
            // vypisZustatek
            // 
            this.vypisZustatek.AutoSize = true;
            this.vypisZustatek.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.vypisZustatek.Location = new System.Drawing.Point(125, 54);
            this.vypisZustatek.Name = "vypisZustatek";
            this.vypisZustatek.Size = new System.Drawing.Size(10, 13);
            this.vypisZustatek.TabIndex = 7;
            this.vypisZustatek.Text = "-";
            // 
            // vybratB
            // 
            this.vybratB.AutoSize = true;
            this.vybratB.Location = new System.Drawing.Point(53, 158);
            this.vybratB.Name = "vybratB";
            this.vybratB.Size = new System.Drawing.Size(91, 23);
            this.vybratB.TabIndex = 8;
            this.vybratB.Text = "Vybrat hotovost";
            this.vybratB.UseVisualStyleBackColor = true;
            this.vybratB.Click += new System.EventHandler(this.vybratB_Click);
            // 
            // vyberN
            // 
            this.vyberN.Location = new System.Drawing.Point(150, 161);
            this.vyberN.Name = "vyberN";
            this.vyberN.Size = new System.Drawing.Size(120, 20);
            this.vyberN.TabIndex = 9;
            // 
            // platbaN
            // 
            this.platbaN.Location = new System.Drawing.Point(628, 164);
            this.platbaN.Name = "platbaN";
            this.platbaN.Size = new System.Drawing.Size(120, 20);
            this.platbaN.TabIndex = 11;
            // 
            // platbaB
            // 
            this.platbaB.AutoSize = true;
            this.platbaB.Location = new System.Drawing.Point(531, 161);
            this.platbaB.Name = "platbaB";
            this.platbaB.Size = new System.Drawing.Size(91, 23);
            this.platbaB.TabIndex = 10;
            this.platbaB.Text = "Zaplatit";
            this.platbaB.UseVisualStyleBackColor = true;
            this.platbaB.Click += new System.EventHandler(this.platbaB_Click);
            // 
            // limitPlatbyB
            // 
            this.limitPlatbyB.AutoSize = true;
            this.limitPlatbyB.Location = new System.Drawing.Point(531, 132);
            this.limitPlatbyB.Name = "limitPlatbyB";
            this.limitPlatbyB.Size = new System.Drawing.Size(75, 23);
            this.limitPlatbyB.TabIndex = 12;
            this.limitPlatbyB.Text = "Limit platby";
            this.limitPlatbyB.UseVisualStyleBackColor = true;
            // 
            // limitPlatbyN
            // 
            this.limitPlatbyN.Location = new System.Drawing.Point(612, 135);
            this.limitPlatbyN.Name = "limitPlatbyN";
            this.limitPlatbyN.Size = new System.Drawing.Size(120, 20);
            this.limitPlatbyN.TabIndex = 13;
            // 
            // nefunguje
            // 
            this.nefunguje.AutoSize = true;
            this.nefunguje.Location = new System.Drawing.Point(635, 139);
            this.nefunguje.Name = "nefunguje";
            this.nefunguje.Size = new System.Drawing.Size(54, 13);
            this.nefunguje.TabIndex = 14;
            this.nefunguje.Text = "nefunguje";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.nefunguje);
            this.Controls.Add(this.limitPlatbyN);
            this.Controls.Add(this.limitPlatbyB);
            this.Controls.Add(this.platbaN);
            this.Controls.Add(this.platbaB);
            this.Controls.Add(this.vyberN);
            this.Controls.Add(this.vybratB);
            this.Controls.Add(this.vypisZustatek);
            this.Controls.Add(this.vypisJmeno);
            this.Controls.Add(this.vkladN);
            this.Controls.Add(this.vkladB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vkladN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vyberN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.platbaN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.limitPlatbyN)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button vkladB;
        private System.Windows.Forms.NumericUpDown vkladN;
        private System.Windows.Forms.Label vypisJmeno;
        private System.Windows.Forms.Label vypisZustatek;
        private System.Windows.Forms.Button vybratB;
        private System.Windows.Forms.NumericUpDown vyberN;
        private System.Windows.Forms.NumericUpDown platbaN;
        private System.Windows.Forms.Button platbaB;
        private System.Windows.Forms.Button limitPlatbyB;
        private System.Windows.Forms.NumericUpDown limitPlatbyN;
        private System.Windows.Forms.Label nefunguje;
    }
}

