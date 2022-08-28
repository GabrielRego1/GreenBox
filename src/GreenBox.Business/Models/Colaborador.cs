namespace GreenBox.Business.Models
{
    public class Colaborador : Entidade
    {
        public string Nome { get; set; }
        public bool Ativo { get; set; }
        public int Pontuacao { get; set; }
        public DateTime DataCadastro { get; set; }
    }

}
