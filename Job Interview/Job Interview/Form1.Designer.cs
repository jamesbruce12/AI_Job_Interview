namespace Job_Interview
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.conversationBox = new System.Windows.Forms.RichTextBox();
            this.responseBox = new System.Windows.Forms.RichTextBox();
            this.answerButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // conversationBox
            // 
            this.conversationBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.conversationBox.Location = new System.Drawing.Point(6, 150);
            this.conversationBox.Margin = new System.Windows.Forms.Padding(0);
            this.conversationBox.MaximumSize = new System.Drawing.Size(559, 298);
            this.conversationBox.MinimumSize = new System.Drawing.Size(559, 298);
            this.conversationBox.Name = "conversationBox";
            this.conversationBox.ReadOnly = true;
            this.conversationBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.conversationBox.Size = new System.Drawing.Size(559, 298);
            this.conversationBox.TabIndex = 0;
            this.conversationBox.Text = "";
            this.conversationBox.TextChanged += new System.EventHandler(this.conversationBox_TextChanged);
            // 
            // responseBox
            // 
            this.responseBox.BackColor = System.Drawing.Color.Snow;
            this.responseBox.Location = new System.Drawing.Point(4, 455);
            this.responseBox.Margin = new System.Windows.Forms.Padding(2);
            this.responseBox.MaxLength = 255;
            this.responseBox.Name = "responseBox";
            this.responseBox.Size = new System.Drawing.Size(449, 99);
            this.responseBox.TabIndex = 1;
            this.responseBox.Text = "";
            // 
            // answerButton
            // 
            this.answerButton.BackColor = System.Drawing.Color.Transparent;
            this.answerButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("answerButton.BackgroundImage")));
            this.answerButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.answerButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.answerButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.answerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.answerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answerButton.ForeColor = System.Drawing.Color.Transparent;
            this.answerButton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.answerButton.Location = new System.Drawing.Point(459, 457);
            this.answerButton.Margin = new System.Windows.Forms.Padding(0);
            this.answerButton.Name = "answerButton";
            this.answerButton.Size = new System.Drawing.Size(106, 98);
            this.answerButton.TabIndex = 2;
            this.answerButton.UseVisualStyleBackColor = false;
            this.answerButton.Click += new System.EventHandler(this.answerButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(8, 9);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(156, 135);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(167, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 31);
            this.label1.TabIndex = 4;
            this.label1.Text = "Kathy";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Location = new System.Drawing.Point(169, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Online";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.answerButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(579, 561);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.answerButton);
            this.Controls.Add(this.responseBox);
            this.Controls.Add(this.conversationBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Location = new System.Drawing.Point(500, 500);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Online Interview";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox conversationBox;
        private System.Windows.Forms.RichTextBox responseBox;
        private System.Windows.Forms.Button answerButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

