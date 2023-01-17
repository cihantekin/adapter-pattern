using adapter_pattern.ModernStuff;

namespace adapter_pattern.Adapter
{
    public interface ITarget
    {
        IEnumerable<Footballer> Footballers();
    }
}
