class Assistente:Funcionario{

  public Assistente(string n, int m, double s):base(n,m,s){
    
  }

  public override double calculaSalario(){
    return salario_base;
  }

}