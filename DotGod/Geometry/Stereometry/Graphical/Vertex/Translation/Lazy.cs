using Tumbleweed.Point.Spatial.Generic;

namespace DotGod.Geometry.Stereometry.Graphical.Vertex.Translation;

public sealed class Lazy : Envelope<Tumbleweed.Number.Real.Any>
{
	public Lazy(Any vertex) : base
	(
		new Tumbleweed.Point.Spatial.Generic.Lazy<Tumbleweed.Number.Real.Any>(
			new Actual(vertex))
	)
	{
	}
}