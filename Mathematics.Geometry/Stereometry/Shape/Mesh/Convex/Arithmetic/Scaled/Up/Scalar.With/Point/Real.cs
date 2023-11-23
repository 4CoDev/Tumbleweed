using Tumbleweed.Mathematics.Geometry.Stereometry.Shape.Mesh.Convex.With.Vertex.Translation.Enumerable;
using Tumbleweed.Mathematics.Vector.Spatial.Generic;


namespace Tumbleweed.Mathematics.Geometry.Stereometry.Shape.Mesh.Convex.Arithmetic.Scaled.Up.Scalar.With.Point;

public sealed class Real : Envelope
{
	public Real
	(
		Any mesh,
		Any<Mathematics.Number.Real.Any> point
	) : base
  (
	  new One(
		  new Mathematics.Arithmetic.Vector.Spatial.Real.Product.Enumerable.With.Point(
			 new Member.Vertex.Translation.Enumerable(mesh),
			 point))
	)
	{
	}
}