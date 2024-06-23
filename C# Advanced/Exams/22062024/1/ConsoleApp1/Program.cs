using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] packageWeights = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int[] courierCapacity = Console.ReadLine().Split().Select(int.Parse).ToArray();

        Stack<int> packages = new Stack<int>(packageWeights);
        Queue<int> couriers = new Queue<int>(courierCapacity);

        int totalDeliveredWeight = 0;

        while (packages.Any() && couriers.Any())
        {
            int currentPackage = packages.Pop();
            int currentCourier = couriers.Dequeue();

            if (currentCourier >= currentPackage)
            {
                totalDeliveredWeight += currentPackage;

                int remainingCapacity = currentCourier - 2 * currentPackage;
                if (remainingCapacity > 0)
                {
                    couriers.Enqueue(remainingCapacity);
                }
            }
            else
            {
                totalDeliveredWeight += currentCourier;
                int remainingPackageWeight = currentPackage - currentCourier;
                packages.Push(remainingPackageWeight);
            }
        }
        Console.WriteLine($"Total weight: {totalDeliveredWeight} kg");

        if (!packages.Any() && !couriers.Any())
        {
            Console.WriteLine("Congratulations, all packages were delivered successfully by the couriers today.");
        }
        else if (packages.Any() && !couriers.Any())
        {
            Console.WriteLine("Unfortunately, there are no more available couriers to deliver the following packages: " +
                              string.Join(", ", packages));
        }
        else if (!packages.Any() && couriers.Any())
        {
            Console.WriteLine("Couriers are still on duty: " +
                              string.Join(", ", couriers) +
                              " but there are no more packages to deliver.");
        }
    }
}
