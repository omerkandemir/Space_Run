namespace Space_Run
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.kahraman = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblcan = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblskor = new System.Windows.Forms.Label();
            this.labelkalp = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.kahraman)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.labelkalp)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // kahraman
            // 
            this.kahraman.BackColor = System.Drawing.Color.Transparent;
            this.kahraman.Image = ((System.Drawing.Image)(resources.GetObject("kahraman.Image")));
            this.kahraman.Location = new System.Drawing.Point(561, 350);
            this.kahraman.Name = "kahraman";
            this.kahraman.Size = new System.Drawing.Size(313, 213);
            this.kahraman.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.kahraman.TabIndex = 1;
            this.kahraman.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Informal Roman", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 44);
            this.label1.TabIndex = 2;
            this.label1.Text = "SKOR :";
            // 
            // lblcan
            // 
            this.lblcan.AutoSize = true;
            this.lblcan.Font = new System.Drawing.Font("Informal Roman", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcan.Location = new System.Drawing.Point(1258, 30);
            this.lblcan.Name = "lblcan";
            this.lblcan.Size = new System.Drawing.Size(41, 44);
            this.lblcan.TabIndex = 4;
            this.lblcan.Text = "3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.Font = new System.Drawing.Font("Informal Roman", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1202, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 44);
            this.label4.TabIndex = 5;
            this.label4.Text = "X";
            // 
            // lblskor
            // 
            this.lblskor.AutoSize = true;
            this.lblskor.Font = new System.Drawing.Font("Informal Roman", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblskor.Location = new System.Drawing.Point(141, 9);
            this.lblskor.Name = "lblskor";
            this.lblskor.Size = new System.Drawing.Size(40, 44);
            this.lblskor.TabIndex = 6;
            this.lblskor.Text = "0";
            this.lblskor.TextChanged += new System.EventHandler(this.lblskor_TextChanged);
            // 
            // labelkalp
            // 
            this.labelkalp.BackColor = System.Drawing.Color.Transparent;
            this.labelkalp.Image = ((System.Drawing.Image)(resources.GetObject("labelkalp.Image")));
            this.labelkalp.Location = new System.Drawing.Point(1147, 30);
            this.labelkalp.Name = "labelkalp";
            this.labelkalp.Size = new System.Drawing.Size(58, 44);
            this.labelkalp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.labelkalp.TabIndex = 7;
            this.labelkalp.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1327, 683);
            this.Controls.Add(this.labelkalp);
            this.Controls.Add(this.lblskor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblcan);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.kahraman);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form2_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.kahraman)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.labelkalp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox kahraman;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblcan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblskor;
        private System.Windows.Forms.PictureBox labelkalp;
    }
}