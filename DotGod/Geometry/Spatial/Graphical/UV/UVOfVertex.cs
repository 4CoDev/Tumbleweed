using DotGod.Geometry.Spatial.Graphical.Vertex;
using Tumbleweed.Number.Real;
using Tumbleweed.Point.Planar;

namespace DotGod.Geometry.Spatial.Graphical.UV;

public sealed class UVOfVertex : PointEnvelope<IReal>
{
	public UVOfVertex(IVertex vertex) : base
	(
		new PointOfFunction<IReal>(() => vertex.UV)
	)
	{
	}
}