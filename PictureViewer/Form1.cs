using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PictureViewer
{
    public partial class FrmPictureViewer : Form
    {
        static int c = 0;
        bool flag = true;
        public FrmPictureViewer()
        {
            InitializeComponent();
            this.picBoxSlideShow.ImageLocation = "D:\\Pic Directory\\1.jpg";
            
        }

        public void playNext()
        {
            c++;

            if (c == 1)
            {
                this.picBoxSlideShow.ImageLocation = "D:\\Pic Directory\\2.jpg";
            }
            if (c == 2)
            {
                this.picBoxSlideShow.ImageLocation = "D:\\Pic Directory\\3.jpg";
            }
            if (c == 3)
            {
                this.picBoxSlideShow.ImageLocation = "D:\\Pic Directory\\4.jpg";
            }
            if (c == 4)
            {
                this.picBoxSlideShow.ImageLocation = "D:\\Pic Directory\\5.jpg";
            }
            if (c == 5)
            {
                this.picBoxSlideShow.ImageLocation = "D:\\Pic Directory\\6.jpg";
            }
            if (c == 6)
            {
                this.picBoxSlideShow.ImageLocation = "D:\\Pic Directory\\7.jpg";
            }
            if (c == 7)
            {
                this.picBoxSlideShow.ImageLocation = "D:\\Pic Directory\\1.jpg";
                c = 0;
            }


        }
        public void playPrev() {
            if (c == 0)
            {

                this.picBoxSlideShow.ImageLocation = "D:\\Pic Directory\\7.jpg";
                c = 7;
            }


            if (c == 1)
            {

                this.picBoxSlideShow.ImageLocation = "D:\\Pic Directory\\1.jpg";
                c--;
            }
            if (c == 2)
            {

                this.picBoxSlideShow.ImageLocation = "D:\\Pic Directory\\2.jpg";
                c--;
            }
            if (c == 3)
            {

                this.picBoxSlideShow.ImageLocation = "D:\\Pic Directory\\3.jpg";
                c--;
            }
            if (c == 4)
            {

                this.picBoxSlideShow.ImageLocation = "D:\\Pic Directory\\4.jpg";
                c--;
            }
            if (c == 5)
            {

                this.picBoxSlideShow.ImageLocation = "D:\\Pic Directory\\5.jpg";
                c--;
            }
            if (c == 6)
            {

                this.picBoxSlideShow.ImageLocation = "D:\\Pic Directory\\6.jpg";
                c--;
            }
            if (c == 7)
            {

                this.picBoxSlideShow.ImageLocation = "D:\\Pic Directory\\7.jpg";
                c--;
            }
        }

        
        
        private void btnClear_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            flag = true;
            playNext();

        }
        private void btnPrevious_Click(object sender, EventArgs e)
        {
            playPrev();
            flag = false;
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            timer1.Start();
            
            
         
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (flag)
            {
                this.playNext();
            }
            else
            {
                this.playPrev();
            }
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }
    }
}
