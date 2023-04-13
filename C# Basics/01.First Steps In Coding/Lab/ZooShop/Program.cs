using System;

namespace ZooShop
{
    class Program
    {
        static void Main(string[] args)
        {
            int catFoodPrice = 4;
            double dogFoodPrice = 2.50;
            
            int DogPacks = Int32.Parse(Console.ReadLine());
            int CatPacks = Int32.Parse(Console.ReadLine());

            double totalSum = (dogFoodPrice * DogPacks) + (catFoodPrice * CatPacks);
            Console.WriteLine($"{totalSum} lv.");
        }
    }
}