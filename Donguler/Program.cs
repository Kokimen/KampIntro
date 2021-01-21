using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            //[] bu işaret array - diziler

            string[] courses = new string[] {"Software Training","Starting to Programming", "Java Learning" };

            for (int i = 0; i < courses.Length; i++)
            {
                Console.WriteLine(courses[i]);
            }

            Console.WriteLine("---------");

            foreach (var course in courses) //her bir eleman için kursların içinde dolaş, course değişken ismi
            {
                Console.WriteLine(course);
            }
        }
    }
}
