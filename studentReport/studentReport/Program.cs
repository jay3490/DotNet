using System;
using System.Collections.Generic;
namespace demo_student

{

    public class Program
    {
        public static void Main()
        {
            int ID;
            Student student = new Student();

            Console.WriteLine("Please Enter Student Id: ");
            ID = Convert.ToInt32(Console.ReadLine());
            if (ID = Id)
        }

               public List<Student> students = new List<Student>
                {
            new Student
            {
              Id = 1,
              Name = "Shreya",
              Age = 22,
              City = "Ahmedabad"

            },
             new Student
             {
               Id = 2,
               Name = "shivam",
               Age = 23,
               City = "Jaipur",

             },
              new Student
              { Id = 3,
                Name = "Jay",
                Age = 25,
                City = "Kutch",

              },

        };
    }
    }

    public class Student
    {

        public string Name { get; set; }

        public int Age { get; set; }
        public string City { get; set; }
        public int total { get; set; }

        public int Id { get; set; }
        public List<Student> students = new List<Student>
        {
            new Student
            { 
              Id = 1,
              Name = "Shreya",
              Age = 22,
              City = "Ahmedabad"

            },
             new Student
             {
               Id = 2,
               Name = "shivam",
               Age = 23,
               City = "Jaipur",

             },
              new Student
              { Id = 3,
                Name = "Jay",
                Age = 25,
                City = "Kutch",

              },

        };

        public class Subject
        {
            public int SubjectId { get; set; }
            public int Id { get; set; }
            public string SubjectName { get; set; }

            //Subject maths = new Subject();
            //Subject chemistry = new Subject();
            //Subject physics = new Subject();
            static List<Subject> subjects = new List<Subject>
            {
                new Subject
                {
                  SubjectId = 1,
                  SubjectName = "Maths"

                },
                 new Subject
                 {
                  SubjectId= 2,
                  SubjectName ="Chemistry"
                 },
                 new Subject
                 {
                  SubjectId= 3,
                  SubjectName ="Physics"
                 },

             };

        }
        public class Marks
        {
            public int SubjectId { get; set; }
            public int Id { get; set; }
            public int Total { get; set; }
            public int Score { get; set; }
            static List<Marks> marks = new List<Marks>
            {
                new Marks
                {
                    Id = 1,
                    SubjectId = 1,
                    Score = 94
                },
                new Marks
                {
                    Id = 1,
                    SubjectId = 2,
                    Score = 83
                },
                 new Marks
                {
                    Id = 1,
                    SubjectId = 3,
                    Score = 66
                },
                new Marks
                {
                    Id = 2,
                    SubjectId = 1,
                    Score = 54
                },
                new Marks
                {
                    Id = 2,
                    SubjectId = 2,
                    Score = 95
                },
                 new Marks
                {
                    Id = 2,
                    SubjectId = 3,
                    Score = 88
                },
                new Marks
                {
                    Id = 3,
                    SubjectId = 1,
                    Score = 85
                },
               
                new Marks
                {
                    Id = 3,
                    SubjectId = 2,
                    Score = 57
                },
                new Marks
                {
                    Id = 3,
                    SubjectId = 3,
                    Score = 22
                }


             };

        }


    }


//namespace studentReport
//{
//    class Program
//    {

//        static void Main(string[] args)
//        {
//            int r, marks1, marks2, marks3, total;
//            float percentage;
//            string n;

//            Console.WriteLine("Enter Student Roll Number :");
//            r = Convert.ToInt32(Console.ReadLine());


//            Console.WriteLine("Enter Student Name :");
//            n = Console.ReadLine();

//            Console.WriteLine("Enter Physics Marks : ");
//            marks1 = Convert.ToInt32(Console.ReadLine());


//            Console.WriteLine("Enter Chemistry Marks : ");
//            marks2 = Convert.ToInt32(Console.ReadLine());

//            Console.WriteLine("Enter Maths Marks :");
//            marks3 = Convert.ToInt32(Console.ReadLine());

//            // total marks
//            total = marks1 + marks2 + marks3;

//            // percentage
//            percentage = total / 3.0f;

//            // final result
//            Console.WriteLine("Final result of {0} is:", n);
//            Console.WriteLine("Total Marks : " + total);
//            Console.WriteLine("Percentage : " + percentage);

//            // grades
//            if (percentage <= 35)
//            {
//                Console.WriteLine("Grade is F");
//            }
//            else if (percentage >= 34 && percentage <= 39)
//            {
//                Console.WriteLine("Grade is D");
//            }
//            else if (percentage >= 40 && percentage <= 59)
//            {
//                Console.WriteLine("Grade is C");
//            }
//            else if (percentage >= 60 && percentage <= 69)
//            {
//                Console.WriteLine("Grade is B");
//            }
//            else if (percentage >= 70 && percentage <= 79)
//            {
//                Console.WriteLine("Grade is B+");
//            }
//            else if (percentage >= 80 && percentage <= 90)
//            {
//                Console.WriteLine("Grade is A");
//            }
//            else if (percentage >= 91)
//            {
//                Console.WriteLine("Grade is A+");
//            }
//        }
//    }
//}
