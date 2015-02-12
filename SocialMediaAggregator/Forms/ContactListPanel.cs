//
// Free to redistribute and use.
// Creator: Gentiana Coman, www.gentianacoman.com
//

using SocialMediaAggregator.Interfaces;
using SocialMediaAggregator.ObjectModel;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SocialMediaAggregator.Forms
{
    public class ContactListPanel : TableLayoutPanel, IContactListView
    {
        public ContactListPanel()
            : base()
        {
            AutoScroll = true;
            AutoScrollMargin = new System.Drawing.Size(5, 5);
            ColumnCount = 1;
            ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            Dock = System.Windows.Forms.DockStyle.Fill;
            Name = "ContactListPanel";
            RowCount = 0;
        }

        public void LoadContacts(IEnumerable<UserInfo> users)
        {
            Controls.Clear();
            int index = 0;
            foreach (var user in users)
            {
                var panel = CreateUserInfoPanel(user);
                this.Controls.Add(panel, 0, index++);
            }
        }

        public bool HasItems { get { return Controls.Count > 0; } }

        private Panel CreateUserInfoPanel(UserInfo item)
        {
            // 
            // PictureBox
            // 
            PictureBox pictureBox = new PictureBox();
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.Location = new System.Drawing.Point(4, 11);
            pictureBox.Name = "PictureBox";
            pictureBox.Size = new System.Drawing.Size(50, 50);
            pictureBox.TabStop = false;
            pictureBox.Load(item.ProfileImageUrl);

            // 
            // ClientNameLabel
            // 
            Label clientNameLabel = new Label();
            clientNameLabel.AutoSize = true;
            clientNameLabel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            clientNameLabel.Location = new System.Drawing.Point(4, 65);
            clientNameLabel.Name = "ClientNameLabel";
            clientNameLabel.Size = new System.Drawing.Size(281, 15);
            clientNameLabel.DataBindings.Add(new Binding("Text", item.ClientName, ""));

            // 
            // MessageLabel
            // 
            Label messageLabel = new Label();
            messageLabel.MaximumSize = new Size(700, 0);
            messageLabel.AutoSize = true;
            messageLabel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            messageLabel.Location = new System.Drawing.Point(60, 32);
            messageLabel.Name = "MessageLabel";
            messageLabel.Size = new System.Drawing.Size(281, 15);
            messageLabel.DataBindings.Add(new Binding("Text", item.Description, ""));

            // 
            // NameLabel
            // 
            Label nameLabel = new Label();
            nameLabel.AutoSize = true;
            nameLabel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nameLabel.Location = new System.Drawing.Point(60, 11);
            nameLabel.Name = "NameLabel";
            nameLabel.DataBindings.Add(new Binding("Text", item.Name, ""));

            // 
            // ScreenNameLabel
            // 
            Label screenNameLabel = new Label();
            screenNameLabel.AutoSize = true;
            screenNameLabel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            screenNameLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            screenNameLabel.Location = new System.Drawing.Point(nameLabel.Location.X + nameLabel.Size.Width + 100, nameLabel.Location.Y);
            screenNameLabel.Name = "IdLabel";
            screenNameLabel.DataBindings.Add(new Binding("Text", item.ScreenName, ""));


            // 
            // FriendsLabel
            // 
            Label friendsLabel = new Label();
            friendsLabel.AutoSize = true;
            friendsLabel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            friendsLabel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            friendsLabel.Location = new System.Drawing.Point(screenNameLabel.Location.X + screenNameLabel.Size.Width + 200, screenNameLabel.Location.Y);
            friendsLabel.Name = "friendsLabel";
            friendsLabel.Size = new System.Drawing.Size(65, 15);
            friendsLabel.TabIndex = 6;
            friendsLabel.Text = "Friends";

            //
            // Friends
            //
            Label friendsValueLabel = new Label();
            friendsValueLabel.AutoSize = true;
            friendsValueLabel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            friendsValueLabel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            friendsValueLabel.Location = new System.Drawing.Point(friendsLabel.Location.X + 50, friendsLabel.Location.Y);
            friendsValueLabel.Name = "FriendsCountLabel";
            friendsValueLabel.DataBindings.Add(new Binding("Text", item.FriendsCount, ""));

            //
            // separator bevel line
            //
            Label separator = new Label();
            separator.AutoSize = false;
            separator.Height = 2;
            separator.BorderStyle = BorderStyle.Fixed3D;
            separator.Location = new System.Drawing.Point(0, 90);
            separator.Size = new System.Drawing.Size(790, 2);

            // 
            // ContactPanel
            // 
            Panel contactPanel = new Panel();
            contactPanel.Controls.Add(pictureBox);
            contactPanel.Controls.Add(clientNameLabel);
            contactPanel.Controls.Add(messageLabel);
            contactPanel.Controls.Add(screenNameLabel);
            contactPanel.Controls.Add(nameLabel);
            contactPanel.Controls.Add(friendsLabel);
            contactPanel.Controls.Add(friendsValueLabel);
            contactPanel.Controls.Add(separator);
            contactPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            contactPanel.Name = "ContactPanel";
            contactPanel.Size = new Size(700, 100);
            contactPanel.Visible = true;

            return contactPanel;
        }
    }
}
