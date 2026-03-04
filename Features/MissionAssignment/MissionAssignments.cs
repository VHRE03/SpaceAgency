using SpaceAgency.Common;
using SpaceAgency.Features.Astronauts;
using SpaceAgency.Features.Missions;

namespace SpaceAgency.Features.MissionAssignments;

public class MissionAssignment : BaseEntity
{
    public Guid missionId { get; set; }
    public Mission mission { get; set; } = null;

    public Guid astronautId { get; set; }
    public Astronaut astronaut { get; set; } = null;

    public string role { get; set; } = string.Empty;
}