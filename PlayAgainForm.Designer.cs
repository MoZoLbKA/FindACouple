namespace FindACouple
{
    partial class PlayAgainForm
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
            this.labelAttention = new System.Windows.Forms.Label();
            this.playAgainButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.labelForTime = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelAttention
            // 
            this.labelAttention.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelAttention.BackColor = System.Drawing.Color.Transparent;
            this.labelAttention.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAttention.Location = new System.Drawing.Point(100, 29);
            this.labelAttention.Name = "labelAttention";
            this.labelAttention.Size = new System.Drawing.Size(180, 34);
            this.labelAttention.TabIndex = 0;
            this.labelAttention.Text = "Ваше время:";
            // 
            // playAgainButton
            // 
            this.playAgainButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.playAgainButton.BackColor = System.Drawing.Color.Transparent;
            this.playAgainButton.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.playAgainButton.Location = new System.Drawing.Point(78, 114);
            this.playAgainButton.Name = "playAgainButton";
            this.playAgainButton.Size = new System.Drawing.Size(187, 42);
            this.playAgainButton.TabIndex = 1;
            this.playAgainButton.Text = "Играть снова!";
            this.playAgainButton.UseVisualStyleBackColor = false;
            this.playAgainButton.Click += new System.EventHandler(this.playAgainButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cancelButton.BackColor = System.Drawing.Color.Transparent;
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cancelButton.Location = new System.Drawing.Point(292, 114);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(201, 42);
            this.cancelButton.TabIndex = 2;
            this.cancelButton.Text = "Выход";
            this.cancelButton.UseVisualStyleBackColor = false;
            // 
            // labelForTime
            // 
            this.labelForTime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelForTime.Font = new System.Drawing.Font("Impact", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelForTime.Location = new System.Drawing.Point(347, 29);
            this.labelForTime.Name = "labelForTime";
            this.labelForTime.Size = new System.Drawing.Size(100, 23);
            this.labelForTime.TabIndex = 4;
            // 
            // PlayAgainForm
            // 
            this.AcceptButton = this.playAgainButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.BackgroundImage = global::FindACouple.Properties.Resources.free_icon_dragon_fruit_7257106;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(585, 207);
            this.Controls.Add(this.labelForTime);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.playAgainButton);
            this.Controls.Add(this.labelAttention);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PlayAgainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PlayAgainForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelAttention;
        private System.Windows.Forms.Button playAgainButton;
        private System.Windows.Forms.Button cancelButton;
        
        private System.Windows.Forms.Label labelForTime;
    }
}