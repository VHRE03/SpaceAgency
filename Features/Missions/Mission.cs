using SpaceAgency.Features.Astronauts;

namespace SpaceAgency.Features.Missions
{
    public sealed class Mission
    {
        public Guid id { get; private set; }
        public string name { get; private set; }
        private readonly List<Astronaut> _crew = new();

    }
}
