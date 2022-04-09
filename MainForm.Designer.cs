namespace FindACouple
{
    partial class MainForm
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.surnameTextBox = new System.Windows.Forms.TextBox();
            this.attentionLabel = new System.Windows.Forms.Label();
            this.acceptButton = new System.Windows.Forms.Button();
            this.panelForLabel = new System.Windows.Forms.Panel();
            this.panelForName = new System.Windows.Forms.Panel();
            this.panelForSurname = new System.Windows.Forms.Panel();
            this.ratingButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panelForLabel.SuspendLayout();
            this.panelForName.SuspendLayout();
            this.panelForSurname.SuspendLayout();
            this.SuspendLayout();
            // 
            // nameTextBox
            // 
            this.nameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nameTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nameTextBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameTextBox.ForeColor = System.Drawing.Color.Gray;
            this.nameTextBox.Location = new System.Drawing.Point(1, 1);
            this.nameTextBox.Multiline = true;
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(201, 38);
            this.nameTextBox.TabIndex = 0;
            this.nameTextBox.Tag = "Имя";
            this.nameTextBox.Text = "Имя";
            this.nameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nameTextBox.Enter += new System.EventHandler(this.OnTextBoxEnter);
            this.nameTextBox.Leave += new System.EventHandler(this.OnTextBoxLeave);
            // 
            // surnameTextBox
            // 
            this.surnameTextBox.AcceptsReturn = true;
            this.surnameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.surnameTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.surnameTextBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.surnameTextBox.ForeColor = System.Drawing.Color.Gray;
            this.surnameTextBox.Location = new System.Drawing.Point(1, 1);
            this.surnameTextBox.Multiline = true;
            this.surnameTextBox.Name = "surnameTextBox";
            this.surnameTextBox.Size = new System.Drawing.Size(198, 36);
            this.surnameTextBox.TabIndex = 1;
            this.surnameTextBox.Tag = "Фамилия";
            this.surnameTextBox.Text = "Фамилия";
            this.surnameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.surnameTextBox.Enter += new System.EventHandler(this.OnTextBoxEnter);
            this.surnameTextBox.Leave += new System.EventHandler(this.OnTextBoxLeave);
            // 
            // attentionLabel
            // 
            this.attentionLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.attentionLabel.AutoSize = true;
            this.attentionLabel.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.attentionLabel.Location = new System.Drawing.Point(74, 15);
            this.attentionLabel.Name = "attentionLabel";
            this.attentionLabel.Size = new System.Drawing.Size(383, 35);
            this.attentionLabel.TabIndex = 2;
            this.attentionLabel.Text = "Введите имя и фамилию";
            this.attentionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            
            // 
            // acceptButton
            // 
            this.acceptButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.acceptButton.AutoSize = true;
            this.acceptButton.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.acceptButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.acceptButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.acceptButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.acceptButton.Font = new System.Drawing.Font("Arial Black", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.acceptButton.Location = new System.Drawing.Point(80, 289);
            this.acceptButton.Name = "acceptButton";
            this.acceptButton.Size = new System.Drawing.Size(360, 65);
            this.acceptButton.TabIndex = 3;
            this.acceptButton.Text = "Играть";
            this.acceptButton.UseVisualStyleBackColor = true;
            this.acceptButton.Click += new System.EventHandler(this.acceptButton_Click);
            // 
            // panelForLabel
            // 
            this.panelForLabel.Controls.Add(this.attentionLabel);
            this.panelForLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelForLabel.Location = new System.Drawing.Point(0, 0);
            this.panelForLabel.Name = "panelForLabel";
            this.panelForLabel.Size = new System.Drawing.Size(510, 65);
            this.panelForLabel.TabIndex = 4;
            // 
            // panelForName
            // 
            this.panelForName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelForName.AutoSize = true;
            this.panelForName.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panelForName.Controls.Add(this.nameTextBox);
            this.panelForName.Location = new System.Drawing.Point(151, 148);
            this.panelForName.Name = "panelForName";
            this.panelForName.Padding = new System.Windows.Forms.Padding(1);
            this.panelForName.Size = new System.Drawing.Size(203, 40);
            this.panelForName.TabIndex = 5;
            // 
            // panelForSurname
            // 
            this.panelForSurname.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelForSurname.AutoSize = true;
            this.panelForSurname.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panelForSurname.Controls.Add(this.surnameTextBox);
            this.panelForSurname.Location = new System.Drawing.Point(151, 228);
            this.panelForSurname.Name = "panelForSurname";
            this.panelForSurname.Padding = new System.Windows.Forms.Padding(1);
            this.panelForSurname.Size = new System.Drawing.Size(200, 38);
            this.panelForSurname.TabIndex = 6;
            // 
            // ratingButton
            // 
            this.ratingButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ratingButton.AutoSize = true;
            this.ratingButton.FlatAppearance.BorderColor = System.Drawing.Color.Crimson;
            this.ratingButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ratingButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ratingButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ratingButton.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ratingButton.Location = new System.Drawing.Point(80, 374);
            this.ratingButton.Name = "ratingButton";
            this.ratingButton.Size = new System.Drawing.Size(360, 45);
            this.ratingButton.TabIndex = 7;
            this.ratingButton.Text = "Рейтинг";
            this.ratingButton.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(510, 450);
            this.Controls.Add(this.ratingButton);
            this.Controls.Add(this.panelForSurname);
            this.Controls.Add(this.panelForName);
            this.Controls.Add(this.panelForLabel);
            this.Controls.Add(this.acceptButton);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Регистрация";
            this.panelForLabel.ResumeLayout(false);
            this.panelForLabel.PerformLayout();
            this.panelForName.ResumeLayout(false);
            this.panelForName.PerformLayout();
            this.panelForSurname.ResumeLayout(false);
            this.panelForSurname.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox surnameTextBox;
        private System.Windows.Forms.Label attentionLabel;
        private System.Windows.Forms.Button acceptButton;
        private System.Windows.Forms.Panel panelForLabel;
        private System.Windows.Forms.Panel panelForName;
        private System.Windows.Forms.Panel panelForSurname;
        private System.Windows.Forms.Button ratingButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

