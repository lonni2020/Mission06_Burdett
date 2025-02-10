namespace MissionSix.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string category { get; set; }
        public string title { get; set; }
        public string year { get; set; }
        public string director { get; set; }
        public string rating { get; set; }
        public bool edited { get; set; }
        public string lent { get; set; }
        public string notes { get; set; }
    }
}
