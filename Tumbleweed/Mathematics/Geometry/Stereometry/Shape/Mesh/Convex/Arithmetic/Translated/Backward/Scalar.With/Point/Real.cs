using Tumbleweed.Mathematics.Arithmetic.Vector.Spatial.Real.Negation.Of;
using Tumbleweed.Mathematics.Vector.Spatial.Generic;


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