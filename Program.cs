namespace MyIF_Statements;

class Program
{
    static int counter = 0;
    static void Main(string[] args)
    {
        string answer;
        string greeting;
        if (counter == 0)
        {
            // Första välkomnandet
            greeting = "Hej och välkommen till tärningsspelet!";
            Console.WriteLine(greeting);

            // Första fråga om användaren vill spela
            Console.WriteLine("Vill du spela tärning? (J/N)");
             answer = Console.ReadLine() ?? "N";
            if (answer.ToUpper() != "J") return;
        }
        else if (counter < 5)
        {
            greeting = "Välkommen tillbaka!";
            Console.WriteLine(greeting);
        }
        else
        {
            // Användaren spelar mycket
            greeting = "Du spelar mycket, ta en paus!";
            Console.WriteLine(greeting);
            return;
        }

        // Generera ett slumptal mellan 1 och 6 för både tärningen och vinnarnumret
        Random dice = new Random();
        int diceValue = dice.Next(1, 7);
        int winnerNumber = dice.Next(1, 7);
        string message;

        // Resultat av tärningskastet
        if (diceValue == winnerNumber)
        {
            message = "Congratulations! You rolled a " + diceValue + " and the winner number is also " + winnerNumber + ". You win!";
            //Console.WriteLine("YOU WON! The dice shows you a " + diceValue + " and the winner number is " + winnerNumber + "! Congratulations!");
        }
        else if (diceValue > winnerNumber)
        {
            message = "You got a novelty bunny, because you toppled the winning number " + winnerNumber + ". The dice shows you a " + diceValue + ".";
            //Console.WriteLine("You got a novelty bunny, because you toppled the winning number " + winnerNumber + ". The dice shows you a " + diceValue + ".");
        }
        else
        {
            message = "You lost, because the dice shows you a " + diceValue + " and the winner number is " + winnerNumber; 
            //Console.WriteLine("You lost, because the dice shows you a " + diceValue + " and the winner number is " + winnerNumber);
        }

        counter++;
        Console.WriteLine(message);
        //Console.ReadLine();

        // Spela igen?
        Console.WriteLine("Vill du pröva din lycka igen? (J/N)");
        answer = Console.ReadLine() ?? "N";
        if (answer.ToUpper() != "J") return;

        Main(args);
    }
}
