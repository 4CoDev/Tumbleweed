using DotGod.Geometry.Spatial.Graphical.Vertices;
using Tumbleweed.Numbers.Real;
using Tumbleweed.Points.Spatial;

namespace DotGod.Geometry.Spatial.Graphical.Normals;

public sealed class LazyNormalOfVertex : PointEnvelope<IReal>
{
	public LazyNormalOfVertex(IVertex vertex) : base
	(
		new LazyPoint<IReal>(
			new NormalOfVertex(vertex))
	)
	{
	}
}