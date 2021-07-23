using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Media;


namespace MusicMasterGame
{
    public partial class Game : Form
    {
        string st = "";
        int timeLeft = 60;
        int CountHintHelp = 0;
        int CountHelp50 = 0;
        int counter = 0;
        bool LangChange = false;
        Manager m;
        int points = 0;
       


        public Game(string playlist,bool b,int points,Manager m)
        {
           
            InitializeComponent();
            this.m = m;
            this.points = points;
            LangChange = b;
            st = playlist;
            m.PlayRandomSong(playlist);
            if (LangChange == false)
            {
                GamePoints.Text = this.points + " " + "points";
            }
            if (LangChange==true)
            {
                GamePoints.Text = this.points + " " + "נקודות";
            }
            m.SetPoints(points);
            if(LangChange==false)
            {
                BackButton.Text = "back to the page before";
            }
           
             if (LangChange==true)

            {
                GameTimer.Text =  "שניות"+ " " + timeLeft;
            }
       
            if (st == "Rap")
            {
                firstOption.Text = "Trap Queen";
                SecondOption.Text = "No Flex Zone"; 
                ThirdOption.Text = "Hot Nigga";
                FourOption.Text = "We dem boys";

            }
            if (st == "Pop")
            {
                firstOption.Text = "Closer"; 
                SecondOption.Text = "Heatnes"; 
                ThirdOption.Text = "Team";
                FourOption.Text = "Roar";

            }
            if (st == "Rock")
            {
                firstOption.Text = "How You Remined Me";
                SecondOption.Text = "Chop Suey";
                ThirdOption.Text = "Numb"; 
                FourOption.Text = " Californication"; 
            }
            if (st == "Edm")
            {
                firstOption.Text = "Tremor"; 
                SecondOption.Text = "Sectrets";
                ThirdOption.Text = "Animals";
                FourOption.Text = "Reload"; 

            }
            if (st == "Rap_hebrew")
            {
                firstOption.Text = "איציבאן";
                SecondOption.Text = "בור והעם הארץ";
                ThirdOption.Text = "באסים בבאגז";
                FourOption.Text = "מתוך הים";

            }
            if (st == "Edm_hebrew")
            {
                firstOption.Text ="הפיל המשוגע";
                SecondOption.Text = "חשמליה";
                ThirdOption.Text = "שיר היונה";
                FourOption.Text = "בובמבוקלאב";

            }
            if (st == "Rock_hebrew")
            {
                firstOption.Text = "אחלום לנצח";
                SecondOption.Text = "המשביר";
                ThirdOption.Text = "השמלה ממדריד";
                FourOption.Text = "אור הירח";

            }
            if (st == "Pop_hebrew")
            {
                firstOption.Text = "מתוק כשמרלי";
                SecondOption.Text = "עוד פעם פעם";
                ThirdOption.Text = "בא לה לרקוד";
                FourOption.Text = "קיץ";

            }

        }
         
