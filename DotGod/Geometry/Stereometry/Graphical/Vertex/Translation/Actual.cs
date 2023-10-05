using Tumbleweed.Mathematics.Vector.Spatial.Generic;
using Tumbleweed.Mathematics.Vector.Spatial.Generic.Function.Result;

namespace DotGod.Geometry.Stereometry.Graphical.Vertex.Translation;

public sealed class Actual : Envelope<Tumbleweed.Mathematics.Number.Real.Any>
{
	public Actual(Any vertex) : base
	(
		new Actual<Tumbleweed.Mathematics.Number.Real.Any>(
			() => vertex.Translation)
	)
	{
	}
}