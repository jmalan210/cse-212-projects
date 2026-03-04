using System.Reflection.Metadata.Ecma335;
using Microsoft.VisualBasic;

public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    /// 
    


    public static double[] MultiplesOf(double number, int length)
    {
        // TODO Problem 1 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        //initialize new list
        // write a for loop that initializes 'i' to 1, and  multiplies 'number' by 'i' while i is less than or equal to length. 
        // add the result to the list
        //return the list
        //append list to array

        List<double> results = new List<double> {};
        for (var i = 1; i <= length; i++)
        {
            double multiple = number * i;
            results.Add(multiple);

          
        }
        return results.ToArray();
      

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

        //get list count
        //use GetRange(index, count) to slice the amount off the end of the list
        //assign those end values to a temp list
        //insert temp list at the beginning of the permanent list

        int length = data.Count();
        Console.Write(length);
        var tempList = data.GetRange(amount, length - amount);
        Console.Write(tempList);
        data.RemoveRange(amount, length - amount);
        data.InsertRange(0, tempList);
    }
}
