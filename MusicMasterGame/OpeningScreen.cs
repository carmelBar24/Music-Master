using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicMasterGame
{
    public partial class OpeningScreen : Form
    {
        bool langHelp = false;
        Manager m;
        int points = 0;
        private bool changeColor;
        HelpForm h;
        public OpeningScreen()
        {
            InitializeComponent();
            this.changeColor = true;
            this.m = new Manager();
            h = new HelpForm(langHelp);
        }

        public HelpForm Playlist
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public Manager Manager
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        private void OpeningScreen_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox17_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void Helpbutton_Click_1(object sender, EventArgs e)
        {
            h = new HelpForm(langHelp);//בעזרת לחיצה על הכפתור המשתמש מופנה לעמוד עזרה
            h.Show();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {       if (StartButton.Text == "Start game")  //בלחיצה על כפתור זה המשתמש מגיע אל מסך
                                                      // הפלייליסטים בו בוחר באיזה סגנון רוצה לשחק 
            {
              
                Playlist p = new Playlist(points,false,false,m);//יצירת פלייליסט חדש באנגלית
                p.Show();
            }
            else
            {
                
                Playlist p = new Playlist(points, true,false,m);// יצירת פלייליסט חדש בעברית
                p.Show();
            }

        }

        

       

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close() ;//סגירת המשחק
        }

        private void ColorChange_Click_1(object sender, EventArgs e)
        {
            //פעולה המשנה את צבע הפורם משחוק לאפור כחול ולהפך
            

            if (changeColor == true)
            {
                this.BackColor = System.Drawing.Color.LightBlue;
                changeColor = false;
            }
            else
            {
                this.BackColor = System.Drawing.Color.Black;
                changeColor = true;
            }

            
        }

       

        private void LangChange_Click_1(object sender, EventArgs e)
        {  //המשתמש יכול לבחור האם רוצה
            //לשחק בעברית/באנגלית,כל הממשק משתנה ובנוסף גם השירים שבמשחק לפי השפה.
            if (LangChange.Text == "you can play also in english!")
            {
                LangChange.Text = "אתה יכול לשחק גם בעברית!";
                StartButton.Text = "Start game";
                Helpbutton.Text = "Help";
                ExitButton.Text = "Exit";
                langHelp = false;
               
                
            }
            else
            {
                m.newGame(StartButton, Helpbutton, ExitButton);
                LangChange.Text = "you can play also in english!";
                langHelp = true;
                
            }

        }
    }
}
