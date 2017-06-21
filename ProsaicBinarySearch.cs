using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProsaicBinarySearch
{
    class KataBinarySearch
    {
        static void Main(string[] args)
        {
            //int[] myArrayOfInt = new int[9] {1,2,3,4,5,6,7,8,9};
            int[] myArrayOfInt = new int[10] {1,2,3,4,5,6,7,8,9,10};
            //int[] myArrayOfInt = new int[4] {3, 4, 5, 6};

            Console.WriteLine(IterativeChop(1, myArrayOfInt)); //0
            Console.WriteLine(IterativeChop(2, myArrayOfInt)); //1
            Console.WriteLine(IterativeChop(3, myArrayOfInt)); //2
            Console.WriteLine(IterativeChop(4, myArrayOfInt)); //3
            Console.WriteLine(IterativeChop(6, myArrayOfInt)); //5
            Console.WriteLine(IterativeChop(10, myArrayOfInt)); //9
            Console.WriteLine(IterativeChop(5, myArrayOfInt)); //4
            Console.WriteLine(IterativeChop(11, myArrayOfInt)); //-1
            Console.WriteLine(IterativeChop(8, myArrayOfInt)); //7
            Console.WriteLine(IterativeChop(9, myArrayOfInt)); //8
            Console.WriteLine(IterativeChop(-1, myArrayOfInt)); //-1

            Console.WriteLine();

            Console.WriteLine(RecursiveChop(1, myArrayOfInt)); //0
            Console.WriteLine(RecursiveChop(2, myArrayOfInt)); //1
            Console.WriteLine(RecursiveChop(3, myArrayOfInt)); //2
            Console.WriteLine(RecursiveChop(4, myArrayOfInt)); //3
            Console.WriteLine(RecursiveChop(6, myArrayOfInt)); //5
            Console.WriteLine(RecursiveChop(10, myArrayOfInt)); //9
            Console.WriteLine(RecursiveChop(5, myArrayOfInt)); //4
            Console.WriteLine(RecursiveChop(11, myArrayOfInt)); //-1
            Console.WriteLine(RecursiveChop(8, myArrayOfInt)); //7
            Console.WriteLine(RecursiveChop(9, myArrayOfInt)); //8
            Console.WriteLine(RecursiveChop(-1, myArrayOfInt)); //-1
            Console.ReadLine();
        }

        public static int RecursiveChop(int searchInt, int[] arrayToSearch)
        {
            int midPoint = new int();
            int leftPoint = new int();
            int rightPoint = new int();

            leftPoint = 0;
            rightPoint = arrayToSearch.Length - 1;

            midPoint = leftPoint + (rightPoint - leftPoint) / 2;

            if (searchInt == arrayToSearch[midPoint])
            {
                return midPoint;
            }
            else if (searchInt > arrayToSearch[midPoint])
            {
                leftPoint = midPoint + 1;

                return RecursiveChop(searchInt, arrayToSearch, leftPoint, rightPoint);
            }
            else if (searchInt < arrayToSearch[midPoint])
            {
                rightPoint = midPoint - 1;

                return RecursiveChop(searchInt, arrayToSearch, leftPoint, rightPoint);
            }

            return -1;
        }

        public static int RecursiveChop(int searchInt, int[] arrayToSearch, int left, int right)
        {
            int midPoint = new int();
            int leftPoint = new int();
            int rightPoint = new int();

            leftPoint = left;
            rightPoint = right;

            midPoint = leftPoint + (rightPoint - leftPoint) / 2;

            if (searchInt == arrayToSearch[midPoint])
            {
                return midPoint;
            }
            else if (searchInt > arrayToSearch[midPoint] && leftPoint < arrayToSearch.Length -1)
            {
                leftPoint = midPoint + 1;

                return RecursiveChop(searchInt, arrayToSearch, leftPoint, rightPoint);
            }
            else if (searchInt < arrayToSearch[midPoint] && rightPoint > 0)
            {
                rightPoint = midPoint - 1;

                return RecursiveChop(searchInt, arrayToSearch, leftPoint, rightPoint);
            }
            else
            {
                return -1;
            }
        }

        public static int IterativeChop(int searchInt, int[] arrayToSearch)
        {
            int midPoint = new int();
            int leftPoint = new int();
            int rightPoint = new int();

            leftPoint = 0;
            rightPoint = arrayToSearch.Length -1;

            while (leftPoint <= rightPoint)
            {
                midPoint = leftPoint + (rightPoint - leftPoint) / 2;

                if (searchInt == arrayToSearch[midPoint])
                    return midPoint;
                else if (searchInt > arrayToSearch[midPoint])
                {
                    leftPoint = midPoint + 1;
                    continue;
                }
                else if (searchInt < arrayToSearch[midPoint])
                {
                    rightPoint = midPoint - 1;
                    continue;
                }
            }
            return -1;
        }

    }
}

