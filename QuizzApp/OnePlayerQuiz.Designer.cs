namespace QuizzApp
{
    partial class OnePlayerQuiz
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
            this.ansARadioBtn = new System.Windows.Forms.RadioButton();
            this.ansBRadioBtn = new System.Windows.Forms.RadioButton();
            this.ansCRadioBtn = new System.Windows.Forms.RadioButton();
            this.ansDRadioBtn = new System.Windows.Forms.RadioButton();
            this.selectAnswerBtn = new System.Windows.Forms.Button();
            this.nameOfQuestionLbl = new System.Windows.Forms.Label();
            this.showStats = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ansARadioBtn
            // 
            this.ansARadioBtn.AutoSize = true;
            this.ansARadioBtn.Location = new System.Drawing.Point(97, 280);
            this.ansARadioBtn.Name = "ansARadioBtn";
            this.ansARadioBtn.Size = new System.Drawing.Size(123, 24);
            this.ansARadioBtn.TabIndex = 0;
            this.ansARadioBtn.TabStop = true;
            this.ansARadioBtn.Tag = "a";
            this.ansARadioBtn.Text = "ansARadioBtn";
            this.ansARadioBtn.UseVisualStyleBackColor = true;
            // 
            // ansBRadioBtn
            // 
            this.ansBRadioBtn.AutoSize = true;
            this.ansBRadioBtn.Location = new System.Drawing.Point(97, 328);
            this.ansBRadioBtn.Name = "ansBRadioBtn";
            this.ansBRadioBtn.Size = new System.Drawing.Size(122, 24);
            this.ansBRadioBtn.TabIndex = 1;
            this.ansBRadioBtn.TabStop = true;
            this.ansBRadioBtn.Tag = "b";
            this.ansBRadioBtn.Text = "ansBRadioBtn";
            this.ansBRadioBtn.UseVisualStyleBackColor = true;
            // 
            // ansCRadioBtn
            // 
            this.ansCRadioBtn.AutoSize = true;
            this.ansCRadioBtn.Location = new System.Drawing.Point(97, 378);
            this.ansCRadioBtn.Name = "ansCRadioBtn";
            this.ansCRadioBtn.Size = new System.Drawing.Size(122, 24);
            this.ansCRadioBtn.TabIndex = 2;
            this.ansCRadioBtn.TabStop = true;
            this.ansCRadioBtn.Tag = "c";
            this.ansCRadioBtn.Text = "ansCRadioBtn";
            this.ansCRadioBtn.UseVisualStyleBackColor = true;
            // 
            // ansDRadioBtn
            // 
            this.ansDRadioBtn.AutoSize = true;
            this.ansDRadioBtn.Location = new System.Drawing.Point(97, 429);
            this.ansDRadioBtn.Name = "ansDRadioBtn";
            this.ansDRadioBtn.Size = new System.Drawing.Size(124, 24);
            this.ansDRadioBtn.TabIndex = 3;
            this.ansDRadioBtn.TabStop = true;
            this.ansDRadioBtn.Tag = "d";
            this.ansDRadioBtn.Text = "ansDRadioBtn";
            this.ansDRadioBtn.UseVisualStyleBackColor = true;
            // 
            // selectAnswerBtn
            // 
            this.selectAnswerBtn.Location = new System.Drawing.Point(545, 328);
            this.selectAnswerBtn.Name = "selectAnswerBtn";
            this.selectAnswerBtn.Size = new System.Drawing.Size(130, 64);
            this.selectAnswerBtn.TabIndex = 4;
            this.selectAnswerBtn.Text = "Select Answer";
            this.selectAnswerBtn.UseVisualStyleBackColor = true;
            this.selectAnswerBtn.Click += new System.EventHandler(this.selectAnswerBtn_Click);
            // 
            // nameOfQuestionLbl
            // 
            this.nameOfQuestionLbl.AutoSize = true;
            this.nameOfQuestionLbl.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nameOfQuestionLbl.Location = new System.Drawing.Point(97, 49);
            this.nameOfQuestionLbl.Name = "nameOfQuestionLbl";
            this.nameOfQuestionLbl.Size = new System.Drawing.Size(261, 41);
            this.nameOfQuestionLbl.TabIndex = 5;
            this.nameOfQuestionLbl.Text = "Name of Question";
            // 
            // showStats
            // 
            this.showStats.Location = new System.Drawing.Point(863, 125);
            this.showStats.Name = "showStats";
            this.showStats.Size = new System.Drawing.Size(134, 48);
            this.showStats.TabIndex = 6;
            this.showStats.Text = "Show Stats";
            this.showStats.UseVisualStyleBackColor = true;
            this.showStats.Click += new System.EventHandler(this.showStats_Click);
            // 
            // OnePlayerQuiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 550);
            this.Controls.Add(this.showStats);
            this.Controls.Add(this.nameOfQuestionLbl);
            this.Controls.Add(this.selectAnswerBtn);
            this.Controls.Add(this.ansDRadioBtn);
            this.Controls.Add(this.ansCRadioBtn);
            this.Controls.Add(this.ansBRadioBtn);
            this.Controls.Add(this.ansARadioBtn);
            this.Name = "OnePlayerQuiz";
            this.Text = "OnePlayerQuiz";
            this.Load += new System.EventHandler(this.OnePlayerQuiz_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label nameOfQuestionLbl;
        public RadioButton ansARadioBtn;
        public RadioButton ansBRadioBtn;
        public RadioButton ansCRadioBtn;
        public RadioButton ansDRadioBtn;
        public Button selectAnswerBtn;
        private Button showStats;
    }
}