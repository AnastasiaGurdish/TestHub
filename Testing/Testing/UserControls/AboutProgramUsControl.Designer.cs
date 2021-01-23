namespace Testing
{
    partial class AboutProgramUsControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutProgramUsControl));
            this.Picture = new System.Windows.Forms.PictureBox();
            this.AboutProgram = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Picture)).BeginInit();
            this.SuspendLayout();
            // 
            // Picture
            // 
            this.Picture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Picture.Image = ((System.Drawing.Image)(resources.GetObject("Picture.Image")));
            this.Picture.Location = new System.Drawing.Point(209, 314);
            this.Picture.Name = "Picture";
            this.Picture.Size = new System.Drawing.Size(731, 298);
            this.Picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Picture.TabIndex = 0;
            this.Picture.TabStop = false;
            // 
            // AboutProgram
            // 
            this.AboutProgram.BackColor = System.Drawing.SystemColors.Control;
            this.AboutProgram.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AboutProgram.Font = new System.Drawing.Font("Bahnschrift SemiLight Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AboutProgram.ForeColor = System.Drawing.SystemColors.ControlText;
            this.AboutProgram.Location = new System.Drawing.Point(83, 11);
            this.AboutProgram.Multiline = true;
            this.AboutProgram.Name = "AboutProgram";
            this.AboutProgram.ReadOnly = true;
            this.AboutProgram.Size = new System.Drawing.Size(969, 296);
            this.AboutProgram.TabIndex = 2;
            this.AboutProgram.Text = resources.GetString("AboutProgram.Text");
            this.AboutProgram.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // AboutProgramUsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.AboutProgram);
            this.Controls.Add(this.Picture);
            this.Name = "AboutProgramUsControl";
            this.Size = new System.Drawing.Size(1145, 710);
            ((System.ComponentModel.ISupportInitialize)(this.Picture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Picture;
        private System.Windows.Forms.TextBox AboutProgram;
    }
}
