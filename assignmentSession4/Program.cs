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
            PrintBookTitle("Clean Code");

            #endregion
        }
        #region Question04

        static void PrintBookTitle(string title)
        {
            Console.WriteLine($"Book title: {title}");
        }
        #endregion
    }
}
