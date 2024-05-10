using System;
using System.Collections.Generic;

class Crossroads
{
    static void Main(string[] args)
    {
        int greenLightDuration = int.Parse(Console.ReadLine());
        int freeWindowDuration = int.Parse(Console.ReadLine());

        Queue<string> carQueue = new Queue<string>();
        int totalCarsPassed = 0;

        while (true)
        {
            string input = Console.ReadLine();

            if (input == "END")
            {
                break;
            }

            if (input == "green")
            {
                int currentGreenLight = greenLightDuration;
                int currentFreeWindow = freeWindowDuration;
                while (carQueue.Count > 0 && currentGreenLight > 0)
                {
                    string currentCar = carQueue.Peek();

                    if (currentCar.Length <= currentGreenLight)
                    {
                        carQueue.Dequeue();
                        currentGreenLight -= currentCar.Length;
                        totalCarsPassed++;
                    }
                    else
                    {
                        int remainingLength = currentCar.Length - currentGreenLight;
                        if (remainingLength <= currentFreeWindow)
                        {
                            currentFreeWindow -= remainingLength;
                            totalCarsPassed++;
                        }
                        else
                        {
                            int crashIndex = currentCar.Length - remainingLength + currentFreeWindow;
                            Console.WriteLine("A crash happened!");
                            Console.WriteLine($"{currentCar} was hit at {currentCar[crashIndex]}.");
                            return;
                        }
                    }
                }
                while (carQueue.Count > 0 && currentFreeWindow > 0)
                {
                    string currentCar = carQueue.Peek();

                    if (currentCar.Length <= currentFreeWindow)
                    {
                        carQueue.Dequeue();
                        currentFreeWindow -= currentCar.Length;
                        totalCarsPassed++;
                    }
                    else
                    {
                        int crashIndex = currentCar.Length - currentFreeWindow;
                        Console.WriteLine("A crash happened!");
                        Console.WriteLine($"{currentCar} was hit at {currentCar[crashIndex]}.");
                        return;
                    }
                }
            }
            else
            {
                carQueue.Enqueue(input);
            }
        }

        Console.WriteLine("Everyone is safe.");
        Console.WriteLine($"{totalCarsPassed} total cars passed the crossroads.");
    }
}
