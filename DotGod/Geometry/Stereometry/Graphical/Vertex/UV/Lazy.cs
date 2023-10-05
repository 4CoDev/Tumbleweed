using Tumbleweed.Mathematics.Vector.Planar;
using Tumbleweed.Mathematics.Vector.Planar.Generic;

namespace DotGod.Geometry.Stereometry.Graphical.Vertex.UV;

public sealed class Lazy : Envelope<Tumbleweed.Mathematics.Number.Real.Any>
{
	public Lazy(Any vertex) : base
	(
		new Tumbleweed.Mathematics.Vector.Planar.Generic.Lazy<Tumbleweed.Mathematics.Number.Real.Any>(
			new Actual(vertex))
	)
	{
	}
}