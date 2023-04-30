using DotGod.Geometrics.Graphical.Vertices;
using Tumbleweed.Numbers.Planar;
using Tumbleweed.Numbers.Real;

namespace DotGod.Geometrics.Graphical.UVs;

public sealed class UVOfVertex : PlanarEnvelope<IReal>
{
	public UVOfVertex(IVertex vertex) : base
	(
		new PlanarOfFunction<IReal>(() => vertex.UV)
	)
	{
	}
}