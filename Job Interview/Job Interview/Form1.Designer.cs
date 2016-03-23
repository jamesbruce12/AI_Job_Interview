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
            System.Windows.Forms.Button answerButton1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OnlineInterviewFormBackground));
            this.conversationBox = new System.Windows.Forms.RichTextBox();
            this.responseBox = new System.Windows.Forms.RichTextBox();
            this.PictureBox = new System.Windows.Forms.PictureBox();
            this.Label_InterviewerName = new System.Windows.Forms.Label();
            this.Label_OnlineStatus = new System.Windows.Forms.Label();
            this.answerButton = new RoundButton();
            answerButton1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // answerButton1
            // 
            answerButton1.Location = new System.Drawing.Point(0, 0);
            answerButton1.Margin = new System.Windows.Forms.Padding(4);
            answerButton1.Name = "answerButton1";
            answerButton1.Size = new System.Drawing.Size(100, 28);
            answerButton1.TabIndex = 7;
            // 
            // conversationBox
            // 
            this.conversationBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.conversationBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.conversationBox.Cursor = System.Windows.Forms.Cursors.No;
            this.conversationBox.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conversationBox.Location = new System.Drawing.Point(0, 185);
            this.conversationBox.Margin = new System.Windows.Forms.Padding(0);
            this.conversationBox.MaximumSize = new System.Drawing.Size(745, 367);
            this.conversationBox.MinimumSize = new System.Drawing.Size(745, 367);
            this.conversationBox.Name = "conversationBox";
            this.conversationBox.ReadOnly = true;
            this.conversationBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.conversationBox.Size = new System.Drawing.Size(745, 367);
            this.conversationBox.TabIndex = 0;
            this.conversationBox.Text = "";
            this.conversationBox.TextChanged += new System.EventHandler(this.conversationBox_TextChanged);
            // 
            // responseBox
            // 
            this.responseBox.BackColor = System.Drawing.Color.OldLace;
            this.responseBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.responseBox.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.responseBox.Location = new System.Drawing.Point(7, 558);
            this.responseBox.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.responseBox.MaxLength = 255;
            this.responseBox.Name = "responseBox";
            this.responseBox.Size = new System.Drawing.Size(639, 124);
            this.responseBox.TabIndex = 1;
            this.responseBox.Text = "";
            // 
            // PictureBox
            // 
            this.PictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PictureBox.BackgroundImage")));
            this.PictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PictureBox.Location = new System.Drawing.Point(8, 10);
            this.PictureBox.Margin = new System.Windows.Forms.Padding(0);
            this.PictureBox.Name = "PictureBox";
            this.PictureBox.Size = new System.Drawing.Size(135, 135);
            this.PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PictureBox.TabIndex = 3;
            this.PictureBox.TabStop = false;
            this.PictureBox.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Label_InterviewerName
            // 
            this.Label_InterviewerName.AutoSize = true;
            this.Label_InterviewerName.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_InterviewerName.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Label_InterviewerName.Location = new System.Drawing.Point(189, 7);
            this.Label_InterviewerName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label_InterviewerName.Name = "Label_InterviewerName";
            this.Label_InterviewerName.Size = new System.Drawing.Size(133, 46);
            this.Label_InterviewerName.TabIndex = 4;
            this.Label_InterviewerName.Text = "Kathrin";
            this.Label_InterviewerName.Click += new System.EventHandler(this.label1_Click);
            // 
            // Label_OnlineStatus
            // 
            this.Label_OnlineStatus.AutoSize = true;
            this.Label_OnlineStatus.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_OnlineStatus.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Label_OnlineStatus.Location = new System.Drawing.Point(3, 527);
            this.Label_OnlineStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label_OnlineStatus.Name = "Label_OnlineStatus";
            this.Label_OnlineStatus.Size = new System.Drawing.Size(68, 25);
            this.Label_OnlineStatus.TabIndex = 5;
            this.Label_OnlineStatus.Text = "Online";
            this.Label_OnlineStatus.Click += new System.EventHandler(this.label2_Click);
            // 
            // answerButton
            // 
            this.answerButton.BackColor = System.Drawing.Color.SlateGray;
            this.answerButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("answerButton.BackgroundImage")));
            this.answerButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.answerButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.answerButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.answerButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.answerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.answerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answerButton.ForeColor = System.Drawing.Color.Transparent;
            this.answerButton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.answerButton.Location = new System.Drawing.Point(600, 527);
            this.answerButton.Margin = new System.Windows.Forms.Padding(0);
            this.answerButton.Name = "answerButton";
            this.answerButton.Size = new System.Drawing.Size(169, 155);
            this.answerButton.TabIndex = 6;
            this.answerButton.UseVisualStyleBackColor = false;
            this.answerButton.Click += new System.EventHandler(this.answerButton_Click);
            // 
            // OnlineInterviewFormBackground
            // 
            this.AcceptButton = this.answerButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(772, 690);
            this.Controls.Add(this.answerButton);
            this.Controls.Add(this.Label_OnlineStatus);
            this.Controls.Add(this.Label_InterviewerName);
            this.Controls.Add(this.PictureBox);
            this.Controls.Add(answerButton1);
            this.Controls.Add(this.responseBox);
            this.Controls.Add(this.conversationBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Location = new System.Drawing.Point(500, 500);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
        private System.Windows.Forms.Label Label_InterviewerName;
        private System.Windows.Forms.Label Label_OnlineStatus;
        private RoundButton answerButton;
    }
}

