using DotGod.Spatial.Graphical.Concave.Geometry.Vertex;
using Tumbleweed.Number.Real;
using Tumbleweed.Spatial.Point;

namespace DotGod.Spatial.Graphical.Concave.Geometry.Normal;

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