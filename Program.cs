// See https://aka.ms/new-console-template for more informatio

class Program
{
    static void Main()
    {
        Random random = new Random();
        int randomNumber = random.Next(1, 11);
        
        
        for  (int i =0; i < 3; i++) 
        { 
            //Console.WriteLine(randomNumber.ToString());
        Console.WriteLine("Guess your number");
        string sGuess = Console.ReadLine();
        int guess = int.Parse(sGuess);
        if (guess == randomNumber)
        {
            Console.WriteLine("Congratulations!!!");
                Environment.Exit(0);
        }
        if (i < 2)
            {
                if (guess > randomNumber)
                {
                    Console.WriteLine("Go lower");

                }
                else
                {
                    Console.WriteLine("Go higher");
                }
                Console.WriteLine("Guess again");
            }

        }
        Console.WriteLine("Take this L");
    }
}

