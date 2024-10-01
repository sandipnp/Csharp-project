using System;
/*using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;*/

namespace randomnumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random= new Random();
            int guess = random.Next(1, 11);
            int userguess = 0;
            int attempt = 4;
            Console.WriteLine("guess the number between 1 and 10");
            while (attempt>0) {
                Console.WriteLine("Enter your guess:");
                userguess=int.Parse(Console.ReadLine());
                if(userguess==guess) {
                    Console.WriteLine("You guessed the right number");
                    break;
                }
                else {
                    attempt--;
                    if(attempt>0) {
                        Console.WriteLine("Wrong guess. You have{0} attempt left");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, you have used all your guesses. The right number was{0}", guess);
                    }



                }
    }
}
}
}
