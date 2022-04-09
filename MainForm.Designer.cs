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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.attentionLabel = new System.Windows.Forms.Label();
            this.acceptButton = new System.Windows.Forms.Button();
            this.panelForLabel = new System.Windows.Forms.Panel();
            this.panelForName = new System.Windows.Forms.Panel();
            this.ratingButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.infoButton = new System.Windows.Forms.Button();
            this.panelForLabel.SuspendLayout();
            this.panelForName.SuspendLayout();
            this.SuspendLayout();
            // 
            // nameTextBox
            // 
            this.nameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nameTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nameTextBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameTextBox.ForeColor = System.Drawing.Color.Gray;
            this.nameTextBox.Location = new System.Drawing.Point(1, 1);
            this.nameTextBox.MaxLength = 15;
            this.nameTextBox.Multiline = true;
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(201, 28);
            this.nameTextBox.TabIndex = 0;
            this.nameTextBox.Tag = "Никнейм";
            this.nameTextBox.Text = "Никнейм";
            this.nameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nameTextBox.Enter += new System.EventHandler(this.OnTextBoxEnter);
            this.nameTextBox.Leave += new System.EventHandler(this.OnTextBoxLeave);
            // 
            // attentionLabel
            // 
            this.attentionLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.attentionLabel.AutoSize = true;
            this.attentionLabel.Font = new System.Drawing.Font("Impact", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.attentionLabel.Location = new System.Drawing.Point(74, 9);
            this.attentionLabel.Name = "attentionLabel";
            this.attentionLabel.Size = new System.Drawing.Size(347, 42);
            this.attentionLabel.TabIndex = 2;
            this.attentionLabel.Text = "Введите ваш никнейм";
            this.attentionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // acceptButton
            // 
            this.acceptButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.acceptButton.AutoSize = true;
            this.acceptButton.BackColor = System.Drawing.Color.Yellow;
            this.acceptButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.acceptButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.acceptButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.acceptButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.acceptButton.Font = new System.Drawing.Font("Impact", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.acceptButton.Location = new System.Drawing.Point(81, 256);
            this.acceptButton.Name = "acceptButton";
            this.acceptButton.Size = new System.Drawing.Size(360, 65);
            this.acceptButton.TabIndex = 3;
            this.acceptButton.Text = "Играть";
            this.acceptButton.UseVisualStyleBackColor = false;
            this.acceptButton.Click += new System.EventHandler(this.acceptButton_Click);
            // 
            // panelForLabel
            // 
            this.panelForLabel.BackColor = System.Drawing.Color.Transparent;
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
            this.panelForName.Location = new System.Drawing.Point(152, 170);
            this.panelForName.Name = "panelForName";
            this.panelForName.Padding = new System.Windows.Forms.Padding(1);
            this.panelForName.Size = new System.Drawing.Size(203, 30);
            this.panelForName.TabIndex = 5;
            // 
            // ratingButton
            // 
            this.ratingButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ratingButton.AutoSize = true;
            this.ratingButton.BackColor = System.Drawing.Color.Yellow;
            this.ratingButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ratingButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ratingButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.ratingButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.ratingButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ratingButton.Font = new System.Drawing.Font("Impact", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ratingButton.Location = new System.Drawing.Point(81, 327);
            this.ratingButton.Name = "ratingButton";
            this.ratingButton.Size = new System.Drawing.Size(360, 45);
            this.ratingButton.TabIndex = 7;
            this.ratingButton.Text = "Рейтинг";
            this.ratingButton.UseVisualStyleBackColor = false;
            this.ratingButton.Click += new System.EventHandler(this.ratingButton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // infoButton
            // 
            this.infoButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.infoButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.infoButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.infoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.infoButton.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.infoButton.Location = new System.Drawing.Point(81, 378);
            this.infoButton.Name = "infoButton";
            this.infoButton.Size = new System.Drawing.Size(360, 45);
            this.infoButton.TabIndex = 8;
            this.infoButton.Text = "О разработчике";
            this.infoButton.UseVisualStyleBackColor = true;
            this.infoButton.Click += new System.EventHandler(this.infoButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(510, 450);
            this.Controls.Add(this.infoButton);
            this.Controls.Add(this.ratingButton);
            this.Controls.Add(this.panelForName);
            this.Controls.Add(this.panelForLabel);
            this.Controls.Add(this.acceptButton);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Find A Couple!";
            this.panelForLabel.ResumeLayout(false);
            this.panelForLabel.PerformLayout();
            this.panelForName.ResumeLayout(false);
            this.panelForName.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label attentionLabel;
        private System.Windows.Forms.Button acceptButton;
        private System.Windows.Forms.Panel panelForLabel;
        private System.Windows.Forms.Panel panelForName;
        private System.Windows.Forms.Button ratingButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button infoButton;
    }
}

