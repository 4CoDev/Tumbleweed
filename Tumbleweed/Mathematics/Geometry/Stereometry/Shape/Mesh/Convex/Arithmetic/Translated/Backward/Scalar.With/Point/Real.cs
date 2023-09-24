using Point = Tumbleweed.Point.Spatial;

namespace Tumbleweed.Mathematics.Geometry.Stereometry.Shape.Mesh.Convex.Arithmetic.Translated.Backward.Scalar.With.Point;

public sealed class Real : Envelope
{
	public Real
	(
		Any mesh,
		Point::Generic.Any<Mathematics.Number.Real.Any> point
	) : base
  (
	  new Forward.Scalar.With.Point.Real(
		  mesh,
		  new Point::Real.Arithmetic.Negation.Of.One(point))
	)
	{
	}
}