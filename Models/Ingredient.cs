using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BdEntityFramework.Models
{
    public class Ingredient
    {
      [Key]
      [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
      public int Id { get; set; }
      public int MyProperty { get; set; }
      public decimal Quantity { get; set; }
      public string Name { get; set; }
      public IEnumerable<Menu> Menues { get; set; }
    }
}