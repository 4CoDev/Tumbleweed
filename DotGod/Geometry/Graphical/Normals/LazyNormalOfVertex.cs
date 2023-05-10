using DotGod.Geometry.Graphical.Vertices;
using Tumbleweed.Numbers.Real;
using Tumbleweed.Numbers.Spatial;

namespace DotGod.Geometry.Graphical.Normals;

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