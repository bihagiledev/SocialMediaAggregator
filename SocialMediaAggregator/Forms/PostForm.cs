//
// Free to redistribute and use.
// Creator: Gentiana Coman, www.gentianacoman.com
//

using SocialMediaAggregator.Controllers;
using SocialMediaAggregator.Interfaces;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SocialMediaAggregator.Forms
{
    public partial class PostForm : Form, IPostView
    {
        IMainPostController m_postController;
        private static long MaxFileSize = 2000000; // 2MB

        public PostForm(IMainPostController postController)
        {
            InitializeComponent();
            m_postController = postController;
        }

        private void bntAddPicture_Click(object sender, EventArgs args)
        {
            var ofd = new OpenFileDialog
            {
                Filter = "JPEG Files|*.jpg",
                Title = "Select picture to upload"
            };
            if (ofd.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            FileInfo fileInfo = new FileInfo(ofd.FileName);
            if (fileInfo.Length > MaxFileSize)
            {
                MessageBox.Show("File is too large. Limit in bytes is " + MaxFileSize);
                return;
            }

            PictureLinkLabel.Text = ofd.FileName;
        }

        private void PostButton_Click(object sender, EventArgs e)
        {
            m_postController.Post(this, MessageTextBox.Text, PictureLinkLabel.Text);
        }

        public void PostSucceeded()
        {
            MessageBox.Show("Post successfull.");
            this.Close();
        }

        private void RemovePictureButton_Click(object sender, EventArgs e)
        {
            PictureLinkLabel.Text = "";
        }
    }
}
