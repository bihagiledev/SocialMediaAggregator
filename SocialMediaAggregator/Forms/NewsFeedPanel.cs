//
// Free to redistribute and use.
// Creator: Gentiana Coman, www.gentianacoman.com
//

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
    public class NewsFeedPanel : TableLayoutPanel, INewsFeedView
    {
        private Panel m_loadMorePanel;
        private EventHandler m_loadMoreHandler;

        public NewsFeedPanel()
            : base()
        {
            AutoScroll = true;
            AutoScrollMargin = new System.Drawing.Size(5, 5);
            ColumnCount = 1;
            ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            Dock = System.Windows.Forms.DockStyle.Fill;
            Name = "NewsFeedPanel";
            RowCount = 0;
            m_loadMorePanel = CreateLoadMorePanel();
        }

        public EventHandler LoadMoreHandler
        {
            get { return m_loadMoreHandler; }
            set
            {
                if (value != null)
                {
                    m_loadMoreHandler = value;
                    m_loadMorePanel.Controls[0].Click += new System.EventHandler(m_loadMoreHandler);
                }
            }
        }

        public void AddNewsItems(IEnumerable<NewsFeedItem> newsItems)
        {
            RemoveLoadMorePanel();
            int index = Controls.Count;
            index = LoadItemsStartingFrom(newsItems, index);
        }

        private int LoadItemsStartingFrom(IEnumerable<NewsFeedItem> newsItems, int index)
        {
            foreach (var newsItem in newsItems)
            {
                var panel = CreateMessagePanel(newsItem);
                this.Controls.Add(panel, 0, index++);
                this.RowStyles.Add(new RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
                this.RowCount++;
            }

            this.Controls.Add(m_loadMorePanel, 0, Controls.Count);
            this.RowStyles.Add(new RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.RowCount++;
            return index;
        }

        public void LoadNewsItems(IEnumerable<NewsFeedItem> newsItems)
        {
            Controls.Clear();
            RowStyles.Clear();
            RowCount = 0;
            LoadItemsStartingFrom(newsItems, 0);
        }

        public void EndFeed()
        {     
            RemoveLoadMorePanel();
        }

        private void RemoveLoadMorePanel()
        {
            if (this.Controls.Count == 0)
                return;

            this.Controls.Remove(m_loadMorePanel);
            this.RowStyles.RemoveAt(RowStyles.Count - 1);
            this.RowCount--;
        }

        public bool HasItems { get { return Controls.Count > 0; } }

        private Panel CreateMessagePanel(NewsFeedItem item)
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
            pictureBox.Load(item.AuthorPictureUrl);

            // 
            // MessageLabel
            // 
            Label messageLabel = new Label();
            messageLabel.MaximumSize = new Size(700, 0);
            messageLabel.AutoSize = true;
            messageLabel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            messageLabel.Location = new System.Drawing.Point(60, 52);
            messageLabel.Name = "MessageLabel";
            messageLabel.Size = new System.Drawing.Size(281, 15);
            messageLabel.DataBindings.Add(new Binding("Text", item.Text, ""));

            // 
            // NameLabel
            // 
            Label nameLabel = new Label();
            nameLabel.AutoSize = true;
            nameLabel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nameLabel.Location = new System.Drawing.Point(60, 11);
            nameLabel.Name = "NameLabel";
            nameLabel.DataBindings.Add(new Binding("Text", item.AuthorName, ""));

            // 
            // ScreenNameLabel
            // 
            Label screenNameLabel = new Label();
            screenNameLabel.AutoSize = true;
            screenNameLabel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            screenNameLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            screenNameLabel.Location = new System.Drawing.Point(nameLabel.Location.X + nameLabel.Size.Width + 100, nameLabel.Location.Y);
            screenNameLabel.Name = "IdLabel";
            screenNameLabel.DataBindings.Add(new Binding("Text", item.AuthorScreenName, ""));

            //
            // Date
            //
            Label dateLabel = new Label();
            dateLabel.AutoSize = true;
            dateLabel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dateLabel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            dateLabel.Location = new System.Drawing.Point(screenNameLabel.Location.X + screenNameLabel.Size.Width + 200, screenNameLabel.Location.Y);
            dateLabel.Name = "DateLabel";
            dateLabel.DataBindings.Add(new Binding("Text", item.CreateDate.ToString(), ""));

            // 
            // popularityLabel
            // 
            Label popularityLabel = new Label();
            popularityLabel.AutoSize = true;
            popularityLabel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            popularityLabel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            popularityLabel.Location = new System.Drawing.Point(60, 32);
            popularityLabel.Name = "popularityLabel";
            popularityLabel.Size = new System.Drawing.Size(65, 15);
            popularityLabel.TabIndex = 6;
            popularityLabel.Text = "Popularity";

            // 
            // popularityValueLabel
            // 
            Label popularityValueLabel = new Label();
            popularityValueLabel.AutoSize = true;
            popularityValueLabel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            popularityValueLabel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            popularityValueLabel.Location = new System.Drawing.Point(124, 32);
            popularityValueLabel.Name = "label5";
            popularityValueLabel.Size = new System.Drawing.Size(14, 15);
            popularityValueLabel.TabIndex = 7;
            popularityValueLabel.DataBindings.Add("Text", item.Popularity, "");

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
            // MessagePanel
            // 
            Panel messagePanel = new Panel();
            messagePanel.Controls.Add(pictureBox);
            messagePanel.Controls.Add(messageLabel);
            messagePanel.Controls.Add(screenNameLabel);
            messagePanel.Controls.Add(nameLabel);
            messagePanel.Controls.Add(popularityLabel);
            messagePanel.Controls.Add(popularityValueLabel);
            messagePanel.Controls.Add(dateLabel);
            messagePanel.Controls.Add(separator);
            messagePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            messagePanel.Name = "MessagePanel";
            messagePanel.Size = new Size(700, 100);
            messagePanel.Visible = true;

            return messagePanel;
        }

        private Panel CreateLoadMorePanel()
        {
            Button loadMoreButton = new Button();
            loadMoreButton.AccessibleName = "LoadMoreButton";
            loadMoreButton.BackColor = System.Drawing.Color.White;
            loadMoreButton.FlatAppearance.BorderSize = 0;
            loadMoreButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            loadMoreButton.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            loadMoreButton.ForeColor = System.Drawing.Color.Silver;
            loadMoreButton.Location = new System.Drawing.Point(300, 10);
            loadMoreButton.Name = "LoadMoreButton";
            loadMoreButton.Size = new System.Drawing.Size(157, 36);
            loadMoreButton.Text = "LOAD MORE";
            loadMoreButton.UseVisualStyleBackColor = false;

            Panel loadMorePanel = new Panel();
            loadMorePanel.Controls.Add(loadMoreButton);
            loadMorePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            loadMorePanel.Name = "LoadMorePanel";
            loadMorePanel.Visible = true;

            return loadMorePanel;
        }
    }
}
