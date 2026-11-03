public static class ArraySelector
{
    public static void Run()
    {
        var l1 = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
        var l2 = new[] { 2, 4, 6, 8, 10, 12, 14, 16, 18, 20};
        var select = new[] { 1, 1, 1, 2, 2, 1, 2, 2, 2, 1, 1, 2, 2, 2, 1, 1, 2, 2};
        var intResult = ListSelector(l1, l2, select);
        Console.WriteLine("<int[]>{" + string.Join(", ", intResult) + "}"); // <int[]>{1, 2, 3, 2, 4, 4, 6, 8, 10, 5}
    }

    private static int[] ListSelector(int[] list1, int[] list2, int[] select)
    {
        int ones = 0;
        int twos = 0;
        var numbers = new int[select.Length];

        for (int num = 0; num < select.Count(); num++)
        {
            if (select[num] == 1)
            {
                ones += 1;
                numbers[num] = list1[ones - 1];
            } else
            {
                twos += 1;
                numbers[num] = list2[twos - 1];
            }
        }

        return numbers;
    }
}