using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Create a queue with the following colors and priorities: yellow (3), red (5), green (1), orange (4), blue (2).
    //ensure that colors are removed from list from highest to lowest priority
    // Expected Result: red, orange, yellow, blue, green
    // Defect(s) Found: Dequeue was iterating for a value 1 less than the length of the list, was also not removing highest found value from the list. Was attempting to Enqueue 
    //the Dequeued value before I realized it was unnecessary. 
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
            
            Assert.AreEqual(expectedResult[i].Value, color);

        }


    }

    [TestMethod]
    // Scenario: Scenario: Create a queue with the following colors and priorities: yellow (3), red (5), green (1), orange (4), blue (2).
    //ensure that colors are removed from list from highest to lowest priority, including multiple instances of some colors.
    // Expected Result: red, red, red, red, red, orange, orange, orange, orange, yellow, yellow, yellow, blue, blue, green.
    // Defect(s) Found: incorrect order listed in test, forgot to remove Assert.Fail.
    public void TestPriorityQueue_2()
    {

        var red = new PriorityItem("red", 5);
        var orange = new PriorityItem("orange", 4);
        var yellow = new PriorityItem("yellow", 3);
        var red2 = new PriorityItem("red", 5);
        var orange2 = new PriorityItem("orange", 4);
        var yellow2 = new PriorityItem("yellow", 3);
        var blue = new PriorityItem("blue", 2);
        var green = new PriorityItem("green", 1);
        var red3 = new PriorityItem("red", 5);
        var orange3 = new PriorityItem("orange", 4);
        var yellow3 = new PriorityItem("yellow", 3);
        var red4 = new PriorityItem("red", 5);
        var blue2 = new PriorityItem("blue", 2);
        var orange4 = new PriorityItem("orange", 4);
        var red5 = new PriorityItem("red", 5);

        PriorityItem[] expectedResult = [red, red, red, red, red, orange, orange, orange, orange, yellow, yellow, yellow, blue, blue, green];

        var colors = new PriorityQueue();
        colors.Enqueue(red.Value, red.Priority);
        colors.Enqueue(orange.Value, orange.Priority);
        colors.Enqueue(yellow.Value, yellow.Priority);
        colors.Enqueue(red2.Value, red2.Priority);
        colors.Enqueue(orange2.Value, orange2.Priority);
        colors.Enqueue(yellow2.Value, yellow2.Priority);
        colors.Enqueue(blue.Value, blue.Priority);
        colors.Enqueue(green.Value, green.Priority);
        colors.Enqueue(red3.Value, red3.Priority);
        colors.Enqueue(orange3.Value, orange3.Priority);
        colors.Enqueue(yellow3.Value, yellow3.Priority);
        colors.Enqueue(red4.Value, red4.Priority);
        colors.Enqueue(blue2.Value, blue2.Priority);
        colors.Enqueue(orange4.Value, orange4.Priority);
        colors.Enqueue(red5.Value, red5.Priority);

        for (int i = 0; i < expectedResult.Length; i++)
        {
            var color = colors.Dequeue();
            
            Assert.AreEqual(expectedResult[i].Value, color);

        }


        
    }
}

    // Add more test cases as needed below.
