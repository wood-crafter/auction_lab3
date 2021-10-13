
namespace Lab3
{
    partial class Display
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.bidToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnBidForm = new System.Windows.Forms.Button();
            this.btnPlaceForm = new System.Windows.Forms.Button();
            this.btnDisplayForm = new System.Windows.Forms.Button();
            this.lblMember = new System.Windows.Forms.Label();
            this.cbxMember = new System.Windows.Forms.ComboBox();
            this.lblItems = new System.Windows.Forms.Label();
            this.cbxItem = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNo = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bidToolStripMenuItem,
            this.itemToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(957, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // bidToolStripMenuItem
            // 
            this.bidToolStripMenuItem.Name = "bidToolStripMenuItem";
            this.bidToolStripMenuItem.Size = new System.Drawing.Size(45, 24);
            this.bidToolStripMenuItem.Text = "Bid";
            // 
            // itemToolStripMenuItem
            // 
            this.itemToolStripMenuItem.Name = "itemToolStripMenuItem";
            this.itemToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.itemToolStripMenuItem.Text = "Item";
            // 
            // btnBidForm
            // 
            this.btnBidForm.Location = new System.Drawing.Point(12, 43);
            this.btnBidForm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBidForm.Name = "btnBidForm";
            this.btnBidForm.Size = new System.Drawing.Size(75, 23);
            this.btnBidForm.TabIndex = 5;
            this.btnBidForm.Text = "Bid";
            this.btnBidForm.UseVisualStyleBackColor = true;
            this.btnBidForm.Click += new System.EventHandler(this.btnBidForm_Click);
            // 
            // btnPlaceForm
            // 
            this.btnPlaceForm.Location = new System.Drawing.Point(93, 43);
            this.btnPlaceForm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPlaceForm.Name = "btnPlaceForm";
            this.btnPlaceForm.Size = new System.Drawing.Size(75, 23);
            this.btnPlaceForm.TabIndex = 6;
            this.btnPlaceForm.Text = "Place";
            this.btnPlaceForm.UseVisualStyleBackColor = true;
            this.btnPlaceForm.Click += new System.EventHandler(this.btnPlaceForm_Click);
            // 
            // btnDisplayForm
            // 
            this.btnDisplayForm.Location = new System.Drawing.Point(173, 43);
            this.btnDisplayForm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDisplayForm.Name = "btnDisplayForm";
            this.btnDisplayForm.Size = new System.Drawing.Size(75, 23);
            this.btnDisplayForm.TabIndex = 7;
            this.btnDisplayForm.Text = "Display";
            this.btnDisplayForm.UseVisualStyleBackColor = true;
            // 
            // lblMember
            // 
            this.lblMember.AutoSize = true;
            this.lblMember.Location = new System.Drawing.Point(39, 82);
            this.lblMember.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMember.Name = "lblMember";
            this.lblMember.Size = new System.Drawing.Size(48, 17);
            this.lblMember.TabIndex = 8;
            this.lblMember.Text = "Seller:";
            // 
            // cbxMember
            // 
            this.cbxMember.FormattingEnabled = true;
            this.cbxMember.Location = new System.Drawing.Point(115, 79);
            this.cbxMember.Margin = new System.Windows.Forms.Padding(4);
            this.cbxMember.Name = "cbxMember";
            this.cbxMember.Size = new System.Drawing.Size(160, 24);
            this.cbxMember.TabIndex = 9;
            this.cbxMember.SelectedIndexChanged += new System.EventHandler(this.cbxMember_SelectedIndexChanged);
            // 
            // lblItems
            // 
            this.lblItems.AutoSize = true;
            this.lblItems.Location = new System.Drawing.Point(363, 82);
            this.lblItems.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblItems.Name = "lblItems";
            this.lblItems.Size = new System.Drawing.Size(38, 17);
            this.lblItems.TabIndex = 10;
            this.lblItems.Text = "Item:";
            // 
            // cbxItem
            // 
            this.cbxItem.FormattingEnabled = true;
            this.cbxItem.Location = new System.Drawing.Point(411, 79);
            this.cbxItem.Margin = new System.Windows.Forms.Padding(4);
            this.cbxItem.Name = "cbxItem";
            this.cbxItem.Size = new System.Drawing.Size(160, 24);
            this.cbxItem.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 127);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "List of bid: ";
            // 
            // lblNo
            // 
            this.lblNo.AutoSize = true;
            this.lblNo.Location = new System.Drawing.Point(124, 127);
            this.lblNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNo.Name = "lblNo";
            this.lblNo.Size = new System.Drawing.Size(16, 17);
            this.lblNo.TabIndex = 13;
            this.lblNo.Text = "0";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(43, 165);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(759, 314);
            this.dataGridView1.TabIndex = 14;
            this.dataGridView1.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridView1_DataBindingComplete);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(615, 79);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(100, 28);
            this.btnSearch.TabIndex = 15;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 506);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(476, 17);
            this.label11.TabIndex = 30;
            this.label11.Text = "Group 5: Phan Van Hung - Bui Tien Anh - Bui Dinh Hai - Nguyen Hai Long";
            // 
            // Display
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 532);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblNo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxItem);
            this.Controls.Add(this.lblItems);
            this.Controls.Add(this.cbxMember);
            this.Controls.Add(this.lblMember);
            this.Controls.Add(this.btnDisplayForm);
            this.Controls.Add(this.btnPlaceForm);
            this.Controls.Add(this.btnBidForm);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Display";
            this.Text = "Display";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem bidToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem itemToolStripMenuItem;
        private System.Windows.Forms.Button btnBidForm;
        private System.Windows.Forms.Button btnPlaceForm;
        private System.Windows.Forms.Button btnDisplayForm;
        private System.Windows.Forms.Label lblMember;
        private System.Windows.Forms.ComboBox cbxMember;
        private System.Windows.Forms.Label lblItems;
        private System.Windows.Forms.ComboBox cbxItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNo;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label11;
    }
}