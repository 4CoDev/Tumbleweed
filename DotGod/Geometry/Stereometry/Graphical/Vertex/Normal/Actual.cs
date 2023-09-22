using Tumbleweed.Point.Spatial.Function;
using Tumbleweed.Point.Spatial.Generic;

namespace DotGod.Geometry.Stereometry.Graphical.Vertex.Normal;

public sealed class Actual : Envelope<Tumbleweed.Number.Real.Any>
{
	public Actual(Any vertex) : base
	(
		new Result<Tumbleweed.Number.Real.Any>(() => vertex.Normal)
	)
	{
	}
}