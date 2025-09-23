# Inventory Management System Project

## Overview
This project demonstrates advanced arrays and lists concepts by creating a comprehensive inventory management system. Students will learn about multi-dimensional arrays, complex data structures, sorting, searching, and data persistence concepts.

## Learning Objectives
- Practice advanced collection operations
- Work with multi-dimensional arrays and jagged arrays
- Learn sorting and searching algorithms
- Understand data relationships and references
- Practice LINQ for complex queries
- Work with data validation and business logic

## Requirements
Create a program that:

1. **Manages inventory items** with properties:
   - Item ID (unique)
   - Name
   - Category
   - Quantity in stock
   - Price
   - Supplier information
   - Reorder level
   - Last updated date

2. **Provides comprehensive functionality**:
   - 1. Add New Item
   - 2. Update Item Quantity
   - 3. Search Items
   - 4. View Items by Category
   - 5. Low Stock Report
   - 6. Inventory Value Report
   - 7. Sort Items
   - 8. Remove Item
   - 9. Bulk Operations
   - 10. Export Inventory
   - 11. Exit

3. **Implements advanced features**:
   - Multi-criteria searching
   - Sorting by different fields
   - Category-based organization
   - Stock level monitoring
   - Value calculations
   - Bulk import/export simulation

4. **Uses various collection types**:
   - Arrays for fixed categories
   - Lists for dynamic inventory
   - Dictionaries for fast lookups
   - Multi-dimensional arrays for reports

## Sample Output
```
=== Inventory Management System ===

Total Items: 15 | Total Value: $12,450.00 | Low Stock Items: 3

Menu:
1. Add New Item
2. Update Item Quantity
3. Search Items
4. View Items by Category
5. Low Stock Report
6. Inventory Value Report
7. Sort Items
8. Remove Item
9. Bulk Operations
10. Export Inventory
11. Exit

Choose an option (1-11): 1

=== Add New Item ===
Enter Item ID: ELEC001
Enter Item Name: Wireless Mouse
Available Categories:
1. Electronics    2. Clothing    3. Books
4. Home & Garden  5. Sports      6. Other

Select category (1-6): 1
Enter quantity: 50
Enter price: $25.99
Enter supplier: TechSupply Co.
Enter reorder level: 10

Item 'Wireless Mouse' added successfully!

Choose an option (1-11): 5

=== Low Stock Report ===
Items below reorder level:

ID: BOOK003 | Name: Programming Guide | Stock: 5 | Reorder: 10
ID: CLOTH002 | Name: T-Shirt Blue | Stock: 8 | Reorder: 15
ID: ELEC005 | Name: USB Cable | Stock: 3 | Reorder: 20

Total low stock items: 3
Recommended action: Place orders for these items

Choose an option (1-11): 7

=== Sort Items ===
Sort by:
1. Name (A-Z)
2. Name (Z-A)
3. Price (Low to High)
4. Price (High to Low)
5. Quantity (Low to High)
6. Quantity (High to Low)
7. Category

Select sort option (1-7): 3

Items sorted by Price (Low to High):
ID: BOOK001 | Programming Basics | $12.99 | Qty: 25
ID: CLOTH001 | Cotton Socks | $8.50 | Qty: 100
ID: ELEC001 | Wireless Mouse | $25.99 | Qty: 50
...

Choose an option (1-11): 11

Thank you for using Inventory Management System!
```

## Data Structures

### Item Class
```csharp
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
    
    public decimal TotalValue => Quantity * Price;
    public bool IsLowStock => Quantity <= ReorderLevel;
}
```

### Collections Used
```csharp
List<InventoryItem> inventory = new List<InventoryItem>();
string[] categories = { "Electronics", "Clothing", "Books", "Home & Garden", "Sports", "Other" };
Dictionary<string, List<InventoryItem>> categoryIndex = new Dictionary<string, List<InventoryItem>>();
int[,] monthlySales = new int[12, 6]; // 12 months, 6 categories
```

## Key Features

### Item Management
- Add items with full validation
- Update quantities with transaction logging
- Remove items with confirmation
- Bulk operations for multiple items

### Search and Filter
- Search by ID, name, or supplier
- Filter by category, price range, stock level
- Multi-criteria search combinations
- Advanced LINQ queries

### Reporting and Analysis
- Low stock alerts and reports
- Inventory value calculations
- Category-wise analysis
- Sales trend simulation (using 2D arrays)

### Data Organization
- Sort by multiple criteria
- Category-based grouping
- Custom sorting algorithms
- Data export formatting

## Advanced Concepts

### Multi-dimensional Arrays
```csharp
// Sales data: [month][category]
int[,] monthlySales = new int[12, 6];

// Access: monthlySales[month, category]
monthlySales[0, 1] = 150; // January, Electronics
```

### LINQ Operations
```csharp
// Complex queries
var lowStockElectronics = inventory
    .Where(item => item.Category == "Electronics" && item.IsLowStock)
    .OrderBy(item => item.Quantity)
    .ToList();

var categoryTotals = inventory
    .GroupBy(item => item.Category)
    .Select(group => new { 
        Category = group.Key, 
        TotalValue = group.Sum(item => item.TotalValue) 
    });
```

### Dictionary for Fast Lookups
```csharp
Dictionary<string, InventoryItem> itemLookup = inventory.ToDictionary(item => item.ItemId);
```

## Tips
- Use appropriate collection types for different needs
- Implement proper validation for all inputs
- Consider performance for large datasets
- Use LINQ for complex data operations
- Handle edge cases (empty inventory, duplicate IDs)
- Implement proper error handling

## Challenge Extensions
- Add barcode scanning simulation
- Implement purchase order generation
- Add supplier management with ratings
- Create inventory forecasting
- Add multi-location inventory tracking
- Implement audit trail for all changes
- Add data import/export from CSV
- Create dashboard with visual charts (ASCII art)
- Add inventory optimization suggestions