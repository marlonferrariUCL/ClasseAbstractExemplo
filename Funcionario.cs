abstract class Funcionario {

  private string nome;
  public string getNome(){
    return nome;
  }
  private int matricula;
  protected double salario_base;

  public Funcionario (string n, int m, double s){
    nome = n;
    matricula = m;
    salario_base = s;
  }

  public abstract double calculaSalario();

}