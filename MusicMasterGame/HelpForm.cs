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
    public partial class HelpForm : Form
    {
        bool lang = false;
        public HelpForm(bool lang)
        {
            
            InitializeComponent();
            this.lang = lang;//שינוי השפה בהתאם למה שבחר המשתמש בעמוד המרכזי של המשחק
            if (lang==true)
            {
                label1.Visible = true;
                HelpInformation.Visible = false;
                BackButton.Text = "חזרה לתפריט הראשי";
            }
            if (lang == false)
            {
                label1.Visible = false;
                HelpInformation.Visible = true;
                BackButton.Text = "back to the menu";
              
            }
        }

        private void HelpForm_Load(object sender, EventArgs e)
        {

        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();//סגירת עמוד העזרה וחזרה לעמוד הראשי
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
       
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
