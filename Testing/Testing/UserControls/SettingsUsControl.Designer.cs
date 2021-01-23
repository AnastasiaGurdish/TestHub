namespace Testing
{
    partial class SettingsUsControl
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
            this.DeleteA = new System.Windows.Forms.Button();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.ChangeName = new System.Windows.Forms.Label();
            this.LastnameBox = new System.Windows.Forms.TextBox();
            this.PasswordBox = new System.Windows.Forms.TextBox();
            this.Lastname = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.Label();
            this.UpdateA = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DeleteA
            // 
            this.DeleteA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.DeleteA.FlatAppearance.BorderSize = 0;
            this.DeleteA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteA.Font = new System.Drawing.Font("Bahnschrift SemiLight Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteA.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(236)))));
            this.DeleteA.Location = new System.Drawing.Point(629, 430);
            this.DeleteA.Name = "DeleteA";
            this.DeleteA.Size = new System.Drawing.Size(390, 80);
            this.DeleteA.TabIndex = 9;
            this.DeleteA.Text = "Удалить аккаунт";
            this.DeleteA.UseVisualStyleBackColor = false;
            this.DeleteA.Click += new System.EventHandler(this.DeleteA_Click);
            // 
            // NameBox
            // 
            this.NameBox.BackColor = System.Drawing.SystemColors.Control;
            this.NameBox.Font = new System.Drawing.Font("Bahnschrift SemiLight Condensed", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameBox.Location = new System.Drawing.Point(369, 81);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(390, 40);
            this.NameBox.TabIndex = 0;
            this.NameBox.TextChanged += new System.EventHandler(this.NameBox_TextChanged);
            // 
            // ChangeName
            // 
            this.ChangeName.AutoSize = true;
            this.ChangeName.BackColor = System.Drawing.Color.Transparent;
            this.ChangeName.Font = new System.Drawing.Font("Bahnschrift SemiLight Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChangeName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ChangeName.Location = new System.Drawing.Point(486, 42);
            this.ChangeName.Name = "ChangeName";
            this.ChangeName.Size = new System.Drawing.Size(149, 36);
            this.ChangeName.TabIndex = 1;
            this.ChangeName.Text = "Сменить имя :";
            this.ChangeName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LastnameBox
            // 
            this.LastnameBox.BackColor = System.Drawing.SystemColors.Control;
            this.LastnameBox.Font = new System.Drawing.Font("Bahnschrift SemiLight Condensed", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LastnameBox.Location = new System.Drawing.Point(369, 205);
            this.LastnameBox.Name = "LastnameBox";
            this.LastnameBox.Size = new System.Drawing.Size(390, 40);
            this.LastnameBox.TabIndex = 2;
            this.LastnameBox.TextChanged += new System.EventHandler(this.LastnameBox_TextChanged);
            // 
            // PasswordBox
            // 
            this.PasswordBox.BackColor = System.Drawing.SystemColors.Control;
            this.PasswordBox.Font = new System.Drawing.Font("Bahnschrift SemiLight Condensed", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PasswordBox.Location = new System.Drawing.Point(369, 317);
            this.PasswordBox.Name = "PasswordBox";
            this.PasswordBox.Size = new System.Drawing.Size(390, 40);
            this.PasswordBox.TabIndex = 3;
            this.PasswordBox.TextChanged += new System.EventHandler(this.PasswordBox_TextChanged);
            // 
            // Lastname
            // 
            this.Lastname.AutoSize = true;
            this.Lastname.BackColor = System.Drawing.Color.Transparent;
            this.Lastname.Font = new System.Drawing.Font("Bahnschrift SemiLight Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Lastname.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Lastname.Location = new System.Drawing.Point(467, 166);
            this.Lastname.Name = "Lastname";
            this.Lastname.Size = new System.Drawing.Size(207, 36);
            this.Lastname.TabIndex = 4;
            this.Lastname.Text = "Сменить фамилию :";
            this.Lastname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.BackColor = System.Drawing.Color.Transparent;
            this.Password.Font = new System.Drawing.Font("Bahnschrift SemiLight Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Password.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Password.Location = new System.Drawing.Point(477, 278);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(183, 36);
            this.Password.TabIndex = 5;
            this.Password.Text = "Сменить пароль :";
            this.Password.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UpdateA
            // 
            this.UpdateA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.UpdateA.FlatAppearance.BorderSize = 0;
            this.UpdateA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateA.Font = new System.Drawing.Font("Bahnschrift SemiLight Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UpdateA.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(236)))));
            this.UpdateA.Location = new System.Drawing.Point(107, 430);
            this.UpdateA.Name = "UpdateA";
            this.UpdateA.Size = new System.Drawing.Size(390, 80);
            this.UpdateA.TabIndex = 8;
            this.UpdateA.Text = "Обновить аккаунт";
            this.UpdateA.UseVisualStyleBackColor = false;
            this.UpdateA.Click += new System.EventHandler(this.UpdateA_Click);
            // 
            // SettingsUsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.UpdateA);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.DeleteA);
            this.Controls.Add(this.Lastname);
            this.Controls.Add(this.PasswordBox);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.LastnameBox);
            this.Controls.Add(this.ChangeName);
            this.Name = "SettingsUsControl";
            this.Size = new System.Drawing.Size(1145, 600);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DeleteA;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.Label ChangeName;
        private System.Windows.Forms.TextBox LastnameBox;
        private System.Windows.Forms.TextBox PasswordBox;
        private System.Windows.Forms.Label Lastname;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.Button UpdateA;
    }
}
