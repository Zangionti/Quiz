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
            System.Windows.Forms.Label labelCount;
            System.Windows.Forms.Label labelScore;
            System.Windows.Forms.Label labelQuestion;
            this.buttonA = new System.Windows.Forms.Button();
            this.buttonB = new System.Windows.Forms.Button();
            this.buttonC = new System.Windows.Forms.Button();
            this.buttonD = new System.Windows.Forms.Button();
            labelCount = new System.Windows.Forms.Label();
            labelScore = new System.Windows.Forms.Label();
            labelQuestion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelCount
            // 
            labelCount.Font = new System.Drawing.Font("Cascadia Code", 18.875F);
            labelCount.Location = new System.Drawing.Point(12, 9);
            labelCount.Name = "labelCount";
            labelCount.Size = new System.Drawing.Size(669, 67);
            labelCount.TabIndex = 2;
            labelCount.Text = "Вопрос 1 из 10";
            // 
            // labelScore
            // 
            labelScore.Font = new System.Drawing.Font("Cascadia Code", 18.875F);
            labelScore.Location = new System.Drawing.Point(639, 9);
            labelScore.Name = "labelScore";
            labelScore.Size = new System.Drawing.Size(300, 67);
            labelScore.TabIndex = 3;
            labelScore.Text = "Счет 0";
            // 
            // labelQuestion
            // 
            labelQuestion.Font = new System.Drawing.Font("Cascadia Code", 20.875F);
            labelQuestion.Location = new System.Drawing.Point(102, 281);
            labelQuestion.Name = "labelQuestion";
            labelQuestion.Size = new System.Drawing.Size(677, 93);
            labelQuestion.TabIndex = 4;
            labelQuestion.Text = "Столица Португалии?";
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
            // QuizForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 829);
            this.Controls.Add(this.buttonD);
            this.Controls.Add(this.buttonC);
            this.Controls.Add(this.buttonB);
            this.Controls.Add(this.buttonA);
            this.Controls.Add(labelQuestion);
            this.Controls.Add(labelScore);
            this.Controls.Add(labelCount);
            this.Name = "QuizForm";
            this.Text = "Квиз по столицам";
            this.Load += new System.EventHandler(this.QuizForm_Load);
            this.ResumeLayout(false);

        }
        private System.Windows.Forms.Button buttonA;
        private System.Windows.Forms.Button buttonB;
        private System.Windows.Forms.Button buttonC;
        private System.Windows.Forms.Button buttonD;
    }
}