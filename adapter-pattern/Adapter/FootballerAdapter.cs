using adapter_pattern.LegacyStuff;
using adapter_pattern.ModernStuff;

namespace adapter_pattern.Adapter
{
    public class FootballerAdapter : ITarget
    {
        private readonly FootballerProvider _footballerProvider;

        public FootballerAdapter(FootballerProvider footballerProvider)
        {
            _footballerProvider = footballerProvider;
        }

        public IEnumerable<Footballer> Footballers()
        {
            throw new NotImplementedException();
        }
    }
}
