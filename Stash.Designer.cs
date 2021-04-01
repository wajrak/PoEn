
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Stash));
            this.pnlStash = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // pnlStash
            // 
            this.pnlStash.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlStash.Location = new System.Drawing.Point(0, 0);
            this.pnlStash.Name = "pnlStash";
            this.pnlStash.Size = new System.Drawing.Size(800, 450);
            this.pnlStash.TabIndex = 0;
            // 
            // Stash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlStash);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Stash";
            this.Text = "Stash";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlStash;
    }
}