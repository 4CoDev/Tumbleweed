using Tumbleweed.Point.Spatial;

namespace Tumbleweed.Geometry.Spatial.Aabb.With.Points;

public sealed class One : Any
{
	public One
	(
		Any<Tumbleweed.Number.Real.Any> a,
		Any<Tumbleweed.Number.Real.Any> b
	)
	{
		A = a;
		B = b;
	}

	public Any<Tumbleweed.Number.Real.Any> A { get; }

	public Any<Tumbleweed.Number.Real.Any> B { get; }
}