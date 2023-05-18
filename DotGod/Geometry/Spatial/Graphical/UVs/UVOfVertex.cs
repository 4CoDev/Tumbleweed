using DotGod.Geometry.Spatial.Graphical.Vertices;
using Tumbleweed.Numbers.Real;
using Tumbleweed.Points.Planar;

namespace DotGod.Geometry.Spatial.Graphical.UVs;

public sealed class UVOfVertex : PointEnvelope<IReal>
{
	public UVOfVertex(IVertex vertex) : base
	(
		new PointOfFunction<IReal>(() => vertex.UV)
	)
	{
	}
}