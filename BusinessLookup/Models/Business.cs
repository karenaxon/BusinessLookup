using System.Security.AccessControl;
using System;
using System.ComponentModel.DataAnnotations;

namespace BusinessLookup.Models
{
  public class Business
  {
    public int BusinessId  { get; set; }

    [Required]
    [StringLength(255, ErrorMessage = "A business name is required.")]
    public string Name { get; set; }

    [Required]
    [StringLength(40, ErrorMessage = "A business type is required.")]
    public string Type { get; set; }

    [Required]
    [StringLength(255, ErrorMessage = "A street address is required.")]
    public string StreetAddress { get; set; }

    [Required]
    [StringLength(100, ErrorMessage = "A city is required.")]
    public string City { get; set; }

    [Required]
    [StringLength(2, ErrorMessage = "State is required. Use State abbreviations.")]
    public string State { get; set; }

    [Required]
    [StringLength(5, ErrorMessage = "Zip code is required and must be 5 digits.")]
    public string ZipCode { get; set; }
  }
}