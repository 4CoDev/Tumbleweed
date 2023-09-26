using Tumbleweed.Mathematics.Geometry.Stereometry.Point.Generic;

namespace DotGod.Geometry.Stereometry.Graphical.Vertex.Normal;

public sealed class Lazy : Envelope<Tumbleweed.Mathematics.Number.Real.Any>
{
	public Lazy(Any vertex) : base
	(
		new Tumbleweed.Mathematics.Geometry.Stereometry.Point.Generic.Lazy<Tumbleweed.Mathematics.Number.Real.Any>(
			new Actual(vertex))
	)
	{
	}
}