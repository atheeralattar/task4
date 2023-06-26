using ConsoleApp2;

//21. Write a C# program that implements a stack and find elements that are in the first stack but not in the second stack.
/* void ElementsInFirstStackOnly(int[] arr1, int[] arr2)
{
   var result = "";
   for (int i = 0; i < arr1.Length; i++)
   {
       if (!arr2.Contains(arr1[i]))
       {
           result = arr1[i] + " ";
       }
   }

   var checkResult = string.IsNullOrEmpty(result);
   Console.WriteLine(checkResult? "no elements found" : $"elements are: {result}");

}

var stack1 = new Stack(4);
stack1.Push(1);
stack1.Push(2);
stack1.Push(3);
stack1.Push(4);
Console.WriteLine("First Stack");
stack1.Print();

var stack2 = new Stack(4);
stack2.Push(1);
stack2.Push(2);
stack2.Push(3);
Console.WriteLine("\nSecond Stack");
stack2.Print();
ElementsInFirstStackOnly(stack1.stack, stack2.stack);
*/


//22. Write a C# program that implements a stack and creates a new stack that contains all elements from both stacks without duplicates.
/* void StackUnion(int[] arr1, int[] arr2)
{
    var arr1Length = arr1.Length;
    var arr2Length = arr2.Length;
    var unionStack = new Stack(arr1Length + arr2Length);
    var unionArray = unionStack.stack;
    
        for (int i = 0; i < arr1.Length; i++)
        {
            if (!unionArray.Contains(arr1[i]))
            {
                unionStack.Push(arr1[i]);
            }
        }
        for (int i = 0; i < arr2.Length; i++)
        {
            if (!unionArray.Contains(arr2[i]))
            {
                unionStack.Push(arr2[i]);
            }
        }
    
    unionStack.Print();
}

var stack1 = new Stack(4);
stack1.Push(1);
stack1.Push(2);
stack1.Push(3);
stack1.Push(4);
Console.WriteLine("First Stack");
stack1.Print();

var stack2 = new Stack(4);
stack2.Push(5);
stack2.Push(6);
stack2.Push(7);
stack2.Push(8);

Console.WriteLine("\nSecond Stack");
stack2.Print();
Console.WriteLine("\nStack Union:");
StackUnion(stack1.stack, stack2.stack);
*/

//23. Write a C# program that implements a stack and creates a new stack that contains only elements that are in either the first or the second stack, but not in both.
/* void NonCommonElements(int[] arr1, int[] arr2)
{
   var resultStack = new Stack(arr1.Length + arr2.Length);
   for (int i = 0; i < arr1.Length; i++)
   {
       if (!arr2.Contains(arr1[i]))
       {
           resultStack.Push(arr1[i]);
       }
   }



   for (int i = 0; i < arr2.Length; i++)
   {
       if (!arr1.Contains(arr2[i]))
       {
           resultStack.Push(arr2[i]);
       }
   }
   Console.WriteLine("\nElements in Either one of the stacks");

   resultStack.Print();
}
var stack1 = new Stack(4);
stack1.Push(1);
stack1.Push(2);
stack1.Push(3);
stack1.Push(4);
Console.WriteLine("First Stack");
stack1.Print();

var stack2 = new Stack(3);
stack2.Push(1);
stack2.Push(2);
stack2.Push(5);
Console.WriteLine("\nSecond Stack");
stack2.Print();
NonCommonElements(stack1.stack,stack2.stack);
*/

//24.Write a C# program that implements a stack and creates a new stack from a portion of the original stack.
 /* void PortionOfStack(Stack originalStack)
{
    Console.WriteLine("Stack is :");
    originalStack.Print();
    Console.WriteLine("Enter the start index");
    var start = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter the end index");
    var end = Convert.ToInt32(Console.ReadLine());
    if (start < 0 || end > originalStack.Top || start > end || end < start)
    {
        Console.WriteLine("Invalid Index");
        return;
    }

    var resultStack = new Stack(end - start + 1);
    for (int i = start; i <= end; i++)
    {
        resultStack.Push(originalStack.stack[i]);
    }

    Console.WriteLine("Portion Stack is:");
    resultStack.Print();
}
var stack = new Stack(4);
stack.Push(1);
stack.Push(2);
stack.Push(3);
stack.Push(4);
PortionOfStack(stack);
 */