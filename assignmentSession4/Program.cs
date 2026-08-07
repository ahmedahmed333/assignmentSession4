using System.Diagnostics;

namespace assignmentSession4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question01 
            //double[] numbers = { 25.5, 40.0, 33.75 };
            //Console.WriteLine(numbers[1]); // 40
            #endregion
            #region Question02
            //int[,] newArr =
            //{
            //    {3,5 },
            //    {1,4 }
            //};
            //Console.WriteLine(newArr[1, 0]); // 1
            #endregion
            #region Question04
            //PrintBookTitle("Clean Code");

            #endregion
            #region Question05
            //int pages = 400;
            //AddBonusPages(pages);

            //Console.WriteLine(pages); //I expect to see 400 because int is a value type, so the method receives a copy of the value.
            //                          //The original pages variable remains unchanged.

            #endregion
            #region Question06

            //double[] prices = { 25.5, 40.0 };

            //ApplyDiscount(prices);

            //Console.WriteLine(prices[0]); // answer : 20.5 
            //                              // Because double[] is a reference type, so the method modifies the same array,
            // and the change to prices[0] is visible in Main.
            #endregion

            #region Question07
            //int pages = 400;
            //AddBonusPages(ref pages);

            //Console.WriteLine(pages); // In question 5, the result was 400 because the method received a copy of the value.
            //                          // With ref, the method modifies the original variable, so the result is 450.
            #endregion

            #region Question08

            double[] prices = { 25.5, 40.0 };
            ReplaceArray(ref prices);


            Console.WriteLine(prices.Length); // 3

            #endregion

        }
        #region Question04

        //static void PrintBookTitle(string title)
        //{
        //    Console.WriteLine($"Book title: {title}");
        //}
        #endregion
        #region Question05
        //static void AddBonusPages(int pages)
        //{
        //    pages = pages + 50;
        //}
        #endregion
        #region Question06
        //static void ApplyDiscount(double[] prices)
        //{
        //    prices[0] = prices[0] - 5;
        //}
        #endregion
        #region Question06
        static void ApplyDiscount(double[] prices)
        {
            prices[0] = prices[0] - 5;
        }
        #endregion
        #region Question07
        //static void AddBonusPages(ref int pages)
        //{
        //    pages = pages + 50;
        //}
        #endregion
        #region Question08
        static void ReplaceArray(ref double[] prices)
        {
            prices = new double[] { 10.0, 12.5, 15.0 };
        }
        #endregion
    }
}
