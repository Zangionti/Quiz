namespace Quiz
{
    partial class QuizForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.buttonA = new System.Windows.Forms.Button();
            this.buttonB = new System.Windows.Forms.Button();
            this.buttonC = new System.Windows.Forms.Button();
            this.buttonD = new System.Windows.Forms.Button();
            this.labelCount = new System.Windows.Forms.Label();
            this.labelScore = new System.Windows.Forms.Label();
            this.labelQuestion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonA
            // 
            this.buttonA.Location = new System.Drawing.Point(12, 466);
            this.buttonA.Name = "buttonA";
            this.buttonA.Size = new System.Drawing.Size(408, 76);
            this.buttonA.TabIndex = 6;
            this.buttonA.Text = "Лиссабон";
            this.buttonA.UseVisualStyleBackColor = true;
            this.buttonA.Click += new System.EventHandler(this.buttonA_Click);
            // 
            // buttonB
            // 
            this.buttonB.Location = new System.Drawing.Point(454, 466);
            this.buttonB.Name = "buttonB";
            this.buttonB.Size = new System.Drawing.Size(408, 76);
            this.buttonB.TabIndex = 7;
            this.buttonB.Text = "Лиссабон";
            this.buttonB.UseVisualStyleBackColor = true;
            this.buttonB.Click += new System.EventHandler(this.buttonB_Click);
            // 
            // buttonC
            // 
            this.buttonC.Location = new System.Drawing.Point(12, 586);
            this.buttonC.Name = "buttonC";
            this.buttonC.Size = new System.Drawing.Size(408, 76);
            this.buttonC.TabIndex = 8;
            this.buttonC.Text = "Лиссабон";
            this.buttonC.UseVisualStyleBackColor = true;
            this.buttonC.Click += new System.EventHandler(this.buttonC_Click);
            // 
            // buttonD
            // 
            this.buttonD.Location = new System.Drawing.Point(454, 586);
            this.buttonD.Name = "buttonD";
            this.buttonD.Size = new System.Drawing.Size(408, 76);
            this.buttonD.TabIndex = 9;
            this.buttonD.Text = "Лиссабон";
            this.buttonD.UseVisualStyleBackColor = true;
            this.buttonD.Click += new System.EventHandler(this.buttonD_Click);
            // 
            // labelCount
            // 
            this.labelCount.Font = new System.Drawing.Font("Cascadia Code", 15.875F);
            this.labelCount.Location = new System.Drawing.Point(38, 19);
            this.labelCount.Name = "labelCount";
            this.labelCount.Size = new System.Drawing.Size(449, 85);
            this.labelCount.TabIndex = 10;
            this.labelCount.Text = "Вопрос 1 из 10";
            // 
            // labelScore
            // 
            this.labelScore.Font = new System.Drawing.Font("Cascadia Code", 15.875F);
            this.labelScore.Location = new System.Drawing.Point(647, 19);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(339, 85);
            this.labelScore.TabIndex = 11;
            this.labelScore.Text = "Счет 0";
            // 
            // labelQuestion
            // 
            this.labelQuestion.AutoSize = true;
            this.labelQuestion.Font = new System.Drawing.Font("Cascadia Code", 19.875F);
            this.labelQuestion.Location = new System.Drawing.Point(165, 330);
            this.labelQuestion.Name = "labelQuestion";
            this.labelQuestion.Size = new System.Drawing.Size(526, 70);
            this.labelQuestion.TabIndex = 12;
            this.labelQuestion.Text = "Столица Франции?";
            // 
            // QuizForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 829);
            this.Controls.Add(this.labelQuestion);
            this.Controls.Add(this.labelScore);
            this.Controls.Add(this.labelCount);
            this.Controls.Add(this.buttonD);
            this.Controls.Add(this.buttonC);
            this.Controls.Add(this.buttonB);
            this.Controls.Add(this.buttonA);
            this.Name = "QuizForm";
            this.Text = "Квиз по столицам";
            this.Load += new System.EventHandler(this.QuizForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private System.Windows.Forms.Button buttonA;
        private System.Windows.Forms.Button buttonB;
        private System.Windows.Forms.Button buttonC;
        private System.Windows.Forms.Button buttonD;
        private System.Windows.Forms.Label labelCount;
        private System.Windows.Forms.Label labelScore;
        private System.Windows.Forms.Label labelQuestion;
    }
}