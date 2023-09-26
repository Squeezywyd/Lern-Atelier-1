using System.Security.Cryptography.X509Certificates;

internal class Program
{
    private static void Main(string[] args)
    {
        Random random = new Random();

        while (true)
        {
            Console.WriteLine("Wählen Sie einen Würfel:");
            Console.WriteLine("1 - 6-seitiger Würfel");
            Console.WriteLine("2 - 12-seitiger Würfel");
            Console.WriteLine("0 - Beenden");

            int choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 0)
                break;
            else if (choice == 1)
                RollDice(random, 6);
            else if (choice == 2)
                RollDice(random, 12);
            else
                Console.WriteLine("Ungültige Auswahl.");
        }
    }

    static void RollDice(Random random, int sides)
    {
        int result = random.Next(1, sides + 1);
        Console.WriteLine($"Du hast einen {sides}-seitigen Würfel geworfen und die Zahl {result} erhalten.");
    }
}
    
