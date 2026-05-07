public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {
       //plan:
       //1. create a new double array with the size of length.
       //3. For each index, multiply number by index + 1
       //4. Store that calue in the array.
       //5. return the finished array.

       double[] result = new double[length];

       for (int i = 0; i < length; i++)
        {
            result[i] = number * (i + 1);
        }

        return result;
    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        // Plan:
        // 1. Find the index where the rotated list should start.
        // 2. Copy the values from that index to the end of the list.
        // 3. Copy the values from the beginning of the list up to that index.
        // 4. Clear the original list.
        // 5. Add the copied values back into the original list in rotated order.

        int splitPoint = data.Count -amount;

        List<int> rotated = new List<int>();

        rotated.AddRange(data.GetRange(splitPoint, amount));
        rotated.AddRange(data.GetRange(0, splitPoint));

        data.Clear();
        data.AddRange(rotated);
    }
}
