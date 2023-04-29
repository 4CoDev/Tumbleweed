using DotGod.Geometrics.Graphical.Vertices;
using Tumbleweed.Numerics.Fractional;
using Tumbleweed.Numerics.Planar;

namespace DotGod.Geometrics.Graphical.UVs;

public sealed class LazyUVOfVertex : PlanarEnvelope<IFractional>
{
	public LazyUVOfVertex(IVertex vertex) : base
	(
		new LazyPlanar<IFractional>(
			new UVOfVertex(vertex))
	)
	{
	}
}