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
    public partial class Playlist : Form
    {
        HelpForm h = new HelpForm(false);
        Manager m;
        bool check = false;
        int points = 0;
        public Playlist(int points1,bool b,bool winnerCheck,Manager m)
        {
            InitializeComponent();
            check = b;
            this.m = m;
            this.points = points1;
            if(winnerCheck==true)
            {
                WinnersGame.Visible = true;
            }
            if (check == false)
            {
                PointsLabel.Text = points + " " + "Points";
                BackButton.Text = "back to the menu";
                Helpbutton.Text = "if you need help";
            }

            else
            {
                PointsLabel.Text = points + " " + "נקודות";
                BackButton.Text = "חזרה לתפריט";
                Helpbutton.Text = "מעבר לעמוד עזרה";
            }
            if (points>20)
            {
                Lock1.BackgroundImage = Resource1.מנעול_פתוח;
                EdmButton.Enabled = true;
                Lock1.Enabled = false;
            }
            if (points >60 )
            {
                Lock2.BackgroundImage = Resource1.מנעול_פתוח;
                RockButton.Enabled = true;
                Lock2.Enabled = false;
            }
            if (points > 90)
            {
                Lock3.BackgroundImage = Resource1.מנעול_פתוח;
                PopButton.Enabled = true;
                Lock3.Enabled = false;
            }
            if (check==true)
            {
                RapButton.Text = "ראפ";
                EdmButton.Text = "אלקטרו";
                PopButton.Text = "פופ";
                RockButton.Text = "רוק";
                h = new HelpForm(true);
        

            }

        }

        public HelpForm HelpForm
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public Manager OpeningScreen
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        private void RapButton_Click(object sender, EventArgs e)
        {
            if (RapButton.Text == "ראפ")               //סגירת הפורם ומעבר לעמוד המשחק
                                               //כאשר פלייליסט השירים הוא ראפ בעברית
            {
                Game c = new Game("Rap_hebrew",true,points,this.m);
                c.Show();
                this.Close();

            }
          else
            {                                                      //סגירת הפורם ומעבר לעמוד המשחק
                Game c = new Game("Rap",false,points,this.m);     //כאשר פלייליסט השירים הוא ראפ באנגלית
                c.Show();
                this.Close();
            }
        }

        private void Game_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            
            this.Close();//סגירת הפורם וחזרה לתפריט הראשי
        }

        private void Helpbutton_Click(object sender, EventArgs e)
        {
            h.Show();//סגירת הפורם ומעבר לעמוד עזרה
            this.Close();
        }

        private void Lock1_Click(object sender, EventArgs e)
        {   //הפלייליסט נעול כל עוד אין 30 נקודות
            MessageBox.Show("בכדי לפתוח את שלב זה עליך להשיג 30 נקודות","Sorry!",
            MessageBoxButtons.OK,
		    MessageBoxIcon.Hand);
        }


        private void Lock2_Click(object sender, EventArgs e)
        {
            //הפלייליסט נעול כל עוד אין 70 נקודות
            MessageBox.Show("בכדי לפתוח את שלב זה עליך להשיג 70 נקודות  ","Sorry!",
                  MessageBoxButtons.OK,
            MessageBoxIcon.Hand);
           
        }

        private void Lock3_Click(object sender, EventArgs e)
        {
            //הפלייליסט נעול כל עוד אין 100 נקודות
            MessageBox.Show("בכדי לפתוח את שלב זה עליך להשיג 100 נקודות ,בהצלחה","Sorry!",
                  MessageBoxButtons.OK,
            MessageBoxIcon.Hand);
           
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
        }

        private void EdmButton_Click(object sender, EventArgs e)
        {
           // סגירת הפורם ומעבר לעמוד המשחק
           //כאשר פלייליסט השירים הוא אלקטרו בעברית

            if (EdmButton.Text == "אלקטרו")  
            {
                this.m.InitTempArray();
                Game c = new Game("Edm_hebrew",true,points,this.m);
                c.Show();
                this.Close();

            }
            else
            {
                // סגירת הפורם ומעבר לעמוד המשחק
                //כאשר פלייליסט השירים הוא אלקטרו באנגלית
                this.m.InitTempArray();
                Game c = new Game("Edm",false,points,this.m);
                c.Show();
                this.Close();
            }
        }

        private void RockButton_Click(object sender, EventArgs e)
        {

            // סגירת הפורם ומעבר לעמוד המשחק
            //כאשר פלייליסט השירים הוא רוק בעברית
            if (RockButton.Text == "רוק")
            {
                this.m.InitTempArray();
                Game c = new Game("Rock_hebrew",true,points,this.m);
                c.Show();
                this.Close();


            }
            else
            {
                // סגירת הפורם ומעבר לעמוד המשחק
                //כאשר פלייליסט השירים הוא רוק באנגלית
                this.m.InitTempArray();
                Game c = new Game("Rock",false,points,this.m);
                c.Show();
                this.Close();
            }
        }

        private void PopButton_Click(object sender, EventArgs e)
        {
            // סגירת הפורם ומעבר לעמוד המשחק
            //כאשר פלייליסט השירים הוא פופ בעברית
            if (PopButton.Text == "פופ")
            {
                this.m.InitTempArray();
                Game c = new Game("Pop_hebrew", true,points,this.m);
                c.Show();
                this.Close();

            }
            else
            {
                // סגירת הפורם ומעבר לעמוד המשחק
                //כאשר פלייליסט השירים הוא פופ באנגלית
                this.m.InitTempArray();
                Game c = new Game("Pop",false,points,this.m);
                c.Show();
                this.Close();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        internal void changeBackground()
        {
            Lock1.BackgroundImage = Resource1.מנעול;
        }

        private void WinnersGame_Click_1(object sender, EventArgs e)
        {
            this.Close();    //סגירת הפורם ומעבר למשחק המנצחים
            WinnersGame w = new WinnersGame(check,m);//
            w.Show();
        }

        internal bool GetCheck()
        {
            return this.check;
        }
    }
}
