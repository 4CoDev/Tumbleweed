using Tumbleweed.Point.Spatial;

namespace DotGod.Node.Batch.Dimension.Spatial.Space.With.Points;

public sealed class One : Any
{
	public One
	(
		Any<Tumbleweed.Number.Real.Any> from,
		Any<Tumbleweed.Number.Real.Any> to
	)
	{
		A = from;
		B = to;
	}

	public Any<Tumbleweed.Number.Real.Any> A { get; }

	public Any<Tumbleweed.Number.Real.Any> B { get; }
}