
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvStash)).BeginInit();
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
            this.dgvStash.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvStash.Location = new System.Drawing.Point(0, 0);
            this.dgvStash.MultiSelect = false;
            this.dgvStash.Name = "dgvStash";
            this.dgvStash.ReadOnly = true;
            this.dgvStash.RowHeadersWidth = 25;
            this.dgvStash.RowTemplate.Height = 24;
            this.dgvStash.Size = new System.Drawing.Size(800, 450);
            this.dgvStash.TabIndex = 0;
            this.dgvStash.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvStash_RowPostPaint);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(713, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(632, 415);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Stash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvStash);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Stash";
            this.Text = "Stash";
            ((System.ComponentModel.ISupportInitialize)(this.dgvStash)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvStash;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}