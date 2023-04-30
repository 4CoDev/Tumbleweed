using Tumbleweed.Numbers.Real;
using Tumbleweed.Numbers.Spatial;

namespace DotGod.Nodes.BatchMaps.Spatial.Occupation;

public sealed class SpaceWithPoints : IOccupiedSpace
{
	public SpaceWithPoints
	(
		ISpatial<IReal> from,
		ISpatial<IReal> to
	)
	{
		From = from;
		To = to;
	}

	public ISpatial<IReal> From { get; }

	public ISpatial<IReal> To { get; }
}