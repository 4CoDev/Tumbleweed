using DotGod.Geometrics.Graphical.Vertices;
using Tumbleweed.Numbers.Planar;
using Tumbleweed.Numbers.Real;

namespace DotGod.Geometrics.Graphical.UVs;

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