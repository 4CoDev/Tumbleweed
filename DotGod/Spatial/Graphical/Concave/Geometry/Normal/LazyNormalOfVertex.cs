using DotGod.Spatial.Graphical.Concave.Geometry.Vertex;
using Tumbleweed.Number.Real;
using Tumbleweed.Point.Spatial;

namespace DotGod.Spatial.Graphical.Concave.Geometry.Normal;

public sealed class LazyNormalOfVertex : Envelope<Any>
{
	public LazyNormalOfVertex(IVertex vertex) : base
	(
		new Tumbleweed.Point.Spatial.Lazy<Any>(
			new NormalOfVertex(vertex))
	)
	{
	}
}