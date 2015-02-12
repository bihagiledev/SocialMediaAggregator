//
// Free to redistribute and use.
// Creator: Gentiana Coman, www.gentianacoman.com
//

using SocialMediaAggregator.Interfaces;
using SocialMediaAggregator.ObjectModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SocialMediaAggregator.Forms
{
    public partial class UserInfoForm : Form, IUserInfoView
    {
        public UserInfoForm()
        {
            InitializeComponent();
        }

        public void LoadUserInfo(UserInfo userInfo, Image clientIcon)
        {
            this.NameLabel.DataBindings.Add("Text", userInfo.Name, "");
            this.ScreenNameLabel.DataBindings.Add("Text", userInfo.ScreenName, "");
            this.AboutLabel.DataBindings.Add("Text", userInfo.Description, "");
            this.GenderLabel.DataBindings.Add("Text", userInfo.Gender, "");
            this.PictureBox.Load(userInfo.ProfileImageUrl);
            this.ClientPictureBox.Image = clientIcon;
            this.LinkLabel.DataBindings.Add("Text", userInfo.Link, "");
        }

        private void LinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LinkLabel linkLabel = sender as LinkLabel;
            ProcessStartInfo sInfo = new ProcessStartInfo(linkLabel.Text);
            Process.Start(sInfo);
        }
    }
}
