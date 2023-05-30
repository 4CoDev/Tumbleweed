using DotGod.Spatial.Graphical.Concave.Geometry.Vertex;
using Tumbleweed.Number.Real;
using Tumbleweed.Planar.Point;

namespace DotGod.Spatial.Graphical.Concave.Geometry.UV;

public sealed class UVOfVertex : PointEnvelope<IReal>
{
	public UVOfVertex(IVertex vertex) : base
	(
		new PointOfFunction<IReal>(() => vertex.UV)
	)
	{
	}
}