using System.Collections.Generic;

namespace HairSalon.Models
{
  public class Stylist
  {
    private static List<Stylist> _instances = new List<Stylist> { };
    public string Name { get; set; }
    public string Description { get; set; }
    public int Id { get; }
    public List<Client> Clients { get; set; }
  }
}