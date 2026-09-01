namespace Lap03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int MaxLevel = 10;

            var bossName = "Kirin";   // ต้องประกาศด้วย var ห้ามเขียน string ตรงๆ
            var rank = 'S';            // ต้องประกาศด้วย var ห้ามเขียน char ตรงๆ
            int level = 7;
            int maxHp = 240;
            int currentHp = 115;       // ค่าตั้งต้นของ Lab นี้คือ HP "หลังโดนโจมตี" จาก Lab 2 แล้ว ไม่ใช่ 175
            float attackPower = 42.5f;
            double critMultiplier = 1.75;
            bool isBoss = true;

            Console.WriteLine("=======KIRIN SAVE CONVERTER========");
            Console.WriteLine($"" +
                $"Name: {bossName}\n" +
                $"Rank: {rank}\n" +
                $"Level: {level}\n" +
                $"Max HP: {maxHp}\n" +
                $"Current HP: {currentHp}\n" +
                $"Attack Power: {attackPower}\n" +
                $"Critical Multiplier: {critMultiplier}\n" +
                $"Is Boss: {isBoss}");
            //   Implicit Coversion Int (HP) ----> Double 
            Console.WriteLine("\n=======Conversion: HP as double========");
            double currentHpDouble = currentHp;
            Console.WriteLine($"HP (double): {currentHpDouble}%");

            //   Calculate Percentage 
            Console.WriteLine("\n======Exact HP Percent (no integer truncation) =========");
            double hpPercentageExact = (double)currentHp / 100 * maxHp;
            Console.WriteLine($"HP percent (exact): {hpPercentageExact}%");

            //   Explicit float (attackPower) ---> int 
            Console.WriteLine("\n====== Explicit Cast: Attack Power -> Display Int =====");
            int attackPowerInt = (int)attackPower;
            Console.WriteLine($"Attack Power (int cast): {attackPowerInt}");

            //   Cast vs. convert double (critMultiplier) ---> int
            Console.WriteLine("\n====== Cast vs. Convert: Critical Multiplier -> Display Int =====");
            int critMultiplierInt = (int )critMultiplier;
            int critMultiplierConverted = Convert.ToInt32(critMultiplier);
            Console.WriteLine($"Critical Multiplier (int cast): {critMultiplierInt}");
            Console.WriteLine($"Critical Multiplier (int convert): {critMultiplierConverted}");

        }
        }
    }

