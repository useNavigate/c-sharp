/*
- the game should prompt the user for the maximum range(1 to n)
- the game should generate a random number in that range.
- the game shoulld keep track of the number of (valid) guesses
- the game should prompt the user for a guess and give feedback (higher, lower, win, invalid guess, etc.)
- When the user wins, the game should print the number of guesses it took.
 */

/*
GuessTracker {
F:-------------------
RNG : Random
MaxNumber :int,
NumberToGuess : int 
GuessCount : int 
M:--------------------
GenerateRandomNumber(int)
}


ConsoleIO{
M:-------------------
GetMaxRange() : int
GetGuess() : int 
DisplayMessage(string message) : void 
}
 


GuessingGameWorkflow{
Tracker : GuessTracker
IO : ConsoleIO
M:-------------------
RUN() : void
EvaluateGuess() : int 

}
 
 */