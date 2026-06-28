namespace Quiz
{
    partial class MainForm
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
            System.Windows.Forms.Label labelTitle;
            System.Windows.Forms.Label labelText;
            System.Windows.Forms.Label labelName;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.pictureBoxGlobus = new System.Windows.Forms.PictureBox();
            this.buttonStart = new System.Windows.Forms.Button();
            this.textBoxName = new System.Windows.Forms.TextBox();
            labelTitle = new System.Windows.Forms.Label();
            labelText = new System.Windows.Forms.Label();
            labelName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGlobus)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            labelTitle.Font = new System.Drawing.Font("Cascadia Code", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelTitle.Location = new System.Drawing.Point(156, -8);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new System.Drawing.Size(574, 67);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "Квиз по столицам";

            // 
            // labelText
            // 
            labelText.Font = new System.Drawing.Font("Cascadia Code", 16.875F);
            labelText.Location = new System.Drawing.Point(184, 457);
            labelText.Name = "labelText";
            labelText.Size = new System.Drawing.Size(546, 67);
            labelText.TabIndex = 2;
            labelText.Text = "Проверь свои знания!";
            // 
            // labelName
            // 
            labelName.Font = new System.Drawing.Font("Cascadia Code", 15.875F);
            labelName.Location = new System.Drawing.Point(289, 524);
            labelName.Name = "labelName";
            labelName.Size = new System.Drawing.Size(332, 67);
            labelName.TabIndex = 3;
            labelName.Text = "Введите имя";
            // 
            // pictureBoxGlobus
            // 
            this.pictureBoxGlobus.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxGlobus.Image")));
            this.pictureBoxGlobus.Location = new System.Drawing.Point(158, 62);
            this.pictureBoxGlobus.Name = "pictureBoxGlobus";
            this.pictureBoxGlobus.Size = new System.Drawing.Size(572, 473);
            this.pictureBoxGlobus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxGlobus.TabIndex = 1;
            this.pictureBoxGlobus.TabStop = false;
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(236, 662);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(408, 76);
            this.buttonStart.TabIndex = 5;
            this.buttonStart.Text = "Начать";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(289, 594);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(300, 31);
            this.textBoxName.TabIndex = 6;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 829);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(labelName);
            this.Controls.Add(labelText);
            this.Controls.Add(this.pictureBoxGlobus);
            this.Controls.Add(labelTitle);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGlobus)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxGlobus;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.TextBox textBoxName;
    }
}

