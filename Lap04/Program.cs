namespace Lap4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("+____________________________+");
            Console.WriteLine("|       NEW ADVENTURE        |");
            Console.WriteLine("+____________________________+");

            Console.WriteLine("+Name your hero :");
            string playerName = Console.ReadLine();

            Console.WriteLine($"\nWelcome, {playerName}.your jonrney begins . .");

            Console.WriteLine("+____________________________+");
            Console.WriteLine("|       DIFFCULTY SELECY     |");
            Console.WriteLine("+____________________________+");

            Console.WriteLine("Chooe diffculty (1-3):");
            int diffculty = convert.ToInt32(Console.ReadLine);

            Console.WriteLine($"\ndiffculty, {diffculty}.your jonrney begins . .");

            Console.WriteLine("+____________________________+");
            Console.WriteLine("|       Item shop            |");
            Console.WriteLine("+____________________________+");

            Console.WriteLine("How many potions?: ");
            bool isValid = int.TryParse(Console.ReadLine(), out int quantity);
            Console.WriteLine($"Value input: {isValid}");
            Console.WriteLine($"Quantity: {quantity}");

            Console.WriteLine("+____________________________+");
            Console.WriteLine("|     CHARACTER CREATION     |");
            Console.WriteLine("+____________________________+");

            Console.WriteLine("name your character: ");
            string charname = Console.ReadLine();
            Console.Write("Choose a class (1-3): ");*/


            /*
            *Student ID:1690703168
            *Name: Ratchanon Chaloklang
            *Section: 129C
            *No: 28
            */
            Console.WriteLine("1690703168/Ratchanon Chaloklang/129C/28");

            Console.WriteLine("+------------------------------+");
            Console.WriteLine("|      CHARACTER CREATION       |");
            Console.WriteLine("+------------------------------+");
            Console.Write("Name your character: ");
            string charName = Console.ReadLine();
            Console.Write("Choose a class (1-3): ");
            bool classOk = int.TryParse(Console.ReadLine(), out int classNum);
            Console.Write("Starting luck (0.0-10.0): ");
            bool luckOk = double.TryParse(Console.ReadLine(), out double luck);
            Console.WriteLine($"{charName} the Class-{classNum} adventurer enters the dungeon. Luck: {luck}");

            Console.WriteLine("+------------------------------+");
            Console.WriteLine("|           ITEM SHOP           |");
            Console.WriteLine("+------------------------------+");
            Console.Write("How many potions? ");
            bool quantityOk = int.TryParse(Console.ReadLine(), out int quantity);
            Console.WriteLine($"Valid input: {quantityOk}");
            Console.WriteLine($"Quantity: {quantity}");

            Console.WriteLine("+------------------------------+");
            Console.WriteLine("|          SET VOLUME           |");
            Console.WriteLine("+------------------------------+");
            Console.Write("Set music volume (0.0-1.0): ");
            bool volumeOk = double.TryParse(Console.ReadLine(), out double volume);
            Console.WriteLine($"Valid input: {volumeOk}");
            Console.WriteLine($"Volume: {volume}");

            Console.WriteLine("+------------------------------+");
            Console.WriteLine("|         NEW SAVE FILE         |");
            Console.WriteLine("+------------------------------+");
            Console.Write("Enter save name: ");
            string saveName = Console.ReadLine();
            Console.Write("Choose save slot (1-3): ");
            bool slotOk = int.TryParse(Console.ReadLine(), out int slot);
            Console.WriteLine($"Save name: {saveName}");
            Console.WriteLine($"Valid input: {slotOk}");
            Console.WriteLine($"Slot: {slot}");

        }
    }
}
