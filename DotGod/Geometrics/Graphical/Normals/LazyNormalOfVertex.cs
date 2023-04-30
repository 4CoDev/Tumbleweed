using DotGod.Geometrics.Graphical.Vertices;
using Tumbleweed.Numbers.Real;
using Tumbleweed.Numbers.Spatial;

namespace DotGod.Geometrics.Graphical.Normals;

public sealed class LazyNormalOfVertex : SpatialEnvelope<IReal>
{
	public LazyNormalOfVertex(IVertex vertex) : base
	(
		new LazySpatial<IReal>(
			new NormalOfVertex(vertex))
	)
	{
	}
}