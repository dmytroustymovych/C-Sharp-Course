internal class Program
{
    private static void Main(string[] args)
    {
        int[] IntList = new int[] { 5, 2, 10, 23, 65, 1, 15 };
        int TotalNum = 0;

        for (int i = 0; i < IntList.Length; i++)
        {
            TotalNum += IntList[i];
            Console.WriteLine(TotalNum);
        }

        TotalNum = 0;

        DateTime startTime = DateTime.Now;

        foreach (int IntCompressedList in IntList)
        {
            TotalNum += IntCompressedList;
            Console.WriteLine(TotalNum);
        }

        Console.WriteLine((DateTime.Now - startTime).TotalSeconds);

        int index = 0;
        TotalNum = 0;

        while (index < IntList.Length)
        {
            Console.WriteLine(index);
            Console.WriteLine(index < IntList.Length);
            TotalNum += IntList[index];
            Console.WriteLine(TotalNum);
            index++;
        }

        TotalNum = 0;
        index = 0;

        do
        {

            Console.WriteLine(index);
            Console.WriteLine(index < IntList.Length);
            TotalNum += IntList[index];
            Console.WriteLine(TotalNum);
            index++;

        }
        while (index < IntList.Length);

        int[] IntList2 = new int[] { 23, 56, 12, 15, 87, 35, 2, 4, 1 };
        TotalNum = GetSum(IntList2);
        Console.WriteLine("The total sum of " + IntList2 + " is: " + TotalNum);
    }

        public static int GetSum(int[] IntArr)
        {
            int TotalNum = 0;
            int index = 0;
            while (index < IntArr.Length)
            {
                TotalNum += IntArr[index];
                index++;
            }
            return TotalNum;
        }

}
