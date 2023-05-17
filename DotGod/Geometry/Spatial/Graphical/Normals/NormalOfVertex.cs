using DotGod.Geometry.Spatial.Graphical.Vertices;
using Tumbleweed.Numbers.Real;
using Tumbleweed.Points.Spatial;

namespace DotGod.Geometry.Spatial.Graphical.Normals;

public sealed class NormalOfVertex : SpatialEnvelope<IReal>
{
	public NormalOfVertex(IVertex vertex) : base
	(
		new SpatialOfFunction<IReal>(() => vertex.Normal)
	)
	{
	}
}