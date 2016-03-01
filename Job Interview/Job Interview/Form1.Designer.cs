namespace Job_Interview
{
    partial class OnlineInterviewFormBackground
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
            System.Windows.Forms.Button answerButton;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OnlineInterviewFormBackground));
            this.conversationBox = new System.Windows.Forms.RichTextBox();
            this.responseBox = new System.Windows.Forms.RichTextBox();
            this.PictureBox = new System.Windows.Forms.PictureBox();
            this.Label_Name = new System.Windows.Forms.Label();
            this.Labal_OnlineStatus = new System.Windows.Forms.Label();
            answerButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // answerButton
            // 
            answerButton.BackColor = System.Drawing.Color.Transparent;
            answerButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("answerButton.BackgroundImage")));
            answerButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            answerButton.Cursor = System.Windows.Forms.Cursors.Hand;
            answerButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            answerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            answerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            answerButton.ForeColor = System.Drawing.Color.Transparent;
            answerButton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            answerButton.Location = new System.Drawing.Point(459, 457);
            answerButton.Margin = new System.Windows.Forms.Padding(0);
            answerButton.Name = "answerButton";
            answerButton.Size = new System.Drawing.Size(106, 98);
            answerButton.TabIndex = 2;
            answerButton.UseVisualStyleBackColor = false;
            answerButton.Click += new System.EventHandler(this.answerButton_Click);
            answerButton.FlatAppearance.MouseOverBackColor = answerButton.BackColor;           
            // 
            // conversationBox
            // 
            this.conversationBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.conversationBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.conversationBox.Location = new System.Drawing.Point(5, 150);
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
            this.responseBox.BackColor = System.Drawing.Color.SeaShell;
            this.responseBox.Location = new System.Drawing.Point(5, 455);
            this.responseBox.Margin = new System.Windows.Forms.Padding(2);
            this.responseBox.MaxLength = 255;
            this.responseBox.Name = "responseBox";
            this.responseBox.Size = new System.Drawing.Size(449, 99);
            this.responseBox.TabIndex = 1;
            this.responseBox.Text = "";
            // 
            // PictureBox
            // 
            this.PictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PictureBox.BackgroundImage")));
            this.PictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PictureBox.Location = new System.Drawing.Point(6, 8);
            this.PictureBox.Margin = new System.Windows.Forms.Padding(0);
            this.PictureBox.Name = "PictureBox";
            this.PictureBox.Size = new System.Drawing.Size(135, 135);
            this.PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PictureBox.TabIndex = 3;
            this.PictureBox.TabStop = false;
            this.PictureBox.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Label_Name
            // 
            this.Label_Name.AutoSize = true;
            this.Label_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.Label_Name.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Label_Name.Location = new System.Drawing.Point(147, 12);
            this.Label_Name.Name = "Label_Name";
            this.Label_Name.Size = new System.Drawing.Size(100, 31);
            this.Label_Name.TabIndex = 4;
            this.Label_Name.Text = "Kathrin";
            this.Label_Name.Click += new System.EventHandler(this.label1_Click);
            // 
            // Labal_OnlineStatus
            // 
            this.Labal_OnlineStatus.AutoSize = true;
            this.Labal_OnlineStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Labal_OnlineStatus.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Labal_OnlineStatus.Location = new System.Drawing.Point(150, 43);
            this.Labal_OnlineStatus.Name = "Labal_OnlineStatus";
            this.Labal_OnlineStatus.Size = new System.Drawing.Size(49, 17);
            this.Labal_OnlineStatus.TabIndex = 5;
            this.Labal_OnlineStatus.Text = "Online";
            this.Labal_OnlineStatus.Click += new System.EventHandler(this.label2_Click);
            // 
            // OnlineInterviewFormBackground
            // 
            this.AcceptButton = answerButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(579, 561);
            this.Controls.Add(this.Labal_OnlineStatus);
            this.Controls.Add(this.Label_Name);
            this.Controls.Add(this.PictureBox);
            this.Controls.Add(answerButton);
            this.Controls.Add(this.responseBox);
            this.Controls.Add(this.conversationBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Location = new System.Drawing.Point(500, 500);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OnlineInterviewFormBackground";
            this.Text = "Online Interview";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox conversationBox;
        private System.Windows.Forms.RichTextBox responseBox;
        private System.Windows.Forms.PictureBox PictureBox;
        private System.Windows.Forms.Label Label_Name;
        private System.Windows.Forms.Label Labal_OnlineStatus;
    }
}

