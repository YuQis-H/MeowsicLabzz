namespace MeowsicLabzz.Components.Domain
{
    public class Songs: BaseDomainModel
    {

        public string? Title  { get; set; }
        public int? Duration { get; set; }
        public int ArtistID { get; set; }
        public int AlbumsID { get; set; }

    }
}
