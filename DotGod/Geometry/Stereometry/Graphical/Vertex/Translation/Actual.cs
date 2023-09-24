using Tumbleweed.Point.Spatial.Function;
using Tumbleweed.Point.Spatial.Generic;

namespace DotGod.Geometry.Stereometry.Graphical.Vertex.Translation;

public sealed class Actual : Envelope<Tumbleweed.Mathematics.Number.Real.Any>
{
	public Actual(Any vertex) : base
	(
		new Result<Tumbleweed.Mathematics.Number.Real.Any>(
			() => vertex.Translation)
	)
	{
	}
}