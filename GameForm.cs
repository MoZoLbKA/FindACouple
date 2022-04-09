using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Drawing;
using System.Collections;
using System.Threading;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace FindACouple
{
    public partial class GameForm : Form
    {       
        public GameForm(string text1, string text2)
        {
            this.name = text1;
            this.surname = text2;
            InitializeComponent();
            timerForGame.Start();
            openImages = 0;
            loadPicture = new List<PictureBox>()
            {
                pictureBox1,pictureBox2,pictureBox3,pictureBox4,pictureBox5,pictureBox6,pictureBox7, pictureBox8, pictureBox9,
                pictureBox10,pictureBox11,pictureBox12,pictureBox13, pictureBox14,pictureBox15, pictureBox16,pictureBox17,
                pictureBox18, pictureBox19,pictureBox20,pictureBox21, pictureBox22,pictureBox23, pictureBox24, pictureBox25,
                pictureBox26,  pictureBox27,pictureBox28,pictureBox29,pictureBox30, pictureBox31, pictureBox32,pictureBox33,
                pictureBox34, pictureBox35,pictureBox36,
            };
        }

        int timerCount;
        List<Picture> pictureList = new List<Picture>();
        List<PictureBox> loadPicture;
        int openImages;
        Predicate<PictureBox> predicate = CheckOpenPictures;
        private string name;
        private string surname;

        private void GameForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            timerForGame.Stop();
            timerForGame.Dispose();
            Form ifrm = Application.OpenForms[0];
            ifrm.StartPosition = FormStartPosition.CenterScreen;
            ifrm.Left = Left;
            ifrm.Top = Top;
            ifrm.Show();
        }
        private void Shuffle()
        {
            Random r = new Random();
            int randomInd;
            for (int i = 0; i < pictureList.Count; i++)
            {         
                randomInd = r.Next(pictureList.Count);
                var tmp = pictureList[i];
                pictureList[i] = pictureList[randomInd];
                pictureList[randomInd] = tmp;
            }

        }

        private void timerForGame_Tick(object sender, EventArgs e)
        {


            labelForTime.Text = (++timerCount).ToString();
        }
        private void LoadToPictureBoxes()
        {
            for (int i = 0; i < loadPicture.Count; i++)
            {
                loadPicture[i].SizeMode = PictureBoxSizeMode.Normal;
                loadPicture[i].Image = pictureList[i].Image;
                loadPicture[i].Tag = pictureList[i].Id;                             
                loadPicture[i].Click += new EventHandler(PictureBox_Click);
            }
        }
        

        private static bool CheckOpenPictures(PictureBox obj)
        {
            if(obj.SizeMode == PictureBoxSizeMode.StretchImage)
            {
                return true;
            }
            return false;
        }
        private bool CheckTags(PictureBox box1,PictureBox box2)
        {
            if (box1.Tag.Equals(box2.Tag))
            {
                return true;
            }
            return false;
        }
        private void OpenRightImages(PictureBox box1,PictureBox box2)
        {
            box1.Click -= PictureBox_Click;
            box2.Click -= PictureBox_Click;
            loadPicture.Remove(box1);
            loadPicture.Remove(box2);
            box1.BackColor = Color.LimeGreen;
            box2.BackColor = Color.LimeGreen;
            openImages = 0;
        }
        private void CloseWrongImages(PictureBox box1, PictureBox box2)
        {
            box1.BackColor = Color.Red;
            box2.BackColor = Color.Red;
            Update();
            Thread.Sleep(1000);
            box1.BackColor = Color.Yellow;
            box2.BackColor = Color.Yellow;
            box1.SizeMode = PictureBoxSizeMode.Normal;
            box2.SizeMode = PictureBoxSizeMode.Normal;
            openImages = 0;
        }
        private void PictureBox_Click(object sender,EventArgs e)
        {
            
            PictureBox cur = sender as PictureBox;
            if (!CheckOpenPictures(cur))
            {
                cur.BackColor = Color.Yellow;
                cur.SizeMode = PictureBoxSizeMode.StretchImage;
                cur.Update();
                openImages++;
            }
            if (openImages == 2)
            {
                var array = Array.FindAll(loadPicture.ToArray(), predicate);
                if (CheckTags(array[0], array[1]))
                {
                   OpenRightImages(array[0], array[1]);
                    
                }
                else
                {
                    CloseWrongImages(array[0], array[1]);

                }
                
            }
            if (loadPicture.Count == 0)
            {
                timerForGame.Stop();
                SaveRecord();
                ChangeToDefaultColorWithDelay();
                MessageBox.Show("Ура");
            }
        }

        private void SaveRecord()
        {
            Player player = new Player();
        }

        private void GameForm_Load(object sender, EventArgs e)
        {
            LoadImageToList();
            //Shuffle();
            LoadToPictureBoxes();
        }
        private void ChangeToDefaultColorWithDelay()//для красоты(необязательный метод)
        {
            Update();
            Thread.Sleep(150);
            loadPicture = new List<PictureBox>()
            {
                pictureBox1,pictureBox2,pictureBox3,pictureBox4,pictureBox5,pictureBox6,pictureBox7, pictureBox8, pictureBox9,
                pictureBox10,pictureBox11,pictureBox12,pictureBox13, pictureBox14,pictureBox15, pictureBox16,pictureBox17,
                pictureBox18, pictureBox19,pictureBox20,pictureBox21, pictureBox22,pictureBox23, pictureBox24, pictureBox25,
                pictureBox26,  pictureBox27,pictureBox28,pictureBox29,pictureBox30, pictureBox31, pictureBox32,pictureBox33,
                pictureBox34, pictureBox35,pictureBox36,
            };
            for (int i = 0; i < loadPicture.Count; i++)
            {
                loadPicture[i].BackColor = Color.Yellow;
                Thread.Sleep(60);
                Update();
            }
        }
        private void LoadImageToList()
        {
            try
            {


                using (SQLiteConnection con = new SQLiteConnection("Data Source=FindACouple.db;Version=3;"))
                {
                    SQLiteCommand cmd = new SQLiteCommand("SELECT images FROM images", con);
                    con.Open();
                    SQLiteDataReader dr;
                    dr = cmd.ExecuteReader();
                    int id = 0;
                    while (dr.Read())
                    {
                        if (!dr.IsDBNull(0))
                        {
                            byte[] im = (byte[])dr["images"];
                            MemoryStream ms = new MemoryStream(im);
                            pictureList.Add(new Picture(Image.FromStream(ms), id++));
                        }
                        else
                        {
                            pictureBox1.Image = null;
                        }
                    }
                    con.Close();
                }
                pictureList.AddRange(pictureList);

            }
            catch
            {
                MessageBox.Show("");
            }
        }
    }
}
