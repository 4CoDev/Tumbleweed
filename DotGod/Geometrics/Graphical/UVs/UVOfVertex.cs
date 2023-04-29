using DotGod.Geometrics.Graphical.Vertices;
using Tumbleweed.Numerics.Fractional;
using Tumbleweed.Numerics.Planar;

namespace DotGod.Geometrics.Graphical.UVs;

public sealed class UVOfVertex : PlanarEnvelope<IFractional>
{
	public UVOfVertex(IVertex vertex) : base
	(
		new PlanarOfFunction<IFractional>(() => vertex.UV)
	)
	{
	}
}