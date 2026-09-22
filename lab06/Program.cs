using System.Collections;

namespace lab06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1690703168
            //Ratchanon Chaloklang 
            //GI113/129c
            //No.28
             /*
            int lives = 1;
            if (lives <= 0) // ใส่เงื่อนไขที่ต้องการเช็ค ค่าที่ได้ต้องเป็น bool (true / false)
            {                //โด๊ดด้านในจะรันก็ต่อเมื่อ If เป็น true เท่านั้น
                Console.WriteLine("Game Over");
            }
            else
            {
                Console.WriteLine("Keep Fighting");
            }
            //ถ้า if ทำงานเสร็จแล้ว หรือ เป็น false จะทำงานต่อมาบรรทัดด้านนอกทันที
            Console.WriteLine("Continue Code");


            int level = 10;
            // เมื่อใช้เงื่อนไขหลายเคส ให้เช็คเลขลงจาก มาก -> น้อย เสมอ
            if (level >= 10) // เงื่อนไข 1
            {
                Console.WriteLine("Boss floor unlocked");
            }
            else if (level >= 5) // เงื่อนไข 2 ถ้ายังไม่ตรงเงื่อนไข 1
            {
                Console.WriteLine("The door opens.");
            }
            else // เมื่อไม่ตรงซักเงื่อนไข
            {
                Console.WriteLine("The door stays shut.");
            }

            bool isPosioned = true;
            if (isPosioned == true) // เช็คว่าเป็นจริงมั้ย?
            {
                Console.WriteLine("You Died");
            }
            else if (isPosioned == false) // เช็คว่าเป็นเท็จมั้ย?
            {
                Console.WriteLine("You Lives");
            }
            */

            int heroAtk = 30;
            int heroHp = 100;
            int monHp = 100;
            int monatk = 20;


            Console.WriteLine(">=== Hero VS Monster <===");
            Console.WriteLine("ACTION 1: Attack");
            Console.WriteLine("ACTION 2: Strong Attack");
            Console.WriteLine("ACTION 3: Defend");

            int action = int.Parse(Console.ReadLine());

            if (action == 1)
            {
                monHp = monHp - heroAtk;
                Console.WriteLine("Hero Attacks Monster");

            }
            else if (action == 2)
            {
                monHp = monHp - heroAtk;
                Console.WriteLine("Hero Strong Attacks Monster");

            }
            else if (action == 3)
            {
                heroHp = heroHp + 10;
                Console.WriteLine("Hero Defends and Gains 10 HP");
            }
            else
            {
                Console.WriteLine("Invalid Action");
            }

        }
    }
}
            
        
    

