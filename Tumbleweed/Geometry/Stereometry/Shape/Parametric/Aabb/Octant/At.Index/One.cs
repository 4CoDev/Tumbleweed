using Tumbleweed.Geometry.Stereometry.Shape.Parametric.Aabb.Octant.At.Index.Point;
using Tumbleweed.Point.Spatial.Generic;

namespace Tumbleweed.Geometry.Stereometry.Shape.Parametric.Aabb.Octant.At.Index;

public sealed class One : Envelope
{
	public One
	(
		Any space,
		Any<Mathematics.Number.Natural.Any> index) : base
	(
		new With.Points.One(
			new A(space, index),
			new B(space, index))
	)
	{
	}
}