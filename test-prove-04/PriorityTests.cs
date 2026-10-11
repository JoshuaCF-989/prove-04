using NUnit.Framework;
using prove_04;

public class PriorityTests
{
    [Test]
    public void TestPriority1()
    {
        // TODO Problem 2 - Write and run test cases and fix the code to match requirements
        // Test 1
        // Scenario: The Enqueue function adds an item to the back of the queue
        // Expected Result: "Seven (Pri:7)", "Six (Pri:6)", "Eight (Pri:8)"

        var priorityQueue = new PriorityQueue(); // Example of creating and using the priority queue
        priorityQueue.Enqueue("Seven",7);
        priorityQueue.Enqueue("Six",6);
        priorityQueue.Enqueue("Eight",8);
        
        Console.WriteLine(priorityQueue);
        Assert.That(priorityQueue.ToString(), Is.EqualTo("[Seven (Pri:7), Six (Pri:6), Eight (Pri:8)]"));
        // Make sure you use Assert.That(<whatever>, Is.EqualTo(<expected value>));

        // Defect(s) Found: Pass
    }

    [Test]
    public void TestPriority2()
    {
        // Test 2
        // Scenario: The Dequeue function removes and returns the value with the highest value
        // Expected Result: 
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Seven",7);
        priorityQueue.Enqueue("Six",6);
        priorityQueue.Enqueue("Eight",8);

        var highestPriority = priorityQueue.Dequeue();
        Console.WriteLine(priorityQueue.ToString());
        Console.WriteLine(highestPriority);
        Assert.That(highestPriority, Is.EqualTo("Eight"));
        Assert.That(priorityQueue.ToString(), Is.EqualTo("[Seven (Pri:7), Six (Pri:6)]"));
        // Defect(s) Found: Doesn't remove the value and doesn't return the one with highest priority
    }

    // TODO Add more test cases as needed to test all of the requirements and find all the bugs
    
    [Test]
    public void TestPriority3()
    {
        // Test 3
        // Scenario: More than one of the same priority
        // Expected Result: 
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Seven",7);
        priorityQueue.Enqueue("Six",8);
        priorityQueue.Enqueue("Eight",8);

        var highestPriority = priorityQueue.Dequeue();
        Console.WriteLine(priorityQueue.ToString());
        Console.WriteLine(highestPriority);
        Assert.That(highestPriority, Is.EqualTo("Six"));
        Assert.That(priorityQueue.ToString(), Is.EqualTo("[Seven (Pri:7), Eight (Pri:8)]"));
        // Defect(s) Found: Doesn't remove the value
    }
    
    [Test]
    public void TestPriority4()
    {
        // Test 4
        // Scenario: Queue is empty
        // Expected Result: You should have had an exception
        var priorityQueue = new PriorityQueue();
        try
        {
            priorityQueue.Dequeue();
            Assert.Fail("The code should fail with an exception");
        }
        catch (InvalidOperationException)
        {
            Assert.Pass("You should have had an exception");
        }
        // Make sure you use Assert.That(<whatever>, Is.EqualTo(<expected value>));

        // Defect(s) Found: no Exception
    }
}