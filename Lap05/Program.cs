namespace Lap05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1690703168,Ratchanon Chaloklang,GI113/129c,No.28
            //Game title , Sub=title
            Console.WriteLine("==>> MY GAME DEE <<==");
            Console.WriteLine("Hero vs. Monster, Fight damage calulator\n");
            
            // Hero stats input HP, ATK, DEF
            Console.Write("Hero Health: ");
            bool heroHpok = int.TryParse(Console.ReadLine(), out int heroHp);
            Console.Write("Hero Attack: ");
            bool heroAtkok = int.TryParse(Console.ReadLine(), out int heroAtk);
            Console.Write("Hero Defense: ");
            bool herodefok = int.TryParse(Console.ReadLine(), out int herodef);
            
            // Monster stats input
            Console.Write("Monster Health: ");
            bool monHpok = int.TryParse(Console.ReadLine(), out int monHp);
            Console.Write("Monster Attack: ");
            bool monAtkok = int.TryParse(Console.ReadLine(), out int monAtk);
            Console.Write("Monster Defense: ");
            bool monDefok = int.TryParse(Console.ReadLine(), out int mondef);

            //Input validation
            bool isHeroIntValid = heroHpok && heroAtkok && herodefok;
            bool isMonsterIntValid = monHpok && monAtkok && monDefok;
            Console.WriteLine($"Hero Stats Valid: {isHeroIntValid}");
            Console.WriteLine($"Monster Stats Valid: {isMonsterIntValid}");

            Console.WriteLine($"[HERO] HP: {heroHp}, ATK: {heroAtk}, DEF: {herodef}");
            Console.WriteLine($"[MONSTER] HP: {monHp}, ATK: {monAtk}, DEF: {mondef}");

            //Compount assignment :+-   จำลองสถานะการณ์การดื่มยาฟื้นฟูพลังชีวิตของ Hero ก่อนต่อสู้กับ 
            int potionHeal = 8;
            //heroHp = heroHp + potionHeal; //  ยาว 
            heroHp += potionHeal;
            Console.WriteLine($"\nHero drank a potion, healing {potionHeal} HP. Hero now {heroHp} Hp");

            //Arithmetic +การโจมตีธรรมดา
            int normalDamage = Math.Max(0,heroAtk - mondef); //ความแรงในการโจมตีขึ้นอยู่กับค่าป้องกันของมอนสเตอร์
            Console.WriteLine($"\nHero attacks Monster for {normalDamage} damage.");

            //Precedence การโจมตีแบบพิเศษ
            int pwrDmg = Math.Max(0, (heroAtk * 2) - mondef); //โจมตีคูณ 2 จะใส่วงเล็บเพื่อให้แน่ใจว่าการคูณเกิดขึ้นก่อนการลบ
            Console.WriteLine($"power attack damage would deal {pwrDmg} damage.");

            //Random , Simple percent of critical chance
            Random randomSomthing = new Random();
            int roll = randomSomthing.Next(1, 101); // ต้อง+1 ค่ามากสุดเสมอ เช่น 100 ต้องเป็น 101
            bool isCritical = roll <= 10; // 10% chance for 100
            int criticalDamage = normalDamage + Convert.ToInt32(isCritical) * normalDamage; // bool 1 หรือ 0
            Console.WriteLine($"\nCritical hit roll: {roll} (critical: {isCritical})");
            Console.WriteLine($"If cirtical , normal attack damage would instead deal {criticalDamage}");
        }
    }
}
