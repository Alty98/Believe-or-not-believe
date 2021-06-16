using System;

namespace BelieveOrNotBelieve
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game("Questions.txt", 2);
            game.EndOfGame += (sender, eventArgs) =>
            {
                Console.WriteLine($"Total question:{eventArgs.QuestionCount} \nRight answers:{eventArgs.QuestionsPassed}. Mistakes made:{eventArgs.MistakesMade}.");
                Console.WriteLine(eventArgs.IsWin ? "You won!" : "You lost!");
                
            };

            while (game.GameStatus == GameStatus.InProgress)
            {
                Question q = game.GetNextQuestion();
                Console.WriteLine("Do you believe in the next statement or question? Enter 'y' or 'n'");
                Console.WriteLine(q.Text);

                string answer = Console.ReadLine();
                bool boolAnswer = answer == "y";

                if (q.CorrectAnswer == boolAnswer)
                {
                    Console.WriteLine("Good job. You're right!");
                }
                else
                {
                    Console.WriteLine("Ooops, actually you're mistaken. Here is the commentary:");
                    Console.WriteLine($"{q.Explanation}");
                }

                game.GiveAnswer(boolAnswer);
            }

            Console.ReadLine();
        }
    }
}
