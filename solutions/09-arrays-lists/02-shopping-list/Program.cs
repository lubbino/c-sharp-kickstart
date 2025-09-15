// Exercise 09-02: Shopping List Manager - Reference Solution
// Create a program that manages a shopping list using List operations

using System;
using System.Collections.Generic;

Console.WriteLine("Shopping List Manager");
Console.WriteLine("====================");
Console.WriteLine("");

List<string> shoppingList = new List<string>();
int choice = 0;

while (choice != 7)
{
    // Display menu
    Console.WriteLine("Menu:");
    Console.WriteLine("1. Add item");
    Console.WriteLine("2. Remove item");
    Console.WriteLine("3. View all items");
    Console.WriteLine("4. Search for item");
    Console.WriteLine("5. Clear list");
    Console.WriteLine("6. Show statistics");
    Console.WriteLine("7. Exit");
    Console.WriteLine("");
    Console.WriteLine("Enter your choice (1-7):");
    
    if (int.TryParse(Console.ReadLine(), out choice))
    {
        Console.WriteLine("");
        
        switch (choice)
        {
            case 1:
                // Add item
                Console.WriteLine("Enter item to add:");
                string newItem = Console.ReadLine() ?? "";
                if (!string.IsNullOrWhiteSpace(newItem))
                {
                    shoppingList.Add(newItem);
                    Console.WriteLine($"Added \"{newItem}\" to the shopping list.");
                }
                else
                {
                    Console.WriteLine("Item cannot be empty.");
                }
                break;
                
            case 2:
                // Remove item
                if (shoppingList.Count > 0)
                {
                    Console.WriteLine("Enter item to remove:");
                    string itemToRemove = Console.ReadLine() ?? "";
                    if (shoppingList.Remove(itemToRemove))
                    {
                        Console.WriteLine($"Removed \"{itemToRemove}\" from the list.");
                    }
                    else
                    {
                        Console.WriteLine($"\"{itemToRemove}\" not found in the list.");
                    }
                }
                else
                {
                    Console.WriteLine("Shopping list is empty.");
                }
                break;
                
            case 3:
                // View all items
                if (shoppingList.Count > 0)
                {
                    Console.WriteLine("Shopping List:");
                    Console.WriteLine("=============");
                    for (int i = 0; i < shoppingList.Count; i++)
                    {
                        Console.WriteLine($"{i + 1}. {shoppingList[i]}");
                    }
                }
                else
                {
                    Console.WriteLine("Shopping list is empty.");
                }
                break;
                
            case 4:
                // Search for item
                Console.WriteLine("Enter item to search for:");
                string searchItem = Console.ReadLine() ?? "";
                int index = -1;
                for (int i = 0; i < shoppingList.Count; i++)
                {
                    if (shoppingList[i].ToLower() == searchItem.ToLower())
                    {
                        index = i;
                        break;
                    }
                }
                if (index >= 0)
                {
                    Console.WriteLine($"Found \"{shoppingList[index]}\" at position {index + 1}.");
                }
                else
                {
                    Console.WriteLine($"\"{searchItem}\" not found in the list.");
                }
                break;
                
            case 5:
                // Clear list
                shoppingList.Clear();
                Console.WriteLine("Shopping list cleared.");
                break;
                
            case 6:
                // Show statistics
                Console.WriteLine("List Statistics:");
                Console.WriteLine("===============");
                Console.WriteLine($"Total items: {shoppingList.Count}");
                Console.WriteLine($"List is {(shoppingList.Count == 0 ? "empty" : "not empty")}");
                if (shoppingList.Count > 0)
                {
                    Console.WriteLine($"Items: {string.Join(", ", shoppingList)}");
                }
                break;
                
            case 7:
                Console.WriteLine("Thank you for using Shopping List Manager!");
                break;
                
            default:
                Console.WriteLine("Invalid choice! Please enter 1-7.");
                break;
        }
    }
    else
    {
        Console.WriteLine("Please enter a valid number.");
    }
    
    Console.WriteLine("");
}