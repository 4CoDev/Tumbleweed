using DotGod.Spatial.Graphical.Concave.Geometry.Vertex;
using Tumbleweed.Number.Real;
using Tumbleweed.Point.Planar;

namespace DotGod.Spatial.Graphical.Concave.Geometry.UV;

public sealed class LazyUVOfVertex : Envelope<Any>
{
	public LazyUVOfVertex(IVertex vertex) : base
	(
		new Tumbleweed.Point.Planar.Lazy<Any>(
			new UVOfVertex(vertex))
	)
	{
	}
}