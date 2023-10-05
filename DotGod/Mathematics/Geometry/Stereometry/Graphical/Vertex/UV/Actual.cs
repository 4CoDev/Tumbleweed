using Tumbleweed.Mathematics.Vector.Planar.Generic;
using Tumbleweed.Mathematics.Vector.Planar.Generic.Function.Result;

namespace DotGod.Mathematics.Geometry.Stereometry.Graphical.Vertex.UV;

public sealed class Actual : Envelope<Tumbleweed.Mathematics.Number.Real.Any>
{
	public Actual(Any vertex) : base
	(
		new Actual<Tumbleweed.Mathematics.Number.Real.Any>(() => vertex.UV)
	)
	{
	}
}