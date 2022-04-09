using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FindACouple
{
    public partial class Rating : Form
    {
        public Rating()
        {
            InitializeComponent();
        }

        private void Rating_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form ifrm = Application.OpenForms[0];
            ifrm.StartPosition = FormStartPosition.CenterScreen;
            ifrm.Left = Left;
            ifrm.Top = Top;
            ifrm.Show();
        }

        private void Rating_Load(object sender, EventArgs e)
        {
            UploadDataFromDB();
        }

        private void UploadDataFromDB()
        {
            try
            {
                SQLiteConnection con = new SQLiteConnection("Data Source=FindACouple.db;Version=3;");
                con.Open();
                SQLiteCommand cmd = new SQLiteCommand("SELECT * FROM rating", con);
                
                SQLiteDataReader dr;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    tableRatingDataGrid.Rows.Add(dr[1].ToString(), Math.Round((double)dr[2],2));               
                }
                con.Close();
            }
            catch
            {

            }
            
        }
    }
}
