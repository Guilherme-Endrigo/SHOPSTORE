using System;
using System.Collections.Generic;

namespace projetoLoja
{
  public static class DataBase
  {
    public static List<User> Users { get; set; }

    static DataBase()
    {
      Users = new List<User>();
    }
  }
}
