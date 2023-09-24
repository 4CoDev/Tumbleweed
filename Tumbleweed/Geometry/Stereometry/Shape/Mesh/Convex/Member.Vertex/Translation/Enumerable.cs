using Tumbleweed.Geometry.Stereometry.Vertex.Member.Translation;
using Enumerable = Tumbleweed.Enumerable;
using Point = Tumbleweed.Point.Spatial;
using Real = Tumbleweed.Mathematics.Number.Real;

namespace Tumbleweed.Geometry.Stereometry.Shape.Mesh.Convex.Member.Vertex.Translation;

public sealed class Enumerable :
	Enumerable::Envelope<Point::Generic.Any<Mathematics.Number.Real.Any>>
{
	public Enumerable(Any mesh) : base
	(
		new Multiple(
			new Whole.Enumerable(mesh))
  )
	{
	}
}