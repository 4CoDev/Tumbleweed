using DotGod.Geometrics.Graphical.Vertices;
using Tumbleweed.Numbers.Real;
using Tumbleweed.Numbers.Spatial;

namespace DotGod.Geometrics.Graphical.Normals;

public sealed class NormalOfVertex : SpatialEnvelope<IReal>
{
	public NormalOfVertex(IVertex vertex) : base
	(
		new SpatialOfFunction<IReal>(() => vertex.Normal)
	)
	{
	}
}