namespace WindowsFormsApp1
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
            this.timer = new System.Windows.Forms.TextBox();
            this.startbutton = new System.Windows.Forms.Button();
            this.liczba1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.liczba2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.wynik = new System.Windows.Forms.TextBox();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 51);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(344, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "TIME REMAINIGN";
           
            // 
            // timer
            // 
            this.timer.BackColor = System.Drawing.Color.Black;
            this.timer.Font = new System.Drawing.Font("Segoe Script", 24.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timer.ForeColor = System.Drawing.Color.Red;
            this.timer.Location = new System.Drawing.Point(402, 45);
            this.timer.Name = "timer";
            this.timer.ReadOnly = true;
            this.timer.Size = new System.Drawing.Size(82, 60);
            this.timer.TabIndex = 1;
            this.timer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // startbutton
            // 
            this.startbutton.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.impresionante_explosion_en_bangladesh_deja_hasta_el_momento_49_personas_fallecidas_1036291;
            this.startbutton.Font = new System.Drawing.Font("Trebuchet MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startbutton.Location = new System.Drawing.Point(50, 281);
            this.startbutton.Name = "startbutton";
            this.startbutton.Size = new System.Drawing.Size(454, 60);
            this.startbutton.TabIndex = 2;
            this.startbutton.Text = "START";
            this.startbutton.UseVisualStyleBackColor = true;
            this.startbutton.Click += new System.EventHandler(this.startbutton_Click);
            // 
            // liczba1
            // 
            this.liczba1.AutoSize = true;
            this.liczba1.BackColor = System.Drawing.Color.Transparent;
            this.liczba1.Font = new System.Drawing.Font("MV Boli", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.liczba1.Location = new System.Drawing.Point(21, 149);
            this.liczba1.Name = "liczba1";
            this.liczba1.Size = new System.Drawing.Size(68, 70);
            this.liczba1.TabIndex = 3;
            this.liczba1.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("MV Boli", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(106, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 70);
            this.label3.TabIndex = 4;
            this.label3.Text = "+";
            // 
            // liczba2
            // 
            this.liczba2.AutoSize = true;
            this.liczba2.BackColor = System.Drawing.Color.Transparent;
            this.liczba2.Font = new System.Drawing.Font("MV Boli", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.liczba2.Location = new System.Drawing.Point(172, 149);
            this.liczba2.Name = "liczba2";
            this.liczba2.Size = new System.Drawing.Size(68, 70);
            this.liczba2.TabIndex = 5;
            this.liczba2.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("MV Boli", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(255, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 70);
            this.label5.TabIndex = 6;
            this.label5.Text = "=";
            // 
            // wynik
            // 
            this.wynik.Font = new System.Drawing.Font("Palatino Linotype", 40.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wynik.ForeColor = System.Drawing.Color.OliveDrab;
            this.wynik.Location = new System.Drawing.Point(317, 149);
            this.wynik.Name = "wynik";
            this.wynik.Size = new System.Drawing.Size(82, 80);
            this.wynik.TabIndex = 7;
            this.wynik.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreLabel.Location = new System.Drawing.Point(431, 158);
            this.scoreLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(57, 63);
            this.scoreLabel.TabIndex = 8;
            this.scoreLabel.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.s960_Maths_English_blackboard_960x640;
            this.ClientSize = new System.Drawing.Size(557, 366);
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.wynik);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.liczba2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.liczba1);
            this.Controls.Add(this.startbutton);
            this.Controls.Add(this.timer);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox timer;
        private System.Windows.Forms.Button startbutton;
        private System.Windows.Forms.Label liczba1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label liczba2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox wynik;
        private System.Windows.Forms.Label scoreLabel;
    }
}

