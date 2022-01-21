using System;

namespace BusinessLookup.Models
{
  public class Business
  {
    public int BusinessId  { get; set; }
    public string Name { get; set; }
    public string Type { get; set; }
    public string StreetAddress { get; set; }
    public string City { get; set; }
    public string State { get; set; }
    public string ZipCode { get; set; }
  }
}