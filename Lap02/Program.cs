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
            Console.WriteLine($"Is boss : {isBoss}");

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

            // Part B

            string kingName = "Nice";
            int kinghp = 125;
            int kingatk = 150;
            float kingcurrentXp = 0.70f;
            double kingcurrentLevel = 99.87;
            bool kingisRank = true;

            Console.WriteLine("===== Character 1 : {king} =====");
            Console.WriteLine($"Name : {kingName}");
            Console.WriteLine($"HP: {kinghp}/{maxHp}");
            Console.WriteLine($"Attack power:{kingatk}");
            Console.WriteLine($"Rank: {kingisRank} ");

            string QueenName = "Nana";
            int queenhp = 125;
            int queenatk = 150;
            float queencurrentXp = 0.70f;
            double queencurrentLevel = 99.87;
            bool queenisRank = true;

            Console.WriteLine("===== Character 2 : {Queen} =====");
            Console.WriteLine($"Name : {QueenName}");
            Console.WriteLine($"HP: {queenhp}/{maxHp}");
            Console.WriteLine($"Attack power:{queenatk}");
            Console.WriteLine($"Rank: {queenisRank} ");

            string KnightName = "Lancelot";
            int knighthp = 125;
            int knightatk = 150;
            float knightcurrentXp = 0.70f;
            double knightcurrentLevel = 99.87;
            bool knightisRank = true;

            Console.WriteLine("===== Character 3 : {Knight} =====");
            Console.WriteLine($"Name : {KnightName}");
            Console.WriteLine($"HP: {knighthp}/{maxHp}");
            Console.WriteLine($"Attack power:{knightatk}");
            Console.WriteLine($"Rank: {knightisRank} ");


            string MageName = "Yoru";
            int magehp = 125;
            int mageatk = 150;
            float magecurrentXp = 0.70f;
            double magecurrentLevel = 99.87;
            bool mageisRank = true;

            Console.WriteLine("===== Character 4 : {Mage} =====");
            Console.WriteLine($"Name : {MageName}");
            Console.WriteLine($"HP: {magehp}/{maxHp}");
            Console.WriteLine($"Attack power:{mageatk}");
            Console.WriteLine($"Rank: {mageisRank} ");

            string RogueName = "Bim";
            int roguehp = 125;
            int rogueatk = 150;
            float roguecurrentXp = 0.70f;
            double roguecurrentLevel = 99.87;
            bool rogueisRank = true;

            Console.WriteLine("===== Character 5 : {Rogue} =====");
            Console.WriteLine($"Name : {RogueName}");
            Console.WriteLine($"HP: {roguehp}/{maxHp}");
            Console.WriteLine($"Attack power:{rogueatk}");
            Console.WriteLine($"Rank: {rogueisRank} ");
        }
    }
}