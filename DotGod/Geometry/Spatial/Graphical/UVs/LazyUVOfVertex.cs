using DotGod.Geometry.Spatial.Graphical.Vertices;
using Tumbleweed.Numbers.Real;
using Tumbleweed.Points.Planar;

namespace DotGod.Geometry.Spatial.Graphical.UVs;

public sealed class LazyUVOfVertex : PlanarEnvelope<IReal>
{
	public LazyUVOfVertex(IVertex vertex) : base
	(
		new LazyPlanar<IReal>(
			new UVOfVertex(vertex))
	)
	{
	}
}