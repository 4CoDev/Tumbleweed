using DotGod.Geometry.Spatial.Graphical.Vertex;
using Tumbleweed.Number.Real;
using Tumbleweed.Point.Spatial;

namespace DotGod.Geometry.Spatial.Graphical.Normal;

public sealed class LazyNormalOfVertex : PointEnvelope<IReal>
{
	public LazyNormalOfVertex(IVertex vertex) : base
	(
		new LazyPoint<IReal>(
			new NormalOfVertex(vertex))
	)
	{
	}
}