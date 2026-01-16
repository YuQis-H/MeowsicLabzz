using System.ComponentModel.DataAnnotations.Schema;

namespace MeowsicLabzz.Components.Domain
{
    public abstract class BaseDomainModel
    {
        public int Id { get; set; }

        [NotMapped]
        public string? CreatedAt { get; set; }

        [NotMapped]
        public string? CreatedBy { get; set; }

        [NotMapped]
        public string? UpdatedAt { get; set; }

        [NotMapped]
        public string? UpdatedBy { get; set; }
    }
}
