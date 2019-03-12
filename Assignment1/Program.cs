using System;
using System.Collections.Generic;

namespace Assignment1
{
    class Program
    {
        public static void Main()
        {

            #region Print prime number call
            Console.WriteLine("***Start: Print prime numbers.***");
            int a = 5, b = 15;
            printPrimeNumbers(a, b);
            Console.WriteLine("***End: Print prime numbers.***");
            #endregion

            #region Series sum call
            Console.WriteLine("***Start: Series sum call.***");
            int n1 = 5;
            double r1 = getSeriesResult(n1);
            Console.WriteLine("The sum of the series is: " + r1);
            Console.WriteLine("***End: Series sum call.***");
            #endregion

            #region Print Triangle Call
            Console.WriteLine("***Start: Print triangle.***");
            int n4 = 5;
            printTriangle(n4);
            Console.WriteLine("***End: Print triangle.***");
            #endregion

            #region Compute Frequency Call
            Console.WriteLine("***Start: Compute frequency.***");
            int[] arr = new int[] { 1, 2, 3, 2, 2, 1, 3, 2 };
            computeFrequency(arr);
            Console.ReadLine();
            Console.WriteLine("***End: Compute frequency.***");
            #endregion


            #region self reflection
            /*Nicely curated exercise for beginner level C# programming. It took me around 2-3 hours to complete 
            the exercise and I really enjoyed doing this. I really likes the prime number problem as it took me 
            back to memory lane and I could review some of the old algorithms for prime number calculation such as 
            Lucas-Lehemer, Sieve of Eratosthenes, and AKS. 
            Difficulty level of some of these problems can be increased, however, I would say based on the profile
            of the class these are good set of problems. If I may suggest, I would prefer the exercise to have 6 problems 
            with varying difficulty levels and students should choose to answer any 4 based on their expertise. 
            This will give a fair sense of idea about the skill level of the class. */ 
            //
            #endregion
        }

        #region Print prime number method

        /// <summary>
        /// This method checks if the number is prime and prints it.
        /// </summary>
        /// <param name="x">Start Number</param>
        /// <param name="y">End Number</param>
        public static void printPrimeNumbers(int x, int y)
        {
            try
            {
                //loop through each number
                for (int i = x; i <= y; i++)
                {
                    //Calling isPrime method.
                    bool bIsPrime = isPrime(i);
                    //bool bIsPrime = isPrimeAKS(i);
                    //bool bIsPrime = isPrimeSqrt(i);
                    if (bIsPrime)
                    {
                        //Print if the number is prime
                        Console.WriteLine("This is prime: " + i);
                        Console.ReadKey();
                    }
                   
                }
                    
            }
            catch
            {
                Console.WriteLine("Exception occured while computing printPrimeNumbers()");
            }
        }

        #endregion

        #region Calculate prime method  
        

        /// <summary>
        /// Checks if the number is Prime and returns boolean
        /// </summary>
        /// <param name="x">The input number</param>
        /// <returns>bool returns true if the number is Prime else returns false</returns>
        public static bool isPrime(int x)
        {

            try
            {
                if (x % 2 == 0)
                    return false;
                else
                    for (int i = 3; i < x; i += 2)
                    {
                        if (x % i == 0)
                            return false;
                        else return true;
                    }

                return true;

            }
            catch (Exception ex)
            {

                Console.WriteLine("Exception occured while computing printPrimeNumbers()" + ex.ToString());
                return false;
            }
            
            
        }
        #endregion


        #region Squre root method for the large numbers.
        /// <summary>
        /// This is square root method For large number. This requires less number of iterations to check if the number is prime.
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public static bool isPrimeSqrt(int x)
        {
            if (x <= 1)
                return false;
            if (x % 2 == 0)
                return false;
            long longX = (long)(Math.Sqrt(x) + 0.5);

            for (int i = 3; i <= longX; i += 2)
            {
                if (longX % i == 0)
                    return false;
                else return true;
            }

            return false;

        }
        #endregion

        
        /// <summary>
        /// Calculates the sum of the series as defined in the problem statement.
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static double getSeriesResult(int n)
        {
            double result=0.00; 
            try
            {                // Write your code here
                for (int i=1; i <n; i++)
                {
                    if (i % 2 == 0)
                    {

                        result = result + (-1)*((double)(getFactorial(i)) / (i+1));
                        Console.WriteLine("Value of i: " + i + " cummulative sum of the series: " + result);

                    }
                    else
                    {
                        result = result + ((double)(getFactorial(i)) / (i+1));
                        Console.WriteLine("Value of i: " + i + " cummulative sum of the series: " + result);
                    }
                }
                return result;
            }
            catch
            {
                Console.WriteLine("Exception occured while computing getSeriesResult()");
            }
            return 0;
        }


        /// <summary>
        /// Get factorial method
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static int getFactorial(int n)
        {
            try
            {
                int fact = 1;
                int i = 1;
                while (i <= n)
                {
                    fact = fact * i;
                    i++;
                }
                return fact;

            }
            catch (Exception)
            {

                Console.WriteLine("There is an exception in calculating the factoral.");

                throw;
            }
           
        }


        /// <summary>
        /// Print triangle method. The triangle dimention is defined by the input n.
        /// </summary>
        /// <param name="n"></param>
        public static void printTriangle(int n)
        {
            try
            {
                // Write your code here 
                for (int i = 1; i <= n; i++)
                {
                    for (int k=n; k>=i; k--)
                    {
                        Console.Write("  ");
                    }
                    for (int j=1; j<=2*i-1; j++)
                    {
                        Console.Write("* ");
                    }
                    Console.Write('\n');
                }
                Console.ReadKey();

            }
            catch
            {
                Console.WriteLine("Exception occured while computing printTriangle()");
            }
        }


        /// <summary>
        /// Computes frequency of the number in the given array
        /// </summary>
        /// <param name="a"></param>
        public static void computeFrequency(int[] a)
        {
            try
            {                // Write your code here   
                List<int> temp = new List<int>();
                for (int i = 0; i < a.Length; i++)
                {
                    //int ctr = 0;
                    
                    int count = 0;
                    if (!temp.Contains(a[i]))
                    {
                        for (int j = 0; j < a.Length; j++)
                    {

                        
                            if (a[i] == a[j])
                            {
                                count = count + 1;

                            }
                        }

                        //else ctr = i;
                        Console.WriteLine("Number: " + a[i] + " Count: " + count);
                    }
                    
                    temp.Add(a[i]);
                }
            }
            catch
            {
                Console.WriteLine("Exception occured while computing computeFrequency()");
            }
        }
    }
}