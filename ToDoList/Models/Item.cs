using System.Collections.Generic; // if we need to use the list objects.

namespace ToDoList.Models
{
  public class Item
  {
    public string Description = ""; //{ get; set;} // public string Description = ""; ***this also works instead of using "get" and is much simpler logic***
    public int Id { get; }
    private static List<Item> _instances = new List<Item> {};
    public Item(string description)
    {
      Description = description;
      _instances.Add(this);
      Id = _instances.Count;
    }

    public static List<Item> GetAll()
    {
      return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

    public static Item Find(int searchId)
    {
      return _instances[searchId-1];
    }
  }
}

