namespace MeowsicLabzz.Components.Domain
{
    public class Albums: BaseDomainModel
    {
        public string? Title { get; set; }
        public int ArtistID { get; set; }
        public int GenreID { get; set; }
    }
}
