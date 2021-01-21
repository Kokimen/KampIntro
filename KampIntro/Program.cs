using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Course course1 = new Course();
            course1.Name = "Java";
            course1.Teacher = "Engin Demiroğ";
            course1.WatchingRates = 65;

            Course course2 = new Course();
            course2.Name = "Python";
            course2.Teacher = "Berkay Bilgin";
            course2.WatchingRates = 75;

            Course course3 = new Course();
            course3.Name = "C++";
            course3.Teacher = "Kerem Varış";
            course3.WatchingRates = 85;

            Console.WriteLine(course1.Name + " " + course1.Teacher + " " + course1.WatchingRates); //burası kendini tekrar ettiğin yer, uzun hal
            Console.WriteLine(course2.Name + " " + course2.Teacher + " " + course2.WatchingRates);
            Console.WriteLine(course3.Name + " " + course3.Teacher + " " + course3.WatchingRates);

            Course[] courses = new Course[] {course1, course2, course3 };

            foreach (var course in courses)
            {
                Console.WriteLine(course.Name + " " + course.Teacher + " " + course.WatchingRates); //yukarıdakinin kısaltılmış hali, kendini tekrar etme
            }


        }
    }
    class Course
    {
        public string Name { get; set; }
        public string Teacher { get; set; }
        public int WatchingRates { get; set; }
    }

}
