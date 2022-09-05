namespace conference_app.Models
{
    public class Speaker
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Title { get; set; }
        public string Company { get; set; }
        public string Image { get; set; } = "https://pbs.twimg.com/profile_images/1429238876007186437/Id4GhAeC_400x400.jpg";
    }
}
