namespace Testing
{
    partial class Testingcards
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Testingcards));
            this.exit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.settingsUsControl1 = new Testing.SettingsUsControl();
            this.passTheTestUsControl1 = new Testing.PassTheTestUsControl();
            this.aboutProgramUsControl1 = new Testing.AboutProgramUsControl();
            this.resultsUsControl1 = new Testing.ResultsUsControl();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(177)))), ((int)(((byte)(136)))));
            this.exit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("exit.BackgroundImage")));
            this.exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.exit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(177)))), ((int)(((byte)(136)))));
            this.exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit.ForeColor = System.Drawing.SystemColors.Control;
            this.exit.Location = new System.Drawing.Point(1354, 0);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(43, 47);
            this.exit.TabIndex = 2;
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(177)))), ((int)(((byte)(136)))));
            this.panel1.Location = new System.Drawing.Point(-1, 768);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1401, 55);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(177)))), ((int)(((byte)(136)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(-1, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1401, 47);
            this.panel2.TabIndex = 5;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.Info;
            this.label1.Location = new System.Drawing.Point(541, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 40);
            this.label1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.panel3.Controls.Add(this.button4);
            this.panel3.Controls.Add(this.button3);
            this.panel3.Controls.Add(this.button5);
            this.panel3.Controls.Add(this.button2);
            this.panel3.Location = new System.Drawing.Point(-1, 46);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1401, 65);
            this.panel3.TabIndex = 6;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Bahnschrift SemiLight Condensed", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(236)))));
            this.button4.Location = new System.Drawing.Point(352, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(345, 60);
            this.button4.TabIndex = 2;
            this.button4.Text = "Таблица результатов";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Bahnschrift SemiLight Condensed", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(236)))));
            this.button3.Location = new System.Drawing.Point(1055, 1);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(345, 60);
            this.button3.TabIndex = 4;
            this.button3.Text = "О приложении*";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Bahnschrift SemiLight Condensed", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(236)))));
            this.button5.Location = new System.Drawing.Point(704, 3);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(345, 60);
            this.button5.TabIndex = 3;
            this.button5.Text = "Настройки";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Bahnschrift SemiLight Condensed", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(236)))));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(0, 1);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(345, 60);
            this.button2.TabIndex = 0;
            this.button2.Text = "Пройти тест";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // settingsUsControl1
            // 
            this.settingsUsControl1.BackColor = System.Drawing.Color.Transparent;
            this.settingsUsControl1.Location = new System.Drawing.Point(152, 155);
            this.settingsUsControl1.Name = "settingsUsControl1";
            this.settingsUsControl1.Size = new System.Drawing.Size(1205, 581);
            this.settingsUsControl1.TabIndex = 9;
            this.settingsUsControl1.Visible = false;
            // 
            // passTheTestUsControl1
            // 
            this.passTheTestUsControl1.BackColor = System.Drawing.Color.Transparent;
            this.passTheTestUsControl1.Location = new System.Drawing.Point(132, 169);
            this.passTheTestUsControl1.Name = "passTheTestUsControl1";
            this.passTheTestUsControl1.Size = new System.Drawing.Size(1216, 590);
            this.passTheTestUsControl1.TabIndex = 7;
            this.passTheTestUsControl1.Visible = false;
            // 
            // aboutProgramUsControl1
            // 
            this.aboutProgramUsControl1.BackColor = System.Drawing.Color.Transparent;
            this.aboutProgramUsControl1.Location = new System.Drawing.Point(134, 127);
            this.aboutProgramUsControl1.Name = "aboutProgramUsControl1";
            this.aboutProgramUsControl1.Size = new System.Drawing.Size(1216, 632);
            this.aboutProgramUsControl1.TabIndex = 8;
            // 
            // resultsUsControl1
            // 
            this.resultsUsControl1.BackColor = System.Drawing.Color.Transparent;
            this.resultsUsControl1.Location = new System.Drawing.Point(127, 133);
            this.resultsUsControl1.Name = "resultsUsControl1";
            this.resultsUsControl1.Size = new System.Drawing.Size(1160, 581);
            this.resultsUsControl1.TabIndex = 10;
            this.resultsUsControl1.Visible = false;
            // 
            // Testingcards
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1400, 820);
            this.Controls.Add(this.settingsUsControl1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.passTheTestUsControl1);
            this.Controls.Add(this.aboutProgramUsControl1);
            this.Controls.Add(this.resultsUsControl1);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1400, 820);
            this.MinimumSize = new System.Drawing.Size(1400, 820);
            this.Name = "Testingcards";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Testingcards";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button5;
        public System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private PassTheTestUsControl passTheTestUsControl1;
        private AboutProgramUsControl aboutProgramUsControl1;
        private SettingsUsControl settingsUsControl1;
        private ResultsUsControl resultsUsControl1;
    }
}