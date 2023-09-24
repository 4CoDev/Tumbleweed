using Tumbleweed.Mathematics.Geometry.Stereometry.Vertex.Member.Translation;
using Enumerable = Tumbleweed.Enumerable;
using Point = Tumbleweed.Point.Spatial;

namespace Tumbleweed.Mathematics.Geometry.Stereometry.Shape.Mesh.Convex.Member.Vertex.Translation;

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