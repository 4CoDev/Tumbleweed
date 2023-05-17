using Tumbleweed.Numbers.Real;
using Tumbleweed.Points.Spatial;

namespace DotGod.Nodes.BatchMaps.Spatial.Spaces;

public sealed class SpaceWithPoints : ISpace
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