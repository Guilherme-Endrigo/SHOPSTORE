using System;

namespace projetoLoja
{
  public class User : ICliente, ISeller
  {
    public int id { get; set; }
    public string name { get; set; }
    public string user { get; set; }
    public string password { get; set; }
    public DateTime birthDate { get; set; }
    public Address deliveryAddress { get; set; }
    public Address billingAddress { get; set; }
    public bool client { get; set; } = false;
    public bool seller { get; set; } = false;

  }
}