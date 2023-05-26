using DotGod.Geometry.Spatial.Graphical.Vertex;
using Tumbleweed.Number.Real;
using Tumbleweed.Point.Spatial;

namespace DotGod.Geometry.Spatial.Graphical.Normal;

public sealed class NormalOfVertex : PointEnvelope<IReal>
{
	public NormalOfVertex(IVertex vertex) : base
	(
		new PointOfFunction<IReal>(() => vertex.Normal)
	)
	{
	}
}