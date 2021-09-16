class Vendedor:Funcionario{
  private double comissao;

  public Vendedor(string n, int m, double s, double c):base(n,m,s){
    comissao = c;
  }

  public override double calculaSalario(){
    return salario_base + comissao;
  }

}