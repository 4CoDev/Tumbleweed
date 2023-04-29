using DotGod.Geometrics.Graphical.Vertices;
using Tumbleweed.Numerics.Fractional;
using Tumbleweed.Numerics.Spatial;

namespace DotGod.Geometrics.Graphical.Normals;

public sealed class LazyNormalOfVertex : SpatialEnvelope<IFractional>
{
	public LazyNormalOfVertex(IVertex vertex) : base
	(
		new LazySpatial<IFractional>(
			new NormalOfVertex(vertex))
	)
	{
	}
}