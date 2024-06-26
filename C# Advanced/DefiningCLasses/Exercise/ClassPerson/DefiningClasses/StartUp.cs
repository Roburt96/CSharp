﻿namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Family family = new Family();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] info = Console.ReadLine().Split();

                string name = info[0];
                int age = int.Parse(info[1]);

                Person person = new Person(name, age);

                family.AddMember(person);
            }

            foreach(var member in family.People.OrderBy(x => x.Name))
            {
                if (member.Age > 30)
                {
                    Console.WriteLine($"{member.Name} - {member.Age}");
                }
            }

            //Person findOldest = family.GetOldestMember();
            //Console.WriteLine($"{findOldest.Name} {findOldest.Age}");
        }
    }
}