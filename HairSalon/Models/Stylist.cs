using System.Collections.Generic;

namespace HairSalon.Models
{
  public class Stylist
  {
    private static List<Stylist> _instances = new List<Stylist> { };
    public int StylistId { get; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public List<Client> Clients { get; set; }
  }
}