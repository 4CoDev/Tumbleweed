using DotGod.Geometry.Spatial.Graphical.Polygons;
using DotGod.Geometry.Spatial.Graphical.Vertices;
using Godot;
using Tumbleweed.Scalars;

namespace DotGod.Geometry.Spatial.Graphical.Surfaces.SurfaceTools.
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