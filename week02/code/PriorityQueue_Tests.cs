using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Create a queue with the following colors and priorities: yellow (3), red (5), green (1), orange (4), blue (2).
    //ensure that colors are removed from list from highest to lowest priority
    // Expected Result: red, orange, yellow, blue, green
    // Defect(s) Found: Dequeue method was iterating for a value 1 less than the length of the list, was also not removing highest found value from the list.
    public void TestPriorityQueue_1()
    {
        var red = new PriorityItem("red", 5);
        var orange = new PriorityItem("orange", 4);
        var yellow = new PriorityItem("yellow", 3);
        var blue = new PriorityItem("blue", 2);
        var green = new PriorityItem("green", 1);

        PriorityItem[] expectedResult = [red, orange, yellow, blue, green];

        var colors = new PriorityQueue();
        colors.Enqueue(yellow.Value, yellow.Priority);
        colors.Enqueue(red.Value, red.Priority);
        colors.Enqueue(green.Value, green.Priority);
        colors.Enqueue(orange.Value, orange.Priority);
        colors.Enqueue(blue.Value, blue.Priority);



        for (int i = 0; i < expectedResult.Length; i++)
        {
            var color = colors.Dequeue();
            Console.WriteLine(color);
            Assert.AreEqual(expectedResult[i].Value, color);

        }
        


        // Assert.Fail("Implement the test case and then remove this.");
    }

    [TestMethod]
    // Scenario: 
    // Expected Result: 
    // Defect(s) Found: 
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();
        Assert.Fail("Implement the test case and then remove this.");
    }

    // Add more test cases as needed below.
}