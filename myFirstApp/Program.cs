using System;

namespace myFirstApp
{
     class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            int reminder,temp;
            int sum = 0;
            temp = number;
            while(number > 0)
            {   
                reminder = number % 10;
                number = number / 10;
                sum  = sum * 10 + reminder;
            }
        
            if(temp == sum)
            {
                Console.WriteLine("The number is palindrome number");
            }

            else
            {
                Console.WriteLine("The number is not palindrome number");     
            }
        }

    }
}
