
namespace Lab3
{
    partial class Bid
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.bidToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblBidder = new System.Windows.Forms.Label();
            this.cbxBidder = new System.Windows.Forms.ComboBox();
            this.btnBidForm = new System.Windows.Forms.Button();
            this.btnPlaceForm = new System.Windows.Forms.Button();
            this.btnDisplayForm = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxItem = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtItemDescription = new System.Windows.Forms.TextBox();
            this.txtCurrentPrice = new System.Windows.Forms.TextBox();
            this.txtEdt = new System.Windows.Forms.TextBox();
            this.txtBidPirce = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSeller = new System.Windows.Forms.TextBox();
            this.txtMbi = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.labelTime = new System.Windows.Forms.Label();
            this.labelTimeRe = new System.Windows.Forms.Label();
            this.btnBid = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
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
            this.menuStrip1.Size = new System.Drawing.Size(914, 28);
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
            // lblBidder
            // 
            this.lblBidder.AutoSize = true;
            this.lblBidder.Location = new System.Drawing.Point(60, 101);
            this.lblBidder.Name = "lblBidder";
            this.lblBidder.Size = new System.Drawing.Size(49, 17);
            this.lblBidder.TabIndex = 1;
            this.lblBidder.Text = "Bidder";
            // 
            // cbxBidder
            // 
            this.cbxBidder.FormattingEnabled = true;
            this.cbxBidder.Location = new System.Drawing.Point(125, 98);
            this.cbxBidder.Name = "cbxBidder";
            this.cbxBidder.Size = new System.Drawing.Size(121, 24);
            this.cbxBidder.TabIndex = 2;
            this.cbxBidder.SelectedIndexChanged += new System.EventHandler(this.cbxBidder_SelectedIndexChanged);
            // 
            // btnBidForm
            // 
            this.btnBidForm.Location = new System.Drawing.Point(12, 44);
            this.btnBidForm.Name = "btnBidForm";
            this.btnBidForm.Size = new System.Drawing.Size(75, 23);
            this.btnBidForm.TabIndex = 3;
            this.btnBidForm.Text = "Bid";
            this.btnBidForm.UseVisualStyleBackColor = true;
            this.btnBidForm.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnPlaceForm
            // 
            this.btnPlaceForm.Location = new System.Drawing.Point(93, 44);
            this.btnPlaceForm.Name = "btnPlaceForm";
            this.btnPlaceForm.Size = new System.Drawing.Size(75, 23);
            this.btnPlaceForm.TabIndex = 4;
            this.btnPlaceForm.Text = "Place";
            this.btnPlaceForm.UseVisualStyleBackColor = true;
            this.btnPlaceForm.Click += new System.EventHandler(this.btnPlaceForm_Click);
            // 
            // btnDisplayForm
            // 
            this.btnDisplayForm.Location = new System.Drawing.Point(174, 44);
            this.btnDisplayForm.Name = "btnDisplayForm";
            this.btnDisplayForm.Size = new System.Drawing.Size(75, 23);
            this.btnDisplayForm.TabIndex = 5;
            this.btnDisplayForm.Text = "Display";
            this.btnDisplayForm.UseVisualStyleBackColor = true;
            this.btnDisplayForm.Click += new System.EventHandler(this.btnDisplayForm_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Item";
            // 
            // cbxItem
            // 
            this.cbxItem.FormattingEnabled = true;
            this.cbxItem.Location = new System.Drawing.Point(125, 145);
            this.cbxItem.Name = "cbxItem";
            this.cbxItem.Size = new System.Drawing.Size(121, 24);
            this.cbxItem.TabIndex = 7;
            this.cbxItem.SelectedIndexChanged += new System.EventHandler(this.cbxItem_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Item description";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 246);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = " Current price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 294);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "End date time";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(47, 336);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Bid date time";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(50, 390);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Bid price";
            // 
            // txtItemDescription
            // 
            this.txtItemDescription.Location = new System.Drawing.Point(174, 198);
            this.txtItemDescription.Name = "txtItemDescription";
            this.txtItemDescription.Size = new System.Drawing.Size(208, 22);
            this.txtItemDescription.TabIndex = 13;
            // 
            // txtCurrentPrice
            // 
            this.txtCurrentPrice.Location = new System.Drawing.Point(174, 240);
            this.txtCurrentPrice.Name = "txtCurrentPrice";
            this.txtCurrentPrice.Size = new System.Drawing.Size(208, 22);
            this.txtCurrentPrice.TabIndex = 14;
            // 
            // txtEdt
            // 
            this.txtEdt.Location = new System.Drawing.Point(174, 294);
            this.txtEdt.Name = "txtEdt";
            this.txtEdt.Size = new System.Drawing.Size(208, 22);
            this.txtEdt.TabIndex = 15;
            // 
            // txtBidPirce
            // 
            this.txtBidPirce.Location = new System.Drawing.Point(174, 390);
            this.txtBidPirce.Name = "txtBidPirce";
            this.txtBidPirce.Size = new System.Drawing.Size(100, 22);
            this.txtBidPirce.TabIndex = 17;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(502, 444);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 18;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(527, 197);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 17);
            this.label7.TabIndex = 19;
            this.label7.Text = "Seller";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(527, 243);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(152, 17);
            this.label8.TabIndex = 20;
            this.label8.Text = "Minimum bid increment";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(527, 336);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(109, 17);
            this.label9.TabIndex = 21;
            this.label9.Text = " Time remaining";
            // 
            // txtSeller
            // 
            this.txtSeller.Location = new System.Drawing.Point(704, 191);
            this.txtSeller.Name = "txtSeller";
            this.txtSeller.Size = new System.Drawing.Size(173, 22);
            this.txtSeller.TabIndex = 22;
            // 
            // txtMbi
            // 
            this.txtMbi.Location = new System.Drawing.Point(704, 246);
            this.txtMbi.Name = "txtMbi";
            this.txtMbi.Size = new System.Drawing.Size(100, 22);
            this.txtMbi.TabIndex = 23;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Location = new System.Drawing.Point(174, 340);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(54, 17);
            this.labelTime.TabIndex = 25;
            this.labelTime.Text = "label10";
            // 
            // labelTimeRe
            // 
            this.labelTimeRe.AutoSize = true;
            this.labelTimeRe.Location = new System.Drawing.Point(704, 336);
            this.labelTimeRe.Name = "labelTimeRe";
            this.labelTimeRe.Size = new System.Drawing.Size(54, 17);
            this.labelTimeRe.TabIndex = 26;
            this.labelTimeRe.Text = "label10";
            // 
            // btnBid
            // 
            this.btnBid.Location = new System.Drawing.Point(306, 444);
            this.btnBid.Name = "btnBid";
            this.btnBid.Size = new System.Drawing.Size(75, 23);
            this.btnBid.TabIndex = 27;
            this.btnBid.Text = "Bid";
            this.btnBid.UseVisualStyleBackColor = true;
            this.btnBid.Click += new System.EventHandler(this.btnBid_Click);
            // 
            // Bid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 511);
            this.Controls.Add(this.btnBid);
            this.Controls.Add(this.labelTimeRe);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.txtMbi);
            this.Controls.Add(this.txtSeller);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtBidPirce);
            this.Controls.Add(this.txtEdt);
            this.Controls.Add(this.txtCurrentPrice);
            this.Controls.Add(this.txtItemDescription);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbxItem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDisplayForm);
            this.Controls.Add(this.btnPlaceForm);
            this.Controls.Add(this.btnBidForm);
            this.Controls.Add(this.cbxBidder);
            this.Controls.Add(this.lblBidder);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Bid";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cbxBidder;
        private System.Windows.Forms.Button btnBidForm;
        private System.Windows.Forms.Button btnPlaceForm;
        private System.Windows.Forms.Button btnDisplayForm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtItemDescription;
        private System.Windows.Forms.TextBox txtCurrentPrice;
        private System.Windows.Forms.TextBox txtEdt;
        private System.Windows.Forms.TextBox txtBidPirce;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtSeller;
        private System.Windows.Forms.TextBox txtMbi;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Label labelTimeRe;
        private System.Windows.Forms.Button btnBid;
        private System.Windows.Forms.ToolStripMenuItem bidToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem itemToolStripMenuItem;
        private System.Windows.Forms.Label lblBidder;
    }
}

