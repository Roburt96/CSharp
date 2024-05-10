using System;
using System.Collections.Generic;

namespace StackAndQueuesExercise
{
    class TruckTour
    {
        static void Main(string[] args)
        {
            int pumps = int.Parse(Console.ReadLine());

            var gasStations = new Queue<int[]>();

            for (int i = 0; i < pumps; i++)
            {
                string[] input = Console.ReadLine().Split(' ');
                int[] data = Array.ConvertAll(input, int.Parse);
                gasStations.Enqueue(data);
            }

            int start = 0; 
            int gasInside = 0; 
            int attempts = pumps; 


            for (int i = 0; i < attempts; i++)
            {
                bool completedTour = true; 

                for (int j = 0; j < pumps; j++)
                {
                    var station = gasStations.Dequeue();
                    gasInside += station[0];

                    if (station[1] > gasInside) 
                    {
                        completedTour = false; 
                        start++;
                    }
                    else
                    {
                        gasInside -= station[1];
                    }

                    gasStations.Enqueue(station); 
                }

                if (completedTour) 
                {
                    Console.WriteLine(start); 
                    return; 
                }
            }
        }
    }
}
