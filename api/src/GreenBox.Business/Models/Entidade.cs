namespace GreenBox.Business.Models
{
    public abstract class Entidade
    {
        public Guid Id { get; set; }
        public Entidade()
        {
            Id = new Guid();
        }
    }
}
