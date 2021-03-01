using System;
using System.Linq;

namespace TestPage
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] nums = {1, 2 ,3 , 4, 5 };
            //Console.WriteLine(string.Join(' ', nums));
            //Console.WriteLine();

            ////int [] newNums = nums.Reverse().ToArray(); //does not change the old arrray
            //Array.Reverse(nums); // changes the old array !

            //Console.WriteLine(string.Join(' ', nums));


            //Person[] persons = new Person[]
            //{
            //    new Person(){Name = "Pesho", Age = 25 },
            //    new Person(){Name = "Gosho", Age = 20 },
            //    new Person(){Name = "Pesho", Age = 15 },
            //    new Person(){Name = "Misho", Age = 42 },
            //};

            //foreach (var item in persons)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine();

            //persons = persons
            //    .Where(p => p.Name == "Pesho" && p.Age < 21)  // anonymous function in the brackets !!!
            //    //.ThenBy(p => p.Age)
            //    .ToArray();

            //foreach (var item in persons)
            //{
            //    Console.WriteLine(item);
            //}
            // lambda functon is anonymous function !!!
            // lambda is anonimous function !!!
            // p -parameter,  after => p.Name --is the result of the function ! 
            // Console.WriteLine();

            //Person[] newPerson = persons
            //    .OrderBy(p => p.Name)
            //    .ThenBy(p => p.Age)
            //    .ToArray();

            //foreach (var item in newPerson)
            //{
            //    Console.WriteLine(item);
            //}

            int[] nums = new int[] {1, 2 , 3 , 4 , 5 , 6 , 10 };

            int[] even = nums
                .Where(n => n % 2 == 0)
                .OrderBy(n => n)
                .ToArray();

            int[] odd = nums
                .Where(n => n % 2 != 0)
                .OrderByDescending(n => n)
                .ToArray();

            Console.WriteLine(string.Join(' ', odd));
            Console.WriteLine();
            Console.WriteLine( string.Join(' ', even));
        }

        //private static string GetName(Person p)
        //{
        //    return p.Name;
        //}
    }
}
