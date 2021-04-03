
namespace PoEn
{
    partial class Stash
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
            this.dgvStash = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.cmbStashList = new System.Windows.Forms.ComboBox();
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tpMain = new System.Windows.Forms.TabPage();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblItemsTotalWorth = new System.Windows.Forms.Label();
            this.lblItemsCount = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStash)).BeginInit();
            this.tabMain.SuspendLayout();
            this.tpMain.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvStash
            // 
            this.dgvStash.AllowUserToAddRows = false;
            this.dgvStash.AllowUserToDeleteRows = false;
            this.dgvStash.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvStash.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvStash.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStash.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvStash.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.dgvStash.Location = new System.Drawing.Point(3, 3);
            this.dgvStash.MultiSelect = false;
            this.dgvStash.Name = "dgvStash";
            this.dgvStash.ReadOnly = true;
            this.dgvStash.RowHeadersWidth = 25;
            this.dgvStash.RowTemplate.Height = 24;
            this.dgvStash.Size = new System.Drawing.Size(786, 455);
            this.dgvStash.TabIndex = 0;
            this.dgvStash.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvStash_RowPostPaint);
            this.dgvStash.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvStash_RowsAdded);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(799, 131);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(198, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Quad Grid (48)";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(799, 160);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(198, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Standard Grid (24)";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Location = new System.Drawing.Point(799, 218);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(198, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Reload StashList";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // cmbStashList
            // 
            this.cmbStashList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbStashList.FormattingEnabled = true;
            this.cmbStashList.Location = new System.Drawing.Point(808, 459);
            this.cmbStashList.Name = "cmbStashList";
            this.cmbStashList.Size = new System.Drawing.Size(189, 24);
            this.cmbStashList.TabIndex = 4;
            this.cmbStashList.SelectedIndexChanged += new System.EventHandler(this.cmbStashList_SelectedIndexChanged);
            // 
            // tabMain
            // 
            this.tabMain.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tabMain.Controls.Add(this.tpMain);
            this.tabMain.Location = new System.Drawing.Point(-3, 0);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(800, 490);
            this.tabMain.TabIndex = 5;
            // 
            // tpMain
            // 
            this.tpMain.BackColor = System.Drawing.Color.Red;
            this.tpMain.Controls.Add(this.dgvStash);
            this.tpMain.Location = new System.Drawing.Point(4, 25);
            this.tpMain.Name = "tpMain";
            this.tpMain.Padding = new System.Windows.Forms.Padding(3);
            this.tpMain.Size = new System.Drawing.Size(792, 461);
            this.tpMain.TabIndex = 0;
            this.tpMain.Text = "MAIN";
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.Location = new System.Drawing.Point(799, 276);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(198, 23);
            this.button4.TabIndex = 6;
            this.button4.Text = "Test FrameDraw";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button5.Location = new System.Drawing.Point(799, 305);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(198, 23);
            this.button5.TabIndex = 7;
            this.button5.Text = "Reload Items";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.lblItemsTotalWorth);
            this.groupBox1.Controls.Add(this.lblItemsCount);
            this.groupBox1.Location = new System.Drawing.Point(799, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(198, 100);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Statistics:";
            // 
            // lblItemsTotalWorth
            // 
            this.lblItemsTotalWorth.AutoSize = true;
            this.lblItemsTotalWorth.Location = new System.Drawing.Point(6, 35);
            this.lblItemsTotalWorth.Name = "lblItemsTotalWorth";
            this.lblItemsTotalWorth.Size = new System.Drawing.Size(141, 17);
            this.lblItemsTotalWorth.TabIndex = 1;
            this.lblItemsTotalWorth.Text = "Items total worth: N\\A";
            // 
            // lblItemsCount
            // 
            this.lblItemsCount.AutoSize = true;
            this.lblItemsCount.Location = new System.Drawing.Point(6, 18);
            this.lblItemsCount.Name = "lblItemsCount";
            this.lblItemsCount.Size = new System.Drawing.Size(111, 17);
            this.lblItemsCount.TabIndex = 0;
            this.lblItemsCount.Text = "Items count: N\\A";
            // 
            // button6
            // 
            this.button6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button6.Location = new System.Drawing.Point(799, 247);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(198, 23);
            this.button6.TabIndex = 8;
            this.button6.Text = "Reload Tabs";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button7.Location = new System.Drawing.Point(799, 189);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(198, 23);
            this.button7.TabIndex = 9;
            this.button7.Text = "Test Grid (50)";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(854, 386);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 23);
            this.button8.TabIndex = 10;
            this.button8.Text = "button8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // Stash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 490);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.cmbStashList);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tabMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Stash";
            this.Text = "Stash";
            ((System.ComponentModel.ISupportInitialize)(this.dgvStash)).EndInit();
            this.tabMain.ResumeLayout(false);
            this.tpMain.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvStash;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox cmbStashList;
        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage tpMain;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblItemsTotalWorth;
        private System.Windows.Forms.Label lblItemsCount;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
    }
}