    private void Game_Load(object sender, EventArgs e)
        {
            TimerGame.Enabled = true;
        }
         
    
    private void pictureBox1_Click(object sender, EventArgs e)
        {
           
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void label2_Click_1(object sender, EventArgs e)
        {




        }

        private void TimerGame_Tick(object sender, EventArgs e)
       {

            if (timeLeft > 0)
            {
                timeLeft = timeLeft - 1;
                if(LangChange == false)
                GameTimer.Text = timeLeft + " seconds";
                if (LangChange == true)
                    GameTimer.Text = "שניות" + " " + timeLeft;
            }
        
            else
            {
                //      If the user ran out of time, stop the timer, show
                //    a MessageBox, and fill in the answers.
                TimerGame.Stop();
                if (LangChange == false)
                {
                    GameTimer.Text = "Time's up!";
                    MessageBox.Show("You didn't finish in time.", "Sorry!");
                    this.Close();
                    Playlist p = new Playlist(m.GetPoints(), false,false,this.m);
                    p.Show();
                    
                }
                else
                {
                    GameTimer.Text = "!הזמן נגמר";
                    MessageBox.Show(".לא סיימת בזמן", "!סליחה");
                    this.Close();
                    Playlist p = new Playlist(m.GetPoints(), true,false,this.m);
                    p.Show();
                 
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
        
        }

      

        private void BackButton_Click(object sender, EventArgs e)
        {//סגירת הפורם הנוכחי וחזרה לעמוד הפלייליסטים בהתאם לשפה
            this.Close();
            if (LangChange == true)
            {
                Playlist p = new Playlist(m.GetPoints(), true,false,this.m);
                p.Show();
            }
            if (LangChange == false)
            {
                Playlist p = new Playlist(m.GetPoints(), false,false,this.m);
                p.Show();
            }

            m.StopSongs(BackButton);
        }

        private void ThirdOption_Click(object sender, EventArgs e)
        {   //בדיקה האם המשתמש צדק בתשובתו,אם כן מופיע כפתור מעבר שלב בפלייליסט הנוכחי ונמנעת בפניו האפשרות ללחוץ על האופציות שוב

            m.nextLevel(2, ThirdOption, GamePoints, NextLevelButton, LangChange);
            if (NextLevelButton.Visible == true)
            { 
                firstOption.Enabled = false;
                SecondOption.Enabled = false;
                FourOption.Enabled = false;
                NextLevelButton.Visible = true;
            }
            

        }

        private void FirstOption_Click(object sender, EventArgs e)
        {  //בדיקה האם המשתמש צדק בתשובתו,אם כן מופיע כפתור מעבר שלב בפלייליסט הנוכחי ונמנעת בפניו האפשרות ללחוץ על האופציות שוב
            m.nextLevel(0, firstOption, GamePoints, NextLevelButton,LangChange);
            if (NextLevelButton.Visible == true)
            { 

                SecondOption.Enabled = false;
                ThirdOption.Enabled = false;
                FourOption.Enabled = false;
                NextLevelButton.Visible = true;
            }
         
           
        }

        private void HintHelp_Click(object sender, EventArgs e)
        {
            //רמז למשתמש על מנת לגלות את השיר,הרמז עולה 10 נקודות וניתן לראותו פעם אחת בלבד.
            if (CountHintHelp > 0)
            {
                if(LangChange==true)
                   MessageBox.Show("כבר השתמשת בעזרה זו");
                else
                   MessageBox.Show("you already use this help");
            }
           
            if (CountHintHelp == 0)
            {
                MessageBox.Show(m.GiveClue(st,LangChange));
                if(LangChange==false)
                    GamePoints.Text = m.GetPoints() + " " + "Points";
                else
                    GamePoints.Text = m.GetPoints() + " " + "נקודות";

            }
            CountHintHelp++;
        }

       

        private void Help50_Click(object sender, EventArgs e)
        { //עזרה למשתמש על מנת לגלות את השיר,העזרה עולה 10 נקודות,המשחק צובע באדום שתי תשובות לא נכונות ובכך מאפשר למשתמש רק שתי בחירות לתשובה הנכונה.
            if (CountHelp50 > 0)
            {
                if(LangChange==true)
                    MessageBox.Show("כבר השתמשת בעזרה זו");
                else
                    MessageBox.Show("you already use this help");
            }
           
            if (CountHelp50 == 0)
            {
                this.m.FiftyPercent(this.firstOption, this.SecondOption, this.ThirdOption, this.FourOption);
                if(LangChange==false)
                    GamePoints.Text = m.GetPoints() + " " + "Points";
                else
                    GamePoints.Text = m.GetPoints() + " " + "שניות";

            }
            CountHelp50++;

        }

        private void FourOption_Click(object sender, EventArgs e)
        {
            //בדיקה האם המשתמש צדק בתשובתו,אם כן מופיע כפתור מעבר שלב בפלייליסט הנוכחי ונמנעת בפניו האפשרות ללחוץ על האופציות שוב
            m.nextLevel(3, FourOption, GamePoints, NextLevelButton,LangChange);
                if (NextLevelButton.Visible == true)
            {
                firstOption.Enabled = false;
                SecondOption.Enabled = false;
                ThirdOption.Enabled = false;
                NextLevelButton.Visible = true;
            }
        }
            

        private void SecondOption_Click(object sender, EventArgs e)
        {

            m.nextLevel(1, SecondOption, GamePoints, NextLevelButton,LangChange);
            if (NextLevelButton.Visible == true)
            { 
                firstOption.Enabled = false;
                ThirdOption.Enabled = false;
                FourOption.Enabled = false;
                NextLevelButton.Visible = true;
            }

           

        }

        private void NextLevelButton_Click_1(object sender, EventArgs e)
        {   //מעבר לשלב הבא בפלייליסט הנוכחי או במקרה והמשתמש סיים את השלבים בפלייליסט 
            //חזרה לעמוד הפלייליסטים בו נפתח פלייליסט חדש בו ניתן לשחק.
            //אם המשתמש סיים את הפלייליסט האחרון במלואו נפתחת בפניו האופציה לשחק במשחק למנצחים.
            counter++;
            if (counter == 4)
            {
                if (LangChange == true)
                {
                    
                    this.Close();
                    if (st == "Pop_hebrew")
                    {
                        Playlist p = new Playlist(m.GetPoints(), true, true,this.m);
                        p.Show();
                        m.StopSongs(NextLevelButton);
                        MessageBox.Show("כל הכבוד!,סיימת את המשחק!. אתה יכול לשחק כעת במשחק למנצחים!", "!עבודה טובה");
                     
                    }
                    else
                    {
                        Playlist p = new Playlist(m.GetPoints(), true, false,this.m);
                        p.Show();
                        m.StopSongs(NextLevelButton);
                        // m.Change();
                    }
                    
                }
                else
                {
                    this.Close();
                    if (st == "Pop")
                    {
                        Playlist p = new Playlist(m.GetPoints(), false, true,this.m);
                        p.Show();
                        m.StopSongs(NextLevelButton);
                        MessageBox.Show("Good Job!,you finish the game!. you can play in the winners game now!", "Good job!");
                    }
                    else
                    {
                        Playlist p = new Playlist(m.GetPoints(), false, false,this.m);
                        p.Show();
                        m.StopSongs(NextLevelButton);
                    }
                  
                    
                  

         
                    }


            }

            //מעבר לשלב הבא בפלייליסט הנוכחי ואיפוס הכפתורים והטיימר
            else
            {
                
                firstOption.Enabled = true;
                firstOption.BackColor = System.Drawing.Color.White;
                SecondOption.Enabled = true;
                SecondOption.BackColor = System.Drawing.Color.White;
                ThirdOption.Enabled = true;
                ThirdOption.BackColor = System.Drawing.Color.White;
                FourOption.Enabled = true;
                FourOption.BackColor = System.Drawing.Color.White;
                timeLeft = 61;
                m.PlayRandomSong(st);
                CountHintHelp = 0;
                CountHelp50 = 0;
                NextLevelButton.Visible = false;
            }


        }
    }
}



