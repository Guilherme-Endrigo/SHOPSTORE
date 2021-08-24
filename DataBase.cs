using System;
using System.Collections.Generic;

namespace projetoLoja
{
  public static class DataBase
  {
    public static List<User> Users { get; set; }
    public static List<Client> Clients { get; set; }
    public static List<Sellers> Sellers { get; set; }

    static DataBase()
    {
      Users = new List<User>();
      Sellers = new List<Sellers>();
      Clients = new List<Client>();
    }
  }
}
