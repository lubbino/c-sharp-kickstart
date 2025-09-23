using System;
using System.Collections.Generic;
using System.Linq;

namespace InventoryManagement
{
    class InventoryItem
    {
        public string ItemId { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public string Supplier { get; set; }
        public int ReorderLevel { get; set; }
        public DateTime LastUpdated { get; set; }

        public InventoryItem(string itemId, string name, string category, int quantity, decimal price, string supplier, int reorderLevel)
        {
            ItemId = itemId;
            Name = name;
            Category = category;
            Quantity = quantity;
            Price = price;
            Supplier = supplier;
            ReorderLevel = reorderLevel;
            LastUpdated = DateTime.Now;
        }

        public decimal TotalValue => Quantity * Price;
        public bool IsLowStock => Quantity <= ReorderLevel;
    }

    class Program
    {
        static List<InventoryItem> inventory = new List<InventoryItem>();
        static string[] categories = { "Electronics", "Clothing", "Books", "Home & Garden", "Sports", "Other" };
        static Dictionary<string, List<InventoryItem>> categoryIndex = new Dictionary<string, List<InventoryItem>>();
        static int[,] monthlySales = new int[12, 6]; // 12 months, 6 categories

        static void Main(string[] args)
        {
            Console.WriteLine("=== Inventory Management System ===");
            Console.WriteLine();

            // Initialize category index
            foreach (string category in categories)
            {
                categoryIndex[category] = new List<InventoryItem>();
            }

            bool continueRunning = true;

            while (continueRunning)
            {
                DisplayMainMenu();
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AddNewItem();
                        break;

                    case "2":
                        UpdateItemQuantity();
                        break;

                    case "3":
                        SearchItems();
                        break;

                    case "4":
                        ViewItemsByCategory();
                        break;

                    case "5":
                        LowStockReport();
                        break;

                    case "6":
                        InventoryValueReport();
                        break;

                    case "7":
                        SortItems();
                        break;

                    case "8":
                        RemoveItem();
                        break;

                    case "9":
                        BulkOperations();
                        break;

                    case "10":
                        ExportInventory();
                        break;

                    case "11":
                        continueRunning = false;
                        Console.WriteLine("Thank you for using Inventory Management System!");
                        break;

                    default:
                        Console.WriteLine("Invalid option. Please choose 1-11.");
                        break;
                }

                Console.WriteLine();
            }
        }

        static void DisplayMainMenu()
        {
            int totalItems = inventory.Count;
            decimal totalValue = inventory.Sum(item => item.TotalValue);
            int lowStockCount = inventory.Count(item => item.IsLowStock);

            Console.WriteLine($"Total Items: {totalItems} | Total Value: {totalValue:C} | Low Stock Items: {lowStockCount}");
            Console.WriteLine();
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Add New Item");
            Console.WriteLine("2. Update Item Quantity");
            Console.WriteLine("3. Search Items");
            Console.WriteLine("4. View Items by Category");
            Console.WriteLine("5. Low Stock Report");
            Console.WriteLine("6. Inventory Value Report");
            Console.WriteLine("7. Sort Items");
            Console.WriteLine("8. Remove Item");
            Console.WriteLine("9. Bulk Operations");
            Console.WriteLine("10. Export Inventory");
            Console.WriteLine("11. Exit");
            Console.WriteLine();
            Console.Write("Choose an option (1-11): ");
        }

        // TODO: Implement all menu functions
        static void AddNewItem()
        {
            Console.WriteLine("Add New Item - Not implemented yet");
            // TODO: Collect item details, validate, add to inventory and category index
        }

        static void UpdateItemQuantity()
        {
            Console.WriteLine("Update Item Quantity - Not implemented yet");
            // TODO: Find item, update quantity, update last modified date
        }

        static void SearchItems()
        {
            Console.WriteLine("Search Items - Not implemented yet");
            // TODO: Implement multi-criteria search using LINQ
        }

        static void ViewItemsByCategory()
        {
            Console.WriteLine("View Items by Category - Not implemented yet");
            // TODO: Display items grouped by category
        }

        static void LowStockReport()
        {
            Console.WriteLine("Low Stock Report - Not implemented yet");
            // TODO: Find and display items below reorder level
        }

        static void InventoryValueReport()
        {
            Console.WriteLine("Inventory Value Report - Not implemented yet");
            // TODO: Calculate and display value statistics
        }

        static void SortItems()
        {
            Console.WriteLine("Sort Items - Not implemented yet");
            // TODO: Implement multiple sorting options
        }

        static void RemoveItem()
        {
            Console.WriteLine("Remove Item - Not implemented yet");
            // TODO: Find item, confirm removal, remove from all collections
        }

        static void BulkOperations()
        {
            Console.WriteLine("Bulk Operations - Not implemented yet");
            // TODO: Implement bulk add, update, or remove operations
        }

        static void ExportInventory()
        {
            Console.WriteLine("Export Inventory - Not implemented yet");
            // TODO: Format and display complete inventory report
        }

        // TODO: Add helper functions
        // static InventoryItem FindItemById(string itemId)
        // static void DisplayItem(InventoryItem item)
        // static bool IsValidItemId(string itemId)
        // static void UpdateCategoryIndex(InventoryItem item)
    }
}