using System;

class MainClass {
  public static void Main (string[] args) {
    //INSTANCIAR CLASSE VOTAR
    Votar campanha = new Votar();
    
    //MENU CRIAR USUARIO
      string name;
      User u = new User();

      try{
        Console.Write("Insira seu nome: ");
        name = Console.ReadLine();
        u = new User(name);
      } catch(ArgumentException){
        Console.WriteLine("Você deixou o nome de usuario em branco.Tente novamente.");
      }
      
    //MENU CRIAR IDEIA
      string description, application;
      Console.WriteLine("Escreva uma breve descrição da sua ideia: ");
      description = Console.ReadLine();
      Console.WriteLine("Informe a are de aplicação da sua ideia: ");
      application = Console.ReadLine();
      Ideia i = new Ideia(u.getName(), description, application, 0);
      campanha.AdicionarIdeia(i);
    //MENU VOTAR
      for(int j = 0; j < campanha.portfolio.Count; j++){
        Console.WriteLine(campanha.portfolio[j]);
      }
    //MENU DEFINIR VENCEDOR
      //CHAMAR VENCEDORA()

  }
}