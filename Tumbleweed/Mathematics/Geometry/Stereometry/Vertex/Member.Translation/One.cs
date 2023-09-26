using Tumbleweed.Mathematics.Geometry.Stereometry.Point.Generic;
using Tumbleweed.Mathematics.Geometry.Stereometry.Point.Generic.Function.Result;
using Point = Tumbleweed.Mathematics.Geometry.Stereometry.Point;

namespace Tumbleweed.Mathematics.Geometry.Stereometry.Vertex.Member.Translation;

public sealed class One : Envelope<Mathematics.Number.Real.Any>
{
	public One(Any vertex) : base
	(
		new Actual<Mathematics.Number.Real.Any>(
			() => vertex.Translation)
	)
	{
	}
}