using DotGod.Geometry.Spatial.Graphical.Vertices;
using Tumbleweed.Numbers.Real;
using Tumbleweed.Points.Planar;

namespace DotGod.Geometry.Spatial.Graphical.UVs;

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