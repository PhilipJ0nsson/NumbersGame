namespace NumbersGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Välkommen!");
            Console.WriteLine("Tryck 'ENTER' för att starta spelet!");
            Console.ReadLine();
            Console.Clear();
            NumbersGame();
        }

        static void NumbersGame()
        {
            Random random = new Random();
            int guesses = 1;

            while (true)
            {
                bool loop = true;
                int number = random.Next(1, 21);
                //Asking user to guess correct number
                Console.WriteLine("Jag tänker på ett nummer mellan 1-20.");
                Console.WriteLine("Kan du gissa vilket? Du får fem försök.");
                while (loop)
                {
                    //User input number
                    int guess = Convert.ToInt32(Console.ReadLine());

                    //The user gets 5 guesses before program exit loop
                    if (guesses > 5)
                    {
                        Console.WriteLine("Tyvärr du lyckades inte gissa talet på fem försök!");
                        loop = false;
                    }
                    //If user guesses the correct number program exit loop
                    else if (number == guess)
                    {
                        Console.WriteLine("Woho! Du gjorde det!");
                        Console.WriteLine("Talet var {0}", number);
                        Console.WriteLine("Du gissade {0} gånger!", guesses);
                        break;
                    }
                    //The user gets a notification if the guess is to high
                    else if (guess > number)
                    {
                        Console.WriteLine("Tyvärr du gissade för högt!");
                    }
                    //The user gets a notification if the guess is to low
                    else if (guess < number)
                    {
                        Console.WriteLine("Tyvärr du gissade för lågt!");
                    }
                    guesses++;

                }


                //Asking if user wants to play again.
                Console.WriteLine("Vill du spela igen? JA/NEJ");
                string play = Console.ReadLine();
                Console.Clear();
                play = play.ToUpper();

                //Restart program is user input "JA"
                if (play == "JA")
                {
                    //Reset "guesses" to 1.
                    guesses = 1;
                    continue;

                }
                //Exit program if user input is NOT "JA"
                else
                {
                    Console.WriteLine("Tack för att du spelade. Tryck på valfri tangent för att avsluta.");
                }
                Console.ReadKey();
                break;


            }
        }

    }
}