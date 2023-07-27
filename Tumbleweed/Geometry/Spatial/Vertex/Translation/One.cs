using Point =  Tumbleweed.Point.Spatial;
using Real = Tumbleweed.Number.Real;
using Vertex = Tumbleweed.Geometry.Spatial.Vertex;

namespace Tumbleweed.Geometry.Spatial.Vertex.Translation;

public sealed class One : Point::Envelope<Real::Any>
{
	public One(Vertex::Any vertex) : base
	(
		new Point::Function.Result<Real::Any>(
			() => vertex.Translation)
	)
	{
	}
}