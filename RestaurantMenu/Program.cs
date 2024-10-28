using System;
using System.Collections.Generic;

public class MenuItem
{
    public string Name { get; }
    public decimal Price { get; }
    public string Description { get; }
    public string Category { get; }
    public bool IsNew { get; }
    private DateTime DateAdded { get; }

    public MenuItem(string name, decimal price, string description, string category, bool isNew)
    {
        Name = name;
        Price = price;
        Description = description;
        Category = category;
        IsNew = isNew;
        DateAdded = DateTime.Now;
    }
}

public class Menu
{
    private List<MenuItem> Items { get; set; }
    private DateTime LastUpdated { get; set; }

    public Menu()
    {
        Items = new List<MenuItem>();
        LastUpdated = DateTime.Now;
    }

    public Menu(List<MenuItem> items)
    {
        Items = items;
        LastUpdated = DateTime.Now;
    }

    public void AddMenuItem(MenuItem item)
    {
        Items.Add(item);
        LastUpdated = DateTime.Now;
    }

    public void UpdateMenuItem(int index, MenuItem updatedItem)
    {
        if (index >= 0 && index < Items.Count)
        {
            Items[index] = updatedItem;
            LastUpdated = DateTime.Now;
        }
    }

    public void DisplayMenu()
    {
        Console.WriteLine($"Menu (Last Updated: {LastUpdated})");
        foreach (var item in Items)
        {
            Console.WriteLine($"Name: {item.Name}, Price: {item.Price:C}, Description: {item.Description}, Category: {item.Category}, New: {item.IsNew}");
        }
    }
}

public class Program
{
    public static void Main()
    {
        Menu menu = new Menu();

        menu.AddMenuItem(new MenuItem("Mozzarella Sticks", 8.99m, "Crispy mozzarella cheese sticks served with marinara sauce.", "Appetizer", true));
        menu.AddMenuItem(new MenuItem("Buffalo Wings", 12.49m, "Spicy chicken wings served with blue cheese dressing.", "Main Course", false));
        menu.AddMenuItem(new MenuItem("Loaded Nachos", 10.99m, "Tortilla chips topped with cheese, jalapeños, and guacamole.", "Appetizer", true));
        menu.AddMenuItem(new MenuItem("Sliders", 11.99m, "Mini burgers served with pickles and a side of fries.", "Main Course", false));
        menu.AddMenuItem(new MenuItem("Chocolate Lava Cake", 6.99m, "Warm chocolate cake with a molten center, served with vanilla ice cream.", "Dessert", true));

        menu.DisplayMenu();
    }
}
