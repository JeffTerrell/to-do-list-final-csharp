namespace ToDoList.Models
{
  public class Item
  {
    public string Description { get; set;} // public string Description = ""; ***this also works instead of using "get" and is much simpler logic***
    public Item(string description)
    {
      Description = description;
    }
  }
}

