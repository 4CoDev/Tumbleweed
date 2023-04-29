using DotGod.Geometrics.Graphical.Vertices;
using Tumbleweed.Numerics.Fractional;
using Tumbleweed.Numerics.Spatial;

namespace DotGod.Geometrics.Graphical.Normals;

public sealed class NormalOfVertex : SpatialEnvelope<IFractional>
{
	public NormalOfVertex(IVertex vertex) : base
	(
		new SpatialOfFunction<IFractional>(() => vertex.Normal)
	)
	{
	}
}