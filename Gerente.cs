class Gerente:Funcionario{

  public Gerente(string n, int m, double s):base(n,m,s){
    
  }

  public override double calculaSalario(){
    return 2*salario_base;
  }

}