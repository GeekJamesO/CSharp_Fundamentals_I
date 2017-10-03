using System;

namespace Fundamentals_I
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Create a Loop that prints all values from 1-255");
            Print1To255();
            Console.WriteLine();

            Console.WriteLine("Create a new loop that prints all values from 1-100 that are divisible by 3 or 5, but not both");
            Print3or5_V1();
			Console.WriteLine();

            Console.WriteLine("Modify the previous loop to print \"Fizz\" for multiples of 3, \"Buzz\" for multiples of 5, and \"FizzBuzz\" for numbers that are multiples of both 3 and 5");
			Print3or5_V2();
			Console.WriteLine();

            Console.WriteLine("(Optional) If you used modulus in the last step, try doing the same without using it. Vice-versa for those who didnt!");
            Print3or5_V3();
			Console.WriteLine();

            Console.WriteLine("(Optional) Generate 10 random values and output the respective word, in relation to step three, for the generated values");
            RndPrint3or5_V5();
			Console.WriteLine();
		}

        //Create a Loop that prints all values from 1-255  
        public static void Print1To255(int start = 1, int end = 255)
        {
            for (int k = start; k <= end; k++)
            {
                if (k < end)
                {
                    Console.Write(string.Format("{0}, ", k.ToString("000")));
                } else { 
                    Console.WriteLine(k.ToString("000")); 
                }
            }
        }

        //Create a new loop that prints all values from 1-100 that are divisible by 3 or 5, but not both 
        public static void Print3or5_V1(int start = 1, int end = 100)
        {
			Console.Write("Numbers:");
			for (int k = start; k <= end; k++) 
            {
                if ( (k % 3 == 0) ^ (k % 5 == 0) ) {
                    Console.Write(k + ", "); 
                }
            }
            Console.WriteLine();
		}

		//Modify the previous loop to print "Fizz" for multiples of 3, "Buzz" for multiples of 5, and "FizzBuzz" for numbers that are multiples of both 3 and 5  
		public static void Print3or5_V2(int start = 1, int end = 100)
		{
			Console.Write("Numbers:");
			for (int k = start; k <= end; k++)
			{
				if ((k % 3 == 0) && (k % 5 == 0))
				{
                    Console.Write("FizzBuzz ");
				}
				else if (k % 3 == 0) 
				{
					Console.Write("Fizz ");
				}
				else if (k % 5 == 0)
				{
					Console.Write("Buzz ");
				}
			}
			Console.WriteLine();
		}

        private static Boolean divisibleByThree(int anInt)
        {
            int newValue = (anInt / 3) * 3;
            return anInt == newValue;
        }
		private static Boolean divisibleByFive(int anInt)
		{
			int newValue = (anInt / 5) * 5;
			return anInt == newValue;
		}
		//(Optional) If you used modulus in the last step, try doing the same without using it. Vice-versa for those who didnt!  
		public static void Print3or5_V3()
		{
			Console.Write("Numbers:");
			for (int k = 1; k <= 100; k++)
			{
				if (divisibleByThree(k) && divisibleByFive(k))
				{
					Console.Write("FizzBuzz ");
				}
                else if (divisibleByThree(k))
				{
					Console.Write("Fizz ");
				}
                         else if (divisibleByFive(k))
				{
					Console.Write("Buzz ");
				}
			}
			Console.WriteLine();
		}
		//(Optional) Generate 10 random values and output the respective word, in relation to step three, for the generated values   
		public static void RndPrint3or5_V5()
		{
			Console.Write("Numbers:");
            var RndObj = new System.Random();
			for (int x = 1; x <= 10; x++)
			{
                int k = RndObj.Next(1, 100);

                Console.Write(k);
                if ((k % 3 == 0) && (k % 5 == 0))
                {
                    Console.Write(":FizzBuzz ");
                }
                else if (k % 3 == 0)
                {
                    Console.Write(":Fizz ");
                }
                else if (k % 5 == 0)
                {
                    Console.Write(":Buzz ");
                }
                else Console.Write(" - ");
			}
			Console.WriteLine();
		}
	}
}