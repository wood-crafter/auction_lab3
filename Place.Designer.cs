
namespace Lab3
{
    partial class Place
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbMinimum = new System.Windows.Forms.Label();
            this.cbSeller = new System.Windows.Forms.ComboBox();
            this.cbItemType = new System.Windows.Forms.ComboBox();
            this.tbItemName = new System.Windows.Forms.TextBox();
            this.tbCurrentPrice = new System.Windows.Forms.TextBox();
            this.tbItemDes = new System.Windows.Forms.TextBox();
            this.txtMinumum = new System.Windows.Forms.TextBox();
            this.dtPDateTime = new System.Windows.Forms.DateTimePicker();
            this.btnPlace = new System.Windows.Forms.Button();
            this.btnCancer = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
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
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
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
            this.btnBidForm.Location = new System.Drawing.Point(12, 46);
            this.btnBidForm.Name = "btnBidForm";
            this.btnBidForm.Size = new System.Drawing.Size(75, 23);
            this.btnBidForm.TabIndex = 4;
            this.btnBidForm.Text = "Bid";
            this.btnBidForm.UseVisualStyleBackColor = true;
            this.btnBidForm.Click += new System.EventHandler(this.btnBidForm_Click);
            // 
            // btnPlaceForm
            // 
            this.btnPlaceForm.Location = new System.Drawing.Point(93, 46);
            this.btnPlaceForm.Name = "btnPlaceForm";
            this.btnPlaceForm.Size = new System.Drawing.Size(75, 23);
            this.btnPlaceForm.TabIndex = 5;
            this.btnPlaceForm.Text = "Place";
            this.btnPlaceForm.UseVisualStyleBackColor = true;
            // 
            // btnDisplayForm
            // 
            this.btnDisplayForm.Location = new System.Drawing.Point(174, 46);
            this.btnDisplayForm.Name = "btnDisplayForm";
            this.btnDisplayForm.Size = new System.Drawing.Size(75, 23);
            this.btnDisplayForm.TabIndex = 6;
            this.btnDisplayForm.Text = "Display";
            this.btnDisplayForm.UseVisualStyleBackColor = true;
            this.btnDisplayForm.Click += new System.EventHandler(this.btnDisplayForm_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Seller:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Item Type:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Item Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 233);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Current Price:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(53, 275);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "End Date Time:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(399, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Item Description:";
            // 
            // tbMinimum
            // 
            this.tbMinimum.AutoSize = true;
            this.tbMinimum.Location = new System.Drawing.Point(402, 145);
            this.tbMinimum.Name = "tbMinimum";
            this.tbMinimum.Size = new System.Drawing.Size(160, 17);
            this.tbMinimum.TabIndex = 13;
            this.tbMinimum.Text = "Minimum bid increment: ";
            // 
            // cbSeller
            // 
            this.cbSeller.FormattingEnabled = true;
            this.cbSeller.Location = new System.Drawing.Point(174, 98);
            this.cbSeller.Name = "cbSeller";
            this.cbSeller.Size = new System.Drawing.Size(187, 24);
            this.cbSeller.TabIndex = 14;
            // 
            // cbItemType
            // 
            this.cbItemType.FormattingEnabled = true;
            this.cbItemType.Location = new System.Drawing.Point(174, 138);
            this.cbItemType.Name = "cbItemType";
            this.cbItemType.Size = new System.Drawing.Size(187, 24);
            this.cbItemType.TabIndex = 15;
            // 
            // tbItemName
            // 
            this.tbItemName.Location = new System.Drawing.Point(174, 185);
            this.tbItemName.Name = "tbItemName";
            this.tbItemName.Size = new System.Drawing.Size(187, 22);
            this.tbItemName.TabIndex = 16;
            // 
            // tbCurrentPrice
            // 
            this.tbCurrentPrice.Location = new System.Drawing.Point(174, 233);
            this.tbCurrentPrice.Name = "tbCurrentPrice";
            this.tbCurrentPrice.Size = new System.Drawing.Size(187, 22);
            this.tbCurrentPrice.TabIndex = 17;
            // 
            // tbItemDes
            // 
            this.tbItemDes.Location = new System.Drawing.Point(568, 102);
            this.tbItemDes.Name = "tbItemDes";
            this.tbItemDes.Size = new System.Drawing.Size(199, 22);
            this.tbItemDes.TabIndex = 18;
            // 
            // txtMinumum
            // 
            this.txtMinumum.Location = new System.Drawing.Point(568, 138);
            this.txtMinumum.Name = "txtMinumum";
            this.txtMinumum.Size = new System.Drawing.Size(199, 22);
            this.txtMinumum.TabIndex = 19;
            // 
            // dtPDateTime
            // 
            this.dtPDateTime.Location = new System.Drawing.Point(174, 275);
            this.dtPDateTime.Name = "dtPDateTime";
            this.dtPDateTime.Size = new System.Drawing.Size(252, 22);
            this.dtPDateTime.TabIndex = 20;
            // 
            // btnPlace
            // 
            this.btnPlace.Location = new System.Drawing.Point(247, 343);
            this.btnPlace.Name = "btnPlace";
            this.btnPlace.Size = new System.Drawing.Size(75, 23);
            this.btnPlace.TabIndex = 21;
            this.btnPlace.Text = "Place";
            this.btnPlace.UseVisualStyleBackColor = true;
            this.btnPlace.Click += new System.EventHandler(this.btnPlace_Click);
            // 
            // btnCancer
            // 
            this.btnCancer.Location = new System.Drawing.Point(442, 343);
            this.btnCancer.Name = "btnCancer";
            this.btnCancer.Size = new System.Drawing.Size(75, 23);
            this.btnCancer.TabIndex = 22;
            this.btnCancer.Text = "Cancer";
            this.btnCancer.UseVisualStyleBackColor = true;
            this.btnCancer.Click += new System.EventHandler(this.btnCancer_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(22, 424);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(476, 17);
            this.label11.TabIndex = 30;
            this.label11.Text = "Group 5: Phan Van Hung - Bui Tien Anh - Bui Dinh Hai - Nguyen Hai Long";
            // 
            // Place
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnCancer);
            this.Controls.Add(this.btnPlace);
            this.Controls.Add(this.dtPDateTime);
            this.Controls.Add(this.txtMinumum);
            this.Controls.Add(this.tbItemDes);
            this.Controls.Add(this.tbCurrentPrice);
            this.Controls.Add(this.tbItemName);
            this.Controls.Add(this.cbItemType);
            this.Controls.Add(this.cbSeller);
            this.Controls.Add(this.tbMinimum);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDisplayForm);
            this.Controls.Add(this.btnPlaceForm);
            this.Controls.Add(this.btnBidForm);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Place";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label tbMinimum;
        private System.Windows.Forms.ComboBox cbSeller;
        private System.Windows.Forms.ComboBox cbItemType;
        private System.Windows.Forms.TextBox tbItemName;
        private System.Windows.Forms.TextBox tbCurrentPrice;
        private System.Windows.Forms.TextBox tbItemDes;
        private System.Windows.Forms.TextBox txtMinumum;
        private System.Windows.Forms.DateTimePicker dtPDateTime;
        private System.Windows.Forms.Button btnPlace;
        private System.Windows.Forms.Button btnCancer;
        private System.Windows.Forms.Label label11;
    }
}