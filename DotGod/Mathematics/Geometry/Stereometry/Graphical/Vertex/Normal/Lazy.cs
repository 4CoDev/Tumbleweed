using Tumbleweed.Mathematics.Vector.Spatial.Generic;

namespace DotGod.Mathematics.Geometry.Stereometry.Graphical.Vertex.Normal;

public sealed class Lazy : Envelope<Tumbleweed.Mathematics.Number.Real.Any>
{
	public Lazy(Any vertex) : base
	(
		new Tumbleweed.Mathematics.Vector.Spatial.Generic.Lazy<Tumbleweed.Mathematics.Number.Real.Any>(
			new Actual(vertex))
	)
	{
	}
}