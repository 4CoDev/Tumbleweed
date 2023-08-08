using Tumbleweed.Point.Spatial;

namespace DotGod.Node.Spatial.Batch.Space;

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