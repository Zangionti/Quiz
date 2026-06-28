using System;
using System.IO;
using System.Windows.Forms;

namespace Quiz
{
    public partial class QuizForm : Form
    {
        private Question[] questions;
        private Player player;
        private int currentQuestion = 0;

        public QuizForm(string playerName)
        {
            InitializeComponent();
            player = new Player();
            player.Name = playerName;
            player.Score = 0;
            LoadQuestions();
            ShowQuestion();
        }

        private void LoadQuestions()
        {
            questions = new Question[]
            {
                new Question { Text = "Столица Франции?", Options = new string[] { "Париж", "Берлин", "Рим", "Мадрид" }, CorrectIndex = 0 },
                new Question { Text = "Столица Японии?", Options = new string[] { "Сеул", "Пекин", "Токио", "Бангкок" }, CorrectIndex = 2 },
                new Question { Text = "Столица Бразилии?", Options = new string[] { "Рио", "Сан-Паулу", "Буэнос-Айрес", "Бразилиа" }, CorrectIndex = 3 },
                new Question { Text = "Столица Австралии?", Options = new string[] { "Сидней", "Канберра", "Мельбурн", "Перт" }, CorrectIndex = 1 },
                new Question { Text = "Столица Канады?", Options = new string[] { "Торонто", "Ванкувер", "Оттава", "Монреаль" }, CorrectIndex = 2 },
                new Question { Text = "Столица Египта?", Options = new string[] { "Каир", "Александрия", "Луксор", "Асуан" }, CorrectIndex = 0 },
                new Question { Text = "Столица Аргентины?", Options = new string[] { "Рио", "Сантьяго", "Лима", "Буэнос-Айрес" }, CorrectIndex = 3 },
                new Question { Text = "Столица Германии?", Options = new string[] { "Мюнхен", "Берлин", "Гамбург", "Франкфурт" }, CorrectIndex = 1 },
                new Question { Text = "Столица Китая?", Options = new string[] { "Шанхай", "Гонконг", "Пекин", "Нанкин" }, CorrectIndex = 2 },
                new Question { Text = "Столица Италии?", Options = new string[] { "Милан", "Венеция", "Неаполь", "Рим" }, CorrectIndex = 3 }
            };
        }

        private void ShowQuestion()
        {
            labelCount.Text = "Вопрос " + (currentQuestion + 1) + " из 10";
            labelScore.Text = "Счёт: " + player.Score;
            labelQuestion.Text = questions[currentQuestion].Text;
            buttonA.Text = questions[currentQuestion].Options[0];
            buttonB.Text = questions[currentQuestion].Options[1];
            buttonC.Text = questions[currentQuestion].Options[2];
            buttonD.Text = questions[currentQuestion].Options[3];
        }

        private void CheckAnswer(int index)
        {
            if (index == questions[currentQuestion].CorrectIndex)
            {
                player.Score++;
            }
            currentQuestion++;
            if (currentQuestion < 10)
            {
                ShowQuestion();
            }
            else
            {
                SaveResult();
                MessageBox.Show("Игра окончена!\n" + player.Name + ", ваш счёт: " + player.Score + " из 10");
                this.Hide();
                foreach (Form f in Application.OpenForms)
                {
                    if (f is MainForm)
                    {
                        f.Show();
                        break;
                    }
                }
                this.Close();
            }
        }

        private void SaveResult()
        {
            string result = player.Name + " - " + player.Score + "/10 - " + DateTime.Now.ToString("dd.MM.yyyy");
            File.AppendAllText("results.txt", result + Environment.NewLine);
        }

        private void buttonA_Click(object sender, EventArgs e) { CheckAnswer(0); }
        private void buttonB_Click(object sender, EventArgs e) { CheckAnswer(1); }
        private void buttonC_Click(object sender, EventArgs e) { CheckAnswer(2); }
        private void buttonD_Click(object sender, EventArgs e) { CheckAnswer(3); }

        private void QuizForm_Load(object sender, EventArgs e) { }
    }
}