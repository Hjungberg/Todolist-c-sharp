using System;

List<string> toDo = new List<string>();

while (true)
{
    Console.Clear();
    Console.WriteLine("--Todo-List--");
    Console.WriteLine("-------------");
    foreach (string item in toDo) {
        Console.WriteLine(item);
    }
    Console.Write("Enter todo item (Write DONE to quit): ");
    
    var todoItem = Console.ReadLine();

    if (todoItem == "DONE")
    {
        break;
    }

    if (todoItem == "SORT")
    {
        toDo.Sort();
    }
    else
    {
        toDo.Add(todoItem);
    }
}
Console.Clear();
Console.WriteLine("--Todo-List--");
Console.WriteLine("-------------");
int i = 0;
foreach (string item in toDo)
{
    i++;
    Console.Write(i + ": ");
    Console.WriteLine(item);
}
Console.ReadKey();

