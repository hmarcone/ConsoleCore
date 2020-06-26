namespace GameTop
{
     public class Jogador1: IJogador
    {
        public string Nome { get; set; }

        public Jogador1(string nome = "Ronaldo") => this.Nome = nome;

        public string Chuta()
        {
            return $"{Nome} está chutando \n";
        }
        public string Corre()
        {
            return $"{Nome} está correndo \n";
        }
        public string Passe()
        {
            return $"{Nome} está passando \n";
        }
    }
}