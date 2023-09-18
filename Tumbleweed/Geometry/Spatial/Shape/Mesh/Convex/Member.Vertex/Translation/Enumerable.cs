using Enumerable = Tumbleweed.Enumerable;
using Point = Tumbleweed.Point.Spatial;
using Real = Tumbleweed.Number.Real;
using Vertex = Tumbleweed.Geometry.Spatial.Vertex;

namespace Tumbleweed.Geometry.Spatial.Shape.Mesh.Convex.Member.Vertex.Translation;

public sealed class Enumerable :
	Enumerable::Envelope<Point::Generic.Any<Real::Any>>
{
	public Enumerable(Any mesh) : base
	(
		new Vertex::Member.Translation.Multiple(
			new Whole.Enumerable(mesh))
  )
	{
	}
}