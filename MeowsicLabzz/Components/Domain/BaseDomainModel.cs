namespace MeowsicLabzz.Components.Domain
{
    public abstract class BaseDomainModel
    {
        public int Id { get; set; } 
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string? Createdby { get; set; }
        public string? UpdatedBy { get; set; }
    }
}
