using Tumbleweed.Mathematics.Vector.Spatial.Generic;

namespace Tumbleweed.Mathematics.Geometry.Stereometry.Shape.Parametric.Aabb.With.Points;

public sealed class One : Any
{
	public One
	(
		Any<Mathematics.Number.Real.Any> a,
		Any<Mathematics.Number.Real.Any> b
	)
	{
		A = a;
		B = b;
	}

	public Any<Mathematics.Number.Real.Any> A { get; }

	public Any<Mathematics.Number.Real.Any> B { get; }
}