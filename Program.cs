// See https://aka.ms/new-console-template for more information


using CostumQueue;
using static System.Net.Mime.MediaTypeNames;



MyQueue<int> queue = new MyQueue<int>();

Console.Write("check if queue is empty: ");
bool res1 = queue.IsEmpty();
Console.WriteLine(res1);


queue.Enqueue(10);
queue.Enqueue(30);
queue.Enqueue(50);
queue.Enqueue(70);

Console.Write("check if queue is empty after add elements: ");
bool res= queue.IsEmpty();

Console.WriteLine(res);


Console.Write("Queue size is : ");
int? queueSize = queue.Size();
Console.WriteLine(queueSize);



Console.WriteLine("Deleted elements are : ");

int delEl=queue.Dequeue();
Console.WriteLine(delEl);

int delEl2=queue.Dequeue();
Console.WriteLine(delEl2);

int delEl3=queue.Dequeue();
Console.WriteLine(delEl3);



