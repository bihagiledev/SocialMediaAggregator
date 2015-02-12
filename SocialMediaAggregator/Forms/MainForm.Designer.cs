using System.Drawing;
using System.Windows.Forms;
namespace SocialMediaAggregator.Forms
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.TopPanel = new System.Windows.Forms.Panel();
            this.PostButton = new System.Windows.Forms.Button();
            this.SortLabel = new System.Windows.Forms.Label();
            this.SortComboBox = new System.Windows.Forms.ComboBox();
            this.UserFeedButton = new System.Windows.Forms.Button();
            this.SeparatorLabel = new System.Windows.Forms.Label();
            this.AboutButton = new System.Windows.Forms.Button();
            this.AboutButtonContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.FriendsButton = new System.Windows.Forms.Button();
            this.NewsFeedButton = new System.Windows.Forms.Button();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.NewsFeedPanel = new SocialMediaAggregator.Forms.NewsFeedPanel();
            this.UserFeedPanel = new SocialMediaAggregator.Forms.NewsFeedPanel();
            this.ContactListPanel = new SocialMediaAggregator.Forms.ContactListPanel();
            this.NewsFeedButtonToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.UserFeedButtonToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.FriendsButtonToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.AboutButtonToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.PostButtonToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.TopPanel.SuspendLayout();
            this.MainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // TopPanel
            // 
            this.TopPanel.AccessibleName = "TopPanel";
            this.TopPanel.Controls.Add(this.PostButton);
            this.TopPanel.Controls.Add(this.SortLabel);
            this.TopPanel.Controls.Add(this.SortComboBox);
            this.TopPanel.Controls.Add(this.UserFeedButton);
            this.TopPanel.Controls.Add(this.SeparatorLabel);
            this.TopPanel.Controls.Add(this.AboutButton);
            this.TopPanel.Controls.Add(this.FriendsButton);
            this.TopPanel.Controls.Add(this.NewsFeedButton);
            this.TopPanel.Location = new System.Drawing.Point(12, 5);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(800, 94);
            this.TopPanel.TabIndex = 0;
            // 
            // PostButton
            // 
            this.PostButton.AccessibleName = "FriendsButton";
            this.PostButton.BackColor = System.Drawing.Color.Transparent;
            this.PostButton.FlatAppearance.BorderSize = 0;
            this.PostButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue;
            this.PostButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PostButton.Font = new System.Drawing.Font("Calibri", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PostButton.ForeColor = System.Drawing.Color.SteelBlue;
            this.PostButton.Image = ((System.Drawing.Image)(resources.GetObject("PostButton.Image")));
            this.PostButton.Location = new System.Drawing.Point(359, 8);
            this.PostButton.Name = "PostButton";
            this.PostButton.Size = new System.Drawing.Size(90, 57);
            this.PostButton.TabIndex = 10;
            this.PostButton.UseVisualStyleBackColor = false;
            this.PostButton.Click += new System.EventHandler(this.PostButton_Click);
            // 
            // SortLabel
            // 
            this.SortLabel.AutoSize = true;
            this.SortLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SortLabel.Location = new System.Drawing.Point(16, 70);
            this.SortLabel.Name = "SortLabel";
            this.SortLabel.Size = new System.Drawing.Size(47, 13);
            this.SortLabel.TabIndex = 9;
            this.SortLabel.Text = "Sort by";
            // 
            // SortComboBox
            // 
            this.SortComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SortComboBox.FormattingEnabled = true;
            this.SortComboBox.Items.AddRange(new object[] {
            "Date",
            "Popularity"});
            this.SortComboBox.Location = new System.Drawing.Point(69, 67);
            this.SortComboBox.Name = "SortComboBox";
            this.SortComboBox.Size = new System.Drawing.Size(70, 21);
            this.SortComboBox.TabIndex = 8;
            this.SortComboBox.SelectedValueChanged += new System.EventHandler(this.SortComboBox_SelectedValueChanged);
            // 
            // UserFeedButton
            // 
            this.UserFeedButton.AccessibleName = "NewsFeedButton";
            this.UserFeedButton.BackColor = System.Drawing.Color.Transparent;
            this.UserFeedButton.FlatAppearance.BorderSize = 0;
            this.UserFeedButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue;
            this.UserFeedButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UserFeedButton.Font = new System.Drawing.Font("Calibri", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserFeedButton.ForeColor = System.Drawing.Color.SteelBlue;
            this.UserFeedButton.Image = ((System.Drawing.Image)(resources.GetObject("UserFeedButton.Image")));
            this.UserFeedButton.Location = new System.Drawing.Point(159, 10);
            this.UserFeedButton.Name = "UserFeedButton";
            this.UserFeedButton.Size = new System.Drawing.Size(90, 57);
            this.UserFeedButton.TabIndex = 6;
            this.UserFeedButton.UseVisualStyleBackColor = false;
            this.UserFeedButton.Click += new System.EventHandler(this.UserFeedButton_Click);
            // 
            // SeparatorLabel
            // 
            this.SeparatorLabel.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.SeparatorLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.SeparatorLabel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SeparatorLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.SeparatorLabel.Location = new System.Drawing.Point(8, 92);
            this.SeparatorLabel.Name = "SeparatorLabel";
            this.SeparatorLabel.Size = new System.Drawing.Size(784, 2);
            this.SeparatorLabel.TabIndex = 5;
            // 
            // AboutButton
            // 
            this.AboutButton.AccessibleName = "AboutButton";
            this.AboutButton.BackColor = System.Drawing.Color.Transparent;
            this.AboutButton.ContextMenuStrip = this.AboutButtonContextMenuStrip;
            this.AboutButton.FlatAppearance.BorderSize = 0;
            this.AboutButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue;
            this.AboutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AboutButton.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AboutButton.ForeColor = System.Drawing.Color.Silver;
            this.AboutButton.Image = ((System.Drawing.Image)(resources.GetObject("AboutButton.Image")));
            this.AboutButton.Location = new System.Drawing.Point(692, 3);
            this.AboutButton.Name = "AboutButton";
            this.AboutButton.Size = new System.Drawing.Size(75, 75);
            this.AboutButton.TabIndex = 2;
            this.AboutButton.UseVisualStyleBackColor = false;
            // 
            // AboutButtonContextMenuStrip
            // 
            this.AboutButtonContextMenuStrip.Name = "AboutButtonContextMenuStrip";
            this.AboutButtonContextMenuStrip.Size = new System.Drawing.Size(153, 26);
            this.AboutButtonContextMenuStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.AboutButtonContextMenuStrip_ItemClicked);
            // 
            // FriendsButton
            // 
            this.FriendsButton.AccessibleName = "FriendsButton";
            this.FriendsButton.BackColor = System.Drawing.Color.Transparent;
            this.FriendsButton.FlatAppearance.BorderSize = 0;
            this.FriendsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue;
            this.FriendsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FriendsButton.Font = new System.Drawing.Font("Calibri", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FriendsButton.ForeColor = System.Drawing.Color.SteelBlue;
            this.FriendsButton.Image = ((System.Drawing.Image)(resources.GetObject("FriendsButton.Image")));
            this.FriendsButton.Location = new System.Drawing.Point(259, 8);
            this.FriendsButton.Name = "FriendsButton";
            this.FriendsButton.Size = new System.Drawing.Size(90, 57);
            this.FriendsButton.TabIndex = 1;
            this.FriendsButton.UseVisualStyleBackColor = false;
            this.FriendsButton.Click += new System.EventHandler(this.FriendsButton_Click);
            // 
            // NewsFeedButton
            // 
            this.NewsFeedButton.AccessibleName = "NewsFeedButton";
            this.NewsFeedButton.BackColor = System.Drawing.Color.Transparent;
            this.NewsFeedButton.FlatAppearance.BorderSize = 0;
            this.NewsFeedButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue;
            this.NewsFeedButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NewsFeedButton.Font = new System.Drawing.Font("Calibri", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewsFeedButton.ForeColor = System.Drawing.Color.SteelBlue;
            this.NewsFeedButton.Image = ((System.Drawing.Image)(resources.GetObject("NewsFeedButton.Image")));
            this.NewsFeedButton.Location = new System.Drawing.Point(59, 10);
            this.NewsFeedButton.Name = "NewsFeedButton";
            this.NewsFeedButton.Size = new System.Drawing.Size(90, 57);
            this.NewsFeedButton.TabIndex = 0;
            this.NewsFeedButton.UseVisualStyleBackColor = false;
            this.NewsFeedButton.Click += new System.EventHandler(this.NewsFeedButton_Click);
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.NewsFeedPanel);
            this.MainPanel.Controls.Add(this.UserFeedPanel);
            this.MainPanel.Controls.Add(this.ContactListPanel);
            this.MainPanel.Location = new System.Drawing.Point(12, 105);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(800, 445);
            this.MainPanel.TabIndex = 0;
            // 
            // NewsFeedPanel
            // 
            this.NewsFeedPanel.AutoScroll = true;
            this.NewsFeedPanel.AutoScrollMargin = new System.Drawing.Size(5, 5);
            this.NewsFeedPanel.ColumnCount = 1;
            this.NewsFeedPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.NewsFeedPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.NewsFeedPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.NewsFeedPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.NewsFeedPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.NewsFeedPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.NewsFeedPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NewsFeedPanel.LoadMoreHandler = null;
            this.NewsFeedPanel.Location = new System.Drawing.Point(0, 0);
            this.NewsFeedPanel.Name = "NewsFeedPanel";
            this.NewsFeedPanel.Size = new System.Drawing.Size(800, 445);
            this.NewsFeedPanel.TabIndex = 0;
            // 
            // UserFeedPanel
            // 
            this.UserFeedPanel.AutoScroll = true;
            this.UserFeedPanel.AutoScrollMargin = new System.Drawing.Size(5, 5);
            this.UserFeedPanel.ColumnCount = 1;
            this.UserFeedPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.UserFeedPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.UserFeedPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.UserFeedPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.UserFeedPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.UserFeedPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.UserFeedPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UserFeedPanel.LoadMoreHandler = null;
            this.UserFeedPanel.Location = new System.Drawing.Point(0, 0);
            this.UserFeedPanel.Name = "UserFeedPanel";
            this.UserFeedPanel.Size = new System.Drawing.Size(800, 445);
            this.UserFeedPanel.TabIndex = 1;
            // 
            // ContactListPanel
            // 
            this.ContactListPanel.AutoScroll = true;
            this.ContactListPanel.AutoScrollMargin = new System.Drawing.Size(5, 5);
            this.ContactListPanel.ColumnCount = 1;
            this.ContactListPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ContactListPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ContactListPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ContactListPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ContactListPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ContactListPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ContactListPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContactListPanel.Location = new System.Drawing.Point(0, 0);
            this.ContactListPanel.Name = "ContactListPanel";
            this.ContactListPanel.Size = new System.Drawing.Size(800, 445);
            this.ContactListPanel.TabIndex = 2;
            // 
            // NewsFeedButtonToolTip
            // 
            this.NewsFeedButtonToolTip.ToolTipTitle = "News Feed";
            // 
            // UserFeedButtonToolTip
            // 
            this.UserFeedButtonToolTip.ToolTipTitle = "User Feed";
            // 
            // FriendsButtonToolTip
            // 
            this.FriendsButtonToolTip.ToolTipTitle = "Friends";
            // 
            // AboutButtonToolTip
            // 
            this.AboutButtonToolTip.ToolTipTitle = "About";
            // 
            // PostButtonToolTip
            // 
            this.PostButtonToolTip.ToolTipTitle = "Post";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(827, 587);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.TopPanel);
            this.Name = "MainForm";
            this.Text = "SocialMediaAggregator";
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            this.MainPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
        }

        #endregion

        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Button NewsFeedButton;
        private System.Windows.Forms.Button FriendsButton;
        private Button UserFeedButton;
        private Button AboutButton;
        private Label SeparatorLabel;
        private Panel MainPanel;
        private NewsFeedPanel NewsFeedPanel;
        private NewsFeedPanel UserFeedPanel;
        private ContactListPanel ContactListPanel;
        private ToolTip NewsFeedButtonToolTip;
        private ToolTip UserFeedButtonToolTip;
        private ToolTip FriendsButtonToolTip;
        private ToolTip AboutButtonToolTip;
        private ComboBox SortComboBox;
        private Label SortLabel;
        private Button PostButton;
        private ToolTip PostButtonToolTip;
        private ContextMenuStrip AboutButtonContextMenuStrip;
    }
}

