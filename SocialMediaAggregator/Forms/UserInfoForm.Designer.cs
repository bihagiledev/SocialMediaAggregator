//
// Free to redistribute and use.
// Creator: Gentiana Coman, www.gentianacoman.com
//

namespace SocialMediaAggregator.Forms
{
    partial class UserInfoForm
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
            this.NameLabel = new System.Windows.Forms.Label();
            this.ScreenNameLabel = new System.Windows.Forms.Label();
            this.AboutLabel = new System.Windows.Forms.Label();
            this.GenderLabel = new System.Windows.Forms.Label();
            this.ClientPictureBox = new System.Windows.Forms.PictureBox();
            this.PictureBox = new System.Windows.Forms.PictureBox();
            this.LinkLabel = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.ClientPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel.Location = new System.Drawing.Point(129, 31);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(49, 16);
            this.NameLabel.TabIndex = 1;
            this.NameLabel.Text = "Name";
            // 
            // ScreenNameLabel
            // 
            this.ScreenNameLabel.AutoSize = true;
            this.ScreenNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScreenNameLabel.Location = new System.Drawing.Point(129, 50);
            this.ScreenNameLabel.Name = "ScreenNameLabel";
            this.ScreenNameLabel.Size = new System.Drawing.Size(80, 15);
            this.ScreenNameLabel.TabIndex = 2;
            this.ScreenNameLabel.Text = "ScreenName";
            // 
            // AboutLabel
            // 
            this.AboutLabel.AutoSize = true;
            this.AboutLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AboutLabel.Location = new System.Drawing.Point(20, 173);
            this.AboutLabel.MaximumSize = new System.Drawing.Size(300, 0);
            this.AboutLabel.Name = "AboutLabel";
            this.AboutLabel.Size = new System.Drawing.Size(251, 16);
            this.AboutLabel.TabIndex = 3;
            this.AboutLabel.Text = "This is a description about me something";
            // 
            // GenderLabel
            // 
            this.GenderLabel.AutoSize = true;
            this.GenderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenderLabel.Location = new System.Drawing.Point(129, 83);
            this.GenderLabel.Name = "GenderLabel";
            this.GenderLabel.Size = new System.Drawing.Size(49, 15);
            this.GenderLabel.TabIndex = 4;
            this.GenderLabel.Text = "Female";
            // 
            // ClientPictureBox
            // 
            this.ClientPictureBox.Image = global::SocialMediaAggregator.Properties.Resources.facebookIcon;
            this.ClientPictureBox.Location = new System.Drawing.Point(301, 25);
            this.ClientPictureBox.Name = "ClientPictureBox";
            this.ClientPictureBox.Size = new System.Drawing.Size(20, 20);
            this.ClientPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ClientPictureBox.TabIndex = 5;
            this.ClientPictureBox.TabStop = false;
            // 
            // PictureBox
            // 
            this.PictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PictureBox.Location = new System.Drawing.Point(23, 31);
            this.PictureBox.Name = "PictureBox";
            this.PictureBox.Size = new System.Drawing.Size(85, 77);
            this.PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox.TabIndex = 0;
            this.PictureBox.TabStop = false;
            // 
            // LinkLabel
            // 
            this.LinkLabel.AutoSize = true;
            this.LinkLabel.Location = new System.Drawing.Point(26, 126);
            this.LinkLabel.Name = "LinkLabel";
            this.LinkLabel.Size = new System.Drawing.Size(79, 13);
            this.LinkLabel.TabIndex = 7;
            this.LinkLabel.TabStop = true;
            this.LinkLabel.Text = "http://somelink";
            this.LinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel_LinkClicked);
            // 
            // UserInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 290);
            this.Controls.Add(this.LinkLabel);
            this.Controls.Add(this.ClientPictureBox);
            this.Controls.Add(this.GenderLabel);
            this.Controls.Add(this.AboutLabel);
            this.Controls.Add(this.ScreenNameLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.PictureBox);
            this.Name = "UserInfoForm";
            this.Text = "UserInfoForm";
            ((System.ComponentModel.ISupportInitialize)(this.ClientPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PictureBox;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label ScreenNameLabel;
        private System.Windows.Forms.Label AboutLabel;
        private System.Windows.Forms.Label GenderLabel;
        private System.Windows.Forms.PictureBox ClientPictureBox;
        private System.Windows.Forms.LinkLabel LinkLabel;
    }
}