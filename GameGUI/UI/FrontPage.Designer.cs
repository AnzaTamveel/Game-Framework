namespace MyGameGUI
{
    partial class FrontPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrontPage));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.enemyCount = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.playercount = new System.Windows.Forms.Label();
            this.Player_Health = new System.Windows.Forms.ProgressBar();
            this.w1 = new System.Windows.Forms.PictureBox();
            this.w4 = new System.Windows.Forms.PictureBox();
            this.w3 = new System.Windows.Forms.PictureBox();
            this.w2 = new System.Windows.Forms.PictureBox();
            this.b3 = new System.Windows.Forms.PictureBox();
            this.w5 = new System.Windows.Forms.PictureBox();
            this.w6 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.w1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.w4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.w3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.w2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.b3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.w5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.w6)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // enemyCount
            // 
            this.enemyCount.AutoSize = true;
            this.enemyCount.BackColor = System.Drawing.Color.Transparent;
            this.enemyCount.Font = new System.Drawing.Font("Stencil", 9.75F);
            this.enemyCount.ForeColor = System.Drawing.Color.Black;
            this.enemyCount.Location = new System.Drawing.Point(934, 71);
            this.enemyCount.Name = "enemyCount";
            this.enemyCount.Size = new System.Drawing.Size(55, 16);
            this.enemyCount.TabIndex = 9;
            this.enemyCount.Text = "Player";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Stencil", 9.75F);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(862, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Enemy: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Stencil", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(857, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Player: ";
            // 
            // playercount
            // 
            this.playercount.AutoSize = true;
            this.playercount.BackColor = System.Drawing.Color.Transparent;
            this.playercount.Font = new System.Drawing.Font("Stencil", 9.75F);
            this.playercount.ForeColor = System.Drawing.Color.Black;
            this.playercount.Location = new System.Drawing.Point(934, 44);
            this.playercount.Name = "playercount";
            this.playercount.Size = new System.Drawing.Size(55, 16);
            this.playercount.TabIndex = 7;
            this.playercount.Text = "Player";
            // 
            // Player_Health
            // 
            this.Player_Health.Location = new System.Drawing.Point(678, 44);
            this.Player_Health.Name = "Player_Health";
            this.Player_Health.Size = new System.Drawing.Size(158, 32);
            this.Player_Health.TabIndex = 13;
            // 
            // w1
            // 
            this.w1.Image = ((System.Drawing.Image)(resources.GetObject("w1.Image")));
            this.w1.Location = new System.Drawing.Point(-19, 1);
            this.w1.Name = "w1";
            this.w1.Size = new System.Drawing.Size(1035, 28);
            this.w1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.w1.TabIndex = 1;
            this.w1.TabStop = false;
            // 
            // w4
            // 
            this.w4.Image = ((System.Drawing.Image)(resources.GetObject("w4.Image")));
            this.w4.Location = new System.Drawing.Point(-66, 569);
            this.w4.Name = "w4";
            this.w4.Size = new System.Drawing.Size(1101, 72);
            this.w4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.w4.TabIndex = 0;
            this.w4.TabStop = false;
            // 
            // w3
            // 
            this.w3.Image = ((System.Drawing.Image)(resources.GetObject("w3.Image")));
            this.w3.Location = new System.Drawing.Point(1005, -50);
            this.w3.Name = "w3";
            this.w3.Size = new System.Drawing.Size(30, 647);
            this.w3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.w3.TabIndex = 3;
            this.w3.TabStop = false;
            // 
            // w2
            // 
            this.w2.Image = ((System.Drawing.Image)(resources.GetObject("w2.Image")));
            this.w2.Location = new System.Drawing.Point(-2, 1);
            this.w2.Name = "w2";
            this.w2.Size = new System.Drawing.Size(25, 612);
            this.w2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.w2.TabIndex = 2;
            this.w2.TabStop = false;
            // 
            // b3
            // 
            this.b3.Image = ((System.Drawing.Image)(resources.GetObject("b3.Image")));
            this.b3.Location = new System.Drawing.Point(12, 433);
            this.b3.Name = "b3";
            this.b3.Size = new System.Drawing.Size(305, 28);
            this.b3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.b3.TabIndex = 10;
            this.b3.TabStop = false;
            // 
            // w5
            // 
            this.w5.Image = ((System.Drawing.Image)(resources.GetObject("w5.Image")));
            this.w5.Location = new System.Drawing.Point(657, 302);
            this.w5.Name = "w5";
            this.w5.Size = new System.Drawing.Size(359, 28);
            this.w5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.w5.TabIndex = 11;
            this.w5.TabStop = false;
            // 
            // w6
            // 
            this.w6.Image = ((System.Drawing.Image)(resources.GetObject("w6.Image")));
            this.w6.Location = new System.Drawing.Point(12, 278);
            this.w6.Name = "w6";
            this.w6.Size = new System.Drawing.Size(409, 28);
            this.w6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.w6.TabIndex = 12;
            this.w6.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Stencil", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(559, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "Player Health:";
            // 
            // FrontPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1028, 595);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Player_Health);
            this.Controls.Add(this.w1);
            this.Controls.Add(this.w4);
            this.Controls.Add(this.enemyCount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.playercount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.w3);
            this.Controls.Add(this.w2);
            this.Controls.Add(this.b3);
            this.Controls.Add(this.w5);
            this.Controls.Add(this.w6);
            this.DoubleBuffered = true;
            this.Name = "FrontPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.w1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.w4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.w3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.w2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.b3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.w5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.w6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox w4;
        private System.Windows.Forms.PictureBox w1;
        private System.Windows.Forms.PictureBox w2;
        private System.Windows.Forms.PictureBox w3;
        private System.Windows.Forms.Label enemyCount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label playercount;
        private System.Windows.Forms.PictureBox b3;
        private System.Windows.Forms.PictureBox w5;
        private System.Windows.Forms.PictureBox w6;
        private System.Windows.Forms.ProgressBar Player_Health;
        private System.Windows.Forms.Label label2;
    }
}

