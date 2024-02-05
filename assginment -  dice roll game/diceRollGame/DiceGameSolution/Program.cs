using DiceGameSolution.Game;

Console.WriteLine(new Random().Next(1, 7));
var random = new Random();
var dice = new Dice(random);
var gussingGame = new GussingGame(dice);

GameResult gameResult = gussingGame.Play();
gussingGame.PrintResult(gameResult);


Console.ReadKey();



//enums
//Season firstSeason = Season.Spring;
//Season lastSeason = Season.Winter;
//int firstSeasonAsNumber = (int)firstSeason;
//int lastSeasonAsNumber = (int)lastSeason;

//Console.WriteLine(firstSeasonAsNumber);
//Console.WriteLine(lastSeasonAsNumber);


//Console.ReadKey();
//public enum Season
//{ 
//    Spring,
//    Summer,
//    Autumn,
//    Winter
//}
