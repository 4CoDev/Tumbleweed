using DotGod.Spatial.Graphical.Concave.Geometry.Polygon;
using DotGod.Spatial.Graphical.Concave.Geometry.Vertex;
using Godot;
using Tumbleweed.Scalar;

namespace DotGod.Spatial.Graphical.Concave.Geometry.Surface._SurfaceTool.
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