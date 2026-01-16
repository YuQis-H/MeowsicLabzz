namespace MeowsicLabzz.Components.Domain
{
    public class Album : BaseDomainModel
    {
        public string? Title { get; set; }
        public int ArtistId { get; set; }
        public int GenreId { get; set; }
    }
}
