namespace PictureViewer
{
    partial class FrmPictureViewer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.picBoxSlideShow = new System.Windows.Forms.PictureBox();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxSlideShow)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(86, 43);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(62, 31);
            this.btnPrevious.TabIndex = 0;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(198, 43);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(62, 31);
            this.btnNext.TabIndex = 1;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(305, 43);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(62, 31);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "Close";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // picBoxSlideShow
            // 
            this.picBoxSlideShow.Location = new System.Drawing.Point(12, 108);
            this.picBoxSlideShow.Name = "picBoxSlideShow";
            this.picBoxSlideShow.Size = new System.Drawing.Size(480, 308);
            this.picBoxSlideShow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxSlideShow.TabIndex = 3;
            this.picBoxSlideShow.TabStop = false;
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(168, 453);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(62, 31);
            this.btnPlay.TabIndex = 4;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnPause
            // 
            this.btnPause.Location = new System.Drawing.Point(264, 453);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(62, 31);
            this.btnPause.TabIndex = 5;
            this.btnPause.Text = "Pause";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FrmPictureViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 513);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.picBoxSlideShow);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevious);
            this.Name = "FrmPictureViewer";
            this.Text = "Imran Khan Gallery";
            ((System.ComponentModel.ISupportInitialize)(this.picBoxSlideShow)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.PictureBox picBoxSlideShow;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Timer timer1;
    }
}

