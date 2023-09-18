using Tumbleweed.Point.Spatial.Generic;

namespace Tumbleweed.Geometry.Spatial.Shape.Parametric.Aabb.With.Points;

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