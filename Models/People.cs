namespace testeMVC.Models
{
    public class People
    {
        public string Nome {get; set;}
        public int Idade {get; set;}

        public People(string nome, int idade){
          this.Nome = nome;
          this.Idade = idade;
        }
    }
}