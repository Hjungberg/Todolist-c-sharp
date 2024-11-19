using System;

List<string> toDo = new List<string>();
bool doLoop = true;

while (doLoop)
{
    ShowList(toDo);
    Console.WriteLine("");
    Console.Write("Enter todo item (Write help for commands): ");
    
    var todoItem = Console.ReadLine();

    switch (todoItem)
    {
        case "done":
            doLoop = false;
            break;
        case "sort":
            toDo.Sort();
            break;
        case "help":
            Console.Clear();
            Console.WriteLine("       Commands");
            Console.WriteLine("-------------------------");
            Console.WriteLine(" Help - Show this text.");
            Console.WriteLine(" Sort - Sort the list.");
            Console.WriteLine(" Done - Finish the list.");
            Console.WriteLine(" ------------------------");
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
            break;
        default:
            toDo.Add(todoItem);
            break;
    }
}

ShowList(toDo);
Console.WriteLine(" ------------------------");
Console.ReadKey();

static void ShowList(List<string> toDo)
{
    int i = 0;
    Console.Clear();
    Console.WriteLine("--Todo-List--");
    Console.WriteLine("-------------");
    i = 0;
    foreach (string item in toDo)
    {
        i++;
        Console.WriteLine($" {i}: {item}");
    }
}