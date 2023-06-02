using Tumbleweed.Number.Real;
using Tumbleweed.Spatial.Point;

namespace DotGod.Spatial._Node.Batch.Spaces;

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