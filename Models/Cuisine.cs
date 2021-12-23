using System.Collections.Generic;
using System;

namespace BestRestaurants.Models
{
  public class Cuisine
  {
    public Cuisine()
    {
      this.Restaurants = new HashSet<Restaurant>();
    }
    public int CuisineId {get; set;}
    public string Name {get; set;}
    public string Description {get; set;}

    public virtual ICollection<Restaurant> Restaurants { get; set; } 
  }
}