namespace ProsaicBinarySearch2
{
    //    class KataFunctionalBinarySearch
    //    {
    //        static void Main(string[] args)
    //        {
    //            //When programming in a functional style, you’re always looking for simple, repeatable 
    //            //actions that can be abstracted out into a function. We can then build more complex 
    //            //features by calling these functions in sequence (also known as “composing” functions)
    //            //— more on that in a second. In the meantime, let’s look at the steps we’d take in the 
    //            //process of transforming the initial API response to the structure required by our 
    //            //visualization library. At a basic level, we’ll perform the following actions on our data:
    //            //
    //            //•add every number in a list,
    //            //•calculate an average,
    //            //•retrieve a single property from a list of objects.

    //            //We’ll write a function for each of these three basic actions, then compose our program 
    //            //from those functions. Functional programming can be a little confusing at first, and 
    //            //you’ll probably be tempted to slip into old imperative habits. To avoid that, here are 
    //            //some simple ground rules to ensure that you’re following best practices:
    //            //
    //            //1.All of your functions must accept at least one argument.
    //            //2.All of your functions must return data or another function.
    //            //3.No loops!

    //            //int[] myArrayOfInt = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

    //            //Console.WriteLine(FunctionalChop(1, myArrayOfInt)); //0
    //            //Console.WriteLine(FunctionalChop(2, myArrayOfInt)); //1
    //            //Console.WriteLine(FunctionalChop(3, myArrayOfInt)); //2
    //            //Console.WriteLine(FunctionalChop(4, myArrayOfInt)); //3
    //            //Console.WriteLine(FunctionalChop(6, myArrayOfInt)); //5
    //            //Console.WriteLine(FunctionalChop(10, myArrayOfInt)); //9
    //            //Console.WriteLine(FunctionalChop(5, myArrayOfInt)); //4
    //            //Console.WriteLine(FunctionalChop(11, myArrayOfInt)); //-1
    //            //Console.WriteLine(FunctionalChop(8, myArrayOfInt)); //7
    //            //Console.WriteLine(FunctionalChop(9, myArrayOfInt)); //8
    //            //Console.WriteLine(FunctionalChop(-1, myArrayOfInt)); //-1

    //            //Console.ReadLine();
    //        }

    //        public static int FunctionalChop(int searchInt, int[] arrayToSearch)
    //        {
    //            int midPoint = new int();
    //            int leftPoint = new int();
    //            int rightPoint = new int();

    //            leftPoint = 0;
    //            rightPoint = SubNumber(arrayToSearch.Length, 1);

    //            midPoint = CalcMidPoint(leftPoint, rightPoint, arrayToSearch);

    //            if (searchInt == midPoint)
    //            {
    //                return midPoint;
    //            }
    //            else if (searchInt > midPoint)
    //            {
    //                return 1;
    //            }
    //            else if (searchInt < midPoint)
    //            {
    //                return 1;
    //            }
    //            else
    //            {
    //                return -1;
    //            }
    //        }

    //        public static int CalcMidPoint(int left, int right, int[] arrayToCalc)
    //        {
    //            //return left + (right - left) / 2;
    //            return DivNumber(AddNumber(left, SubNumber(right, left)), 2);
    //        }

    //        public static int AddNumber(int a, int b)
    //        {
    //            return a + b;
    //        }

    //        public static int SubNumber(int a, int b)
    //        {
    //            return a - b;
    //        }

    //        public static int DivNumber(int a, int b)
    //        {
    //            return a / b;
    //        }


    //    }
}
