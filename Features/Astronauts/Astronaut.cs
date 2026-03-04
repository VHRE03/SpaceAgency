using SpaceAgency.Common;
using SpaceAgency.Features.MissionAssignments;

namespace SpaceAgency.Features.Astronauts;

public class Astronaut : BaseEntity
{
    public string Name { get; set; } = string.Empty;
    public string Nationality { get; set; } = string.Empty;

    public List<MissionAssignment> MissionHistory { get; set; } = new();
}