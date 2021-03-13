using System.Collections.Generic;

namespace HairSalon.Models
{
  public class Client
  {
    public string Title { get; set; }
    public string Description { get; set; }
    public string Price { get; set; }
    public string Date { get; set; }
    public int Id { get; }
    private static List<Client> _instances = new List<Client> { };
  }
}