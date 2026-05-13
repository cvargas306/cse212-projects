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
        // TODO Problem 1 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        //Step 1: Create an array of doubles with the size of 'length'
        double[] result = new double[length];
        //Step 2: Loop from 0 to length - 1 (inclusive)
        for (int i = 0; i < length; i++)
        {
            //Step 3: For each index, calculate the multiple of 'number' and store it in the array
            //Step 4: The multiple can be calculated as number * (i + 1) because we want to start with number (which is number * 1) and then go to number * 2, etc.
            result[i] = number * (i + 1);
        }
        //Step 5: Return the resulting array
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
        // TODO Problem 2 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        //Step1: Get the last 'amount' elements from the list and store them in a temporary list
        List<int> temp = data.GetRange(data.Count - amount, amount);
        //Step2: Get the first 'data.Count - amount' elements from the list and store them in another temporary list
        List<int> temp2 = data.GetRange(0, data.Count - amount);
        //Step3: Clear the original list
        data.Clear();
        //Step4: Add the elements from the temporary list (the last 'amount' elements) to the original list
        data.AddRange(temp);
        //Step5: Add the elements from the second temporary list (the first 'data.Count - amount' elements) to the original list
        data.AddRange(temp2);
    }
}
