using Tumbleweed.Mathematics.Geometry.Stereometry.Point.Generic;
using Tumbleweed.Mathematics.Geometry.Stereometry.Point.Real.Arithmetic.Negation.Of;
using Point = Tumbleweed.Mathematics.Geometry.Stereometry.Point;

namespace Tumbleweed.Mathematics.Geometry.Stereometry.Shape.Mesh.Convex.Arithmetic.Translated.Backward.Scalar.With.Point;

public sealed class Real : Envelope
{
	public Real
	(
		Any mesh,
		Any<Mathematics.Number.Real.Any> point
	) : base
  (
	  new Forward.Scalar.With.Point.Real(
		  mesh,
		  new One(point))
	)
	{
	}
}