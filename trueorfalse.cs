using System;

namespace TrueOrFalse
{
    class Program
    {
        static void Main(string[] args)
        {
            // Do not edit these lines
            Console.WriteLine("Welcome to 'True or False?'\nPress Enter to begin:");
            string entry = Console.ReadLine();
            Tools.SetUpInputStream(entry);

            string[] questions = {
                "The Earth is the third planet from the Sun.", // True
                "Rabbits lay eggs.", // False
                "Water boils at 100 degrees Celsius, under standard atmospheric conditions.", // True
                "Fire is cold.", // False
                "Humans can breathe underwater without any equipment." // False
            };

            bool[] answers = { true, false, true, false, false };
            bool[] responses = new bool[questions.Length];

            if (questions.Length != answers.Length)
            {
                Console.WriteLine("Warning: Questions and answers arrays are not the same length!");
            }

            int askingIndex = 0;

            foreach (string question in questions)
            {
                string input;
                bool isBool = false;
                bool inputBool = false;

                while (!isBool)
                {
                    Console.WriteLine(question);
                    Console.WriteLine("True or false?");
                    input = Console.ReadLine();

                    isBool = Boolean.TryParse(input, out inputBool);

                    if (!isBool)
                    {
                        Console.WriteLine("Please respond with 'True' or 'False'.");
                    }
                }

                responses[askingIndex] = inputBool;
                askingIndex++;
            }

            Console.WriteLine("\nRecorded Responses:");
            for (int i = 0; i < responses.Length; i++)
            {
                Console.WriteLine($"Question {i + 1}: {responses[i]}");
            }

            int score = 0;

            for (int i = 0; i < responses.Length; i++)
            {
                Console.WriteLine($"Question {i + 1}: Your answer was {responses[i]}, Correct answer was {answers[i]}");

                if (responses[i] == answers[i])
                {
                    score++;
                }
            }

            Console.WriteLine($"You got {score} out of {questions.Length} correct!");
        }
    }
}
