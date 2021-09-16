using System;

class Program {
  public static void Main (string[] args) {
    Funcionario joao = new Gerente("João",123,4000.98);
    Assistente joana = new Assistente("Joana",456,11000);
    Vendedor juca = new Vendedor("Juca",987,1500.99, 900);
    //FOLHA DE PGTO
    FolhaPagamento calend2021 = new FolhaPagamento();
    calend2021.FuncAtivos.Add(joao);
    calend2021.FuncAtivos.Add(joana);
    calend2021.FuncAtivos.Add(juca);

    for(int x=0;x<calend2021.FuncAtivos.Count;x++){
      Console.WriteLine(calend2021.FuncAtivos[x].getNome());
    }

    foreach (Funcionario x in calend2021.FuncAtivos){
      Console.WriteLine(x.getNome());
    }
    
    
  }
}