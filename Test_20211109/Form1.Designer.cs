namespace Test_20211109
{
    partial class limitVyberuN
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
            System.Windows.Forms.NumericUpDown limitVyberu;
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
            this.limitPlatbyN = new System.Windows.Forms.NumericUpDown();
            this.nefunguje = new System.Windows.Forms.Label();
            this.limitPlatby = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            limitVyberu = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(limitVyberu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vkladN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vyberN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.platbaN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.limitPlatbyN)).BeginInit();
            this.SuspendLayout();
            // 
            // limitVyberu
            // 
            limitVyberu.Location = new System.Drawing.Point(128, 199);
            limitVyberu.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            limitVyberu.Name = "limitVyberu";
            limitVyberu.Size = new System.Drawing.Size(120, 20);
            limitVyberu.TabIndex = 17;
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
            this.vkladN.Maximum = new decimal(new int[] {
            -1530494976,
            232830,
            0,
            0});
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
            this.vyberN.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.vyberN.Name = "vyberN";
            this.vyberN.Size = new System.Drawing.Size(120, 20);
            this.vyberN.TabIndex = 9;
            // 
            // platbaN
            // 
            this.platbaN.Location = new System.Drawing.Point(628, 164);
            this.platbaN.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
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
            this.nefunguje.Location = new System.Drawing.Point(678, 119);
            this.nefunguje.Name = "nefunguje";
            this.nefunguje.Size = new System.Drawing.Size(54, 13);
            this.nefunguje.TabIndex = 14;
            this.nefunguje.Text = "nefunguje";
            // 
            // limitPlatby
            // 
            this.limitPlatby.AutoSize = true;
            this.limitPlatby.Location = new System.Drawing.Point(541, 137);
            this.limitPlatby.Name = "limitPlatby";
            this.limitPlatby.Size = new System.Drawing.Size(59, 13);
            this.limitPlatby.TabIndex = 15;
            this.limitPlatby.Text = "Limit platby";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Limit výběru";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(213, 222);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "nefunguje";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(727, 428);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Lukáš Krejčí";
            // 
            // limitVyberuN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(limitVyberu);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.limitPlatby);
            this.Controls.Add(this.nefunguje);
            this.Controls.Add(this.limitPlatbyN);
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
            this.Name = "limitVyberuN";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(limitVyberu)).EndInit();
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
        private System.Windows.Forms.NumericUpDown limitPlatbyN;
        private System.Windows.Forms.Label nefunguje;
        private System.Windows.Forms.Label limitPlatby;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

