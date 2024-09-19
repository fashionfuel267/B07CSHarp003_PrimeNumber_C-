using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B07CSHarp003_w01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("Enter number");
            int num = int.Parse(Console.ReadLine());
            IsPrime(num);*/
         //   Add( y:7,x: 9);
           Console.WriteLine( Add(x: 2,z :5));
         Console.WriteLine(   Name("Firoz"));
            Console.WriteLine(Name());

             AllPrime();
            Console.ReadKey();
        }//method
        //static void IsPrime(int n)
        //{
        //    bool isPrime = true;
        //    int m = n / 2;
        //    for (int i = 2; i <= m; i++)
        //    {
        //        //if(n!=i && n % i == 0)
        //        if (  n % i == 0)
        //        {
        //            isPrime = false;
        //        }
        //    }
        //    if (isPrime) {
        //        Console.WriteLine(  $"{n} is prime number");
        //    }
        //    else
        //    {
        //        Console.WriteLine($"{n} is not a prime number");
        //    }

        //}
        static bool IsPrime(int n)
        {
            bool isPrime = true;
            int m = n / 2;
            for (int i = 2; i <= m; i++)
            {
                //if(n!=i && n % i == 0)
                if (n % i == 0)
                {
                    isPrime = false;
                }
            }
            return isPrime;

        }
        static void AllPrime( )
        {
            string prime = "";
            //bool isPrime =true;
            int n = 100;
            for (int i = 1; i <= n; i++)
            {
              
                if (IsPrime(i))
                {
                    prime += i + "\t";
                }
                
            }
            Console.WriteLine(prime);

        }
        //Method overloading
        static int Add(int x, int y)
        {
            return x + y;
        }
        static int Add(int x, int y, int z)//paramaeter signature
        {
            return x + y + z;
        }
        static float Add(float x, int z, int y = 20)//optional parameter
        {
            return x + y + z;
        }
            static string Name(string n="")//optional parameter
        {
            if(string.IsNullOrEmpty(n))
            {
                n = "Defualt";
            }
            return  n.ToUpper();
        }

    }//cl
}//ns
