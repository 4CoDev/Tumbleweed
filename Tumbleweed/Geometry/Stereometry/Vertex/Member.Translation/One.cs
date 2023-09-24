using Tumbleweed.Point.Spatial.Generic;
using Point =  Tumbleweed.Point.Spatial;
using Real = Tumbleweed.Mathematics.Number.Real;

namespace Tumbleweed.Geometry.Stereometry.Vertex.Member.Translation;

public sealed class One : Envelope<Mathematics.Number.Real.Any>
{
	public One(Any vertex) : base
	(
		new Point::Function.Result<Mathematics.Number.Real.Any>(
			() => vertex.Translation)
	)
	{
	}
}