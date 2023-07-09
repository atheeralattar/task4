//7. Write a C# program to calculate the sum of the elements in a queue. 
/*var queue = new Queue(6);
queue.Enqueue(1);
queue.Enqueue(2);
queue.Enqueue(3);
queue.Enqueue(4);
queue.Enqueue(5);
queue.Print();
Console.WriteLine($"\nSum of the elements in the queue is: {queue.Sum()}");

Console.Write("\nRemove 2 elements from the said queue:");
queue.Dequeue();
queue.Dequeue();
queue.Print();
Console.WriteLine($"\nSum of the elements in the queue is: {queue.Sum()}");

Console.Write("\nInsert 3 more elements:");
queue.Enqueue(300);
queue.Enqueue(400);
queue.Enqueue(500);
queue.Print();
Console.WriteLine($"\nSum of the elements in the queue is: {queue.Sum()}");*/


//8. Write a C# program to compute the average value of the elements in a queue. >
var queue = new Queue(6);
queue.Enqueue(1);
queue.Enqueue(2);
queue.Enqueue(3);
queue.Enqueue(4);
queue.Enqueue(5);
queue.Print();
Console.WriteLine($"\nSum of the elements in the queue is: {queue.Average()}");

Console.Write("\nRemove 2 elements from the said queue:");
queue.Dequeue();
queue.Dequeue();
queue.Print();
Console.WriteLine($"\nSum of the elements in the queue is: {queue.Average()}");

Console.Write("\nInsert 3 more elements:");
queue.Enqueue(300);
queue.Enqueue(427);
queue.Enqueue(519);
queue.Print();
Console.WriteLine($"\nSum of the elements in the queue is: {queue.Average()}");