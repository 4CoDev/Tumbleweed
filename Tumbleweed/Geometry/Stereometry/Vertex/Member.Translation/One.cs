using Tumbleweed.Point.Spatial.Generic;
using Point =  Tumbleweed.Point.Spatial;
using Real = Tumbleweed.Number.Real;

namespace Tumbleweed.Geometry.Stereometry.Vertex.Member.Translation;

public sealed class One : Envelope<Real::Any>
{
	public One(Any vertex) : base
	(
		new Point::Function.Result<Real::Any>(
			() => vertex.Translation)
	)
	{
	}
}