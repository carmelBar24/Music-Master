using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicMasterGame
{
     public class Manager
    {
        private UnmanagedMemoryStream[] others;
        private UnmanagedMemoryStream[] Rap;
        private UnmanagedMemoryStream[] Edm;
        private UnmanagedMemoryStream[] Rock;
        private UnmanagedMemoryStream[] Pop;
        private UnmanagedMemoryStream[] Rap_hebrew;
        private UnmanagedMemoryStream[] Edm_hebrew;
        int high=0;

        internal SoundPlayer PlayWinnerRandomSong(string v)
        {
            numberSong = randSong.Next(10);
            while (tempWin[numberSong])
                numberSong = randSong.Next(10);
           tempWin[numberSong] = true;
            song = new SoundPlayer(others[numberSong]);
            song.Play();
            return song;
        }

        private UnmanagedMemoryStream[] Rock_hebrew;
        private UnmanagedMemoryStream[] Pop_hebrew;
        private Random randSong = new Random();
        private Random randNum = new Random();
        private int numberSong;
        private string typeMusic;
        private int[] changeColor;
        SoundPlayer song = new SoundPlayer();
        private int points=0;
        private bool [] temp;
        private bool[] tempWin;
 


        public Manager()
        {
            temp = new bool[8];
            temp[0] = false;
            temp[1] = false;
            temp[2] = false;
            temp[3] = false;
            tempWin = new bool[10];
            tempWin[0] = false;
            tempWin[1] = false;
            tempWin[2] = false;
            tempWin[3] = false;
            tempWin[4] = false;
            tempWin[5] = false;
            tempWin[6] = false;
            tempWin[7] = false;
            tempWin[8] = false;
            tempWin[9] = false;
            changeColor = new int[3];
            Rap = new UnmanagedMemoryStream[4];
            Rap[0] = audio.Trap_Queen_Rap;
            Rap[1] = audio.Flex_Zone_Rap;
            Rap[2] = audio.Hot_Nigga_Rap;
            Rap[3] = audio.We_Dem_Boyz_Rap;
            Edm = new UnmanagedMemoryStream[4];
            Edm[0] = audio.Tremor_Edm;
            Edm[1] = audio.Secrets_Edm;
            Edm[2] = audio.Animals_Edm;
            Edm[3] = audio.Reload_Edm;
            Rock = new UnmanagedMemoryStream[4];
            Rock[0] = audio.Remined_Me_Rock;
            Rock[1] = audio.Chop_Suey_Rock;
            Rock[2] = audio.Numb_Rock;
            Rock[3] = audio.Californication_Rock;
            Pop = new UnmanagedMemoryStream[4];
            Pop[0] = audio.Closer_Pop;
            Pop[1] = audio.Heatnes_Pop;
            Pop[2] = audio.Team_Pop;
            Pop[3] = audio.Roar_Pop;
            Rap_hebrew = new UnmanagedMemoryStream[4];
            Rap_hebrew[0] = audio.Ichiban_Rap;
            Rap_hebrew[1] = audio.Bur_Ve_Am_Ha_Aretz_Rap;
            Rap_hebrew[2] = audio.Basim_Babagag_Rap;
            Rap_hebrew[3] = audio.Mitoh_Ayam_Rap;
            Pop_hebrew = new UnmanagedMemoryStream[4];
            Pop_hebrew[0] = audio.Matok_Ceshemarli_Pop;
            Pop_hebrew[1] = audio.Od_Pam_Pop;
            Pop_hebrew[2] = audio.Ba_La_Lirkod_Pop;
            Pop_hebrew[3] = audio.Kaiz_Pop;
            Rock_hebrew = new UnmanagedMemoryStream[4];
            Rock_hebrew[0] = audio.Ahlom_Lanezah_Rock;
            Rock_hebrew[1] = audio.Mashbir_Rock;
            Rock_hebrew[2] = audio.Ha_Simla_Mi_Madrid_Rock;
            Rock_hebrew[3] = audio.Or_Hayareh_Rock;
            Edm_hebrew = new UnmanagedMemoryStream[4];
            Edm_hebrew[0] = audio.Hapil_Hameshuga_Edm;
            Edm_hebrew[1] = audio.Hashmaliya_Edm;
            Edm_hebrew[2] = audio.Yona_Edm;
            Edm_hebrew[3] = audio.Bomboclat_Edm;
            others= new UnmanagedMemoryStream[10];
            others[0] = audio.איך_אפשר_שלא;
            others[1] = audio.ארץ_חדשה;
            others[2] = audio.היא_כל_כך_יפה;
            others[3] = audio.יום_אחד_תבקשי;
            others[4] = audio.שישי_בצהריים;
            others[5] = audio.Thinking_About_It;
            others[6] = audio.Is_this_Love;
            others[7] = audio.Hello;
            others[8] = audio.Come_As_You_Are;
            others[9] = audio.We_Will_Rock_You;

        }

        internal void HighLevel()
        {
            this.high =this.high+1;
        }
        public void InitTempArray()
        {
            temp[0] = false;
            temp[1] = false;
            temp[2] = false;
            temp[3] = false;
        }
        public void PlayRandomSong(string typeMusic)
        {
            this.typeMusic = typeMusic;
            numberSong = randSong.Next(4);
            while(temp[numberSong])
            numberSong = randSong.Next(4);
            temp[numberSong] = true;
            if (typeMusic == "Rap")
            {
                song =new SoundPlayer(Rap[numberSong]);
                song.Play();
            }
            else
                if (typeMusic == "Pop")
            {
                song = new SoundPlayer(Pop[numberSong]);
                song.Play();
            }
            else

                if (typeMusic == "Edm")
            {
                song = new System.Media.SoundPlayer(Edm[numberSong]);
                song.Play();
            }

            else
                  if (typeMusic=="Rap_hebrew")
            {
                song = new System.Media.SoundPlayer(Rap_hebrew[numberSong]);
                song.Play();
            }
            else
                  if (typeMusic == "Rock_hebrew")
            {
                song = new System.Media.SoundPlayer(Rock_hebrew[numberSong]);
                song.Play();
            }
            else
                  if (typeMusic == "Edm_hebrew")
            {
                song = new System.Media.SoundPlayer(Edm_hebrew[numberSong]);
                song.Play();
            }
            else
                  if (typeMusic == "Pop_hebrew")
            {
                song = new System.Media.SoundPlayer(Pop_hebrew[numberSong]);
                song.Play();
            }
            else
                  
            {
                song = new System.Media.SoundPlayer(Rock[numberSong]);
                song.Play();
            }

        }
        public string GiveClue(string typeMusic, bool check)
        {
            points = points - 10;
            if (check == false)
            {
                if (typeMusic == "Rap")
                {

                    if (numberSong == 0)
                        return " fetty wap שם הזמר ששר את שיר זה הוא ";
                    if (numberSong == 1)
                        return " rea sremmurd שם הזמר ששר את שיר זה הוא";
                    if (numberSong == 2)
                        return "not white,n=h,white=opposite";
                    if (numberSong == 3)
                        return "אם אנחנו לא בנות אז?";

                }
                if (typeMusic == "Pop")
                {

                    if (numberSong == 0)
                        return "אם אני לא מתרחק אני?";
                    if (numberSong == 1)
                        return "שיר זה הוא שיר נושא של סרט מפורסם";
                    if (numberSong == 2)
                        return "There is no i in?";
                    if (numberSong == 3)
                        return "קול של נמר";

                }
                if (typeMusic == "Rock")
                {

                    if (numberSong == 0)
                        return "יפה שזכרת לקחת רמז..";
                    if (numberSong == 1)
                        return "שהלהקה עבדה על השיר הם קראו לו בהתחלה התאבדות";
                    if (numberSong == 2)
                        return "הופיעו בישראל ב2010";
                    if (numberSong == 3)
                        return "פלפלים חריפים";

                }
                if (typeMusic == "Edm")
                {

                    if (numberSong == 0)
                        return "מה קורה שמקבלים הודעה?";
                    if (numberSong == 1)
                        return "מה אין בחברה?";
                    if (numberSong == 2)
                        return " מה יש בגן חיות?";



                }
                return "הרמז נטען מחדש נא לחכות";
            }
            else
            {
                if (typeMusic == "Rap_hebrew")
                {

                    if (numberSong == 0)
                        return "מספר 1";
                    if (numberSong == 1)
                        return "אם לא הבנתם את הרמז כנראה שאתם?";
                    if (numberSong == 2)
                        return "שיר זה הוא חלק מהאלבום חרקות";
                    if (numberSong == 3)
                        return "שם הזמר ששר את השיר הזה הוא גם מטבע";

                }
                if (typeMusic == "Pop_hebrew")
                {

                    if (numberSong == 0)
                        return "הזמר ששר שיר זה התפרסם לראשונה בתוכנית שמש";
                    if (numberSong == 1)
                        return "?..שוב";
                    if (numberSong == 2)
                        return "אחד הזמרים הוא חלק מהצמד השופטים בדה וויס";
                    if (numberSong == 3)
                        return "ההפך מחורף";

                }
                if (typeMusic == "Rock_hebrew")
                {

                    if (numberSong == 0)
                        return "הזמר ששר את השיר הוא גם דוקטור";
                    if (numberSong == 1)
                        return "חנות בארץ";
                    if (numberSong == 2)
                        return "עיר הבירה של ספרד";
                    if (numberSong == 3)
                        return "הזמר הוא שופט בתוכנית דה וויס";

                }
                if (typeMusic == "Edm_hebrew")
                {

                    if (numberSong == 0)
                        return "מועדון באילת";
                    if (numberSong == 1)
                        return "יוצרי השיר הם צמד דיג'יים";
                    if (numberSong == 2)
                        return " סימן לשלום";



                }
                return "פצצה+רעש הבהלה+מועדון";
            }
        }

       

        internal int GetHigh()
        {
            return this.high;
        }

        internal string WinnersHint()
        {
            if (this.numberSong == 0)
            {
                return "שם הלהקה ששרה שיר זה הוא חברה של טרזן+צבע";
            }
            if (this.numberSong == 1)
            {
                return "שאתה עולה לארץ אחרת בשבילך זוהי..?";
            }
            if (this.numberSong == 2)
            {
                return "שם הלהקה ששרה שיר זה הוא מקום מחייתם של הדבורים";
            }
            if (this.numberSong == 3)
            {
                return "הזמר ששר שיר זה השתתף בתוכנית חי בלה לה לנד";
            }
            if (this.numberSong == 4)
            {
                return "באיזה יום בשבוע שהוא לא חופש הולכים לים?";
            }
            if (this.numberSong == 5)
            {
                return "I need to think on hint for you....";
            }
            if (this.numberSong == 6)
            {
                return "את עושה מתוק כמו?";
            }
            if (this.numberSong == 7)
            {
                return "מילה נרדפת להיי";
            }
            if (this.numberSong == 8)
            {
                return " smells like teen spirit הלהקה ששרה שיר זה שרה גם את";
            }

             return  "שם הלהקה ששרה שיר זה היא אשתו של המלך";

        }

        internal void newGame(Button b1,Button b2,Button b3)
        {
            b1.Text = "התחל משחק"; 
            b2.Text = "עזרה";
            b3.Text = "יציאה";
           


        }

       

        

        internal string nextLevel(int numAnswer, Button button,Label l,Button button1,bool lang)
        {
            
            if (this.numberSong == numAnswer)
            {
                button1.Enabled = true; 
                button1.Visible = true;
                button.BackColor = System.Drawing.Color.Green;
                points = points + 10;
                if (lang == false)
                {
                    l.Text = points + " " + "Points";
                }
                if (lang == true)
                {
                    l.Text = points + " " + "נקודות";
                }
                button.Enabled = false;
                return " כל הכבוד עברת לשלב הבא!";
             

            }
            if ((this.numberSong != numAnswer))
            {
                button.BackColor = System.Drawing.Color.Red;
                button.Enabled = false;
                points = points - 10;
                if (lang == false)
                {
                    l.Text = points + " " + "Points";
                }
                if (lang == true)
                {
                    l.Text = points + " " + "נקודות";
                }
                
            }
            return "תשובתך לא נכונה!,לא נורא נסה שוב";

        }

        internal void FiftyPercent(Button firstButton, Button secondButton, Button thirdButton, Button fourButton)
        {
            Button[] buttons = new Button[4];
            buttons[0] = firstButton;
            buttons[1] = secondButton;
            buttons[2] = thirdButton;
            buttons[3] = fourButton;
            points = points - 10;
            DesabledButtons(buttons);
            
        }

        private void DesabledButtons(Button[] buttons)
        {
            int n1, n2;
            n1 = randSong.Next(4);
            while(n1==this.numberSong)
                n1 = randSong.Next(4);
            n2 = randSong.Next(4);
            while (n2 == this.numberSong || n2==n1)
                n2 = randSong.Next(4);
            buttons[n1].BackColor = System.Drawing.Color.Red;
           buttons[n1].Enabled = false;
            buttons[n2].BackColor = System.Drawing.Color.Red;
           buttons[n2].Enabled = false;
        }
       

        internal void StopSongs(Button button1)
        {
            song.Stop();
        }
        public int GetPoints()
        {
            return this.points;
        }
        public void SetPoints(int p)
        {
            this.points = p;
        }
        public int GetNumberSong()
        {
            return this.numberSong;
        }

        public WinnersGame WinnersGame
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public Game Game
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }
    }
}

