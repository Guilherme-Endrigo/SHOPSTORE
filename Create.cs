using System;
using System.Globalization;

namespace projetoLoja
{
  public class Create
  {
    internal static void CreateUser()
    {

      string _name = ReadName();
      string _userName = ReadUser();
      string _passaword = ReadPassaword();
      Address _address = ReadAdress();
      DateTime _dateBirth = ReadDate();
      Address _deliveryAdress = ReadAdress();
      Address _billingAddress = sameAddress(_deliveryAdress);

      User user = new User
      {
        id = DataBase.Users.Count + 1,
        name = _name,
        user = _userName,
        password = _passaword,
        birthDate = _dateBirth
      };

      DataBase.Users.Add(user);
      Menu.GeneralMenuOption();
    }

    internal static void CreateSeller()
    {
      string _name = ReadName();
      string _userName = ReadUser();
      string _passaword = ReadPassaword();
      Address _address = ReadAdress();
      DateTime _dateBirth = ReadDate();
      Address _deliveryAdress = ReadAdress();
      Address _billingAddress = sameAddress(_deliveryAdress);

      Sellers seller = new Sellers
      {
        id = DataBase.Sellers.Count + 1,
        name = _name,
        user = _userName,
        password = _passaword,
        birthDate = _dateBirth,
        seller = true
      };

      DataBase.Sellers.Add(seller);
      Menu.GeneralMenuOption();
    }


    internal static void CreateCliente()
    {
      string _name = ReadName();
      string _userName = ReadUser();
      string _passaword = ReadPassaword();
      Address _address = ReadAdress();
      DateTime _dateBirth = ReadDate();
      Address _deliveryAdress = ReadAdress();
      Address _billingAddress = sameAddress(_deliveryAdress);

      var client = new Client
      {
        id = DataBase.Clients.Count + 1,
        name = _name,
        user = _userName,
        password = _passaword,
        birthDate = _dateBirth,
        client = true
      };

      DataBase.Clients.Add(client);
      Menu.GeneralMenuOption();
    }

    private static string ReadName()
    {
      Console.WriteLine();
      Console.WriteLine("Digite o nome do usuario: ");
      return Console.ReadLine();
    }

    private static string ReadUser()
    {
      Console.WriteLine();
      Console.WriteLine("Digite o username: ");
      return Console.ReadLine();
    }

    private static string ReadPassaword()
    {
      Console.WriteLine();
      Console.WriteLine("Digite a sua senha: ");
      return Console.ReadLine();
    }

    private static DateTime ReadDate()
    {
      Console.WriteLine();
      Console.WriteLine("Digite o sua data de nascimento (dd/mm/aaaa): ");
      var entrada = Console.ReadLine();
      try
      {
        return Convert.ToDateTime(entrada, new CultureInfo("pt-BR"));
      }
      catch (System.Exception)
      {
        return ReadDate();
      }

    }

    private static Address ReadAdress()
    {
      Console.WriteLine();
      Console.WriteLine("Digite o seu endereço: ");
      var _adress = Console.ReadLine();

      Console.WriteLine();
      Console.WriteLine("Digite o seu complemento: ");
      var _complement = Console.ReadLine();

      Console.WriteLine();
      Console.WriteLine("Digite a sua cidade: ");
      var _city = Console.ReadLine();

      Console.WriteLine();
      Console.WriteLine("Digite o seu estado: ");
      var _state = Console.ReadLine();

      Console.WriteLine();
      Console.WriteLine("Digite o seu país: ");
      var _country = Console.ReadLine();

      Console.WriteLine();
      Console.WriteLine("Digite o seu numero da sua residencia: ");
      Int32.TryParse(Console.ReadLine(), out int _number);

      Console.WriteLine();
      Console.WriteLine("Digite o seu CEP de endereço: ");
      var _zip = Console.ReadLine();


      return new Address
      {
        address = _adress,
        complement = _complement,
        city = _city,
        state = _state,
        country = _country,
        number = _number,
        zipCode = _zip
      };
    }

    private static Address sameAddress(Address _deliveryAdress)
    {
      Console.WriteLine("Você gostaria de utilizar o mesmo endereço? SIM ou NÃO");
      Console.WriteLine(_deliveryAdress);
      string choice = Console.ReadLine();
      string choiceUpper = choice.ToUpper();

      switch (choiceUpper)
      {
        case "SIM":
          return _deliveryAdress;


        case "NÃO":
        case "NAO":
          return ReadAdress();

        default:
          Console.WriteLine("Opção invalida digite novamente");
          return sameAddress(_deliveryAdress);

      }
    }
  }
}




