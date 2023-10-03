// create arrays of doubles and int 

double[] doubleElements = { 1.1, 2.2, 3.3, 4.4, 5.5, 6.6};

int[] inteLEMENTS = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11};

StackTest.Stack<double> doubleStack = new (); // Stack storees doubles
StackTest.Stack<int> intStack = new(10); // Stack of ints

TestPushDouble();// push double onto doubleStack

//test push method withdoubleStack
void TestPushDouble()
{
    try
    {
        Console.WriteLine("\nPushing elements onto doubleStack");

        foreach (var element in doubleElements)
        {
            Console.Write($"{element: F1}");
            doubleStack.Push(element);
        }
    }
    catch(FullStackException exception )
    {
        Console.Error.WriteLine(exception.Message);
        Console.Error.WriteLine(exception.StackTrace);
    }
   
}
