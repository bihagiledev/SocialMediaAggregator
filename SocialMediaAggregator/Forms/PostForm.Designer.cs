//
// Free to redistribute and use.
// Creator: Gentiana Coman, www.gentianacoman.com
//

namespace SocialMediaAggregator.Forms
{
    partial class PostForm
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
            this.AddPictureButton = new System.Windows.Forms.Button();
            this.PostButton = new System.Windows.Forms.Button();
            this.MessageLabel = new System.Windows.Forms.Label();
            this.MessageTextBox = new System.Windows.Forms.TextBox();
            this.PictureLinkLabel = new System.Windows.Forms.Label();
            this.RemovePictureButton = new System.Windows.Forms.Button();
            this.PictureLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AddPictureButton
            // 
            this.AddPictureButton.Location = new System.Drawing.Point(91, 89);
            this.AddPictureButton.Name = "AddPictureButton";
            this.AddPictureButton.Size = new System.Drawing.Size(79, 40);
            this.AddPictureButton.TabIndex = 25;
            this.AddPictureButton.Text = "Add Picture";
            this.AddPictureButton.UseVisualStyleBackColor = true;
            this.AddPictureButton.Click += new System.EventHandler(this.bntAddPicture_Click);
            // 
            // PostButton
            // 
            this.PostButton.Location = new System.Drawing.Point(358, 89);
            this.PostButton.Name = "PostButton";
            this.PostButton.Size = new System.Drawing.Size(67, 42);
            this.PostButton.TabIndex = 24;
            this.PostButton.Text = "Post";
            this.PostButton.UseVisualStyleBackColor = true;
            this.PostButton.Click += new System.EventHandler(this.PostButton_Click);
            // 
            // MessageLabel
            // 
            this.MessageLabel.AutoSize = true;
            this.MessageLabel.Location = new System.Drawing.Point(35, 24);
            this.MessageLabel.Name = "MessageLabel";
            this.MessageLabel.Size = new System.Drawing.Size(50, 13);
            this.MessageLabel.TabIndex = 23;
            this.MessageLabel.Text = "Message";
            // 
            // MessageTextBox
            // 
            this.MessageTextBox.Location = new System.Drawing.Point(91, 21);
            this.MessageTextBox.MaxLength = 140;
            this.MessageTextBox.Multiline = true;
            this.MessageTextBox.Name = "MessageTextBox";
            this.MessageTextBox.Size = new System.Drawing.Size(334, 62);
            this.MessageTextBox.TabIndex = 22;
            // 
            // PictureLinkLabel
            // 
            this.PictureLinkLabel.AutoSize = true;
            this.PictureLinkLabel.Location = new System.Drawing.Point(95, 143);
            this.PictureLinkLabel.MaximumSize = new System.Drawing.Size(300, 0);
            this.PictureLinkLabel.Name = "PictureLinkLabel";
            this.PictureLinkLabel.Size = new System.Drawing.Size(0, 13);
            this.PictureLinkLabel.TabIndex = 26;
            // 
            // RemovePictureButton
            // 
            this.RemovePictureButton.Location = new System.Drawing.Point(176, 89);
            this.RemovePictureButton.Name = "RemovePictureButton";
            this.RemovePictureButton.Size = new System.Drawing.Size(79, 40);
            this.RemovePictureButton.TabIndex = 27;
            this.RemovePictureButton.Text = "Remove Picture";
            this.RemovePictureButton.UseVisualStyleBackColor = true;
            this.RemovePictureButton.Click += new System.EventHandler(this.RemovePictureButton_Click);
            // 
            // PictureLabel
            // 
            this.PictureLabel.AutoSize = true;
            this.PictureLabel.Location = new System.Drawing.Point(50, 143);
            this.PictureLabel.MaximumSize = new System.Drawing.Size(300, 0);
            this.PictureLabel.Name = "PictureLabel";
            this.PictureLabel.Size = new System.Drawing.Size(46, 13);
            this.PictureLabel.TabIndex = 28;
            this.PictureLabel.Text = "Picture: ";
            // 
            // PostForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 171);
            this.Controls.Add(this.PictureLabel);
            this.Controls.Add(this.RemovePictureButton);
            this.Controls.Add(this.PictureLinkLabel);
            this.Controls.Add(this.AddPictureButton);
            this.Controls.Add(this.PostButton);
            this.Controls.Add(this.MessageLabel);
            this.Controls.Add(this.MessageTextBox);
            this.MaximizeBox = false;
            this.Name = "PostForm";
            this.Text = "New post";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddPictureButton;
        private System.Windows.Forms.Button PostButton;
        private System.Windows.Forms.Label MessageLabel;
        private System.Windows.Forms.TextBox MessageTextBox;
        private System.Windows.Forms.Label PictureLinkLabel;
        private System.Windows.Forms.Button RemovePictureButton;
        private System.Windows.Forms.Label PictureLabel;

    }
}