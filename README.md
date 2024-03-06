# True or False? Quiz Game

This simple console application is a "True or False?" quiz game built using C#. It presents a series of statements to the user, who must decide whether each statement is true or false. The game then evaluates the user's responses, compares them to the correct answers, and displays the user's score along with the correct answers for each question.

## Features

- **Dynamic Question Set:** The game includes a predefined set of questions along with their answers. However, it's easy to modify, add, or remove questions and their corresponding answers in the code.
- **Input Validation:** The game ensures that user inputs are valid (i.e., "True" or "False") and prompts the user to re-enter their response if the input is invalid.
- **Score Calculation:** At the end of the quiz, the game calculates the total number of correct responses and displays the user's score.
- **Answer Review:** After completing the quiz, the game provides a review showing each question, the user's response, and the correct answer, allowing users to learn from their mistakes.

## How to Use

To play the "True or False?" quiz game, follow these steps:

1. **Start the Game:** Run the application. The game will greet you and prompt you to press Enter to begin.
2. **Answer Questions:** The game will display each question one at a time, along with a prompt to answer "True" or "False." Type your response and press Enter.
   - If an invalid response is entered (anything other than "True" or "False"), the game will prompt you to re-enter your response.
3. **Review and Score:** After answering all questions, the game will display your responses compared to the correct answers and then show your total score.

## Requirements

- **.NET SDK:** To compile and run this application, you will need the .NET SDK installed on your machine.
- **IDE or Text Editor:** Any IDE that supports C# (e.g., Visual Studio, Visual Studio Code) or a simple text editor.

## Customization

To add or change questions and answers, modify the `questions` and `answers` arrays in the `Program.cs` file. Ensure each question in the `questions` array has a corresponding true or false value in the `answers` array.

```csharp
string[] questions = {
    "The Earth is the third planet from the Sun.", // True
    // Add more questions here
};

bool[] answers = { true, false, true, false, false };
// Ensure the answers array matches the questions array in length and order

## Contributing

Contributions are welcome! If you have ideas for new features, improvements, or bug fixes, feel free to fork the repository, make your changes, and submit a pull request.

## License

This project is open-source and available under the MIT License. See the LICENSE file for more details.