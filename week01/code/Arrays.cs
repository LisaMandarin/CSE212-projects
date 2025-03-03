using System.Runtime.Intrinsics.X86;

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

        // my code - begin
        // Step 1: Create an array to store the multiples.
        // The array needs to have 'length' number of elements.
        var result = new double[length];

        // Step 2: Populate the array with multiples of the given number.
        // The first element should be 'number' (1 * number)
        // The second element should be '2 * number'.
        // The third element should be '3 * number' and so on.
        for (int i = 0; i < length; ++i) {
            result[i] = number * (i+1); // replace this return statement with your own
        } 

        // Step 3: Return the populated array
        return result;
        // my code - end
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
        
        // my code - begin
        // Step1: Look 'amount' times to ratate the list to the right by one position each time.
        for (var i = 0; i < amount; i++) 
        {
        // Step 2: Store the last element of the list (this will be moved to the front).
            var lastElement = data[data.Count-1];
        // Step 3: Remove the last element from the list.
            data.RemoveAt(data.Count-1);
        // Step 4: Insert the stored last element at the beginning of the list.
            data.Insert(0, lastElement);
        }
        // my code - end
    }
}
