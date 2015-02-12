//
// Free to redistribute and use.
// Creator: Gentiana Coman, www.gentianacoman.com
//

using SocialMediaAggregator.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SocialMediaAggregator.Forms
{
    public partial class MainForm : Form
    {
        #region Members

        Panel m_activeMainPanel;
        MainControllerBase m_mainController;

        #endregion

        public MainForm(MainControllerBase mainController)
        {
            m_mainController = mainController;

            InitializeComponent();
            PostInitializeComponent();
            m_activeMainPanel = this.NewsFeedPanel;
        }

        public void PostInitializeComponent()
        {
            NewsFeedPanel.LoadMoreHandler = LoadMoreButton_Click;
            UserFeedPanel.LoadMoreHandler = LoadMoreButton_Click;
            UserFeedPanel.Visible = false;
            ContactListPanel.Visible = false;
            NewsFeedButtonToolTip.SetToolTip(NewsFeedButton, "News Feed");
            UserFeedButtonToolTip.SetToolTip(UserFeedButton, "User Feed");
            FriendsButtonToolTip.SetToolTip(FriendsButton, "Information on friends");
            AboutButtonToolTip.SetToolTip(AboutButton, "Information on current user");
            PostButtonToolTip.SetToolTip(PostButton, "Write a new post");

            var clientNames = m_mainController.GetClientNames();
            foreach (var clientName in clientNames)
                AboutButtonContextMenuStrip.Items.Add(clientName);
        }

        private void LoadMoreButton_Click(object sender, EventArgs e)
        {
            if (m_activeMainPanel == NewsFeedPanel)
                m_mainController.LoadNewsFeed(NewsFeedPanel);
            else
                m_mainController.LoadUserFeed(UserFeedPanel);
        }

        private void UserFeedButton_Click(object sender, EventArgs e)
        {
            m_activeMainPanel.Visible = false;
            UserFeedPanel.Visible = true;

            if (!UserFeedPanel.HasItems)
                m_mainController.LoadUserFeed(UserFeedPanel);

            m_activeMainPanel = UserFeedPanel;
        }

        private void NewsFeedButton_Click(object sender, EventArgs e)
        {
            m_activeMainPanel.Visible = false;
            NewsFeedPanel.Visible = true;

            if (!NewsFeedPanel.HasItems)
                m_mainController.LoadNewsFeed(NewsFeedPanel);

            m_activeMainPanel = NewsFeedPanel;
        }

        private void TopButton_MouseEnter(object sender, EventArgs e)
        {
            Button button = sender as Button;
            button.UseVisualStyleBackColor = false;
            button.BackColor = Color.Azure;
        }

        private void TopButton_MouseLeave(object sender, EventArgs e)
        {
            Button button = sender as Button;
            button.UseVisualStyleBackColor = true;
            button.BackColor = Color.Azure;
        }

        private void AboutButton_Click(object sender, EventArgs e)
        {
        }

        private void SortComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            // Only available for the NewsFeed
            if (m_activeMainPanel == NewsFeedPanel)
            {
                ComboBox comboBox = sender as ComboBox;
                if ("Popularity".Equals(comboBox.SelectedItem))
                {
                    m_mainController.SortNewsFeedByPopularity(NewsFeedPanel);
                }
                else
                {
                    m_mainController.SortNewsFeedByDate(NewsFeedPanel);
                }
            }
        }

        private void FriendsButton_Click(object sender, EventArgs e)
        {
            m_activeMainPanel.Visible = false;
            ContactListPanel.Visible = true;

            if (!ContactListPanel.HasItems)
                m_mainController.LoadContacts(ContactListPanel);

            m_activeMainPanel = ContactListPanel;
        }

        private void PostButton_Click(object sender, EventArgs e)
        {
            var postForm = new PostForm(m_mainController);
            postForm.ShowDialog();
        }

        private void AboutButtonContextMenuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            ToolStripItem item = e.ClickedItem;
            var userInfoView = new UserInfoForm();
            m_mainController.LoadUserInfo(userInfoView, item.Text);
            userInfoView.ShowDialog();
        }
    }
}
