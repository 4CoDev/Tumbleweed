using Tumbleweed.Mathematics.Vector.Spatial.Generic;
using Tumbleweed.Mathematics.Vector.Spatial.Generic.Function.Result;

namespace DotGod.Mathematics.Geometry.Stereometry.Graphical.Vertex.Normal;

public sealed class Actual : Envelope<Tumbleweed.Mathematics.Number.Real.Any>
{
	public Actual(Any vertex) : base
	(
		new Actual<Tumbleweed.Mathematics.Number.Real.Any>(() => vertex.Normal)
	)
	{
	}
}