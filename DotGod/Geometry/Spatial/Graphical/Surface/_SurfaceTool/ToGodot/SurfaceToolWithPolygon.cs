using DotGod.Geometry.Spatial.Graphical.Polygon;
using DotGod.Geometry.Spatial.Graphical.Vertex;
using Godot;
using Tumbleweed.Scalar;

namespace DotGod.Geometry.Spatial.Graphical.Surface._SurfaceTool.
	ToGodot;

public sealed class SurfaceToolWithPolygon : ScalarEnvelope<SurfaceTool>
{
	public SurfaceToolWithPolygon
	(
		IPolygon polygon,
		IScalar<SurfaceTool> tool
	) : base
	(
		new SurfaceToolWithVertices(
			new VerticesOfPolygon(polygon),
			tool)
	)
	{
	}
}