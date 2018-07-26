using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1Ex
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            Console.ReadLine();
            Ex2a.Q2();
            Console.ReadLine();
        }
    }
    public class Ex2a //My Way - Write a console application to store the numbers 74 & 36, add them together and display the sum of them on the screen.
    {
        public static void Q2()
        {
            var num1 = 74;
            var num2 = 36;

            Console.WriteLine("{0} + {1} = {2}", num1, num2, (num1 + num2));
            Console.ReadLine();
            Ex2b.Q2();
            Console.ReadLine();
        }
    }

    public class Ex2b //Jacob's Way
    {
        public static void Q2()
        {
            int num1 = 74;
            int num2 = 36;
            int total = num1 + num2;

            Console.WriteLine(total);
            Console.ReadLine();
            Ex3.Q3();
            Console.ReadLine();
        }
    }

    public class Ex3 //Jacob's way - Write a console application that takes two numbers as input from the user and displays the product of the two numbers
    {
        public static void Q3()
        {
            Console.WriteLine("Please input a number...");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Please input another number...");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("{0} x {1} = {2}", num1, num2, (num1 * num2));
            Console.ReadLine();
            Ex4.Q4();
            Console.ReadLine();
        }
    }

    public class Ex4 //My way - Write a console application that accepts the users first name and last name and then greets them by their full name.
    {
        public static void Q4()
        {
            Console.WriteLine("Please input your first name.");
            string name1 = (Console.ReadLine());
            Console.WriteLine("Please input your second name.");
            string name2 = (Console.ReadLine());
            Console.WriteLine("Your full name is {0} {1}", name1, name2);
            Console.ReadLine();
            Ex5.Q5();
            Console.ReadLine();
        }
    }

    public class Ex5 //My way - Write a console application that asks the user for a number between 1 and 12 and shows the times tables for that number. HINT: Use a loop.
    {
        public static void Q5()
        {

            Console.WriteLine("Which times table do you want to see?");
            int userNum = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 12; i++)
                Console.WriteLine("{0} x {1} = {2}", i, userNum, (userNum * i));
            Console.ReadLine();
            Ex6.Q6();
            Console.ReadLine();
        }
    }

    public class Ex6 //My way - Write a console application that asks the user to enter two numbers, num1 and num2, then swap the two variables and display back to the screen.

    {
        public static void Q6()

        {
            Console.WriteLine("Please input your first number.");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Please input your second number.");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Number 1 is {0}, Number 2 is {1}", num2, num1);
            Console.ReadLine();
            Ex7.Q7();
            Console.ReadLine();
        }
    }

    public class Ex7 //My way - Write a console application that takes three numbers from the user and displays the largest number on the screen.

    {
        public static void Q7()

        {
            Console.WriteLine("Please input your first number.");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Please input your second number.");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Please input your third number.");
            int num3 = int.Parse(Console.ReadLine());

            if (num1 > num2 && num1 > num3)
            {
                Console.WriteLine("The largest number is {0}", num1);
            }

            if (num2 > num1 && num2 > num3)
            {
                Console.WriteLine("The largest number is {0}", num2);
            }

            else
            {
                Console.WriteLine("The largest number is {0}", num3);
            }
            Console.ReadLine();
            Ex8.Q8();
            Console.ReadLine();
        }
    }

    public class Ex8 //My way - Write a console application that asks the user to enter their final course mark and then tells them if they passed or not (pass mark is 50%).

    {
        public static void Q8()

        {
            Console.WriteLine("Please input your final course mark.");
            int courseMark = int.Parse(Console.ReadLine());

            if (courseMark >= 50)

            {
                Console.WriteLine("Your coursemark is a Pass");
            }

            else

            {
                Console.WriteLine("Your coursemark is a Fail");
            }

            //Console.ReadLine();
            //Ex9.Q9();
            //Console.ReadLine();


        }
    }

    //public class Ex9 //My way - Write a console application that contains an array of size 5 and populate with classmates names and display back to the screen.

    //{
    //    public static void Q9()

    //    {
    //        var myStrArray = ["Bob", "Ann", "Ed", "Sam", "Jo"];

    //        for (int i = 0; i < myStrArray.length; i++)

    //        Console.WriteLine(string{i}: {myStrArray[i]});

    //        Console.ReadLine();



    //    }
    //}
}
