using Tumbleweed.Geometry.Spatial.Shape.Mesh.Convex.With.Vertex.Translation.Enumerable;
using Point = Tumbleweed.Point.Spatial;
using Real = Tumbleweed.Number.Real;

namespace Tumbleweed.Geometry.Spatial.Shape.Mesh.Convex.Arithmetic.Scaled.Up.Scalar.With.Point;

public sealed class Real : Envelope
{
	public Real
	(
		Any mesh,
		Point::Generic.Any<Real::Any> point
	) : base
  (
	  new One(
		  new Point::Real.Arithmetic.Product.Enumerable.With.Point(
			 new Member.Vertex.Translation.Enumerable(mesh),
			 point))
	)
	{
	}
}