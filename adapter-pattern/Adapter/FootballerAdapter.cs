using adapter_pattern.LegacyStuff;
using adapter_pattern.ModernStuff;
using System.Data;

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
            DataTable legacyFootballers = _footballerProvider.LegacyFootballerProvider();
            List<Footballer> footballers = new();

            if (legacyFootballers is not null && legacyFootballers.Rows.Count > 0)
            {
                for (var i = 0; i < legacyFootballers.Rows.Count; i++)
                {
                    var footballer = new Footballer
                    {
                        Name = legacyFootballers.Rows[i]["Name"].ToString(),
                        BirthDate = (DateTime)legacyFootballers.Rows[i]["BirthDate"],
                        Team = legacyFootballers.Rows[i]["Team"].ToString(),
                        Position = FindPosition(legacyFootballers.Rows[i]["Position"].ToString())
                    };

                    footballers.Add(footballer);
                }
            }
            

            return footballers;
        }

        private static Position FindPosition(string? position)
        {
            switch (position)
            {
                case "Goalkeeper":
                    return Position.Goalkeeper;
                case "Defender":
                    return Position.Defender;
                case "Midfielder":
                    return Position.Midfielder;
                case "Striker":
                    return Position.Striker;
                default:
                    break;
            }
            throw new NotImplementedException();
        }
    }
}
