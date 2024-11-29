using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace РГР
{
    public partial class GameForm : Form
    {
        private Computer computer;
        private int playerScore = 0;
        private int computerScore = 0;
        private int roundsPlayed = 0;
        private int numberofmoves;
        private (int,int) smth;
        private Dictionary<int, double> computerDifficulty = new Dictionary<int, double>() {
            {1, 0.5},
            {2, 0.64}, 
            {3, 0.33}  
        };

        public GameForm((int,int) difficultyLevel, int numberofmoves)
        {
            InitializeComponent();
            // Проверка на корректность уровня сложности
            if (!computerDifficulty.ContainsKey(difficultyLevel.Item1))
            {
                //MessageBox.Show("Неверный уровень сложности!");
                Close();
                return;
            }

            computer = new Computer();
            computer.Number = computerDifficulty[difficultyLevel.Item1];
            smth = difficultyLevel;
            this.numberofmoves = numberofmoves;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnTrue_Click_Click(object sender, EventArgs e)
        {
            PlayRound(true);
        }

        private void btnFalse_Click_Click(object sender, EventArgs e)
        {
            PlayRound(false);
        }

        private void PlayRound(bool playerChoice)
        {
            if (roundsPlayed >= numberofmoves)
            {
                numberofmoves = 0;
                roundsPlayed = 0;
                playerScore = 0;
                computerScore = 0;
                computer.Number = computerDifficulty[smth.Item2];
                richTextBox1.Clear();
            }
            btnTrue_Click.Enabled = btnFalse_Click.Enabled = false; // Блокируем кнопки на время хода

            Task.Run(() =>
            {
                Thread.Sleep(1000 + new Random().Next(1000)); // Задержка 1-2 секунды

                bool computerChoice = computer.Play();

                UpdateScores(playerChoice, computerChoice);
                roundsPlayed++;

                this.BeginInvoke((MethodInvoker)delegate
                {
                    richTextBox1.AppendText($"Ход {roundsPlayed}: Вы - {playerChoice}, Противник - {computerChoice}. Счет: Вы - {playerScore}, Противник - {computerScore}\n");
                    btnTrue_Click.Enabled = btnFalse_Click.Enabled = true; // Разблокируем кнопки после хода
                    if (roundsPlayed == 100)
                    {
                        MessageBox.Show($"Игра завершена со счётом {playerScore}:{computerScore}");
                        Close();
                    }
                });

            });

        }

        private void UpdateScores(bool playerChoice, bool computerChoice)
        {
            if (playerChoice == computerChoice)
            {
                if (playerChoice)
                {
                    playerScore += 100;
                    computerScore += 100;
                }
            }
            else if (playerChoice == false && computerChoice == true)
            {
                playerScore += 500;
            }
            else
            {
                computerScore += 500;
            }
        }

    }
}
