using System.Collections;
using System.Collections.Generic;

namespace WebApplication2.Models {
  public class Goal
    {
    public string Name { get; set; }
    public string Description { get; set; }
    public IList<Investment> Investments { get; set; }
  }
}
