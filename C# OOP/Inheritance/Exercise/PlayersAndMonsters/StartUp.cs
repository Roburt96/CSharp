using System;

namespace PlayersAndMonsters
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            Elf elf = new Elf("Hero", 20);
            Console.WriteLine(elf);
        }
    }
}