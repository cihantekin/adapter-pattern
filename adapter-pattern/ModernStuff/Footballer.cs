namespace adapter_pattern.ModernStuff
{
    public record Footballer
    {
        public string Team { get; set; } 
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public Position Position { get; set; }
    }

    public enum Position
    {
        Goalkeeper,
        Defender,
        Midfielder,
        Striker
    }
}
