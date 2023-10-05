using Tumbleweed.Mathematics.Geometry.Stereometry.Shape.Parametric.Aabb.Octant.At.Index.Point;
using Tumbleweed.Mathematics.Vector.Spatial.Generic;

namespace Tumbleweed.Mathematics.Geometry.Stereometry.Shape.Parametric.Aabb.Octant.At.Index;

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