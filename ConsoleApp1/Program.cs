using System;

List<string> shoppingList = new List<string>();
bool doLoop = true;

while (doLoop)
{
    ShowList(shoppingList);
    Console.WriteLine("");
    Console.Write("Enter item (Write help for commands): ");
    
    string shoppingListItem = Console.ReadLine().Trim();

    switch (shoppingListItem.ToLower())
    {
        case "done":
            doLoop = false;
            break;
        case "sort":
            shoppingList.Sort();
            break;
        case "help":
            ShowHelp();
            break;
        case "delete":
            DeleteItem(shoppingList);
            break;
        default:
            shoppingList.Add(shoppingListItem);
            break;
    }
}

ShowList(shoppingList);
Console.ReadKey();

void ShowList(List<string> shoppingList)
{
    int i = 0;
    Console.Clear();
    Console.WriteLine("-------ShoppingList-----");
    i = 0;
    foreach (string item in shoppingList)
    {
        i++;
        Console.WriteLine($" {i}: {item}");
    }
    Console.WriteLine("------------------------");
}

void DeleteItem(List<string> shoppingList)
{
    Console.Write("Enter number of item to remove: ");
    string removeItem = Console.ReadLine();
    bool isANumber = int.TryParse(removeItem, out int value);
    if (isANumber)
    {
        if ((value - 1) < shoppingList.Count() && value > 0)
        {
            shoppingList.RemoveAt(value - 1);
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
}

void ShowHelp()
{
    Console.Clear();
    Console.WriteLine("       Commands");
    Console.WriteLine("--------------------------------");
    Console.WriteLine(" Help   - Show this text.");
    Console.WriteLine(" Sort   - Sort the list.");
    Console.WriteLine(" Delete - Remove item from list.");
    Console.WriteLine(" Done   - Finish the list.");
    Console.WriteLine(" -------------------------------");
    Console.Write(" Press any key to continue.");
    Console.ReadKey();
}