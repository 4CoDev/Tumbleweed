using Tumbleweed.Numerics.Fractional;
using Tumbleweed.Numerics.Spatial;

namespace TumbleGD.Nodes.BatchMaps.Spatial.Occupation;

public sealed class SpaceWithPoints : IOccupiedSpace
{
	public SpaceWithPoints
	(
		ISpatial<IFractional> from,
		ISpatial<IFractional> to
	)
	{
		From = from;
		To = to;
	}

	public ISpatial<IFractional> From { get; }

	public ISpatial<IFractional> To { get; }
}