namespace sakilaUI
{
    partial class MovieDetailsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MovieDetailsForm));
            this.title = new System.Windows.Forms.Label();
            this.category = new System.Windows.Forms.Label();
            this.language = new System.Windows.Forms.Label();
            this.textLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.description = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.duration = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.rating = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.actorsListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.SystemColors.Highlight;
            this.title.Location = new System.Drawing.Point(31, 21);
            this.title.MaximumSize = new System.Drawing.Size(400, 500);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(128, 44);
            this.title.TabIndex = 0;
            this.title.Text = "label1";
            // 
            // category
            // 
            this.category.AutoSize = true;
            this.category.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.category.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.category.Location = new System.Drawing.Point(3, 9);
            this.category.Name = "category";
            this.category.Size = new System.Drawing.Size(52, 17);
            this.category.TabIndex = 1;
            this.category.Text = "label1";
            // 
            // language
            // 
            this.language.AutoSize = true;
            this.language.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.language.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.language.Location = new System.Drawing.Point(12, 9);
            this.language.Name = "language";
            this.language.Size = new System.Drawing.Size(52, 17);
            this.language.TabIndex = 2;
            this.language.Text = "label2";
            // 
            // textLabel
            // 
            this.textLabel.AutoSize = true;
            this.textLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textLabel.Location = new System.Drawing.Point(44, 235);
            this.textLabel.Name = "textLabel";
            this.textLabel.Size = new System.Drawing.Size(115, 24);
            this.textLabel.TabIndex = 3;
            this.textLabel.Text = "Description";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.description);
            this.panel1.Location = new System.Drawing.Point(60, 285);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(386, 106);
            this.panel1.TabIndex = 4;
            // 
            // description
            // 
            this.description.AutoSize = true;
            this.description.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.description.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.description.Location = new System.Drawing.Point(15, 12);
            this.description.MaximumSize = new System.Drawing.Size(400, 5000);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(52, 17);
            this.description.TabIndex = 0;
            this.description.Text = "label3";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(518, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(190, 254);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.Controls.Add(this.duration);
            this.panel2.Location = new System.Drawing.Point(533, 297);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(175, 35);
            this.panel2.TabIndex = 6;
            // 
            // duration
            // 
            this.duration.AutoSize = true;
            this.duration.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.duration.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.duration.Location = new System.Drawing.Point(101, 9);
            this.duration.Name = "duration";
            this.duration.Size = new System.Drawing.Size(52, 17);
            this.duration.TabIndex = 1;
            this.duration.Text = "label3";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel3.Controls.Add(this.rating);
            this.panel3.Location = new System.Drawing.Point(534, 352);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(173, 38);
            this.panel3.TabIndex = 7;
            // 
            // rating
            // 
            this.rating.AutoSize = true;
            this.rating.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rating.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.rating.Location = new System.Drawing.Point(100, 10);
            this.rating.Name = "rating";
            this.rating.Size = new System.Drawing.Size(52, 17);
            this.rating.TabIndex = 1;
            this.rating.Text = "label3";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel4.Controls.Add(this.category);
            this.panel4.Location = new System.Drawing.Point(60, 112);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(119, 37);
            this.panel4.TabIndex = 8;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel5.Controls.Add(this.language);
            this.panel5.Location = new System.Drawing.Point(60, 167);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(119, 37);
            this.panel5.TabIndex = 9;
            // 
            // actorsListBox
            // 
            this.actorsListBox.FormattingEnabled = true;
            this.actorsListBox.ItemHeight = 16;
            this.actorsListBox.Location = new System.Drawing.Point(291, 111);
            this.actorsListBox.Name = "actorsListBox";
            this.actorsListBox.Size = new System.Drawing.Size(181, 164);
            this.actorsListBox.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(199, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 29);
            this.label1.TabIndex = 11;
            this.label1.Text = "Actors";
            // 
            // MovieDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 439);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.actorsListBox);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textLabel);
            this.Controls.Add(this.title);
            this.Name = "MovieDetailsForm";
            this.Text = "MovieDetails";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label category;
        private System.Windows.Forms.Label language;
        private System.Windows.Forms.Label textLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label description;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label duration;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label rating;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.ListBox actorsListBox;
        private System.Windows.Forms.Label label1;
    }
}