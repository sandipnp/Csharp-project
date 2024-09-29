using System;
/*using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;*/

namespace carspeedlimit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the speed limit ");
            int SpeedLimit = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the speed of car");
            int CarSpeed = int.Parse(Console.ReadLine());
            if (CarSpeed <= SpeedLimit) {
                Console.WriteLine("Your Speed is Ok");
                    
                    }
            else {
                Console.WriteLine("Your Speed over the limit");
                int DemeritPoints = (CarSpeed - SpeedLimit) / 5;
                Console.WriteLine("Demerit points:" +DemeritPoints);
                if (DemeritPoints > 12) {
                    Console.WriteLine("License Suspended");



        }
    }
}
    }
}

