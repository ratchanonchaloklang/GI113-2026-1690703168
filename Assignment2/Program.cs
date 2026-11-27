//ชื่อ-นามสกุล: Ratchanon Chaloklang
//Section: 129C
//รหัสนักศึกษา: 1690703168
//เลขที่: N / A

using System;

class Program
{
    const string MaterialName = "Iron";
    const double SmeltRate = 0.25;
    const double SalvageRate = 0.30;
    const double MaxBatch = 500.0;

    static void Main()
    {
        Console.WriteLine("-----------------------------------");
        Console.WriteLine("--     Welcome to the Forge      --");
        Console.WriteLine("-----------------------------------");
        Console.WriteLine($"=> {MaterialName} Smelting {SmeltRate:F2} / Salvage {SalvageRate:F2}");
        Console.WriteLine($"=> Key 'S' for Smelt (Ore -> Ingot)");
        Console.WriteLine($"=> Key 'B' for Breakdown (Ingot -> Ore)");

        Console.Write("=> Choose Menu: ");
        char.TryParse(Console.ReadLine(), out char menu);

        Console.Write("=> How much would you like: ");
        bool amountParsed = double.TryParse(Console.ReadLine(), out double amount);

        if (amountParsed && amount > 0 && amount <= MaxBatch)
        {
            if (menu == 'S' || menu == 's')
            {
                double ingot = amount * SmeltRate;

                Console.WriteLine(
                    $"=> {amount:F2} {MaterialName} Ore = {ingot:F2} {MaterialName} Ingot");
            }
            else if (menu == 'B' || menu == 'b')
            {
                double ore = amount / SalvageRate;

                Console.WriteLine(
                    $"=> {amount:F2} {MaterialName} Ingot = {ore:F2} {MaterialName} Ore");
            }
            else
            {
                Console.WriteLine("Error: Invalid menu.");
            }
        }
        else
        {
            Console.WriteLine("Error: Invalid amount.");
        }
    }
}