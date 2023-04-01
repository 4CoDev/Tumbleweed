using TumbleGD.Geometrics.Graphical.Vertices;
using Tumbleweed.Numerics.Fractional;
using Tumbleweed.Numerics.Planar;

namespace TumbleGD.Geometrics.Graphical.UVs;

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