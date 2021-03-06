using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System;

namespace BestRestaurant.Models
{
  public class Cuisine
  {
    public Cuisine()
    {
      this.Restaurants = new HashSet<Restaurant>();
    }

    public int CuisineId { get; set; }
    public string Name { get; set; }
    public virtual ICollection<Restaurant> Restaurants { get; set; } 
  }  

  public enum CuisineList
  {
    Chinese = 1,
    Japanese = 2,
    Mexican = 3,
    Italian = 4,
    American = 5
  }
}
