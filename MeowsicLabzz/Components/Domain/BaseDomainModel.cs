namespace MeowsicLabzz.Components.Domain
{
    public abstract class BaseDomainModel
    {
        // Primary key for all domain entities
        public int Id { get; set; }
    }

    public class Mood : BaseDomainModel
    {
        public string? Name { get; set; }
    }

    public class Genre : BaseDomainModel
    {
        public string? Name { get; set; }
    }

    public class Artist : BaseDomainModel
    {
        public string? Name { get; set; }
    }

    public class Song : BaseDomainModel
    {
        public string? Title { get; set; }
        public int ArtistId { get; set; }
        public int GenreId { get; set; }
        public int AlbumId { get; set; }
    }

    public class Album : BaseDomainModel
    {
        public string? Title { get; set; }
        public int ArtistId { get; set; }
    }
}
