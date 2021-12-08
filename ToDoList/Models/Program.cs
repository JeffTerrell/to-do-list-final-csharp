using System;
using System.Collections.Generic;
using ToDoList.Models;  //import namespaces from Item.cs

class ToDoListUI
{
  public static void Main()
  {
    List<Item> result = Item.GetAll(); //this is empty list

    Console.WriteLine("Welcome to the 'To Do List' (Add/View)");
    string userInput  = Console.ReadLine();
    if ( userInput == "Add")
    {
      Console.WriteLine("Please enter an item to add to the list");
      string listItem = Console.ReadLine();

      Item newItem = new Item(listItem);
      result = Item.GetAll(); 
      Console.WriteLine("Your current 'To Do List' is :");
      int listOrder = 1; 
      foreach (Item thisItem in result)
      {
      Console.WriteLine(listOrder++ + ". " + thisItem.Description);
      }

      Console.WriteLine("Would you like to add another item (Yes/No)?");
      string userInputTwo = Console.ReadLine();
      if ( userInputTwo == "Yes")
      {  
        Main();     
      }
    }
    else if ( userInput == "View")
    {  
      foreach (Item thisItem in result)
      {
      Console.WriteLine("Updated 'To Do List'" + thisItem.Description);
      }
    }
    else 
    {
      Console.WriteLine("Please Enter Add or View, Or press Control + C to exit");
      Main();
    }
  }
}
// System.Collections.Generic.List`1[ToDoList.Models.Item]




