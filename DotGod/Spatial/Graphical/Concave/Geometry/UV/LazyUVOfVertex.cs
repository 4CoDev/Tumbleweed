using DotGod.Spatial.Graphical.Concave.Geometry.Vertex;
using Tumbleweed.Number.Real;
using Tumbleweed.Planar.Point;

namespace DotGod.Spatial.Graphical.Concave.Geometry.UV;

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