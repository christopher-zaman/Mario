namespace Mario
{
    partial class Form1
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
            this.monster1 = new System.Windows.Forms.PictureBox();
            this.mario = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.monster1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mario)).BeginInit();
            this.SuspendLayout();
            // 
            // monster1
            // 
            this.monster1.BackColor = System.Drawing.Color.Transparent;
            this.monster1.Image = global::Mario.Properties.Resources.monster;
            this.monster1.Location = new System.Drawing.Point(472, 12);
            this.monster1.Name = "monster1";
            this.monster1.Size = new System.Drawing.Size(100, 100);
            this.monster1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.monster1.TabIndex = 1;
            this.monster1.TabStop = false;
            // 
            // mario
            // 
            this.mario.BackColor = System.Drawing.Color.Transparent;
            this.mario.Image = global::Mario.Properties.Resources.mario;
            this.mario.Location = new System.Drawing.Point(12, 12);
            this.mario.Name = "mario";
            this.mario.Size = new System.Drawing.Size(100, 100);
            this.mario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.mario.TabIndex = 0;
            this.mario.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 30;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Mario.Properties.Resources.bg;
            this.ClientSize = new System.Drawing.Size(584, 362);
            this.Controls.Add(this.monster1);
            this.Controls.Add(this.mario);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Mario The Ultimate Game by Ali Koc";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.monster1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox mario;
        private System.Windows.Forms.PictureBox monster1;
        private System.Windows.Forms.Timer timer1;
    }
}

