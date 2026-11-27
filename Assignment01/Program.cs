//ชื่อ - นามสกุล: Ratchanon Chaloklang
//Section: 129C
//รหัสนักศึกษา: 1690703168
//เลขที่: N/A

namespace Assignment01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string GameTitle = "FiveM";
            var CharacterName = "DOV";
            var rank = "OVER";
            int heroLevel = 100;
            float damage = 8.25f;
            double attack = 20.5;
            double opticBlast = 10;
            double concussiveBeam = 34;
            double TeamUp = 10;
            double strength = 37;
            double dexterity = 22;
            double intelligence = 10;
            double abilities = 47;
            bool isPlayable = true;
            
            Console.WriteLine($"░░▄███▄███▄\r\n░░█████████\r\n░░▒▀█████▀░\r\n░░▒░░▀█▀\r\n░░▒░░█░\r\n░░▒░█\r\n░░░█\r\n░░█░░░░███████\r\n░██░░░██▓▓███▓██▒\r\n██░░░█▓▓▓▓▓▓▓█▓████\r\n██░░██▓▓▓(◐)▓█▓█▓█\r\n███▓▓▓█▓▓▓▓▓█▓█▓▓▓▓█\r\n▀██▓▓█░██▓▓▓▓██▓▓▓▓▓█\r\n░▀██▀░░█▓▓▓▓▓▓▓▓▓▓▓▓▓█\r\n░░░░▒░░░█▓▓▓▓▓█▓▓▓▓▓▓█\r\n░░░░▒░░░█▓▓▓▓█▓█▓▓▓▓▓█\r\n░▒░░▒░░░█▓▓▓█▓▓▓█▓▓▓▓█\r\n░▒░░▒░░░█▓▓▓█░░░█▓▓▓█\r\n░▒░░▒░░██▓██░░░██▓▓██\r\n████████████████████████\r\n█▄─▄███─▄▄─█▄─█─▄█▄─▄▄─█\r\n██─██▀█─██─██─█─███─▄█▀█\r\n▀▄▄▄▄▄▀▄▄▄▄▀▀▄▄▄▀▀▄▄▄▄▄▀\r\n");
            Console.WriteLine($"Character Name : {CharacterName}");
            Console.WriteLine($"Rank        : {rank}");
            Console.WriteLine($"Level       : {heroLevel}");
            Console.WriteLine();
            Console.WriteLine($"===== Game Title =====");

            Console.WriteLine($"===== Attributes =====");
            Console.WriteLine($"Damage      : {damage}");
            Console.WriteLine($"Attack      : {attack}");
            Console.WriteLine($"Optic Blast : {opticBlast}");
            Console.WriteLine($"Concussive Beam : {concussiveBeam}");
            Console.WriteLine($"Team Up     : {TeamUp}");
            Console.WriteLine($"Strength    : {strength}");
            Console.WriteLine($"Dexterity   : {dexterity} ");
            Console.WriteLine($"Intelligence: {intelligence}");
            Console.WriteLine($"Abilities   : {abilities}");
            Console.WriteLine($"Playable    : {isPlayable}");
            Console.WriteLine();

            double heroLevelAsDouble = heroLevel;
            Console.WriteLine($"Level as double : {heroLevelAsDouble}");

            int vigorTruncated = (int)attack;
            int vigorRounded = Convert.ToInt32(attack);
            Console.WriteLine($"Vigor cast   : {vigorTruncated} ");
            Console.WriteLine($"Vigor Convert   : {vigorRounded}");
            Console.WriteLine($"======================");


        }
    }
}