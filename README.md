#  Rock, Paper, Scissors
 
A console-based Rock, Paper, Scissors game in C#, played against the computer. Everything is written directly inside `Main` (no separate methods), keeping the logic simple and easy to follow top to bottom.
 
## What it does
- Takes the player's choice (rock/paper/scissors) from the console
- Generates a random choice for the computer
- Validates input (only accepts rock, paper, or scissors)
- Decides the winner of each round based on the classic rules
- Keeps a running score across rounds
- Lets the player choose to play multiple rounds
- Shows a final score and overall winner at the end
## What I learned
- Using `Random.Next()` to pick between a fixed set of options
- Comparing strings safely in C# (`==` works for string equality)
- Combining multiple conditions with `&&` and `||` for the win-check logic
- Keeping score with simple counter variables

 
## Possible improvements
- Add "best of X rounds" instead of playing until the user says stop
- Add lizard/Spock for the extended version of the game
- Refactor into methods once comfortable (e.g. `GetComputerChoice()`, `DecideWinner()`)
 

