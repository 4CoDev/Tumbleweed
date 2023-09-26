using Tumbleweed.Mathematics.Geometry.Stereometry.Point.Generic;
using Tumbleweed.Mathematics.Geometry.Stereometry.Shape.Mesh.Convex.With.Vertex.Translation.Enumerable;
using Point = Tumbleweed.Mathematics.Geometry.Stereometry.Point;

namespace Tumbleweed.Mathematics.Geometry.Stereometry.Shape.Mesh.Convex.Arithmetic.Translated.Forward.Scalar.With.Point;

public sealed class Real : Envelope
{
	public Real
	(
		Any mesh,
		Any<Mathematics.Number.Real.Any> point
	) : base
  (
	  new One(
		  new Stereometry.Point.Real.Arithmetic.Sum.Enumerable.With.Point.Real(
			 new Member.Vertex.Translation.Enumerable(mesh),
			 point))
	)
	{
	}
}