using DotGod.Geometry.Spatial.Graphical.Vertex;
using Tumbleweed.Number.Real;
using Tumbleweed.Point.Planar;

namespace DotGod.Geometry.Spatial.Graphical.UV;

public sealed class LazyUVOfVertex : PointEnvelope<IReal>
{
	public LazyUVOfVertex(IVertex vertex) : base
	(
		new LazyPoint<IReal>(
			new UVOfVertex(vertex))
	)
	{
	}
}