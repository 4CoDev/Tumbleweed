using DotGod.Spatial.Graphical.Concave.Geometry.Vertex;
using Tumbleweed.Number.Real;
using Tumbleweed.Spatial.Point;

namespace DotGod.Spatial.Graphical.Concave.Geometry.Normal;

public sealed class NormalOfVertex : PointEnvelope<IReal>
{
	public NormalOfVertex(IVertex vertex) : base
	(
		new PointOfFunction<IReal>(() => vertex.Normal)
	)
	{
	}
}