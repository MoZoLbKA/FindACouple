using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FindACouple
{
    public partial class InfoForm : Form
    {
        public InfoForm()
        {
            InitializeComponent();
            pictureBox1.Image = new Bitmap(Properties.Resources.flaticon__1_);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox2.Image= new Bitmap(Properties.Resources.vk);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void InfoForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form ifrm = Application.OpenForms[0];
            ifrm.StartPosition = FormStartPosition.CenterScreen;
            ifrm.Left = Left;
            ifrm.Top = Top;
            ifrm.Show();
        }
        private void OpenUrl(string url)
        {
            try
            {
                Process.Start(url);
            }
            catch
            {
                
                if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
                {
                    url = url.Replace("&", "^&");
                    Process.Start(new ProcessStartInfo(url) { UseShellExecute = true });
                }
                else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
                {
                    Process.Start("xdg-open", url);
                }
                else if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
                {
                    Process.Start("open", url);
                }
                else
                {
                    throw;
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenUrl("https://www.flaticon.com/ru/authors/jesus-chavarria");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            OpenUrl("https://vk.com/m0zolbka");
        }
    }
}
