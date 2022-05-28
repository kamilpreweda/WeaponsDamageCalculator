using SwordDamageHermeticPrototype;


namespace WeaponsDamageCalculator
{

    class Program
    {
        static Random random = new Random();

        static void Main(string[] args)
        {

            SwordDamageHermetic swordDamageHermetic = new SwordDamageHermetic(RollDice(3));
            ArrowDamage arrowDamage = new ArrowDamage(RollDice(1));
            while (true)
            {
                Console.WriteLine("Witaj! Wybierz rodzaj broni: (aby zakończyć, wpisz inną wartość niż podane)");
                Console.WriteLine("0 - ani magiczny, ani płonący, 1 - magiczny, 2 - płonący, 3 - magiczny i płonący");
                char userInput = Console.ReadKey(true).KeyChar;

                Console.Write("\nM - miecz, S - strzały, inne znaki - koniec: ");
                char weaponKey = Char.ToUpper(Console.ReadKey().KeyChar);
                

                switch (weaponKey)
                {
                    case 'M':
                        swordDamageHermetic.Roll = RollDice(3);

                        swordDamageHermetic.Magic = (userInput == '1' || userInput == '3');

                        swordDamageHermetic.Flaming = (userInput == '2' || userInput == '3');

                        Console.WriteLine($"\nRzut: {swordDamageHermetic.Roll}, \npunkty obrażeń: {swordDamageHermetic.Damage}");
                        break;
                    case 'S':
                        arrowDamage.Roll = RollDice(1);

                        arrowDamage.Magic = (userInput == '1' || userInput == '3');

                        arrowDamage.Flaming = (userInput == '2' || userInput == '3');

                        Console.WriteLine($"\nRzut: {arrowDamage.Roll}, \npunkty obrażeń: {arrowDamage.Damage}");
                        break;
                        default: break;


                }
            }
        }

        private static int RollDice(int numberOfRolls)
        {
            int total = 0;
            for (int i = 0; i < numberOfRolls; i++) total += random.Next(1, 7);
            return total;

        }
    }


}












