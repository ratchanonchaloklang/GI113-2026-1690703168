/*
 * Student ID :1690703168
 * Name       :Ratchanon Chaloklang
 * Section    :129c
 * No.        :N/A
 * Course     : GI113 Computer Programming (GI)
 */
namespace Lap02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string bossName = "Kirin";
            char rank = 'S';
            int level = 7;
            int maxHp = 240;
            int currentHp = 175;
            float attackPower = 42.5f;
            double critMultiplier = 1.75;
            bool isBoss = true;

            Console.WriteLine("===== BOSS STATUS: INITIAL =====");
            Console.WriteLine($"Name : {bossName}");
            Console.WriteLine($"Rank: {rank}");
            Console.WriteLine($"HP: {currentHp}/{maxHp}");
            Console.WriteLine($"Attack power:{attackPower}");
            Console.WriteLine($"Crit Multiplier: {critMultiplier} ");
            Console.WriteLine ($"Is boss : {isBoss}");

            Console.WriteLine();
            int hpParcent = currentHp * 100 / maxHp;
            Console.WriteLine($"HP Parcent : {hpParcent}%");
            Console.WriteLine();
            Console.WriteLine($"Kirin tskes 60 damage!");
            Console.WriteLine();
            currentHp = currentHp - 60;
            Console.WriteLine();
            Console.WriteLine("===== BOSS STATUS: AFTER DAMAGE =====");
            Console.WriteLine($"HP: {currentHp} / {maxHp} ");
            hpParcent = currentHp * 100 / maxHp;
            Console.WriteLine($"HP Parcent : {hpParcent}%");


        }
    }
}
