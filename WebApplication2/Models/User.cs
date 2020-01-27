using System;
using System.Collections.Generic;

namespace WebApplication2.Models {
  public class User
    {
      public string Username { get; set; }
      public string Password{ get; set; }
      public DateTime Birthday { get; set; }
      public string Email { get; set; }
      public Wallet Wallet { get; set; }
  }
}
