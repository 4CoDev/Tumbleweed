using Tumbleweed.Numbers.Real;
using Tumbleweed.Points.Spatial;

namespace DotGod.Nodes.BatchMaps.Spatial.Spaces;

public sealed class SpaceWithPoints : ISpace
{
	public SpaceWithPoints
	(
		IPoint<IReal> from,
		IPoint<IReal> to
	)
	{
		From = from;
		To = to;
	}

	public IPoint<IReal> From { get; }

	public IPoint<IReal> To { get; }
}