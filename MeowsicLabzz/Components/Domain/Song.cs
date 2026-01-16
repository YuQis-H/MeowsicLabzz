namespace MeowsicLabzz.Components.Domain
{
    public class Song : BaseDomainModel
    {
        public string? Title { get; set; }
        public int Duration { get; set; }
        public int ArtistId { get; set; }
        public int GenreId { get; set; }
        public int AlbumId { get; set; }
    }
}
