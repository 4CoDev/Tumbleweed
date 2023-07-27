using Tumbleweed.Number.Real;
using Tumbleweed.Point.Spatial;

namespace DotGod.Spatial._Node.Batch.Space;

public sealed class SpaceWithPoints : ISpace
{
	public SpaceWithPoints
	(
		Any<Tumbleweed.Number.Real.Any> from,
		Any<Tumbleweed.Number.Real.Any> to
	)
	{
		From = from;
		To = to;
	}

	public Any<Tumbleweed.Number.Real.Any> From { get; }

	public Any<Tumbleweed.Number.Real.Any> To { get; }
}