namespace Testing
{
    partial class PassTheTestUsControl
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Pass_the_test = new System.Windows.Forms.Button();
            this.ListOfTopics = new System.Windows.Forms.ListBox();
            this.Level = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiLight Condensed", 18F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(335, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Выберите категорию";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift SemiLight Condensed", 18F);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(698, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(199, 36);
            this.label2.TabIndex = 2;
            this.label2.Text = "Выберите уровень";
            // 
            // Pass_the_test
            // 
            this.Pass_the_test.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.Pass_the_test.FlatAppearance.BorderSize = 0;
            this.Pass_the_test.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Pass_the_test.Font = new System.Drawing.Font("Bahnschrift SemiLight Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Pass_the_test.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(236)))));
            this.Pass_the_test.Location = new System.Drawing.Point(247, 390);
            this.Pass_the_test.Name = "Pass_the_test";
            this.Pass_the_test.Size = new System.Drawing.Size(650, 58);
            this.Pass_the_test.TabIndex = 5;
            this.Pass_the_test.Text = "Пройти тест";
            this.Pass_the_test.UseVisualStyleBackColor = false;
            this.Pass_the_test.Click += new System.EventHandler(this.Pass_the_test_Click);
            // 
            // ListOfTopics
            // 
            this.ListOfTopics.BackColor = System.Drawing.SystemColors.Control;
            this.ListOfTopics.Font = new System.Drawing.Font("Bahnschrift SemiLight Condensed", 14F);
            this.ListOfTopics.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ListOfTopics.FormattingEnabled = true;
            this.ListOfTopics.ItemHeight = 28;
            this.ListOfTopics.Location = new System.Drawing.Point(247, 131);
            this.ListOfTopics.Name = "ListOfTopics";
            this.ListOfTopics.Size = new System.Drawing.Size(397, 228);
            this.ListOfTopics.TabIndex = 6;
            // 
            // Level
            // 
            this.Level.BackColor = System.Drawing.SystemColors.Control;
            this.Level.Font = new System.Drawing.Font("Bahnschrift SemiLight Condensed", 14F);
            this.Level.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Level.FormattingEnabled = true;
            this.Level.ItemHeight = 28;
            this.Level.Location = new System.Drawing.Point(690, 243);
            this.Level.Name = "Level";
            this.Level.Size = new System.Drawing.Size(214, 116);
            this.Level.TabIndex = 7;
            // 
            // PassTheTestUsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.Level);
            this.Controls.Add(this.ListOfTopics);
            this.Controls.Add(this.Pass_the_test);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "PassTheTestUsControl";
            this.Size = new System.Drawing.Size(1145, 612);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Button Pass_the_test;
        private System.Windows.Forms.ListBox ListOfTopics;
        private System.Windows.Forms.ListBox Level;
    }
}
