namespace Kadoma_City_Council
{
    partial class SearchUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lollipopButton1 = new LollipopButton();
            this.lollipopLabel1 = new LollipopLabel();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(131, 38);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(583, 20);
            this.textBox1.TabIndex = 0;
            // 
            // lollipopButton1
            // 
            this.lollipopButton1.BackColor = System.Drawing.Color.Transparent;
            this.lollipopButton1.BGColor = "#508ef5";
            this.lollipopButton1.FontColor = "#ffffff";
            this.lollipopButton1.Location = new System.Drawing.Point(131, 79);
            this.lollipopButton1.Name = "lollipopButton1";
            this.lollipopButton1.Size = new System.Drawing.Size(143, 32);
            this.lollipopButton1.TabIndex = 1;
            this.lollipopButton1.Text = "Search";
            this.lollipopButton1.Click += new System.EventHandler(this.LollipopButton1_Click);
            // 
            // lollipopLabel1
            // 
            this.lollipopLabel1.AutoSize = true;
            this.lollipopLabel1.BackColor = System.Drawing.Color.Transparent;
            this.lollipopLabel1.Font = new System.Drawing.Font("Source Code Pro", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lollipopLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.lollipopLabel1.Location = new System.Drawing.Point(25, 37);
            this.lollipopLabel1.Name = "lollipopLabel1";
            this.lollipopLabel1.Size = new System.Drawing.Size(45, 19);
            this.lollipopLabel1.TabIndex = 2;
            this.lollipopLabel1.Text = "Name";
            // 
            // SearchUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(30)))), ((int)(((byte)(95)))));
            this.Controls.Add(this.lollipopLabel1);
            this.Controls.Add(this.lollipopButton1);
            this.Controls.Add(this.textBox1);
            this.Name = "SearchUserControl";
            this.Size = new System.Drawing.Size(783, 412);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private LollipopButton lollipopButton1;
        private LollipopLabel lollipopLabel1;
    }
}
