var Dado = new Dice(6);
var UserInput = new DiceInputHandler();
var jugador = new PlayerState();
var PlayingGame = new DiceGame();

PlayingGame.RunningGame(Dado, UserInput, jugador);
Console.ReadKey();
public class DiceGame
{
    public void RunningGame(Dice GeneratedDiceNumber, DiceInputHandler ActualUserInput, PlayerState newPlayer)
    {
        Console.WriteLine($"Dice rolled. Guess what number it shows in {PlayerState.MaxTries} tries.");
        while (!newPlayer.GameEnd)
        {
            Console.WriteLine($"remaining attempts: {PlayerState.MaxTries - ActualUserInput.CountOfTries}");
            ActualUserInput.NumberValidation(GeneratedDiceNumber);
            newPlayer.PlayerCondition(GeneratedDiceNumber, ActualUserInput);
        }
    }
}
