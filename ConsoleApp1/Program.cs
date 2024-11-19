using System;

List<string> toDo = new List<string>();
bool doLoop = true;

while (doLoop)
{
    ShowList(toDo);
    Console.WriteLine("");
    Console.Write("Enter todo item (Write help for commands): ");
    
    var todoItem = Console.ReadLine().Trim();
    string removeItem = "";

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
            Console.WriteLine("--------------------------------");
            Console.WriteLine(" Help   - Show this text.");
            Console.WriteLine(" Sort   - Sort the list.");
            Console.WriteLine(" Delete - Remove item from list.");
            Console.WriteLine(" Done   - Finish the list.");
            Console.WriteLine(" -------------------------------");
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
            break;
        case "delete":
            Console.Write("Enter number of item to remove: ");
            removeItem = Console.ReadLine();
            bool isANumber = int.TryParse(removeItem, out int value);
            if (isANumber)
            {
                if ((value - 1) < toDo.Count() && value > 0)
                {
                    toDo.RemoveAt(value - 1);
                }
                else
                {
                    Console.WriteLine("Number not in list.");
                    Console.ReadKey();
                }
            } 
            else 
            {
                Console.WriteLine($"{removeItem} is not a valid number");
                Console.ReadKey();
            }
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