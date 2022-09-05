using CommunityToolkit.Mvvm.ComponentModel;

namespace conference_app.Models
{
    public partial class Session : ObservableObject
    {
        // # static
        public int Id { get; set; }
        public string Title { get; set; }
        public string Room { get; set; }
        public string Description { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public string StartTimeDisplay => $"{Start:t}";
        public string DateDisplay => $"{Start:MMM} {Start:d}";
        public Speaker Speaker { get; set; } = new Speaker
        {
            Name = "Patrick Mahomes",
            Company = "Kansas City Chiefs",
            Description = "The only GOAT contender",
            Title = "Ketchup's Revenge"
        };

        // # dynamic
        [ObservableProperty]
        bool inAgenda;
    }
}
