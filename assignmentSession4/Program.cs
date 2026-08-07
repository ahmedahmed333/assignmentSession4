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

            double[] prices = { 25.5, 40.0 };

            ApplyDiscount(prices);

            Console.WriteLine(prices[0]); // answer : 20.5 
                                          // Because double[] is a reference type, so the method modifies the same array,
                                          // and the change to prices[0] is visible in Main.
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
        static void ApplyDiscount(double[] prices)
        {
            prices[0] = prices[0] - 5;
        }
        #endregion
    }
}
