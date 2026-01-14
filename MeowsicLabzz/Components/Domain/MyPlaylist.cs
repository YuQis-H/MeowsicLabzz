namespace MeowsicLabzz.Components.Domain
{
    public class MyPlaylist: BaseDomainModel
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
        public int UserID { get; set; }
    }
}
