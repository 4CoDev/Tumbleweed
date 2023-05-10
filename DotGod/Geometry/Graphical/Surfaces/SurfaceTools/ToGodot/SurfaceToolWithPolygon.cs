using DotGod.Geometry.Graphical.Polygons;
using DotGod.Geometry.Graphical.Vertices;
using Godot;
using Tumbleweed.Scalars;

namespace DotGod.Geometry.Graphical.Surfaces.SurfaceTools.
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