using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicMasterGame
{
    public partial class WinnersGame : Form
    {
        int level=1;
        int timeLeft = 80;
        SoundPlayer song = null;
        bool b = false;
        Manager m;
        Playlist p;
        bool lang;
        int counter = 0;
        public WinnersGame(bool check,Manager m)
        {
            InitializeComponent();
            lang = check;
            this.m = m;
            WinnersTimer.Enabled = false;
          
            
        }



        private void PlayMusic_Click(object sender, EventArgs e)
        {
            //מתנגן שיר באופן רנדומלי אשר את שמו המשחק צריך לרשום.
            //הישירם הם גם בעברית וגם באנגלית
            if (b==false) 
            song=m.PlayWinnerRandomSong("others");
            if (b == true)
            song.Play();
            WinnersTimer.Enabled = true;
            b = true;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void CheckButton_Click(object sender, EventArgs e)
        {// בדיקה האם שם השיר שרשם המתשתמש הוא השיר שמתנגן ומעבר לשלב הבא
            //במקרה והמשתמש הגיע לשלב 10 ועבר אותו,המשחק מודיע למשתמש כי הוא ניצח את המשחק וחוזר לפורם הראשי
            if (m.GetNumberSong() == 0)
            {
                if (MusicAnswer.Text == "איך אפשר שלא" || MusicAnswer.Text == "?איך אפשר שלא")
                {
                    m.StopSongs(CheckButton);
                    WinnersTimer.Enabled = false;
                    timeLeft = 80;
                    TimerGame.Text = timeLeft +" "+ "seconds";
                    MessageBox.Show("great!");
                    MusicAnswer.Text = "";
                    if(level<10)
                    level = level + 1;
                    LevelLabel.Text = "Level" + " " + level;
                    b = false;
                    m.HighLevel();
                    counter++;
                    if (counter == 10)
                    {
                        MessageBox.Show("You finish the game!", "Good job");
                        this.Close();
                    }

                }
                else
                {
                    MessageBox.Show("wrong!");
                    MusicAnswer.Text = " ";
                    b = true;
                    
                }


            }
            if (m.GetNumberSong() == 1)
            {
                if (MusicAnswer.Text == "ארץ חדשה")
                {
                    m.StopSongs(CheckButton);
                    WinnersTimer.Enabled = false;
                    timeLeft = 80;
                    TimerGame.Text = timeLeft +" "+ "seconds";
                    MessageBox.Show("great!");
                    MusicAnswer.Text = "";
                    if (level < 10)
                    level = level + 1;
                    LevelLabel.Text = "Level" + " " + level;
                    b = false;
                    m.HighLevel();
                    counter++;
                    if (counter == 10)
                    {
                        MessageBox.Show("You finish the game!", "Good job");
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("wrong!");
                    MusicAnswer.Text = "";
                    b = true;
                }

            }
            if (m.GetNumberSong() == 2)
            {
                if (MusicAnswer.Text == "היא כל כך יפה" || MusicAnswer.Text == "היא כלכך יפה")
                {
                    m.StopSongs(CheckButton);
                    WinnersTimer.Enabled = false;
                    timeLeft = 80;
                    TimerGame.Text = timeLeft +" "+ "seconds";
                    MessageBox.Show("great!");
                    MusicAnswer.Text = "";
                    if (level < 10)
                    level = level + 1;
                    LevelLabel.Text = "Level" + " " + level;
                    b = false;
                    m.HighLevel();
                    counter++;
                    if (counter == 10)
                    {
                        MessageBox.Show("You finish the game!", "Good job");
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("wrong!");
                    MusicAnswer.Text = "";
                    b = true;

                }

            }
            if (m.GetNumberSong() == 3)
            {
                if (MusicAnswer.Text == "יום אחד תבקשי")
                {
                    m.StopSongs(CheckButton);
                    WinnersTimer.Enabled = false;
                    timeLeft = 80;
                    TimerGame.Text = timeLeft +" "+ "seconds";
                    MessageBox.Show("great!");
                    MusicAnswer.Text = "";
                    if (level < 10)
                    level = level + 1;
                    LevelLabel.Text = "Level" +" "+ level;
                    b = false;
                    m.HighLevel();
                    counter++;
                    if (counter == 10)
                    {
                        MessageBox.Show("You finish the game!", "Good job");
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("wrong!");
                    MusicAnswer.Text = "";
                    b = true;

                }
            }

            if (m.GetNumberSong() == 4)
            {
                if (MusicAnswer.Text == "שישי בצהריים")
                { 
                    m.StopSongs(CheckButton);
                    WinnersTimer.Enabled = false;
                    timeLeft = 80;
                    TimerGame.Text = timeLeft +" "+ "seconds";
                    MessageBox.Show("great!");
                    MusicAnswer.Text = "";
                    if (level < 10)
                    level = level + 1;
                    LevelLabel.Text = "Level" + " " + level;
                    b = false;
                    m.HighLevel();
                    counter++;
                    if (counter == 10)
                    {
                        MessageBox.Show("You finish the game!", "Good job");
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("wrong!");
                    MusicAnswer.Text = "";
                    b = true;
                }

            }
            if (m.GetNumberSong() == 5)
            {
                if (MusicAnswer.Text == "Thinking about it"|| MusicAnswer.Text == "thinking about it")
                {
                    m.StopSongs(CheckButton);
                    WinnersTimer.Enabled = false;
                    timeLeft = 80;
                    TimerGame.Text = timeLeft +" "+ "seconds";
                    MessageBox.Show("great!");
                    MusicAnswer.Text = "";
                    if (level < 10)
                    level = level + 1;
                    LevelLabel.Text = "Level" + " " + level;
                    b = false;
                    m.HighLevel();
                    counter++;
                    if (counter == 10)
                    {
                        MessageBox.Show("You finish the game!", "Good job");
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("wrong!");
                    MusicAnswer.Text = "";
                    b = true;
                }

            }

            if (m.GetNumberSong() == 6)
            {
                if (MusicAnswer.Text == "Is this Love" || MusicAnswer.Text == "is this love")
                {
                    m.StopSongs(CheckButton);
                    WinnersTimer.Enabled = false;
                    timeLeft = 80;
                    TimerGame.Text = timeLeft +" "+ "seconds";
                    MessageBox.Show("great!");
                    MusicAnswer.Text = "";
                    if (level < 10)
                    level = level + 1;
                    LevelLabel.Text = "Level" + " " + level;
                    b = false;
                    m.HighLevel();
                    counter++;
                    if (counter == 10)
                    {
                        MessageBox.Show("You finish the game!", "Good job");
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("wrong!");
                    MusicAnswer.Text = "";
                    b = true;
                }

            }
            if (m.GetNumberSong() == 7)
            {
                if (MusicAnswer.Text == "Hello" || MusicAnswer.Text == "hello")
                {
                    m.StopSongs(CheckButton);
                    WinnersTimer.Enabled = false;
                    timeLeft = 80;
                    TimerGame.Text = timeLeft +" "+ "seconds";
                    MessageBox.Show("great!");
                    MusicAnswer.Text = "";
                    if (level < 10)
                    level = level + 1;
                    LevelLabel.Text = "Level" + " " + level;
                    b = false;
                    m.HighLevel();
                    counter++;
                    if (counter == 10)
                    {
                        MessageBox.Show("You finish the game!", "Good job");
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("wrong!");
                    MusicAnswer.Text = "";
                    b = true;
                }

            }
            if (m.GetNumberSong() == 8)
            {
                if (MusicAnswer.Text == "Come as you are" || MusicAnswer.Text == "come as you are")
                {
                    m.StopSongs(CheckButton);
                    WinnersTimer.Enabled = false;
                    timeLeft = 80;
                    TimerGame.Text = timeLeft +" "+ "seconds";
                    MessageBox.Show("great!");
                    MusicAnswer.Text = "";
                    if (level < 10)
                    level = level + 1;
                    LevelLabel.Text = "Level" + " " + level;
                    b = false;
                    m.HighLevel();
                    counter++;
                    if (counter == 10)
                    {
                        MessageBox.Show("You finish the game!", "Good job");
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("wrong!");
                    MusicAnswer.Text = "";
                    b = true;
                }

            }
            if (m.GetNumberSong() == 9)
            {
                if (MusicAnswer.Text == "We will rock you" || MusicAnswer.Text == "we will rock you")
                {
                    m.StopSongs(CheckButton);
                    WinnersTimer.Enabled = false;
                    timeLeft = 80;
                    TimerGame.Text = timeLeft +" "+ "seconds";
                    MessageBox.Show("great!");
                    MusicAnswer.Text = "";
                    if (level < 10)
                    level = level + 1;
                    LevelLabel.Text = "Level" + " " + level;
                    b = false;
                    m.HighLevel();
                    counter++;
                    if (counter == 10)
                    {
                        MessageBox.Show("You finish the game!", "Good job");
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("wrong!");
                    MusicAnswer.Text = "";
                    b = true;
                }

            }

        }




        private void WinnersTimer_Tick(object sender, EventArgs e)
        { //פעולת השעון,כל עוד השניות לא יתאפסו הטיימר יורד ותעדכנת הכותרת במשחק בה רואה המשתמש כמה שניות נותר לו לסיום השלב 
            if (timeLeft > 0)
            {
                timeLeft = timeLeft - 1;
                TimerGame.Text = timeLeft + " "+" seconds";
            }
            else
            {//במקרה והשעון התאפס והמשתמש לא עבר את השלב הוא נפסל,הפואם נסגר ונפתח פורם הפלייליסטים מחדש.
                TimerGame.Text = "Time's up!";
                WinnersTimer.Enabled = false;
                MessageBox.Show("You didn't finish in time,you reach level"+level+"/10"+"\n"+"your best is level"+this.m.GetHigh()+"/10", "Sorry!");
                this.Close();
                p = new Playlist(m.GetPoints(),lang, true,this.m);
                p.Show();


            }
        }
        
        private void WinnersGame_Load_1(object sender, EventArgs e)
        {
            
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {//סוגר את הפורם וחוזר למסך הראשי
            this.Close();
            m.StopSongs(CheckButton);
            WinnersTimer.Enabled = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void HelpButton_Click(object sender, EventArgs e)
        {
           MessageBox.Show(m.WinnersHint());//עזרה הניתנת למשתמש על השיר התמנגן אותו צריך לנחש

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void helpWinners_Click(object sender, EventArgs e)//עהסבר למשתמש על משחק המנצחים
        {
            MessageBox.Show("במשחק המנצחים יופיעו בפנייך עשרה שירים בעברית ובאנגלית,עליך לרשום את שם השיר בכל פעם. בהצלחה!");
        }
    }
}
