namespace LP10.Doadores.Domain.Entities
{
    public abstract class Entity
    {
        public Guid Id { get; set; }
        public DateTime Logg { get; set; }
    }
}
