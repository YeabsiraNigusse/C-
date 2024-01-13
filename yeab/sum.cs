using System;

namespace yeab

{

    class sum{

        static void Main(string[] src){
            Console.WriteLine("Enter some Numebr")
            int number = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            for (int i = 0; i <= number; i++)
            {
                sum += i;
            }

               Console.WriteLine("the sum of 1 up to " + number + " is " + sum);        }
    }
}
