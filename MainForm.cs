using System;
using System.Drawing;
using System.Windows.Forms;

namespace FindACouple
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private void OnTextBoxEnter(object sender, EventArgs e)
        {
            TextBox sndTextBox = sender as TextBox;
            if (sndTextBox != null)
            {
                if (sndTextBox.Text.Equals((string)sndTextBox.Tag))
                {
                    sndTextBox.Text = "";
                }
                sndTextBox.ForeColor = Color.Black;
            }
        }
        private void OnTextBoxLeave(object sender, EventArgs e)
        {
            TextBox sndTextBox = sender as TextBox;
            if (sndTextBox != null)
            {
                if (sndTextBox.Text.Equals(""))
                {
                    sndTextBox.ForeColor = Color.Gray;
                    sndTextBox.Text = (string)sndTextBox.Tag;
                }
            }
        }

        private void acceptButton_Click(object sender, EventArgs e)

        {
            if (!nameTextBox.Text.Equals(nameTextBox.Tag) &&
               (!nameTextBox.Text.Equals("")) &&
               (!surnameTextBox.Text.Equals(surnameTextBox.Tag)) &&
               (!surnameTextBox.Text.Equals("")))
            {
                Form gameForm = new GameForm(nameTextBox.Text, surnameTextBox.Text);
                gameForm.Left = Left;
                gameForm.Top = Top;
                gameForm.Show();
                Hide();
            }
            else
            {
                MessageBox.Show("Вы не ввели данные!", "Предупреждение");
            }
        }

        private void ratingButton_Click(object sender, EventArgs e)
        {
            Form ratingForm = new Rating();
            ratingForm.Left = Left;
            ratingForm.Top = Top;
            ratingForm.Show();
            Hide();
        }
    }
}
