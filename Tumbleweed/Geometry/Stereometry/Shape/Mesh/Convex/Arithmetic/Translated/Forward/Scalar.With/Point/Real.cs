using Tumbleweed.Geometry.Stereometry.Shape.Mesh.Convex.With.Vertex.Translation.Enumerable;
using Point = Tumbleweed.Point.Spatial;
using Real = Tumbleweed.Mathematics.Number.Real;

namespace Tumbleweed.Geometry.Stereometry.Shape.Mesh.Convex.Arithmetic.Translated.Forward.Scalar.With.Point;

public sealed class Real : Envelope
{
	public Real
	(
		Any mesh,
		Point::Generic.Any<Mathematics.Number.Real.Any> point
	) : base
  (
	  new One(
		  new Point::Real.Arithmetic.Sum.Enumerable.With.Point.Real(
			 new Member.Vertex.Translation.Enumerable(mesh),
			 point))
	)
	{
	}
}