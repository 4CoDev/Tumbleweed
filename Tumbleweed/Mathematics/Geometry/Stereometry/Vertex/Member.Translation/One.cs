using Tumbleweed.Mathematics.Vector.Spatial.Generic;
using Tumbleweed.Mathematics.Vector.Spatial.Generic.Function.Result;

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