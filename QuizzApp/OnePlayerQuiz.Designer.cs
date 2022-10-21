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
            this.SuspendLayout();
            // 
            // ansARadioBtn
            // 
            this.ansARadioBtn.AutoSize = true;
            this.ansARadioBtn.Location = new System.Drawing.Point(264, 245);
            this.ansARadioBtn.Name = "ansARadioBtn";
            this.ansARadioBtn.Size = new System.Drawing.Size(123, 24);
            this.ansARadioBtn.TabIndex = 0;
            this.ansARadioBtn.TabStop = true;
            this.ansARadioBtn.Text = "ansARadioBtn";
            this.ansARadioBtn.UseVisualStyleBackColor = true;
            // 
            // ansBRadioBtn
            // 
            this.ansBRadioBtn.AutoSize = true;
            this.ansBRadioBtn.Location = new System.Drawing.Point(264, 293);
            this.ansBRadioBtn.Name = "ansBRadioBtn";
            this.ansBRadioBtn.Size = new System.Drawing.Size(122, 24);
            this.ansBRadioBtn.TabIndex = 1;
            this.ansBRadioBtn.TabStop = true;
            this.ansBRadioBtn.Text = "ansBRadioBtn";
            this.ansBRadioBtn.UseVisualStyleBackColor = true;
            // 
            // ansCRadioBtn
            // 
            this.ansCRadioBtn.AutoSize = true;
            this.ansCRadioBtn.Location = new System.Drawing.Point(264, 343);
            this.ansCRadioBtn.Name = "ansCRadioBtn";
            this.ansCRadioBtn.Size = new System.Drawing.Size(122, 24);
            this.ansCRadioBtn.TabIndex = 2;
            this.ansCRadioBtn.TabStop = true;
            this.ansCRadioBtn.Text = "ansCRadioBtn";
            this.ansCRadioBtn.UseVisualStyleBackColor = true;
            // 
            // ansDRadioBtn
            // 
            this.ansDRadioBtn.AutoSize = true;
            this.ansDRadioBtn.Location = new System.Drawing.Point(264, 394);
            this.ansDRadioBtn.Name = "ansDRadioBtn";
            this.ansDRadioBtn.Size = new System.Drawing.Size(124, 24);
            this.ansDRadioBtn.TabIndex = 3;
            this.ansDRadioBtn.TabStop = true;
            this.ansDRadioBtn.Text = "ansDRadioBtn";
            this.ansDRadioBtn.UseVisualStyleBackColor = true;
            // 
            // selectAnswerBtn
            // 
            this.selectAnswerBtn.Location = new System.Drawing.Point(518, 293);
            this.selectAnswerBtn.Name = "selectAnswerBtn";
            this.selectAnswerBtn.Size = new System.Drawing.Size(130, 64);
            this.selectAnswerBtn.TabIndex = 4;
            this.selectAnswerBtn.Text = "Select Answer";
            this.selectAnswerBtn.UseVisualStyleBackColor = true;
            // 
            // nameOfQuestionLbl
            // 
            this.nameOfQuestionLbl.AutoSize = true;
            this.nameOfQuestionLbl.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nameOfQuestionLbl.Location = new System.Drawing.Point(370, 60);
            this.nameOfQuestionLbl.Name = "nameOfQuestionLbl";
            this.nameOfQuestionLbl.Size = new System.Drawing.Size(261, 41);
            this.nameOfQuestionLbl.TabIndex = 5;
            this.nameOfQuestionLbl.Text = "Name of Question";
            // 
            // OnePlayerQuiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 550);
            this.Controls.Add(this.nameOfQuestionLbl);
            this.Controls.Add(this.selectAnswerBtn);
            this.Controls.Add(this.ansDRadioBtn);
            this.Controls.Add(this.ansCRadioBtn);
            this.Controls.Add(this.ansBRadioBtn);
            this.Controls.Add(this.ansARadioBtn);
            this.Name = "OnePlayerQuiz";
            this.Text = "OnePlayerQuiz";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RadioButton ansARadioBtn;
        private RadioButton ansBRadioBtn;
        private RadioButton ansCRadioBtn;
        private RadioButton ansDRadioBtn;
        private Button selectAnswerBtn;
        private Label nameOfQuestionLbl;
    }
}