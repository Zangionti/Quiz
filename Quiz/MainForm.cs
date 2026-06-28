using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz
{
    public partial class MainForm : Form
    {
        private void MainForm_Load(object sender, EventArgs e)
        {
        }
        public MainForm()
        {
            InitializeComponent();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            if (textBoxName.Text == "")
            {
                MessageBox.Show("Введите ваше имя!");
                return;
            }

            QuizForm quizForm = new QuizForm(textBoxName.Text);
            quizForm.Show();
            this.Hide();
        }
    }
}
