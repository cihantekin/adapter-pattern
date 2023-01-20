namespace adapter_pattern.ModernStuff
{
    public record Footballer
    {
        public string Team { get; set; } = new("");
        public string Name { get; set; } = new("");
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
