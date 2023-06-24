using System;
using System.Collections.Generic;
using System.Linq;
namespace task5
{
    class Students
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            List<Students> students = new List<Students>()
        {
            new Students { Name = "John", Age = 20 },
            new Students { Name = "Alice", Age = 22 },
            new Students { Name = "David", Age = 18 },
            new Students { Name = "Sarah", Age = 21 },
            new Students { Name = "Michael", Age = 19 },
            new Students { Name = "Emily", Age = 20 },
        };
            int minAge = 20;
            var filteredStudents = students.Where(s => s.Age >= minAge);
            var ageGroups = filteredStudents.GroupBy(s => (s.Age / 5) * 5);
            foreach (var group in ageGroups)
            {
                int ageRangeStart = group.Key;
                int ageRangeEnd = ageRangeStart + 4;

                Console.WriteLine($"Age Rangr: {ageRangeStart} - {ageRangeEnd}");
                Console.WriteLine($"Count: {group.Count()}");
                Console.WriteLine();
            }
        }
    }
}